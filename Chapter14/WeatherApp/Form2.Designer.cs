
namespace WeatherApp {
    partial class tbAfterTomorrow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.btWeatherGet = new System.Windows.Forms.Button();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.tbPublisher = new System.Windows.Forms.TextBox();
            this.tbTomorrow = new System.Windows.Forms.TextBox();
            this.tbToday = new System.Windows.Forms.TextBox();
            this.tbTodaymintemp = new System.Windows.Forms.TextBox();
            this.tbtodaymaxtemp = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbWeatherInfo = new System.Windows.Forms.TextBox();
            this.pbToday = new System.Windows.Forms.PictureBox();
            this.pbTomorrow = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbTodayDate = new System.Windows.Forms.Label();
            this.lbTomorrowDate = new System.Windows.Forms.Label();
            this.tbtomorrowmaxtemp = new System.Windows.Forms.TextBox();
            this.tbtomorrowmintemp = new System.Windows.Forms.TextBox();
            this.tbAfterTomorrowmax = new System.Windows.Forms.TextBox();
            this.tbAfterTomorrowmin = new System.Windows.Forms.TextBox();
            this.tbAfterTomorrow1 = new System.Windows.Forms.TextBox();
            this.pbAfterTomorrow = new System.Windows.Forms.PictureBox();
            this.lbAfterTomorrowDate = new System.Windows.Forms.Label();
            this.lbTomorrow2 = new System.Windows.Forms.Label();
            this.lbTomorrow3 = new System.Windows.Forms.Label();
            this.pbtomorrow2 = new System.Windows.Forms.PictureBox();
            this.pbtomorrow3 = new System.Windows.Forms.PictureBox();
            this.pbtomorrow4 = new System.Windows.Forms.PictureBox();
            this.tbtomorrow2max = new System.Windows.Forms.TextBox();
            this.tbtomorrow2min = new System.Windows.Forms.TextBox();
            this.tbtomorrow3max = new System.Windows.Forms.TextBox();
            this.tbtomorrow3min = new System.Windows.Forms.TextBox();
            this.tbtomorrow4max = new System.Windows.Forms.TextBox();
            this.tbtomorrow4min = new System.Windows.Forms.TextBox();
            this.lbTomorrow4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfterTomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtomorrow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtomorrow3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtomorrow4)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(277, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "報告日時";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(289, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "発表者";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(19, 588);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "天気概要";
            // 
            // cbArea
            // 
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(23, 41);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(170, 20);
            this.cbArea.TabIndex = 30;
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.Location = new System.Drawing.Point(199, 41);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(76, 20);
            this.btWeatherGet.TabIndex = 29;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = true;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // tbArea
            // 
            this.tbArea.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbArea.Enabled = false;
            this.tbArea.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbArea.Location = new System.Drawing.Point(23, 74);
            this.tbArea.Multiline = true;
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(252, 37);
            this.tbArea.TabIndex = 27;
            // 
            // tbPublisher
            // 
            this.tbPublisher.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbPublisher.Location = new System.Drawing.Point(350, 12);
            this.tbPublisher.Multiline = true;
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.Size = new System.Drawing.Size(166, 27);
            this.tbPublisher.TabIndex = 26;
            // 
            // tbTomorrow
            // 
            this.tbTomorrow.BackColor = System.Drawing.SystemColors.Menu;
            this.tbTomorrow.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTomorrow.Location = new System.Drawing.Point(227, 207);
            this.tbTomorrow.Multiline = true;
            this.tbTomorrow.Name = "tbTomorrow";
            this.tbTomorrow.Size = new System.Drawing.Size(208, 63);
            this.tbTomorrow.TabIndex = 25;
            // 
            // tbToday
            // 
            this.tbToday.BackColor = System.Drawing.SystemColors.Menu;
            this.tbToday.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbToday.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbToday.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbToday.Location = new System.Drawing.Point(227, 127);
            this.tbToday.Multiline = true;
            this.tbToday.Name = "tbToday";
            this.tbToday.Size = new System.Drawing.Size(208, 53);
            this.tbToday.TabIndex = 24;
            // 
            // tbTodaymintemp
            // 
            this.tbTodaymintemp.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTodaymintemp.ForeColor = System.Drawing.Color.DarkBlue;
            this.tbTodaymintemp.Location = new System.Drawing.Point(501, 134);
            this.tbTodaymintemp.Multiline = true;
            this.tbTodaymintemp.Name = "tbTodaymintemp";
            this.tbTodaymintemp.Size = new System.Drawing.Size(54, 36);
            this.tbTodaymintemp.TabIndex = 23;
            // 
            // tbtodaymaxtemp
            // 
            this.tbtodaymaxtemp.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbtodaymaxtemp.ForeColor = System.Drawing.Color.Red;
            this.tbtodaymaxtemp.Location = new System.Drawing.Point(441, 134);
            this.tbtodaymaxtemp.Multiline = true;
            this.tbtodaymaxtemp.Name = "tbtodaymaxtemp";
            this.tbtodaymaxtemp.Size = new System.Drawing.Size(54, 36);
            this.tbtodaymaxtemp.TabIndex = 22;
            // 
            // tbTime
            // 
            this.tbTime.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTime.Location = new System.Drawing.Point(350, 45);
            this.tbTime.Multiline = true;
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(166, 23);
            this.tbTime.TabIndex = 28;
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.Location = new System.Drawing.Point(119, 584);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.Size = new System.Drawing.Size(337, 137);
            this.tbWeatherInfo.TabIndex = 21;
            // 
            // pbToday
            // 
            this.pbToday.ErrorImage = null;
            this.pbToday.Location = new System.Drawing.Point(129, 117);
            this.pbToday.Name = "pbToday";
            this.pbToday.Size = new System.Drawing.Size(92, 63);
            this.pbToday.TabIndex = 38;
            this.pbToday.TabStop = false;
            // 
            // pbTomorrow
            // 
            this.pbTomorrow.ErrorImage = null;
            this.pbTomorrow.Location = new System.Drawing.Point(129, 207);
            this.pbTomorrow.Name = "pbTomorrow";
            this.pbTomorrow.Size = new System.Drawing.Size(92, 63);
            this.pbTomorrow.TabIndex = 38;
            this.pbTomorrow.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(20, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 12);
            this.textBox1.TabIndex = 39;
            this.textBox1.Text = "地域選択";
            // 
            // lbTodayDate
            // 
            this.lbTodayDate.BackColor = System.Drawing.Color.Transparent;
            this.lbTodayDate.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTodayDate.ForeColor = System.Drawing.Color.Black;
            this.lbTodayDate.Location = new System.Drawing.Point(23, 134);
            this.lbTodayDate.Name = "lbTodayDate";
            this.lbTodayDate.Size = new System.Drawing.Size(100, 40);
            this.lbTodayDate.TabIndex = 41;
            // 
            // lbTomorrowDate
            // 
            this.lbTomorrowDate.BackColor = System.Drawing.Color.Transparent;
            this.lbTomorrowDate.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTomorrowDate.ForeColor = System.Drawing.Color.Black;
            this.lbTomorrowDate.Location = new System.Drawing.Point(28, 219);
            this.lbTomorrowDate.Name = "lbTomorrowDate";
            this.lbTomorrowDate.Size = new System.Drawing.Size(95, 40);
            this.lbTomorrowDate.TabIndex = 41;
            // 
            // tbtomorrowmaxtemp
            // 
            this.tbtomorrowmaxtemp.BackColor = System.Drawing.SystemColors.Window;
            this.tbtomorrowmaxtemp.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbtomorrowmaxtemp.ForeColor = System.Drawing.Color.Red;
            this.tbtomorrowmaxtemp.Location = new System.Drawing.Point(441, 219);
            this.tbtomorrowmaxtemp.Multiline = true;
            this.tbtomorrowmaxtemp.Name = "tbtomorrowmaxtemp";
            this.tbtomorrowmaxtemp.Size = new System.Drawing.Size(54, 36);
            this.tbtomorrowmaxtemp.TabIndex = 22;
            // 
            // tbtomorrowmintemp
            // 
            this.tbtomorrowmintemp.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbtomorrowmintemp.ForeColor = System.Drawing.Color.DarkBlue;
            this.tbtomorrowmintemp.Location = new System.Drawing.Point(501, 218);
            this.tbtomorrowmintemp.Multiline = true;
            this.tbtomorrowmintemp.Name = "tbtomorrowmintemp";
            this.tbtomorrowmintemp.Size = new System.Drawing.Size(54, 36);
            this.tbtomorrowmintemp.TabIndex = 22;
            // 
            // tbAfterTomorrowmax
            // 
            this.tbAfterTomorrowmax.BackColor = System.Drawing.SystemColors.Window;
            this.tbAfterTomorrowmax.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbAfterTomorrowmax.ForeColor = System.Drawing.Color.Red;
            this.tbAfterTomorrowmax.Location = new System.Drawing.Point(441, 305);
            this.tbAfterTomorrowmax.Multiline = true;
            this.tbAfterTomorrowmax.Name = "tbAfterTomorrowmax";
            this.tbAfterTomorrowmax.Size = new System.Drawing.Size(54, 36);
            this.tbAfterTomorrowmax.TabIndex = 22;
            // 
            // tbAfterTomorrowmin
            // 
            this.tbAfterTomorrowmin.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbAfterTomorrowmin.ForeColor = System.Drawing.Color.DarkBlue;
            this.tbAfterTomorrowmin.Location = new System.Drawing.Point(501, 304);
            this.tbAfterTomorrowmin.Multiline = true;
            this.tbAfterTomorrowmin.Name = "tbAfterTomorrowmin";
            this.tbAfterTomorrowmin.Size = new System.Drawing.Size(54, 36);
            this.tbAfterTomorrowmin.TabIndex = 22;
            // 
            // tbAfterTomorrow1
            // 
            this.tbAfterTomorrow1.BackColor = System.Drawing.SystemColors.Menu;
            this.tbAfterTomorrow1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbAfterTomorrow1.Location = new System.Drawing.Point(227, 293);
            this.tbAfterTomorrow1.Multiline = true;
            this.tbAfterTomorrow1.Name = "tbAfterTomorrow1";
            this.tbAfterTomorrow1.Size = new System.Drawing.Size(208, 63);
            this.tbAfterTomorrow1.TabIndex = 25;
            // 
            // pbAfterTomorrow
            // 
            this.pbAfterTomorrow.ErrorImage = null;
            this.pbAfterTomorrow.Location = new System.Drawing.Point(129, 293);
            this.pbAfterTomorrow.Name = "pbAfterTomorrow";
            this.pbAfterTomorrow.Size = new System.Drawing.Size(92, 63);
            this.pbAfterTomorrow.TabIndex = 38;
            this.pbAfterTomorrow.TabStop = false;
            // 
            // lbAfterTomorrowDate
            // 
            this.lbAfterTomorrowDate.BackColor = System.Drawing.Color.Transparent;
            this.lbAfterTomorrowDate.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbAfterTomorrowDate.ForeColor = System.Drawing.Color.Black;
            this.lbAfterTomorrowDate.Location = new System.Drawing.Point(28, 305);
            this.lbAfterTomorrowDate.Name = "lbAfterTomorrowDate";
            this.lbAfterTomorrowDate.Size = new System.Drawing.Size(95, 40);
            this.lbAfterTomorrowDate.TabIndex = 41;
            // 
            // lbTomorrow2
            // 
            this.lbTomorrow2.BackColor = System.Drawing.Color.Transparent;
            this.lbTomorrow2.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTomorrow2.ForeColor = System.Drawing.Color.Black;
            this.lbTomorrow2.Location = new System.Drawing.Point(130, 379);
            this.lbTomorrow2.Name = "lbTomorrow2";
            this.lbTomorrow2.Size = new System.Drawing.Size(91, 39);
            this.lbTomorrow2.TabIndex = 41;
            // 
            // lbTomorrow3
            // 
            this.lbTomorrow3.BackColor = System.Drawing.Color.Transparent;
            this.lbTomorrow3.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTomorrow3.ForeColor = System.Drawing.Color.Black;
            this.lbTomorrow3.Location = new System.Drawing.Point(254, 379);
            this.lbTomorrow3.Name = "lbTomorrow3";
            this.lbTomorrow3.Size = new System.Drawing.Size(90, 39);
            this.lbTomorrow3.TabIndex = 41;
            // 
            // pbtomorrow2
            // 
            this.pbtomorrow2.BackColor = System.Drawing.Color.White;
            this.pbtomorrow2.ErrorImage = null;
            this.pbtomorrow2.Location = new System.Drawing.Point(129, 433);
            this.pbtomorrow2.Name = "pbtomorrow2";
            this.pbtomorrow2.Size = new System.Drawing.Size(92, 63);
            this.pbtomorrow2.TabIndex = 38;
            this.pbtomorrow2.TabStop = false;
            // 
            // pbtomorrow3
            // 
            this.pbtomorrow3.BackColor = System.Drawing.Color.White;
            this.pbtomorrow3.ErrorImage = null;
            this.pbtomorrow3.Location = new System.Drawing.Point(252, 433);
            this.pbtomorrow3.Name = "pbtomorrow3";
            this.pbtomorrow3.Size = new System.Drawing.Size(92, 63);
            this.pbtomorrow3.TabIndex = 38;
            this.pbtomorrow3.TabStop = false;
            // 
            // pbtomorrow4
            // 
            this.pbtomorrow4.BackColor = System.Drawing.Color.White;
            this.pbtomorrow4.ErrorImage = null;
            this.pbtomorrow4.Location = new System.Drawing.Point(385, 433);
            this.pbtomorrow4.Name = "pbtomorrow4";
            this.pbtomorrow4.Size = new System.Drawing.Size(92, 63);
            this.pbtomorrow4.TabIndex = 38;
            this.pbtomorrow4.TabStop = false;
            // 
            // tbtomorrow2max
            // 
            this.tbtomorrow2max.BackColor = System.Drawing.SystemColors.Window;
            this.tbtomorrow2max.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbtomorrow2max.ForeColor = System.Drawing.Color.Red;
            this.tbtomorrow2max.Location = new System.Drawing.Point(112, 515);
            this.tbtomorrow2max.Multiline = true;
            this.tbtomorrow2max.Name = "tbtomorrow2max";
            this.tbtomorrow2max.Size = new System.Drawing.Size(54, 36);
            this.tbtomorrow2max.TabIndex = 22;
            // 
            // tbtomorrow2min
            // 
            this.tbtomorrow2min.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbtomorrow2min.ForeColor = System.Drawing.Color.DarkBlue;
            this.tbtomorrow2min.Location = new System.Drawing.Point(181, 515);
            this.tbtomorrow2min.Multiline = true;
            this.tbtomorrow2min.Name = "tbtomorrow2min";
            this.tbtomorrow2min.Size = new System.Drawing.Size(54, 36);
            this.tbtomorrow2min.TabIndex = 22;
            // 
            // tbtomorrow3max
            // 
            this.tbtomorrow3max.BackColor = System.Drawing.SystemColors.Window;
            this.tbtomorrow3max.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbtomorrow3max.ForeColor = System.Drawing.Color.Red;
            this.tbtomorrow3max.Location = new System.Drawing.Point(240, 515);
            this.tbtomorrow3max.Multiline = true;
            this.tbtomorrow3max.Name = "tbtomorrow3max";
            this.tbtomorrow3max.Size = new System.Drawing.Size(54, 36);
            this.tbtomorrow3max.TabIndex = 22;
            // 
            // tbtomorrow3min
            // 
            this.tbtomorrow3min.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbtomorrow3min.ForeColor = System.Drawing.Color.DarkBlue;
            this.tbtomorrow3min.Location = new System.Drawing.Point(309, 515);
            this.tbtomorrow3min.Multiline = true;
            this.tbtomorrow3min.Name = "tbtomorrow3min";
            this.tbtomorrow3min.Size = new System.Drawing.Size(54, 36);
            this.tbtomorrow3min.TabIndex = 22;
            // 
            // tbtomorrow4max
            // 
            this.tbtomorrow4max.BackColor = System.Drawing.SystemColors.Window;
            this.tbtomorrow4max.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbtomorrow4max.ForeColor = System.Drawing.Color.Red;
            this.tbtomorrow4max.Location = new System.Drawing.Point(371, 515);
            this.tbtomorrow4max.Multiline = true;
            this.tbtomorrow4max.Name = "tbtomorrow4max";
            this.tbtomorrow4max.Size = new System.Drawing.Size(54, 36);
            this.tbtomorrow4max.TabIndex = 22;
            // 
            // tbtomorrow4min
            // 
            this.tbtomorrow4min.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbtomorrow4min.ForeColor = System.Drawing.Color.DarkBlue;
            this.tbtomorrow4min.Location = new System.Drawing.Point(440, 515);
            this.tbtomorrow4min.Multiline = true;
            this.tbtomorrow4min.Name = "tbtomorrow4min";
            this.tbtomorrow4min.Size = new System.Drawing.Size(54, 36);
            this.tbtomorrow4min.TabIndex = 22;
            // 
            // lbTomorrow4
            // 
            this.lbTomorrow4.BackColor = System.Drawing.Color.Transparent;
            this.lbTomorrow4.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTomorrow4.ForeColor = System.Drawing.Color.Black;
            this.lbTomorrow4.Location = new System.Drawing.Point(387, 379);
            this.lbTomorrow4.Name = "lbTomorrow4";
            this.lbTomorrow4.Size = new System.Drawing.Size(90, 39);
            this.lbTomorrow4.TabIndex = 41;
            // 
            // tbAfterTomorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 733);
            this.Controls.Add(this.lbTomorrow4);
            this.Controls.Add(this.lbTomorrow3);
            this.Controls.Add(this.lbTomorrow2);
            this.Controls.Add(this.lbAfterTomorrowDate);
            this.Controls.Add(this.lbTomorrowDate);
            this.Controls.Add(this.lbTodayDate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pbAfterTomorrow);
            this.Controls.Add(this.pbTomorrow);
            this.Controls.Add(this.pbtomorrow4);
            this.Controls.Add(this.pbtomorrow3);
            this.Controls.Add(this.pbtomorrow2);
            this.Controls.Add(this.pbToday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.btWeatherGet);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.tbPublisher);
            this.Controls.Add(this.tbAfterTomorrow1);
            this.Controls.Add(this.tbTomorrow);
            this.Controls.Add(this.tbToday);
            this.Controls.Add(this.tbtomorrow4min);
            this.Controls.Add(this.tbtomorrow3min);
            this.Controls.Add(this.tbtomorrow2min);
            this.Controls.Add(this.tbtomorrow4max);
            this.Controls.Add(this.tbAfterTomorrowmin);
            this.Controls.Add(this.tbtomorrow3max);
            this.Controls.Add(this.tbTodaymintemp);
            this.Controls.Add(this.tbtomorrow2max);
            this.Controls.Add(this.tbAfterTomorrowmax);
            this.Controls.Add(this.tbtomorrowmintemp);
            this.Controls.Add(this.tbtomorrowmaxtemp);
            this.Controls.Add(this.tbtodaymaxtemp);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.tbWeatherInfo);
            this.Name = "tbAfterTomorrow";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTomorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfterTomorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtomorrow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtomorrow3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtomorrow4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.TextBox tbPublisher;
        private System.Windows.Forms.TextBox tbTomorrow;
        private System.Windows.Forms.TextBox tbToday;
        private System.Windows.Forms.TextBox tbTodaymintemp;
        private System.Windows.Forms.TextBox tbtodaymaxtemp;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbWeatherInfo;
        private System.Windows.Forms.PictureBox pbToday;
        private System.Windows.Forms.PictureBox pbTomorrow;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbTodayDate;
        private System.Windows.Forms.Label lbTomorrowDate;
        private System.Windows.Forms.TextBox tbtomorrowmaxtemp;
        private System.Windows.Forms.TextBox tbtomorrowmintemp;
        private System.Windows.Forms.TextBox tbAfterTomorrowmax;
        private System.Windows.Forms.TextBox tbAfterTomorrowmin;
        private System.Windows.Forms.TextBox tbAfterTomorrow1;
        private System.Windows.Forms.PictureBox pbAfterTomorrow;
        private System.Windows.Forms.Label lbAfterTomorrowDate;
        private System.Windows.Forms.Label lbTomorrow2;
        private System.Windows.Forms.Label lbTomorrow3;
        private System.Windows.Forms.PictureBox pbtomorrow2;
        private System.Windows.Forms.PictureBox pbtomorrow3;
        private System.Windows.Forms.PictureBox pbtomorrow4;
        private System.Windows.Forms.TextBox tbtomorrow2max;
        private System.Windows.Forms.TextBox tbtomorrow2min;
        private System.Windows.Forms.TextBox tbtomorrow3max;
        private System.Windows.Forms.TextBox tbtomorrow3min;
        private System.Windows.Forms.TextBox tbtomorrow4max;
        private System.Windows.Forms.TextBox tbtomorrow4min;
        private System.Windows.Forms.Label lbTomorrow4;
    }
}