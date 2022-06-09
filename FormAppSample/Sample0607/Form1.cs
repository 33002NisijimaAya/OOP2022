using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0607 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btRandom_Click(object sender, EventArgs e) {
            var rand = new Random();//乱数オブジェクト生成
            
            Number.Value = rand.Next(minValue:(int)min.Value,maxValue:(int)max.Value+1);
        }
    }
}
