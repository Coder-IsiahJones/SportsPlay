using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SportsPlay.Pages
{
    [BindProperties]
    public class LoginModel : PageModel
    {
        public string MessageColor { get; set; }
        public string Message { get; set; }

        public string EmailAddress { get; set; }
        public string Password { get; set; }

        public void OnGet()
        {

            
        }

        public void OnPostLogin()
        {
            // Log in the user.
            if (EmailAddress == "rregal@sportsplay.com" && Password == "abc")
            {
                // Set the message.
                MessageColor = "Green";
                Message = "You have loggined in successfully! Welcome to SportsPlay!";
            }
            else
            {
                // Set the message.
                MessageColor = "Red";
                Message = "You have entered an invalid email address and password combination. Please try again.";
            }
        }
    }
}
