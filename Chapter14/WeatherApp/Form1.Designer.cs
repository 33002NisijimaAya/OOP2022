
namespace WeatherApp {
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
            this.btWeatherImage = new System.Windows.Forms.Button();
            this.btWeatherforecast = new System.Windows.Forms.Button();
            this.textbox = new System.Windows.Forms.TextBox();
            this.pbWeatherImage = new System.Windows.Forms.PictureBox();
            this.pbWeatherforecast = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherforecast)).BeginInit();
            this.SuspendLayout();
            // 
            // btWeatherImage
            // 
            this.btWeatherImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btWeatherImage.Font = new System.Drawing.Font("メイリオ", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btWeatherImage.ForeColor = System.Drawing.Color.Black;
            this.btWeatherImage.Location = new System.Drawing.Point(155, 563);
            this.btWeatherImage.Name = "btWeatherImage";
            this.btWeatherImage.Size = new System.Drawing.Size(217, 38);
            this.btWeatherImage.TabIndex = 3;
            this.btWeatherImage.Text = "天気図";
            this.btWeatherImage.UseVisualStyleBackColor = true;
            this.btWeatherImage.Click += new System.EventHandler(this.btWeatherImage_Click);
            // 
            // btWeatherforecast
            // 
            this.btWeatherforecast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btWeatherforecast.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btWeatherforecast.ForeColor = System.Drawing.Color.Black;
            this.btWeatherforecast.Location = new System.Drawing.Point(155, 285);
            this.btWeatherforecast.Name = "btWeatherforecast";
            this.btWeatherforecast.Size = new System.Drawing.Size(217, 38);
            this.btWeatherforecast.TabIndex = 2;
            this.btWeatherforecast.Text = "天気予報";
            this.btWeatherforecast.UseVisualStyleBackColor = true;
            this.btWeatherforecast.Click += new System.EventHandler(this.btWeatherforecast_Click_1);
            // 
            // textbox
            // 
            this.textbox.BackColor = System.Drawing.SystemColors.Window;
            this.textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textbox.Location = new System.Drawing.Point(146, 38);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(239, 36);
            this.textbox.TabIndex = 4;
            this.textbox.Text = "お天気アプリ";
            this.textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbWeatherImage
            // 
            this.pbWeatherImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWeatherImage.Location = new System.Drawing.Point(35, 343);
            this.pbWeatherImage.Name = "pbWeatherImage";
            this.pbWeatherImage.Size = new System.Drawing.Size(456, 187);
            this.pbWeatherImage.TabIndex = 5;
            this.pbWeatherImage.TabStop = false;
            // 
            // pbWeatherforecast
            // 
            this.pbWeatherforecast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWeatherforecast.Location = new System.Drawing.Point(35, 99);
            this.pbWeatherforecast.Name = "pbWeatherforecast";
            this.pbWeatherforecast.Size = new System.Drawing.Size(456, 180);
            this.pbWeatherforecast.TabIndex = 5;
            this.pbWeatherforecast.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "閉じる";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(531, 633);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbWeatherforecast);
            this.Controls.Add(this.pbWeatherImage);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.btWeatherImage);
            this.Controls.Add(this.btWeatherforecast);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherforecast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btWeatherImage;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Button btWeatherforecast;
        private System.Windows.Forms.PictureBox pbWeatherImage;
        private System.Windows.Forms.PictureBox pbWeatherforecast;
        private System.Windows.Forms.Button button1;
    }
}

