using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WeatherApp {
    public partial class Form1 : Form {
        WebClient wc;


        public Form1() {
            InitializeComponent();

        }

        private void btWeatherImage_Click(object sender, EventArgs e) {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btWeatherforecast_Click_1(object sender, EventArgs e) {
            this.Hide();
            tbAfterTomorrow form2 = new tbAfterTomorrow();
            form2.Show();
            
        }

        
        private void Form1_Load(object sender, EventArgs e) {
            try {
                this.FormBorderStyle = FormBorderStyle.None;

                wc = new WebClient() {
                    Encoding = Encoding.UTF8
                };

                var url2 = "https://smtgvs.weathernews.jp/s/topics/img/202008/202008300005_top_img_A.png?1598735430";
                var bitmap2 = GetImage(url2);
                pbWeatherforecast.BackgroundImage = bitmap2;

                var url3 = "https://shonanwave.net/wp-content/uploads/2019/06/WM_ChartA_20190615-030000.jpg";
                var bitmap3 = GetImage(url3);
                pbWeatherImage.BackgroundImage = bitmap3;
            } catch (WebException ex) {
                MessageBox.Show("erro:" + ex);
                Application.Exit();
            }
           
        }

        private Bitmap GetImage(string url) {
            Stream stream = wc.OpenRead(url);
            Bitmap bitmap = new Bitmap(stream);
            stream.Close();
            return bitmap;
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
