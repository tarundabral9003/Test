using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept.Solid_Principal
{
    internal class SRP_Single_resposiblity_Principal
    {

    }

    /* Before: Violates SRP because the class handles both user data and logging
    public class UserService
    {
        public void CreateUser(string username)
        {
            // User creation logic
            Console.WriteLine("User created: " + username);
            Log("User created: " + username); // Logging responsibility is mixed with business logic
        }

        public void Log(string message)
        {
            // Log message
            Console.WriteLine("Log: " + message);
        }
    }
    */
    // After: Follows SRP by separating responsibilities
    //After Refactoring:
    public class UserService
    {
        private ILogger _logger;
        public ILogger logcheck { get { return _logger; } set { _logger = value; } }
        public UserService(ILogger logger)
            {

            _logger = logger;
        }

        public void CreateUser(string username)
        {
            // User creation logic
            Console.WriteLine("User created: " + username);
            logcheck.log("User created: " + username); // Logging responsibility is mixed with business logic
        }

    }

  

}
