﻿using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.User
{
    /// <summary>
    /// Create a new administrator
    /// </summary>
    public class CreateNewAdministratorCommand : ICommand
    {
        /// <summary>
        /// Get the administrator name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Get the administrator email
        /// </summary>
        public string Email { get; }

        /// <summary>
        /// Get the administrator password
        /// </summary>
        public string Password { get; }

        /// <summary>
        /// Construct the command
        /// </summary>
        /// <param name="name">The adminsitrator name</param>
        /// <param name="email">The adminsitrator email</param>
        /// <param name="password">The adminsitrator password</param>
        public CreateNewAdministratorCommand(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
