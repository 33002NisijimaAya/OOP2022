﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execise01 {
    class Program {
        static void Main(string[] args) {
            var ym = new YearMonth(2002, 12);

            var check = ym.Is21Century;
            var test = ym.AddOneMonth();

            Console.WriteLine(ym);
        }
    }
}
