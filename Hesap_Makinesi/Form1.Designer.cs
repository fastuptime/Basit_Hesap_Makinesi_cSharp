namespace Hesap_Makinesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.islem = new System.Windows.Forms.ComboBox();
            this.sonuc = new System.Windows.Forms.Label();
            this.hesapla = new System.Windows.Forms.Button();
            this.deger_1 = new System.Windows.Forms.NumericUpDown();
            this.deger_2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.deger_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deger_2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Değer 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Değer 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(299, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "İşlem:";
            // 
            // islem
            // 
            this.islem.FormattingEnabled = true;
            this.islem.Items.AddRange(new object[] {
            "Toplama",
            "Çıkarma",
            "Bölme",
            "Çarpma"});
            this.islem.Location = new System.Drawing.Point(355, 34);
            this.islem.Name = "islem";
            this.islem.Size = new System.Drawing.Size(160, 23);
            this.islem.TabIndex = 5;
            // 
            // sonuc
            // 
            this.sonuc.AutoSize = true;
            this.sonuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sonuc.Location = new System.Drawing.Point(299, 79);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(56, 21);
            this.sonuc.TabIndex = 6;
            this.sonuc.Text = "Sonuç:";
            // 
            // hesapla
            // 
            this.hesapla.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hesapla.Location = new System.Drawing.Point(24, 126);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(491, 49);
            this.hesapla.TabIndex = 7;
            this.hesapla.Text = "Hesapla";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // deger_1
            // 
            this.deger_1.Location = new System.Drawing.Point(98, 32);
            this.deger_1.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
            this.deger_1.Name = "deger_1";
            this.deger_1.Size = new System.Drawing.Size(185, 23);
            this.deger_1.TabIndex = 8;
            // 
            // deger_2
            // 
            this.deger_2.Location = new System.Drawing.Point(98, 80);
            this.deger_2.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
            this.deger_2.Name = "deger_2";
            this.deger_2.Size = new System.Drawing.Size(185, 23);
            this.deger_2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 187);
            this.Controls.Add(this.deger_2);
            this.Controls.Add(this.deger_1);
            this.Controls.Add(this.hesapla);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.islem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Basit Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deger_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deger_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox islem;
        private Label sonuc;
        private Button hesapla;
        private NumericUpDown deger_1;
        private NumericUpDown deger_2;
    }
}