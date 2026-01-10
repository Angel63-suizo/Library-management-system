using LIBRARY.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY.Models
{
    public class Member : User
    {
        private int memberId;
        private string cardnumber;
        private string address;
        private string photopath;
        private string valididpath;
        private int membertypeId;
        private DateTime registrationdate;
        private DateTime expirationdate;
        private string status;


        public int MemberId { get => memberId; set => memberId = value; }
        public string Cardnumber { get => cardnumber; set => cardnumber = value; }
        public string Address { get => address; set => address = value; }
        public string Photopath { get => photopath; set => photopath = value; }
        public string ValidIdpath { get => valididpath; set => valididpath = value; }
        public int MembertypeId { get => membertypeId; set => membertypeId = value; }
        public DateTime Registrationdate { get => registrationdate; set => registrationdate = value; }
        public DateTime Expirationdate { get => expirationdate; set => expirationdate = value; }
        public string Status { get => status; set => status = value; }
        public DataRow Row { get; }
    }
}
