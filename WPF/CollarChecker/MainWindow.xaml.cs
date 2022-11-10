
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
        List<MyColor> colorList = new List<MyColor>();

        public MainWindow() {
            InitializeComponent();
            
            DataContext = GetColorList();
        }

        private void setColor() {
            var r = byte.Parse(RTextBox.Text);
            var g = byte.Parse(GTextBox.Text);
            var b = byte.Parse(BTextBox.Text);
            Color color = Color.FromRgb(r, g, b);
            ColorLabel.Background = new SolidColorBrush(color);

        }
        private void ChangeSlider() {
            if (RTextBox != null && GTextBox != null && BTextBox != null) {
                var R = double.Parse(RTextBox.Text);
                var G = double.Parse(GTextBox.Text);
                var B = double.Parse(BTextBox.Text);

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


        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;

            ColorLabel.Background = new SolidColorBrush(color);

            RSlider.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.R;
            GSlider.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.G;
            BSlider.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.B;
            setColor();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            MyColor stColor = new MyColor();
            var r = byte.Parse(RTextBox.Text);
            var g = byte.Parse(GTextBox.Text);
            var b = byte.Parse(BTextBox.Text);
            stColor.Color = Color.FromRgb(r, g, b);

            var colorName = ((IEnumerable<MyColor>)DataContext)
                                .Where(c => c.Color.R == stColor.Color.R &&
                                          c.Color.G == stColor.Color.G &&
                                          c.Color.B == stColor.Color.B).FirstOrDefault();

            stockList.Items.Insert(0,colorName?.Name ?? "R:" + RTextBox.Text + "G:" + GTextBox.Text + "B:" + BTextBox.Text );
            colorList.Insert(0,stColor);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            if (stockList.SelectedItems.Count == 0)
                return;
            stockList.Items.Remove(stockList.SelectedItem);
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (stockList.SelectedItems.Count == 0)
                return;
            RSlider.Value = colorList[stockList.SelectedIndex].Color.R;
            GSlider.Value = colorList[stockList.SelectedIndex].Color.G;
            BSlider.Value = colorList[stockList.SelectedIndex].Color.B;
            setColor();
        }
    }
}
