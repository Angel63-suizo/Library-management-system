using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY.Class
{
    public class MemberType : Models.Member
    {
        public int MemberTypeId { get; set; }
        public string TypeName { get; set; }
        public int MaxBooksAllowed { get; set; }
        public int RenewalLimit { get; set; }
        public decimal FineRatePerDay { get; set; }
        public bool ReservationPrivilege { get; set; }
        public int BorrowingPeriodDays { get; set; }

    }
}
  
    
