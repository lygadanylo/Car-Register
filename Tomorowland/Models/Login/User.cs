using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Tomorowland.Models.Login
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Last_Name { get; set; }
        public int Year { get; set; }
    }
}
