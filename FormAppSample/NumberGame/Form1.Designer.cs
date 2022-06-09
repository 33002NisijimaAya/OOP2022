
namespace NumberGame {
    partial class form {
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
            this.nup1 = new System.Windows.Forms.NumericUpDown();
            this.bt1 = new System.Windows.Forms.Button();
            this.Ans = new System.Windows.Forms.Label();
            this.Hinto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nup2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(54, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "1から";
            // 
            // nup1
            // 
            this.nup1.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nup1.Location = new System.Drawing.Point(58, 132);
            this.nup1.Name = "nup1";
            this.nup1.Size = new System.Drawing.Size(120, 71);
            this.nup1.TabIndex = 1;
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt1.Location = new System.Drawing.Point(295, 147);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(183, 56);
            this.bt1.TabIndex = 2;
            this.bt1.Text = "入力";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // Ans
            // 
            this.Ans.AutoSize = true;
            this.Ans.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Ans.Location = new System.Drawing.Point(61, 238);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(260, 35);
            this.Ans.TabIndex = 3;
            this.Ans.Text = "正解？不正解？";
            // 
            // Hinto
            // 
            this.Hinto.AutoSize = true;
            this.Hinto.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Hinto.Location = new System.Drawing.Point(64, 302);
            this.Hinto.Name = "Hinto";
            this.Hinto.Size = new System.Drawing.Size(0, 27);
            this.Hinto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(169, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "の中から選んだ数字を当ててください";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(169, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "の中から選んだ数字を当ててください";
            // 
            // nup2
            // 
            this.nup2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nup2.Location = new System.Drawing.Point(110, 52);
            this.nup2.Name = "nup2";
            this.nup2.Size = new System.Drawing.Size(59, 39);
            this.nup2.TabIndex = 1;
            this.nup2.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nup2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 386);
            this.Controls.Add(this.Hinto);
            this.Controls.Add(this.Ans);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.nup2);
            this.Controls.Add(this.nup1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nup1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Label Ans;
        private System.Windows.Forms.Label Hinto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nup2;
    }
}

