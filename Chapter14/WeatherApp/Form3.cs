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

        private void EnabledCheck() {

        }


        private static void GetJson(out WebClient wc, out Rootobject2 json3) {
            wc = new WebClient() {
                Encoding = Encoding.UTF8
            };
            string weatherShow = string.Format("https://www.jma.go.jp/bosai/weather_map/data/list.json");
            var dString3 = wc.DownloadString(weatherShow);
            json3 = JsonConvert.DeserializeObject<Rootobject2>(dString3);
        }

        

        private void WeatherImage_Load(object sender, EventArgs e) {

        }

        

        private void tbWeatherShow_Click_1(object sender, EventArgs e) {
            GetWeatherImage();

        }

        private void btReturn_Click_1(object sender, EventArgs e) {
            GetJson(out wc, out json3);

            if (rbNear.Checked) {
                if (Nearcount > 0) {
                    Nearcount--;
                    var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", json3.near.now[Nearcount]);
                    inputWeather(wc, selectjson);
                }
                else {
                    return;
                }
            }
            if (rbNearMonochrome.Checked) {
                if (NMonochrometcount > 0) {
                    NMonochrometcount--;
                    var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", json3.near_monochrome.now[NMonochrometcount]);
                    inputWeather(wc, selectjson);
                }
                else {
                    return;
                }
            }

            if (rbAsia.Checked) {
                if (Asiacount > 0) {
                    Asiacount--;
                    var selectjson = string.Format("https://www.jma.go.jp/bosai/weather_map/data/png/{0}", json3.asia.now[Asiacount]);
                    inputWeather(wc, selectjson);
                }
                else {
                    return;
                }
            }

            if (rbAsiaMonochrome.Checked) {
                if (AMonochrometcount > 0) {
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
                else {
                    return;
                }
            }

        }
    }
}
