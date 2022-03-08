using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab3.Models
{
    public class AppRole : IdentityRole
    {
        public string Decription { get; set; }
      
    }
}