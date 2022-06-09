using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame {
    public partial class form : Form {

        private Random rand = new Random();

        private int randomNumber;
        private int n;

        public form() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //乱数取得
            getRandom();
        }

        private void bt1_Click(object sender, EventArgs e) {
            if(nup1.Value == randomNumber) {
                Ans.Text = "正解!!";
                Hinto.Text = "";
            }
            else {
                Ans.Text = "不正解";
                if(nup1.Value < randomNumber) {
                    Hinto.Text = nup1.Value + "より大きい数字です";
                }
                else {
                    Hinto.Text = nup1.Value + "より小さい数字です";
                }
            }
            
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e) {
            getRandom();
        }

        public void getRandom() {
            //乱数発生
            randomNumber = rand.Next(1, (int)nup2.Value);
        }
    }
}
