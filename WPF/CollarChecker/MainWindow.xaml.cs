using System;
using System.Collections.Generic;
using System.Linq;
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


        private void RTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            ChangeSlider();
        }

        private void GTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            ChangeSlider();
        }

        private void BTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            ChangeSlider();
        }
    }
}
