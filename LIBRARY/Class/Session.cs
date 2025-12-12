using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY.Class
{
    public static class Session
    {
        public static int UserId { get; private set; }
        public static string Username { get; private set; }
        public static string Role { get; private set; }
        public static string FirstName { get; private set; }
        public static string LastName { get; private set; }

        public static Member MemberObject { get; private set; }
        //public static Admin AdminObject { get; private set; }
        public static Librarian LibrarianObject { get; private set; }

    public static void Start(User user)
        {
            if (user == null) return;

            UserId = user.UserId;
            Username = user.Username;
            Role = user.Role;
            FirstName = user.FirstName;
            LastName = user.LastName;

            if (user is Member)
                MemberObject = (Member)user;

           // if (user is Admin)
                //AdminObject = (Admin)user;

            if (user is Librarian)
                LibrarianObject = (Librarian)user;
        }

        // Clear session
        public static void End()
        {
            UserId = 0;
            Username = null;
            Role = null;
            FirstName = null;
            LastName = null;

            MemberObject = null;
           // AdminObject = null;
            LibrarianObject = null;
        }

        // Check if someone is logged in
        public static bool IsLoggedIn()
        {
            return UserId != 0 && Role != null;
        }
    }
}

