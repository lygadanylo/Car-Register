using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tomorowland.Models.Auto;

namespace Tomorowland.Models.Login
{
    public class ApplicationContext: IdentityDbContext<User>
    {
        public DbSet<Car> Cars { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
    }
}
