using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FynBusSystem
{
    class ProjectCoordinator : IEmployee
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Pin { get; set; }

        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public int AccessLevel { get; set; }
    }
}
