using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface ICup
    {
        string Type { get; set; }
        string Capacity { get; set; }

        string Refill();
        string Wash();
    }
}
