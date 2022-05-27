using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var line = Console.ReadLine();
            int num = 0;//整数値を入れる変数を用意
            //p126
            if (int.TryParse(line, out num)){
                Console.WriteLine("{0:#,#}",num);//整数への変換成功
            } else {
                Console.WriteLine("数値文字列ではありません");//変換失敗
            }
        }
    }
}
