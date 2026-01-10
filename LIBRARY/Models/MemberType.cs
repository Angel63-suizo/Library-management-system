using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY.Class
{
    internal class MemberType : Models.Member
    {
        private int memberTypeId;
        private string typeName; 
        private int maxBooksAllowed;
        private int renewalLimit;
        private decimal fineRatePerDay;
        private bool reservationPrivilege;
        private int borrowingPeriodDays;

        public int MemberTypeId { get => memberTypeId; set => memberTypeId = value; }
        public string TypeName { get => typeName; set => typeName = value; }
        public int MaxBooksAllowed { get => maxBooksAllowed; set => maxBooksAllowed = value; }
        public int RenewalLimit { get => renewalLimit; set => renewalLimit = value; }
        public decimal FineRatePerDay { get => fineRatePerDay; set => fineRatePerDay = value; }
        public bool ReservationPrivilege { get => reservationPrivilege; set => reservationPrivilege = value; }
        public int BorrowingPeriodDays { get => borrowingPeriodDays; set => borrowingPeriodDays = value; }

    }
}
  
    
