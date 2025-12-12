using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY.Class
{
    public class MemberType : Member
    {
        public string name { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
