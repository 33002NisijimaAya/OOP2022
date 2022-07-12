using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvArticles.DataSource = listCarReports;
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            //画像を取り入れる
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbCarPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }

        private void btExit_Click(object sender, EventArgs e) {
            //アプリケーションの終了
            Application.Exit();
        }

        private void btAddCarReport_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(cbCarName.Text)) {
                MessageBox.Show("車名が入力されていません");
                return;
            }

            CarReport newReport = new CarReport {
                Date = dtpDateTime.Value,
                Auther = cbRecorder.Text,
                Maker = GetRadioButtonMakeGroup(),
                CarName= cbCarName.Text,
                Report= tbReport.Text,
                Picture= pbCarPicture.Image,
            };

            listCarReports.Add(newReport);
            dgvArticles.Rows[dgvArticles.RowCount - 1].Selected = true;
            EnabledCheck();//マスク処理呼び出し

            setcbCarName(cbCarName.Text);
            setcbRecorder(cbRecorder.Text);

        }

        //記録者のコンボボックスに記録者名を登録する（重複なし）
        private void setcbRecorder(string Recorder) {
            if (!cbRecorder.Items.Contains(Recorder)) {
                //まだ登録されていなければ登録処理
                cbRecorder.Items.Add(Recorder);
            }
        }

        //車名のコンボボックスに車名を登録する（重複なし）
        private void setcbCarName(string CarName) {
            if (!cbCarName.Items.Contains(CarName)) {
                //まだ登録されていなければ登録処理
                cbCarName.Items.Add(CarName);
            }
        }

        private CarReport.MakerGroup GetRadioButtonMakeGroup() {
            //デフォルトの戻りを設定
            CarReport.MakerGroup selectedKindCar = CarReport.MakerGroup.その他;
            if (rbToyota.Checked) {//トヨタにチェックがついてる
                selectedKindCar = CarReport.MakerGroup.トヨタ;
            }
            if (rbNissan.Checked) {//日産にチェックがついている
                selectedKindCar = CarReport.MakerGroup.日産;
            }
            if (rbHonda.Checked) {//ホンダにチェックがついている
                selectedKindCar = CarReport.MakerGroup.ホンダ;
            }
            if (rbSubaru.Checked) {//スバルにチェックがついている
                selectedKindCar = CarReport.MakerGroup.スバル;
            }
            if (rbOutcar.Checked) {//外国車にチェックがついている
                selectedKindCar = CarReport.MakerGroup.外国車;
            }
            if (rbOther.Checked) {//その他にチェックがついている
                selectedKindCar = CarReport.MakerGroup.その他;
            }
            return selectedKindCar;
        }

        private void EnabledCheck() {
            btDelete.Enabled = btCurrect.Enabled = listCarReports.Count() > 0 ? true : false;
        }

        private void btPictureClear_Click(object sender, EventArgs e) {
            pbCarPicture.Image = null;
        }

        private void dgvArticles_Click(object sender, EventArgs e) {
            if (dgvArticles.CurrentRow == null) return;

            int index = dgvArticles.CurrentRow.Index;

            dtpDateTime.Value = listCarReports[index].Date;
            cbRecorder.Text = listCarReports[index].Auther;
            cbCarName.Text = listCarReports[index].CarName;
            tbReport.Text = listCarReports[index].Report;
            pbCarPicture.Image = listCarReports[index].Picture;

            setKindNumberType(index);
            
        }
        private void setKindNumberType(int index) {
            //番号種別チェック法
            switch (listCarReports[index].Maker) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.外国車:
                    rbOutcar.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }
        }

    }
}
