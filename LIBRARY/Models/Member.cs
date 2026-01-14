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
        public int MemberId { get; set; }
        public string Cardnumber { get; set; }
        public string Address { get; set; }
        public string Photopath { get; set; }
        public string ValidIdpath { get; set; }
        public int MembertypeId { get; set; }
        public DateTime Registrationdate { get; set; }
        public DateTime Expirationdate { get; set; }
        public string Status { get; set; }
        public DataRow Row { get; }
    }
}
