using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPFirstApp.Models
{
    public static class Sorsolo
    {
        static string[] nevek = {"Csink", "Vámossy", "Sergyán", "Szabó Zsé", "Kiss Mari", "Tick",
        "Vígh"};

        static Random r = new Random();

        public static string Sorsol()
        {
            return nevek[r.Next(0, nevek.Length)];
        }
    }
}
