using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class InchConverter {
        private static readonly double ratio = 0.0254;//←外部からもアクセスさせたい場合
        //メートルからインチを求める（静的メソッド）
        public static double FromMeter(double meter) {
            return meter / ratio;
        }
        
        //インチからメートルを求める（静的メソッド）
        public static double ToMeter(double inch) {
            return inch * ratio;
        }
    }
}
