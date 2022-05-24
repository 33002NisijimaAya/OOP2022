using Execise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            //4.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(2002, 12),
                new YearMonth(1998, 5),
                new YearMonth(2001, 8),
                new YearMonth(1654, 9),
                new YearMonth(2002, 7),//最後のカンマはつけておくp103
            };

            //4.2.2
            Exercize2_2(ymCollection);
            Console.WriteLine("-----------");

            //4.2.3
            Exercise2_4(ymCollection);
            Console.WriteLine("-----------");

            //4.2.5
            Exercise2_5(ymCollection);
            Console.WriteLine("-----------");

            Exercise2_6(ymCollection);

            //var ym = new YearMonth(2002, 12);

            //var check = ym.Is21Century;
            //var test = ym.AddOneMonth();

            //Console.WriteLine(ym);
        }

        private static void Exercise2_6(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection.OrderByDescending(ym => ym.Year)) {
                Console.WriteLine(ym);
            }
            

        }



        //4.2.3
        //最初に見つかった21世紀のオブジェクトを返す
        //見つからない場合はnullを返す
        static YearMonth FindFirst21C(YearMonth[] yms) {
            foreach (var ym in yms) {
                if (ym.Is21Century)
                    return ym;
            }
            return null;
        }

        private static void Exercize2_2(YearMonth[] ymCollection) {
            foreach (var ymc in ymCollection) {
                Console.WriteLine(ymc);
            }
        }

        private static void Exercise2_4(YearMonth[] ymCollection) {
            var yearmonth = FindFirst21C(ymCollection);
            if(yearmonth != null) {
                Console.WriteLine(yearmonth);
            } else {
                Console.WriteLine("21世紀のデータはありません");
            }
            
        }

        private static void Exercise2_5(YearMonth[] ymCollection) {
            var array = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
            foreach (var ym in array) {
                Console.WriteLine(ym);
            }
        }
    }
}
