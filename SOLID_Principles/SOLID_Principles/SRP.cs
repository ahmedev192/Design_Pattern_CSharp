using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{

    // Wrong Code :
    public class UserService
    {
        public bool AuthenticateUser(string userId, string password)
        {
            // Code to authenticate user
            // This is just a placeholder for the actual authentication logic
            return userId == "admin" && password == "password";
        }

        public string GenerateUserReport(string userId)
        {
            // Code to generate user report
            // This is just a placeholder for the actual report generation logic
            return $"Report for user {userId}";
        }
    }


    public class UserReporter
    {
        public string GenerateUserReport(string userId)
        {
            // Code to generate user report
            // This is just a placeholder for the actual report generation logic
            return $"Report for user {userId}";
        }
    }


    public class UserAuthenticator
    {
        public bool AuthenticateUser(string userId, string password)
        {
            // Code to authenticate user
            // This is just a placeholder for the actual authentication logic
            return userId == "admin" && password == "password";
        }
    }

}
