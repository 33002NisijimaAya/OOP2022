using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var inputString = Console.ReadLine();
            int num = 0;
            if (int.TryParse(inputString, out num)){
                Console.WriteLine(num.ToString("#,0"));
            } else {
                Console.WriteLine("変換できませんでした。");
            }
        }
    }
}
