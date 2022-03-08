using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab3.Models
{
    public class AppUser : IdentityUser
    {
        public string IdentityNumber  { get; set; }
        public string Phone  { get; set; }
        public string Mail  { get; set; }
        public int Status  { get; set; }
    }
}