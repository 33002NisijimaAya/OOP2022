using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class InchConverter {
        private static readonly double ratio = 0.0254;//←外部からもアクセスさせたい場合
        //インチからメートルを求める（静的メソッド）
        public static double FromMeter(double inch) {
            return inch * ratio;
        }
    }
}
