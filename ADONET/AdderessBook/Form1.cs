using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdderessBook {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void addressTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.addressTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202201DataSet);

        }

        private void Form1_Load(object sender, EventArgs e) {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

        }


        private void addressTableDataGridView_Click(object sender, EventArgs e) {
            
            if (addressTableDataGridView.CurrentRow == null) { return; }

            //データグリッドビューの選択レコードを各テキストボックスへ設定
            tbName.Text = addressTableDataGridView.CurrentRow.Cells[1].Value.ToString();
            tbAddress.Text = addressTableDataGridView.CurrentRow.Cells[3].Value.ToString();
            tbTel.Text = addressTableDataGridView.CurrentRow.Cells[2].Value.ToString();
            tbMail.Text = addressTableDataGridView.CurrentRow.Cells[4].Value.ToString();
            tbMemo.Text = addressTableDataGridView.CurrentRow.Cells[5].Value.ToString();
            //画像表示処理
            if (!(addressTableDataGridView.CurrentRow.Cells[6].Value is DBNull)) {
                pbImage.Image = ByteArrayToImage((byte[])addressTableDataGridView.CurrentRow.Cells[6].Value);
            }
            else {
                pbImage.Image = null;
            }
            //if (!DBNull.Value.Equals(addressTableDataGridView.CurrentRow.Cells[6].Value)) {
            //    pbImage.Image = ByteArrayToImage((byte[])addressTableDataGridView.CurrentRow.Cells[6].Value);
            //}

        }
        private void btUpdate_Click(object sender, EventArgs e) {
            //各テキストボックスからデータグリッドビューへ設定
            addressTableDataGridView.CurrentRow.Cells[1].Value= tbName.Text;
            addressTableDataGridView.CurrentRow.Cells[2].Value = tbAddress.Text;
            addressTableDataGridView.CurrentRow.Cells[3].Value = tbTel.Text;
            addressTableDataGridView.CurrentRow.Cells[4].Value = tbMail.Text;
            addressTableDataGridView.CurrentRow.Cells[5].Value = tbMemo.Text;
            addressTableDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbImage.Image);

            //データセットの中をデータベースへ反映（保存）
            this.Validate();
            this.addressTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202201DataSet);

        }

        private void btAdd_Click(object sender, EventArgs e) {
            DataRow newRow = infosys202201DataSet.AddressTable.NewRow();
            newRow[1] = tbName.Text;
            newRow[2] = tbAddress.Text;
            newRow[3] = tbTel.Text;
            newRow[4] = tbMail.Text;
            newRow[5] = tbMemo.Text;
            newRow[6] = ImageToByteArray(pbImage.Image);

            //データセットへ新しいコードを追加
            infosys202201DataSet.AddressTable.Rows.Add(newRow);
            //データベース更新
            this.addressTableTableAdapter.Update(this.infosys202201DataSet.AddressTable);

        }

        private void btImageClear_Click(object sender, EventArgs e) {
            pbImage.Image = null;
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

        private void btNameSearch_Click(object sender, EventArgs e) {
            addressTableTableAdapter.FillByName(infosys202201DataSet.AddressTable, tbSearchName.Text);

        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            ofdImage.Filter = "画像ファイル(*.jpg; *.png; *.bmp) | *.jpg; *.png; *.bmp";
            if (ofdImage.ShowDialog() == DialogResult.OK) {
                pbImage.Image = System.Drawing.Image.FromFile(ofdImage.FileName);
            }
        }

        private void btClear_Click(object sender, EventArgs e) {
            tbAddress.Text = "";
            tbMail.Text = "";
            tbMemo.Text = "";
            tbName.Text = "";
            tbTel.Text = "";
            pbImage.Image = null;
        }

 
        private void データベース接続ToolStripMenuItem_Click_1(object sender, EventArgs e) {
            this.addressTableTableAdapter.Fill(this.infosys202201DataSet.AddressTable);
        }

        private void btNameClear_Click(object sender, EventArgs e) {
            tbSearchName.Text = "";
            this.addressTableTableAdapter.Fill(this.infosys202201DataSet.AddressTable);
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            new Version().ShowDialog();
        }
    }
}
