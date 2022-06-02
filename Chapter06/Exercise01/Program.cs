using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
        }

        private static void Exercise1_1(int[] numbers) {
            var max = numbers.Max();
            Console.WriteLine(max);
        }

        private static void Exercise1_2(int[] numbers) {
            //最後の二つ要素取り出し
            foreach (var n in numbers.Skip(numbers.Length - 2)) {
                Console.WriteLine(n);
            }
        }

        private static void Exercise1_3(int[] numbers) {
            //数値を文字列に変換
            var strs = numbers.Select(n => n.ToString());
            foreach (var s in strs){
                Console.WriteLine(s);
            }
        }

        private static void Exercise1_4(int[] numbers) {
            var sortednumber = numbers.OrderBy(n => n).Where(n=>n>0).Take(3);
            foreach (var num in sortednumber) {
                Console.WriteLine(num);
            }
        }

        private static void Exercise1_5(int[] numbers) {
            var results = numbers.Distinct().Where(n=>n>10).Count();
            Console.WriteLine(results);  
        }
    }
}
