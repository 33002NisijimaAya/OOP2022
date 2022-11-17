
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
            this.SuspendLayout();
            // 
            // btWeatherImage
            // 
            this.btWeatherImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btWeatherImage.Font = new System.Drawing.Font("メイリオ", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btWeatherImage.Location = new System.Drawing.Point(131, 264);
            this.btWeatherImage.Name = "btWeatherImage";
            this.btWeatherImage.Size = new System.Drawing.Size(257, 81);
            this.btWeatherImage.TabIndex = 3;
            this.btWeatherImage.Text = "天気図";
            this.btWeatherImage.UseVisualStyleBackColor = true;
            this.btWeatherImage.Click += new System.EventHandler(this.btWeatherImage_Click);
            // 
            // btWeatherforecast
            // 
            this.btWeatherforecast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btWeatherforecast.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btWeatherforecast.Location = new System.Drawing.Point(131, 136);
            this.btWeatherforecast.Name = "btWeatherforecast";
            this.btWeatherforecast.Size = new System.Drawing.Size(257, 91);
            this.btWeatherforecast.TabIndex = 2;
            this.btWeatherforecast.Text = "天気予報";
            this.btWeatherforecast.UseVisualStyleBackColor = true;
            this.btWeatherforecast.Click += new System.EventHandler(this.btWeatherforecast_Click_1);
            // 
            // textbox
            // 
            this.textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textbox.Location = new System.Drawing.Point(140, 56);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(239, 36);
            this.textbox.TabIndex = 4;
            this.textbox.Text = "お天気アプリ";
            this.textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 633);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.btWeatherImage);
            this.Controls.Add(this.btWeatherforecast);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btWeatherImage;
        private System.Windows.Forms.Button btWeatherforecast;
        private System.Windows.Forms.TextBox textbox;
    }
}

