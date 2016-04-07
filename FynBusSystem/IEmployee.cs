using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FynBusSystem
{
    interface IEmployee
    {
        string Username { get; set; }
        string Password { get; set; }
        int Pin { get; set; }

        string Name { get; set; }
        string Lastname { get; set; }
        int Age { get; set; }
        DateTime Birthday { get; set; }
        int AccessLevel { get; set; }
    }
}
