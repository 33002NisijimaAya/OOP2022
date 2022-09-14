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
            //dgvArticles.DataSource = listCarReports;
        }

        private void addressTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202201DataSet);

        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            //画像を取り入れる
            ofdImage.Filter = "画像ファイル(*.jpg; *.png; *.bmp) | *.jpg; *.png; *.bmp";
            if (ofdImage.ShowDialog() == DialogResult.OK) {
                pbCarPicture.Image = System.Drawing.Image.FromFile(ofdImage.FileName);
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

            DataRow newRow = infosys202201DataSet.CarReportDB.NewRow();
            newRow[1] = dtpDateTime.Value;
            newRow[2] = cbRecorder.Text;
            newRow[3] = GetRadioButtonMakeGroup();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;
            newRow[6] = ImageToByteArray(pbCarPicture.Image);

            //データセットへ新しいコードを追加
            infosys202201DataSet.CarReportDB.Rows.Add(newRow);
            //データベース更新
            this.carReportDBTableAdapter.Update(this.infosys202201DataSet.CarReportDB);

            //CarReport newReport = new CarReport {
            //    Date = dtpDateTime.Value,
            //    Auther = cbRecorder.Text,
            //    Maker = GetRadioButtonMakeGroup(),
            //    CarName = cbCarName.Text,
            //    Report = tbReport.Text,
            //    Picture = pbCarPicture.Image,
            //};

            //listCarReports.Add(newReport);
            //dgvArticles.Rows[dgvArticles.RowCount - 1].Selected = true;
            //EnabledCheck();//マスク処理呼び出し

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
            btDelete.Enabled = btCurrect.Enabled = carTableDataGridView.Rows.Count > 0 ? true : false;
        }

        private void btPictureClear_Click(object sender, EventArgs e) {
            pbCarPicture.Image = null;
        }

        private void dgvArticles_Click(object sender, EventArgs e) {
            //if (dgvArticles.CurrentRow == null) return;

            //int index = dgvArticles.CurrentRow.Index;

            //dtpDateTime.Value = listCarReports[index].Date;
            //cbRecorder.Text = listCarReports[index].Auther;
            //cbCarName.Text = listCarReports[index].CarName;
            //tbReport.Text = listCarReports[index].Report;
            //pbCarPicture.Image = listCarReports[index].Picture;

            //setKindNumberType(index);

        }
        private void setKindNumberType(string maker) {
            
            if (maker == "トヨタ") {
                rbToyota.Checked = true;
            }
            if (maker == "日産") {
                rbNissan.Checked = true;
            }
            if (maker == "ホンダ") {
                rbHonda.Checked = true;
            }
            if (maker == "スバル") {
                rbSubaru.Checked = true;
            }
            if (maker == "外国車") {
                rbOutcar.Checked = true;
            }
            if (maker == "その他") {
                rbOther.Checked = true;
            }

            //番号種別チェック法
            //switch (listCarReports[index].Maker) {
            //    case CarReport.MakerGroup.トヨタ:
            //        rbToyota.Checked = true;
            //        break;
            //    case CarReport.MakerGroup.日産:
            //        rbNissan.Checked = true;
            //        break;
            //    case CarReport.MakerGroup.ホンダ:
            //        rbHonda.Checked = true;
            //        break;
            //    case CarReport.MakerGroup.スバル:
            //        rbSubaru.Checked = true;
            //        break;
            //    case CarReport.MakerGroup.外国車:
            //        rbOutcar.Checked = true;
            //        break;
            //    case CarReport.MakerGroup.その他:
            //        rbOther.Checked = true;
            //        break;
            //    default:
            //        break;
            //}
        }

        private void btCurrect_Click(object sender, EventArgs e) {
            carTableDataGridView.CurrentRow.Cells[1].Value = dtpDateTime.Value;
            carTableDataGridView.CurrentRow.Cells[2].Value = cbRecorder.Text;
            carTableDataGridView.CurrentRow.Cells[3].Value = GetRadioButtonMakeGroup();
            carTableDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;
            carTableDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;
            carTableDataGridView.CurrentRow.Cells[6].Value = pbCarPicture.Image;

            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202201DataSet);

            //listCarReports[dgvArticles.CurrentRow.Index].Date = dtpDateTime.Value;
            //listCarReports[dgvArticles.CurrentRow.Index].Auther = cbRecorder.Text;
            //listCarReports[dgvArticles.CurrentRow.Index].Maker = GetRadioButtonMakeGroup();
            //listCarReports[dgvArticles.CurrentRow.Index].CarName = cbCarName.Text;
            //listCarReports[dgvArticles.CurrentRow.Index].Report = tbReport.Text;
            //listCarReports[dgvArticles.CurrentRow.Index].Picture = pbCarPicture.Image;
            //dgvArticles.Refresh();//データグリッドビュー更新
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //設定ファイルをシリアル化
            //using (var writer = XmlWriter.Create("settings.xml")) {
            //    var serializer = new XmlSerializer(settings.GetType());
            //    serializer.Serialize(writer, settings);
            //}
        }

        private void Form1_Load(object sender, EventArgs e) {
            //// TODO: このコード行はデータを 'infosys202201DataSet.CarReportDB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.carReportDBTableAdapter.Fill(this.infosys202201DataSet.CarReportDB);
            
            EnabledCheck();
            try {
                ////設定ファイルを逆シリアル化して背景の色を設定
                using (var reader = XmlReader.Create("settings.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    var setting = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(setting.MainFromColor);
                }
            } catch (Exception) {

            }


        }

        private void btDelete_Click(object sender, EventArgs e) {
            //listCarReports.RemoveAt(dgvArticles.CurrentRow.Index);
            //foreach (DataGridViewRow r in carTableDataGridView.SelectedRows) {
            //    if (!r.IsNewRow) {
            //        carTableDataGridView.Rows.Remove(r);
            //    }
            //}

            foreach (DataGridViewRow row in this.carTableDataGridView.SelectedRows) {
                this.carTableDataGridView.Rows.Remove(row);
            }
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202201DataSet);
            EnabledCheck();//マスク処理呼び出し
        }

        private void btSave_Click(object sender, EventArgs e) {
            //if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {
            //    try {
            //        //バイナリ形式でシリアル化
            //        var bf = new BinaryFormatter();

            //        using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create)) {
            //            bf.Serialize(fs, listCarReports);
            //        }
            //    } catch (Exception ex) {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
        }

        private void btOpen_Click(object sender, EventArgs e) {
            this.carReportDBTableAdapter.Fill(this.infosys202201DataSet.CarReportDB);
            //if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
            //    try {
            //        //バイナリ形式で逆シリアル化
            //        var bf = new BinaryFormatter();

            //        using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {
            //            //逆シリアル化して読み込む
            //            listCarReports = (BindingList<CarReport>)bf.Deserialize(fs);
            //            dgvArticles.DataSource = null;
            //            dgvArticles.DataSource = listCarReports;
            //        }
            //    } catch (Exception ex) {
            //        MessageBox.Show(ex.Message);
            //    }
            //    cbCarName.Items.Clear();//コンボボックスのアイテム消去
            //    cbRecorder.Items.Clear();
            //    //コンボボックスへ登録
            //    foreach (var item in listCarReports.Select(p => p.CarName)) {
            //        setcbCarName(item);
            //    }
            //    foreach (var item in listCarReports.Select(p => p.Auther)) {
            //        setcbRecorder(item);
            //    }
            //}
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

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        //エラー回避
        private void addressTableDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }

       
        private void carTableDataGridView_Click_1(object sender, EventArgs e) {
            //データグリッドビューの選択レコードを各テキストボックスへ設定
            if (carTableDataGridView.CurrentRow == null)
                return;

            var maker = carTableDataGridView.CurrentRow.Cells[3].Value.ToString();

            dtpDateTime.Text = carTableDataGridView.CurrentRow.Cells[1].Value.ToString();
            cbRecorder.Text = carTableDataGridView.CurrentRow.Cells[2].Value.ToString();
            setKindNumberType(maker);
            cbCarName.Text = carTableDataGridView.CurrentRow.Cells[4].Value.ToString();
            tbReport.Text = carTableDataGridView.CurrentRow.Cells[5].Value.ToString();
            if (!(carTableDataGridView.CurrentRow.Cells[6].Value is DBNull)) {
                pbCarPicture.Image = ByteArrayToImage((byte[])carTableDataGridView.CurrentRow.Cells[6].Value);
            }
            else {
                pbCarPicture.Image = null;
            }
        }

        private void carTableDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }

        private void btNameSearch_Click(object sender, EventArgs e) {
            //carReportDBTableAdapter.FillByName(infosys202201DataSet.CarReportDB, tbSearchName.Text);
        }
    }
}
