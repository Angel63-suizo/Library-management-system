using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LIBRARY.Class
{
    public class Member : User
    {
        public int MemberId { get; set; }
        public string CardNumber { get; set; }
        public int MemberTypeId { get; set; }

        public string MemberRole { get; set; }
        public int MaxBorrow { get; set; }
        public int MaxReserve { get; set; }
        public int BorrowDays { get; set; }
        public int AccessLevel { get; set; }

        public string Status { get; set; }

        public Member() { }
         
        public Member(MySqlDataReader r)
        {
            UserId = Convert.ToInt32(r["UserId"]);
            MemberId = Convert.ToInt32(r["MemberId"]);
            Username = r["Username"].ToString();
            FirstName = r["FirstName"].ToString();
            LastName = r["LastName"].ToString();
            Email = r["Email"].ToString();
            CardNumber = r["CardNumber"].ToString();
            MemberTypeId = Convert.ToInt32(r["MemberTypeId"]);
            MemberRole = r["MemberRole"].ToString();
            MaxBorrow = Convert.ToInt32(r["MaxBorrow"]);
            MaxReserve = Convert.ToInt32(r["MaxReserve"]);
            BorrowDays = Convert.ToInt32(r["BorrowDays"]);
            AccessLevel = Convert.ToInt32(r["AccessLevel"]);
            Status = r["Status"].ToString();

            Role = "Member";

        }
    }
}
