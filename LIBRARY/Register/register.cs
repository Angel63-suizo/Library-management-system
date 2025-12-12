using LIBRARY.Class;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace LIBRARY.Register
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            PopulateMemberTypes();
            cmbMemberType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            Login.Login lform = new Login.Login();
            lform.Show();
            this.Hide();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
             if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            if (cmbMemberType.SelectedValue == null || !int.TryParse(cmbMemberType.SelectedValue.ToString(), out int memberTypeId) || memberTypeId <= 0)
            {
                MessageBox.Show("Please select a valid member type.");
                return;
            }

            var member = new Class.Member
            {
                Username = txtUsername.Text.Trim(),
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                MemberTypeId = memberTypeId,
                CardNumber = txtCardNumber.Text.Trim()
            };

            bool success = Register.register.RegisterMember(member, txtPassword.Text);
            if (success)
            {
                MessageBox.Show("Account registered successfully!");

                this.Hide();
                new Login.Login().Show();
            }
            else
            {
                MessageBox.Show("Registration failed!");
            }
        }

        public static bool RegisterMember(Member member, string password)
        {
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("sp_register_member", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_username", member.Username);
                cmd.Parameters.AddWithValue("@p_passwordHash", HashPassword(password));
                cmd.Parameters.AddWithValue("@p_firstname", member.FirstName);
                cmd.Parameters.AddWithValue("@p_lastname", member.LastName);
                cmd.Parameters.AddWithValue("@p_email", member.Email);
                cmd.Parameters.Add("@p_memberTypeId", MySqlDbType.Int32).Value = member.MemberTypeId;
                cmd.Parameters.AddWithValue("@p_cardNumber", member.CardNumber);

                conn.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
        }

        private static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        private void PopulateMemberTypes()
        {
            try
            {
                var types = Register.Register_Repository.GetMemberTypes();

                cmbMemberType.DisplayMember = "TypeName";
                cmbMemberType.ValueMember = "MemberTypeId";
                cmbMemberType.DataSource = types;

                cmbMemberType.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load member types: " + ex.Message);
            }
        }
    }
}
