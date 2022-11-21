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
            tbAfterTomorrow form2 = new tbAfterTomorrow();
            form2.Show();

        }

        private void Form1_Load(object sender, EventArgs e) {
            wc = new WebClient() {
                Encoding = Encoding.UTF8
            };


            Stream stream = wc.OpenRead("https://www.nsozai.jp/photos/2017/08/19/img/DSC_7528_g.JPG");
            Bitmap bitmap = new Bitmap(stream);
            stream.Close();
            BackgroundImage = bitmap;

            Stream stream2 = wc.OpenRead("https://storage.tenki.jp/storage/static-images/forecaster_diary/image/2/25/253/2535/main/20181030112231/large.png");
            Bitmap bitmap2 = new Bitmap(stream2);
            stream2.Close();
            btWeatherforecast.BackgroundImage = bitmap2;

            Stream stream3 = wc.OpenRead("https://shonanwave.net/wp-content/uploads/2019/06/WM_ChartA_20190615-030000.jpg");
            Bitmap bitmap3 = new Bitmap(stream3);
            stream3.Close();
            btWeatherImage.BackgroundImage = bitmap3;
        }
    }
}
