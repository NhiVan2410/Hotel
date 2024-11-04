using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    internal class Globals
    {
        public static int GlobalUserID { get; private set; }
        public static string GlobalUserName { get; private set; }
        public static string GlobalUserRole { get; private set; }

        public static void SetGlobalUserID(int UserID)
        {
            GlobalUserID = UserID;
        }

        public static void SetGlobalUserName(string UserName)
        {
            GlobalUserName = UserName;
        }

        public static void SetGlobalUserRole(string UserRole)
        {
            GlobalUserRole = UserRole;
        }
    }
}
