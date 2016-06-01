using System;

namespace Evals.App.Domain.Models.Identity
{
    public class User
    {
        public string Name { get; set; }

        public string PasswordHash { get; set; }

        public string Nickname { get; set; }

        public DateTime LastSignInDate { get; set; }




    }
}
