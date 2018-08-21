using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tomorowland.Models.Auto
{
    public class Car
    {
        public int Id { get; set; }
        public string Brean { get; set; }
        public string Model { get; set; }
        public string RegisterNumber { get; set; }
        public string BodyNamber { get; set; }
        public string Countrys { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Home { get; set; }
        public string Users { get; set; }
        public string Berthday { get; set; }
    }
}

/*Migration 
 * Add-Migration Initial
    Update-Database
 * Enable-Migrations
 * Add-Migration "Nazva" -Context ApplicationContext
Update-Database -Context ApplicationContext*/
