﻿using Microsoft.AspNetCore.Identity;

namespace Identity.Context.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
