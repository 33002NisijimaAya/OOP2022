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
        Rootobject2 json3;

        
        public Form1() {
            InitializeComponent();

        }

        private void btWeatherImage_Click(object sender, EventArgs e) {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btWeatherforecast_Click_1(object sender, EventArgs e) {
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void Form1_Load(object sender, EventArgs e) {
            wc = new WebClient() {
                Encoding = Encoding.UTF8
            };


            Stream stream = wc.OpenRead("https://1.bp.blogspot.com/-kcV5lUNVWjk/U9y_l53j6tI/AAAAAAAAjfc/ksZGpirKWfM/s800/tenki_mark01_hare.png");
            Bitmap bitmap = new Bitmap(stream);
            stream.Close();
            BackgroundImage = bitmap;

            Stream stream2 = wc.OpenRead("http://img-o.starrypages.net/img/nureyon/cloud-2.png");
            Bitmap bitmap2 = new Bitmap(stream2);
            stream2.Close();
            btWeatherforecast.BackgroundImage = bitmap2;

            Stream stream3 = wc.OpenRead("https://www.sozailab.jp/db_img/sozai/26655/0d07bea5867193358904065b663b4f0e.png");
            Bitmap bitmap3 = new Bitmap(stream3);
            stream3.Close();
            btWeatherImage.BackgroundImage = bitmap3;
        }
    }
}
