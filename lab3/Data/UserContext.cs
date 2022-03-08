using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab3.Data
{
    public class UserContext : IdentityDbContext
    {
        public UserContext() : base("UserContext")
        {

        }

        public object AppRole { get; internal set; }

        public System.Data.Entity.DbSet<lab3.Models.AppUser> IdentityUsers { get; set; }

        public System.Data.Entity.DbSet<lab3.Models.AppRole> IdentityRoles { get; set; }
    }
}