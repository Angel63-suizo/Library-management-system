using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY.Models
{
    internal class Category
    {
        private int categoryid;
        private string name;

        public int CategoryId { get => categoryid; set => categoryid = value; }
        public string Name { get => name; set => name = value; }
    }
}
