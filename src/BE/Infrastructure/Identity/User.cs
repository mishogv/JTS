﻿namespace JTSystem.Infrastructure.Identity
{
    using Application.Identity;
    using Microsoft.AspNetCore.Identity;

    public class User : IdentityUser, IUser
    {
        internal User(string email)
            : base(email)
            => this.Email = email;

        public string GetUserId()
            => this.Id;
    }
}