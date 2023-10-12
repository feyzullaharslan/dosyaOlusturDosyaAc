namespace dosyaOlusturDosyaAc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.olusturBtn = new System.Windows.Forms.Button();
            this.calistirBtn = new System.Windows.Forms.Button();
            this.dosyaismiTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // olusturBtn
            // 
            this.olusturBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.olusturBtn.Location = new System.Drawing.Point(12, 63);
            this.olusturBtn.Name = "olusturBtn";
            this.olusturBtn.Size = new System.Drawing.Size(200, 62);
            this.olusturBtn.TabIndex = 0;
            this.olusturBtn.Text = ".txt Dosyası Oluştur";
            this.olusturBtn.UseVisualStyleBackColor = true;
            this.olusturBtn.Click += new System.EventHandler(this.olusturBtn_Click);
            // 
            // calistirBtn
            // 
            this.calistirBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calistirBtn.Location = new System.Drawing.Point(12, 131);
            this.calistirBtn.Name = "calistirBtn";
            this.calistirBtn.Size = new System.Drawing.Size(200, 62);
            this.calistirBtn.TabIndex = 1;
            this.calistirBtn.Text = ".txt Dosyası Çalıştır";
            this.calistirBtn.UseVisualStyleBackColor = true;
            this.calistirBtn.Click += new System.EventHandler(this.calistirBtn_Click);
            // 
            // dosyaismiTxt
            // 
            this.dosyaismiTxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosyaismiTxt.Location = new System.Drawing.Point(42, 23);
            this.dosyaismiTxt.Name = "dosyaismiTxt";
            this.dosyaismiTxt.Size = new System.Drawing.Size(149, 23);
            this.dosyaismiTxt.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 208);
            this.Controls.Add(this.dosyaismiTxt);
            this.Controls.Add(this.calistirBtn);
            this.Controls.Add(this.olusturBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button olusturBtn;
        private System.Windows.Forms.Button calistirBtn;
        private System.Windows.Forms.TextBox dosyaismiTxt;
    }
}

