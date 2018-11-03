namespace CeVIO_App_Test
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Talk_btn = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 19);
            this.textBox1.TabIndex = 0;
            // 
            // Talk_btn
            // 
            this.Talk_btn.Location = new System.Drawing.Point(227, 30);
            this.Talk_btn.Name = "Talk_btn";
            this.Talk_btn.Size = new System.Drawing.Size(75, 19);
            this.Talk_btn.TabIndex = 1;
            this.Talk_btn.Text = "しゃべる！";
            this.Talk_btn.UseVisualStyleBackColor = true;
            this.Talk_btn.Click += new System.EventHandler(this.Talk_btn_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(14, 1);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(149, 23);
            this.Start.TabIndex = 2;
            this.Start.Text = "CeVIO起動";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click_1);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(169, 1);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(133, 23);
            this.Close.TabIndex = 3;
            this.Close.Text = "CeVIO終了";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 61);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Talk_btn);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Talk_btn;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Close;
    }
}

