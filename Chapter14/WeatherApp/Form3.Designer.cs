﻿
namespace WeatherApp {
    partial class Form3 {
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
            this.pbWeather = new System.Windows.Forms.PictureBox();
            this.btReturn = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.rbAsiaMonochrome = new System.Windows.Forms.RadioButton();
            this.rbAsia = new System.Windows.Forms.RadioButton();
            this.rbNearMonochrome = new System.Windows.Forms.RadioButton();
            this.rbNear = new System.Windows.Forms.RadioButton();
            this.tbWeatherShow = new System.Windows.Forms.Button();
            this.btReal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWeather
            // 
            this.pbWeather.Location = new System.Drawing.Point(12, 102);
            this.pbWeather.Name = "pbWeather";
            this.pbWeather.Size = new System.Drawing.Size(627, 405);
            this.pbWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWeather.TabIndex = 15;
            this.pbWeather.TabStop = false;
            // 
            // btReturn
            // 
            this.btReturn.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btReturn.Location = new System.Drawing.Point(460, 64);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(77, 32);
            this.btReturn.TabIndex = 13;
            this.btReturn.Text = "◀";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click_1);
            // 
            // btNext
            // 
            this.btNext.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btNext.Location = new System.Drawing.Point(563, 63);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(76, 32);
            this.btNext.TabIndex = 14;
            this.btNext.Text = "▶";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click_1);
            // 
            // rbAsiaMonochrome
            // 
            this.rbAsiaMonochrome.AutoSize = true;
            this.rbAsiaMonochrome.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbAsiaMonochrome.Location = new System.Drawing.Point(645, 430);
            this.rbAsiaMonochrome.Name = "rbAsiaMonochrome";
            this.rbAsiaMonochrome.Size = new System.Drawing.Size(168, 20);
            this.rbAsiaMonochrome.TabIndex = 9;
            this.rbAsiaMonochrome.TabStop = true;
            this.rbAsiaMonochrome.Text = "アジア太平洋域白黒";
            this.rbAsiaMonochrome.UseVisualStyleBackColor = true;
            // 
            // rbAsia
            // 
            this.rbAsia.AutoSize = true;
            this.rbAsia.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbAsia.Location = new System.Drawing.Point(645, 394);
            this.rbAsia.Name = "rbAsia";
            this.rbAsia.Size = new System.Drawing.Size(172, 20);
            this.rbAsia.TabIndex = 10;
            this.rbAsia.TabStop = true;
            this.rbAsia.Text = "アジア太平洋域カラー";
            this.rbAsia.UseVisualStyleBackColor = true;
            // 
            // rbNearMonochrome
            // 
            this.rbNearMonochrome.AutoSize = true;
            this.rbNearMonochrome.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbNearMonochrome.Location = new System.Drawing.Point(645, 358);
            this.rbNearMonochrome.Name = "rbNearMonochrome";
            this.rbNearMonochrome.Size = new System.Drawing.Size(128, 20);
            this.rbNearMonochrome.TabIndex = 11;
            this.rbNearMonochrome.TabStop = true;
            this.rbNearMonochrome.Text = "日本周辺白黒";
            this.rbNearMonochrome.UseVisualStyleBackColor = true;
            // 
            // rbNear
            // 
            this.rbNear.AutoSize = true;
            this.rbNear.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbNear.Location = new System.Drawing.Point(645, 322);
            this.rbNear.Name = "rbNear";
            this.rbNear.Size = new System.Drawing.Size(132, 20);
            this.rbNear.TabIndex = 12;
            this.rbNear.TabStop = true;
            this.rbNear.Text = "日本周辺カラー";
            this.rbNear.UseVisualStyleBackColor = true;
            // 
            // tbWeatherShow
            // 
            this.tbWeatherShow.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWeatherShow.Location = new System.Drawing.Point(645, 471);
            this.tbWeatherShow.Name = "tbWeatherShow";
            this.tbWeatherShow.Size = new System.Drawing.Size(162, 36);
            this.tbWeatherShow.TabIndex = 8;
            this.tbWeatherShow.Text = "天気図表示";
            this.tbWeatherShow.UseVisualStyleBackColor = true;
            this.tbWeatherShow.Click += new System.EventHandler(this.tbWeatherShow_Click_1);
            // 
            // btReal
            // 
            this.btReal.Location = new System.Drawing.Point(281, 59);
            this.btReal.Name = "btReal";
            this.btReal.Size = new System.Drawing.Size(159, 37);
            this.btReal.TabIndex = 16;
            this.btReal.Text = "最新の実況へ";
            this.btReal.UseVisualStyleBackColor = true;
            this.btReal.Click += new System.EventHandler(this.btReal_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(728, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 27);
            this.button1.TabIndex = 17;
            this.button1.Text = "閉じる";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(819, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btReal);
            this.Controls.Add(this.pbWeather);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.rbAsiaMonochrome);
            this.Controls.Add(this.rbAsia);
            this.Controls.Add(this.rbNearMonochrome);
            this.Controls.Add(this.rbNear);
            this.Controls.Add(this.tbWeatherShow);
            this.Name = "Form3";
            this.Text = "WeatherImage";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWeather;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.RadioButton rbAsiaMonochrome;
        private System.Windows.Forms.RadioButton rbAsia;
        private System.Windows.Forms.RadioButton rbNearMonochrome;
        private System.Windows.Forms.RadioButton rbNear;
        private System.Windows.Forms.Button tbWeatherShow;
        private System.Windows.Forms.Button btReal;
        private System.Windows.Forms.Button button1;
    }
}