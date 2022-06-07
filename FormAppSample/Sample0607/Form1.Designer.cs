
namespace Sample0607 {
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
            this.button1 = new System.Windows.Forms.Button();
            this.NupNum1 = new System.Windows.Forms.NumericUpDown();
            this.NupNum2 = new System.Windows.Forms.NumericUpDown();
            this.nupAns = new System.Windows.Forms.NumericUpDown();
            this.nupMod = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NupNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NupNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMod)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(146, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "÷";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(333, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "＝";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(499, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "あまり";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(650, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NupNum1
            // 
            this.NupNum1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NupNum1.Location = new System.Drawing.Point(20, 63);
            this.NupNum1.Name = "NupNum1";
            this.NupNum1.Size = new System.Drawing.Size(120, 44);
            this.NupNum1.TabIndex = 3;
            // 
            // NupNum2
            // 
            this.NupNum2.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NupNum2.Location = new System.Drawing.Point(207, 61);
            this.NupNum2.Name = "NupNum2";
            this.NupNum2.Size = new System.Drawing.Size(120, 44);
            this.NupNum2.TabIndex = 4;
            // 
            // nupAns
            // 
            this.nupAns.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nupAns.Location = new System.Drawing.Point(373, 61);
            this.nupAns.Name = "nupAns";
            this.nupAns.Size = new System.Drawing.Size(120, 44);
            this.nupAns.TabIndex = 4;
            // 
            // nupMod
            // 
            this.nupMod.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nupMod.Location = new System.Drawing.Point(603, 61);
            this.nupMod.Name = "nupMod";
            this.nupMod.Size = new System.Drawing.Size(120, 44);
            this.nupMod.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 245);
            this.Controls.Add(this.nupAns);
            this.Controls.Add(this.nupMod);
            this.Controls.Add(this.NupNum2);
            this.Controls.Add(this.NupNum1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "計算アプリ";
            ((System.ComponentModel.ISupportInitialize)(this.NupNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NupNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown NupNum1;
        private System.Windows.Forms.NumericUpDown NupNum2;
        private System.Windows.Forms.NumericUpDown nupAns;
        private System.Windows.Forms.NumericUpDown nupMod;
    }
}

