﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            Console.Write("文字1を入力：");
            var inputString1 = Console.ReadLine();
            Console.Write("文字2を入力：");
            var inputString2 = Console.ReadLine();
            Console.Write("文字は");

            if (String.Compare(inputString1, inputString2, true) == 0)
                Console.WriteLine("等しい");
            else
                Console.WriteLine("等しくない");

        }
    }
}
