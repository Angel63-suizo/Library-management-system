using LIBRARY.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace LIBRARY.Class
{
    public class Admin : User
    {
        private MemberManager _memberRepo = new MemberManager();
        private CatalogManager _catalogRepo = new CatalogManager();

        public string RegisterNewMember(Models.Member member, string memberTypeName, string status)
        {
            if (string.IsNullOrWhiteSpace(member.Email) || !member.Email.Contains("@"))
            {
                return string.Empty;
            }

            return _memberRepo.AddNewMember(member, memberTypeName, status);
        }

        public string AddResourceToCatalog(Resource resource, int categoryId, string resourceType, int copies)
        {
            if (string.IsNullOrWhiteSpace(resource.Title) || string.IsNullOrWhiteSpace(resource.ISBN))
            {
                return string.Empty;
            }

            if (copies < 1) return string.Empty;

            return _catalogRepo.AddNewResource(resource, categoryId, resourceType, copies);
        }
    }
}
