
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CollarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            DataContext = GetColorList();
        }

        private void ChangeSlider() {
            if(RTextBox != null && GTextBox != null && BTextBox!=null) {
                var R = (int)Math.Floor(double.Parse(RTextBox.Text));
                var G = (int)Math.Floor(double.Parse(GTextBox.Text));
                var B = (int)Math.Floor(double.Parse(BTextBox.Text));
                RTextBox.Text = R.ToString();
                GTextBox.Text = G.ToString();
                BTextBox.Text = B.ToString();
                Color color = Color.FromRgb((byte)R, (byte)G, (byte)B);
                ColorLabel.Background = new SolidColorBrush(color);
            }
        }

        /// <summary>
        /// すべての色を取得するメソッド
        /// </summary>
        /// <returns></returns>
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void RTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            ChangeSlider();
        }

        private void GTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            ChangeSlider();
        }

        private void BTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            ChangeSlider();
        }

        /// <summary>
        /// 色と色名を保持するクラス
        /// </summary>
        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }
        }


        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;

            ColorLabel.Background = new SolidColorBrush(color);

            RTextBox.Text = color.R.ToString();
            GTextBox.Text = color.G.ToString();
            BTextBox.Text = color.B.ToString();
        }
    }
}
