using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WeatherApp {
    public partial class Form2 : Form {
        List<string> areaname = new List<string>{
            "宗谷地方", "上川・留萌地方","網走・北見・紋別地方","釧路・根室地方","胆振・日高地方","石狩・空知・後志地方", "渡島・檜山地方",
            "青森県","岩手県","宮城県","秋田県","山形県","福島県","茨城県","栃木県","群馬県","埼玉県","千葉県","東京都","神奈川県","山梨県","長野県",
            "岐阜県","静岡県","愛知県","三重県","新潟県","富山県","石川県","福井県","滋賀県","京都府","大阪府","兵庫県","奈良県","	和歌山県","鳥取県","島根県","岡山県",
            "広島県","徳島県","香川県","愛媛県","高知県","山口県","福岡県","佐賀県","長崎県","	熊本県","大分県","宮崎県","奄美地方","鹿児島県（奄美地方除く）","沖縄本島地方","大東島地方","宮古島地方","八重山地方",
        };


        public Form2() {
            InitializeComponent();
        }

        private void btWeatherGet_Click(object sender, EventArgs e) {
            var index = cbArea.SelectedIndex;

            List<string> areacode = new List<string> {"011000","012000","013000","014100","015000","016000","017000",
                "020000","030000","040000","050000","060000","070000","080000","090000","100000","110000","120000","130000",
                "140000","190000","200000","210000","220000","230000","240000","150000","160000","170000","180000","250000",
                "260000","270000","280000","290000","300000","310000","320000","330000","340000","360000","370000","380000",
                "390000","350000","400000","410000","420000","430000","440000","450000","460040","460100","471000",
                "472000","473000","474000"
            };

            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            
            

            string weatherforecast = string.Format("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/{0}.json", areacode[index]);
            string weatherweek = string.Format("https://www.jma.go.jp/bosai/forecast/data/forecast/{0}.json", areacode[index]);

            var dString1 = wc.DownloadString(weatherforecast);
            var dString2 = wc.DownloadString(weatherweek);

            var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);
            var json2 = JsonConvert.DeserializeObject<Class1[]>(dString2);
            var dt = json1.reportDatetime;

            var todayweathercode = json2[0].timeSeries[0].areas[0].weatherCodes[0];
            var tomorrowweathercode = json2[0].timeSeries[0].areas[0].weatherCodes[1];

            pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/"+ todayweathercode + ".png";
            pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + tomorrowweathercode + ".png";

            tbWeatherInfo.Text = json1.text;
            tbArea.Text = string.Format("{0}の天気概要", json1.targetArea);
            tbPublisher.Text = json1.publishingOffice;
            tbTime.Text = dt.ToString("yyyy/MM/dd HH:mm:ss");
            tbToday.Text = json2[0].timeSeries[0].areas[0].weathers[0];
            tbTomorrow.Text = json2[0].timeSeries[0].areas[0].weathers[1];
            tbmaxtemp.Text = json2[1].tempAverage.areas[0].max;
            tbmintemp.Text = json2[1].tempAverage.areas[0].min;
            

        }

        private void Form2_Load(object sender, EventArgs e) {
            cbArea.Items.AddRange(areaname.ToArray());
        }

       
    }
}
