using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    public class Settings {
        private static Settings settings;

        //コンストラクタprivateにする
        private Settings() { }

        public static Settings getInstance() {
            if (settings == null)
                settings = new Settings();

            return settings;
        }
        public int MainFromColor { get; set; }
    }
}
