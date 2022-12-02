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


    public partial class Form3 : Form {
        WebClient wc;
        Rootobject2 json3;

        int Nearcount = 21; int NMonochrometcount = 21; int Asiacount = 12; int AMonochrometcount = 12;


        public Form3() {
            InitializeComponent();
        }
        private WeatherApp.WeatherPlace GetRadioButtonWeatherPlace() {
            GetJson(out wc, out json3);

            var selectedKindPlace = WeatherApp.WeatherPlace.日本周辺カラー;

            if (rbNear.Checked) {
                selectedKindPlace = WeatherApp.WeatherPlace.日本周辺カラー;
            }
            if (rbNearMonochrome.Checked) {
                selectedKindPlace = WeatherApp.WeatherPlace.日本周辺白黒;
            }
            if (rbAsia.Checked) {
                selectedKindPlace = WeatherApp.WeatherPlace.アジア太平洋域カラー;
            }
            if (rbAsiaMonochrome.Checked) {
                selectedKindPlace = WeatherApp.WeatherPlace.アジア太平洋域白黒;
            }
            return selectedKindPlace;
        }



        private void GetWeatherImage() {
            GetJson(out wc, out json3);


            if (rbNear.Checked) {
                var weather = json3.near.now[21];
                var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", weather);
                inputWeather(wc, selectjson);
            }
            if (rbNearMonochrome.Checked) {
                var weather = json3.near_monochrome.now[21];
                var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", weather);
                inputWeather(wc, selectjson);
            }
            if (rbAsia.Checked) {
                var weather = json3.asia.now[12];
                var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", weather);
                inputWeather(wc, selectjson);
            }
            if (rbAsiaMonochrome.Checked) {
                var weather = json3.asia_monochrome.now[12];
                var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", weather);
                inputWeather(wc, selectjson);
            }
        }

        private void inputWeather(WebClient wc, string selectjson) {
            Stream stream = wc.OpenRead(selectjson);
            Bitmap bitmap = new Bitmap(stream);
            stream.Close();
            pbWeather.Image = bitmap;
        }

        

        private static void GetJson(out WebClient wc, out Rootobject2 json3) {
            wc = new WebClient() {
                Encoding = Encoding.UTF8
            };
            string weatherShow = string.Format("https://www.jma.go.jp/bosai/weather_map/data/list.json");
            var dString3 = wc.DownloadString(weatherShow);
            json3 = JsonConvert.DeserializeObject<Rootobject2>(dString3);
        }



       


        private void tbWeatherShow_Click_1(object sender, EventArgs e) {
            GetWeatherImage();

        }

        private void btReturn_Click_1(object sender, EventArgs e) {
            GetJson(out wc, out json3);

            if (rbNear.Checked) {
                if (Nearcount == 23) {
                    Nearcount--;
                    var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", json3.near.ft24);
                    inputWeather(wc, selectjson);
                }
                else if (Nearcount > 0) {
                    Nearcount--;
                    var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", json3.near.now[Nearcount]);
                    inputWeather(wc, selectjson);
                }
                else {
                    return;
                }
            }
            if (rbNearMonochrome.Checked) {
                if (NMonochrometcount == 23) {
                    NMonochrometcount--;
                    var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", json3.near_monochrome.ft24);
                    inputWeather(wc, selectjson);
                }
                else if (NMonochrometcount > 0) {
                    NMonochrometcount--;
                    var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", json3.near_monochrome.now[NMonochrometcount]);
                    inputWeather(wc, selectjson);
                }
                else {
                    return;
                }
            }

            if (rbAsia.Checked) {
                if (Asiacount == 14) {
                    Asiacount--;
                    var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", json3.asia.ft24);
                    inputWeather(wc, selectjson);
                }
                else if (Asiacount > 0) {
                    Asiacount--;
                    var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", json3.asia.now[Asiacount]);
                    inputWeather(wc, selectjson);
                }
                else {
                    return;
                }
            }

            if (rbAsiaMonochrome.Checked) {
                if (AMonochrometcount == 14) {
                    AMonochrometcount--;
                    var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", json3.asia_monochrome.ft24);
                    inputWeather(wc, selectjson);
                }else if (AMonochrometcount > 0) {
                    AMonochrometcount--;
                    var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", json3.asia_monochrome.now[AMonochrometcount]);
                    inputWeather(wc, selectjson);
                }
                else {
                    return;
                }
            }

        }

        private void btNext_Click_1(object sender, EventArgs e) {
            GetJson(out wc, out json3);

            GetRadioButtonWeatherPlace();
            if (rbNear.Checked) {
                if (Nearcount <= 20) {
                    Nearcount++;
                    var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", json3.near.now[Nearcount]);
                    inputWeather(wc, selectjson);
                }
                else if (Nearcount == 21) {
                    Nearcount++;
                    var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", json3.near.ft24);
                    inputWeather(wc, selectjson);
                }
                else if (Nearcount == 22) {
                    Nearcount++;
                    var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", json3.near.ft48);
                    inputWeather(wc, selectjson);
                }
                else {
                    return;
                }
            }
            if (rbNearMonochrome.Checked) {
                if (NMonochrometcount <= 20) {
                    NMonochrometcount++;
                    var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", json3.near_monochrome.now[NMonochrometcount]);
                    inputWeather(wc, selectjson);
                }
                else if (NMonochrometcount == 21) {
                    NMonochrometcount++;
                    var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", json3.near_monochrome.ft24);
                    inputWeather(wc, selectjson);
                }
                else if (NMonochrometcount == 22) {
                    NMonochrometcount++;
                    var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", json3.near_monochrome.ft48);
                    inputWeather(wc, selectjson);
                }
                else {
                    return;
                }
            }

            if (rbAsia.Checked) {
                if (Asiacount < 12) {
                    Asiacount++;
                    var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", json3.asia.now[Asiacount]);
                    inputWeather(wc, selectjson);
                }
                else if (Asiacount == 12) {
                    Asiacount++;
                    var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", json3.asia.ft24);
                    inputWeather(wc, selectjson);
                }
                else if (Asiacount == 13) {
                    Asiacount++;
                    var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", json3.asia.ft48);
                    inputWeather(wc, selectjson);
                }
                else {
                    return;
                }
            }

            if (rbAsiaMonochrome.Checked) {
                if (AMonochrometcount < 12) {
                    AMonochrometcount++;
                    var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", json3.asia_monochrome.now[AMonochrometcount]);
                    inputWeather(wc, selectjson);
                }
                else if (AMonochrometcount == 12) {
                    AMonochrometcount++;
                    var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", json3.asia_monochrome.ft24);
                    inputWeather(wc, selectjson);
                }
                else if (AMonochrometcount == 13) {
                    AMonochrometcount++;
                    var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", json3.asia_monochrome.ft48);
                    inputWeather(wc, selectjson);
                }
                else {
                    return;
                }
            }

        }

        private void btReal_Click(object sender, EventArgs e) {
            CountReset();

            GetWeatherImage();
        }

        private void CountReset() {
            Nearcount = 21;
            NMonochrometcount = 21;
            Asiacount = 12;
            AMonochrometcount = 12;
        }

        private void Form3_Load(object sender, EventArgs e) {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e) {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
