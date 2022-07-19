
namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.cbRecorder = new System.Windows.Forms.ComboBox();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbOutcar = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.btOpen = new System.Windows.Forms.Button();
            this.btPictureClear = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btPictureOpen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pbCarPicture = new System.Windows.Forms.PictureBox();
            this.btAddCarReport = new System.Windows.Forms.Button();
            this.btCurrect = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.ofdFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cdColorSelect = new System.Windows.Forms.ColorDialog();
            this.btSizeChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarPicture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "レポート：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "記事一覧：";
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.Location = new System.Drawing.Point(84, 37);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(200, 19);
            this.dtpDateTime.TabIndex = 1;
            // 
            // cbRecorder
            // 
            this.cbRecorder.FormattingEnabled = true;
            this.cbRecorder.Location = new System.Drawing.Point(84, 72);
            this.cbRecorder.Name = "cbRecorder";
            this.cbRecorder.Size = new System.Drawing.Size(200, 20);
            this.cbRecorder.TabIndex = 2;
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Location = new System.Drawing.Point(84, 106);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(47, 16);
            this.rbToyota.TabIndex = 3;
            this.rbToyota.TabStop = true;
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Location = new System.Drawing.Point(137, 106);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(47, 16);
            this.rbNissan.TabIndex = 3;
            this.rbNissan.TabStop = true;
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(190, 106);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 3;
            this.rbHonda.TabStop = true;
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.Location = new System.Drawing.Point(247, 106);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(52, 16);
            this.rbSubaru.TabIndex = 3;
            this.rbSubaru.TabStop = true;
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbOutcar
            // 
            this.rbOutcar.AutoSize = true;
            this.rbOutcar.Location = new System.Drawing.Point(305, 106);
            this.rbOutcar.Name = "rbOutcar";
            this.rbOutcar.Size = new System.Drawing.Size(59, 16);
            this.rbOutcar.TabIndex = 3;
            this.rbOutcar.TabStop = true;
            this.rbOutcar.Text = "外国車";
            this.rbOutcar.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(370, 106);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(54, 16);
            this.rbOther.TabIndex = 3;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "その他";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(84, 133);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(200, 20);
            this.cbCarName.TabIndex = 2;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(84, 176);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(360, 119);
            this.tbReport.TabIndex = 4;
            // 
            // dgvArticles
            // 
            this.dgvArticles.AllowUserToAddRows = false;
            this.dgvArticles.AllowUserToResizeColumns = false;
            this.dgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticles.Location = new System.Drawing.Point(84, 314);
            this.dgvArticles.MultiSelect = false;
            this.dgvArticles.Name = "dgvArticles";
            this.dgvArticles.RowTemplate.Height = 21;
            this.dgvArticles.Size = new System.Drawing.Size(628, 191);
            this.dgvArticles.TabIndex = 5;
            this.dgvArticles.Click += new System.EventHandler(this.dgvArticles_Click);
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(3, 341);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 6;
            this.btOpen.Text = "開く...";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btPictureClear
            // 
            this.btPictureClear.Location = new System.Drawing.Point(592, 43);
            this.btPictureClear.Name = "btPictureClear";
            this.btPictureClear.Size = new System.Drawing.Size(75, 23);
            this.btPictureClear.TabIndex = 6;
            this.btPictureClear.Text = "削除";
            this.btPictureClear.UseVisualStyleBackColor = true;
            this.btPictureClear.Click += new System.EventHandler(this.btPictureClear_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(3, 469);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "終了";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btPictureOpen
            // 
            this.btPictureOpen.Location = new System.Drawing.Point(511, 43);
            this.btPictureOpen.Name = "btPictureOpen";
            this.btPictureOpen.Size = new System.Drawing.Size(75, 23);
            this.btPictureOpen.TabIndex = 6;
            this.btPictureOpen.Text = "開く...";
            this.btPictureOpen.UseVisualStyleBackColor = true;
            this.btPictureOpen.Click += new System.EventHandler(this.btPictureOpen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "画像：";
            // 
            // pbCarPicture
            // 
            this.pbCarPicture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbCarPicture.Location = new System.Drawing.Point(490, 72);
            this.pbCarPicture.Name = "pbCarPicture";
            this.pbCarPicture.Size = new System.Drawing.Size(222, 194);
            this.pbCarPicture.TabIndex = 7;
            this.pbCarPicture.TabStop = false;
            // 
            // btAddCarReport
            // 
            this.btAddCarReport.Location = new System.Drawing.Point(472, 272);
            this.btAddCarReport.Name = "btAddCarReport";
            this.btAddCarReport.Size = new System.Drawing.Size(75, 23);
            this.btAddCarReport.TabIndex = 6;
            this.btAddCarReport.Text = "追加";
            this.btAddCarReport.UseVisualStyleBackColor = true;
            this.btAddCarReport.Click += new System.EventHandler(this.btAddCarReport_Click);
            // 
            // btCurrect
            // 
            this.btCurrect.Location = new System.Drawing.Point(553, 272);
            this.btCurrect.Name = "btCurrect";
            this.btCurrect.Size = new System.Drawing.Size(75, 23);
            this.btCurrect.TabIndex = 6;
            this.btCurrect.Text = "修正";
            this.btCurrect.UseVisualStyleBackColor = true;
            this.btCurrect.Click += new System.EventHandler(this.btCurrect_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(634, 272);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(3, 370);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "保存...";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // ofdFileOpenDialog
            // 
            this.ofdFileOpenDialog.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.設定ToolStripMenuItem,
            this.toolStripSeparator1,
            this.終了ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル（&F)";
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.開くToolStripMenuItem.Text = "開く...";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.保存ToolStripMenuItem.Text = "保存...";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.btSave_Click);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.設定ToolStripMenuItem.Text = "色設定...";
            this.設定ToolStripMenuItem.Click += new System.EventHandler(this.設定ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(116, 6);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btSizeChange
            // 
            this.btSizeChange.Location = new System.Drawing.Point(669, 43);
            this.btSizeChange.Name = "btSizeChange";
            this.btSizeChange.Size = new System.Drawing.Size(63, 23);
            this.btSizeChange.TabIndex = 6;
            this.btSizeChange.Text = "☆";
            this.btSizeChange.UseVisualStyleBackColor = true;
            this.btSizeChange.Click += new System.EventHandler(this.btSizeChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 526);
            this.Controls.Add(this.pbCarPicture);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSizeChange);
            this.Controls.Add(this.btPictureClear);
            this.Controls.Add(this.btAddCarReport);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btCurrect);
            this.Controls.Add(this.btPictureOpen);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.dgvArticles);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.rbOther);
            this.Controls.Add(this.rbOutcar);
            this.Controls.Add(this.rbSubaru);
            this.Controls.Add(this.rbHonda);
            this.Controls.Add(this.rbNissan);
            this.Controls.Add(this.rbToyota);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.cbRecorder);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "試乗レポート管理システム";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarPicture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.ComboBox cbRecorder;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbOutcar;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.DataGridView dgvArticles;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btPictureClear;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btPictureOpen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbCarPicture;
        private System.Windows.Forms.Button btAddCarReport;
        private System.Windows.Forms.Button btCurrect;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.OpenFileDialog ofdFileOpenDialog;
        private System.Windows.Forms.SaveFileDialog sfdSaveDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ColorDialog cdColorSelect;
        private System.Windows.Forms.Button btSizeChange;
    }
}

