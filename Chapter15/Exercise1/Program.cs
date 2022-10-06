using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var book = Library.Books.First(b => b.Price == Library.Books.Max(x => x.Price));
            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
            var count1= 0;
            var count2 = 0;
            var count3 = 0;
            var count4 = 0;
            foreach (var book in Library.Books) {
                if(book.PublishedYear == 2013) {
                    count1++;
                }
                if (book.PublishedYear == 2014) {
                    count2++;
                }
                if (book.PublishedYear == 2015) {
                    count3++;
                }
                if (book.PublishedYear == 2016) {
                    count4++;
                }
            }
            Console.WriteLine($"2013年 {count1}冊");
            Console.WriteLine($"2014年 {count2}冊");
            Console.WriteLine($"2015年 {count3}冊");
            Console.WriteLine($"2016年 {count4}冊");
        }

        private static void Exercise1_4() {
            
        }

        private static void Exercise1_5() {
            
        }

        private static void Exercise1_6() {
            
        }

        private static void Exercise1_7() {
            
        }

        private static void Exercise1_8() {
            
        }
    }
}
