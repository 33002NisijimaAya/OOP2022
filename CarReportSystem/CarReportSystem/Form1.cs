using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        int mode = 0;
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();
        //設定情報保存用オブジェクト
        Settings settings = Settings.getInstance();

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
            if (String.IsNullOrWhiteSpace(cbRecorder.Text)) {
                MessageBox.Show("記録者名が入力されていません");
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
        private void setcbCarName(string Carname) {
            if (!cbCarName.Items.Contains(Carname)) {
                //まだ登録されていなければ登録処理
                cbCarName.Items.Add(Carname);
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

        private void btCurrect_Click(object sender, EventArgs e) {
            listCarReports[dgvArticles.CurrentRow.Index].Date = dtpDateTime.Value;
            listCarReports[dgvArticles.CurrentRow.Index].Auther = cbRecorder.Text;
            listCarReports[dgvArticles.CurrentRow.Index].Maker = GetRadioButtonMakeGroup();
            listCarReports[dgvArticles.CurrentRow.Index].CarName = cbCarName.Text;
            listCarReports[dgvArticles.CurrentRow.Index].Report = tbReport.Text;
            listCarReports[dgvArticles.CurrentRow.Index].Picture = pbCarPicture.Image;
            dgvArticles.Refresh();//データグリッドビュー更新
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //設定ファイルをシリアル化
            using (var writer = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            EnabledCheck();
            try {
                ////設定ファイルを逆シリアル化して背景の色を設定
                using (var reader = XmlReader.Create("settings.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    var setting = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(setting.MainFromColor);
                }
            } catch (Exception){

            }
                
            
        }

        private void btDelete_Click(object sender, EventArgs e) {
            listCarReports.RemoveAt(dgvArticles.CurrentRow.Index);
            EnabledCheck();//マスク処理呼び出し
        }

        private void btSave_Click(object sender, EventArgs e) {
            if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReports);
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listCarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvArticles.DataSource = null;
                        dgvArticles.DataSource = listCarReports;
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                cbCarName.Items.Clear();//コンボボックスのアイテム消去
                cbRecorder.Items.Clear();
                //コンボボックスへ登録
                foreach (var item in listCarReports.Select(p => p.CarName)) {
                    setcbCarName(item);
                }
                foreach (var item in listCarReports.Select(p => p.Auther)) {
                    setcbRecorder(item);
                }
            }
            EnabledCheck();
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            //色設定ダイアログの表示

            if (cdColorSelect.ShowDialog() == DialogResult.OK) {
                BackColor = cdColorSelect.Color;
                settings.MainFromColor = cdColorSelect.Color.ToArgb();//設定オブジェクトへセット
            }
        }

        private void btSizeChange_Click(object sender, EventArgs e) {
            pbCarPicture.SizeMode = (PictureBoxSizeMode)mode;
            mode = mode < 4 ? ++mode : 0;
        }

        
    }
}
