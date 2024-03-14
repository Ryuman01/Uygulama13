namespace Uygulama13
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumaraN = new System.Windows.Forms.TextBox();
            this.txtAdSoyadN = new System.Windows.Forms.TextBox();
            this.rbBay = new System.Windows.Forms.RadioButton();
            this.rbBayan = new System.Windows.Forms.RadioButton();
            this.lbNesne = new System.Windows.Forms.ListBox();
            this.btnEkleNesne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyet";
            // 
            // txtNumaraN
            // 
            this.txtNumaraN.Location = new System.Drawing.Point(219, 139);
            this.txtNumaraN.Name = "txtNumaraN";
            this.txtNumaraN.Size = new System.Drawing.Size(100, 20);
            this.txtNumaraN.TabIndex = 3;
            // 
            // txtAdSoyadN
            // 
            this.txtAdSoyadN.Location = new System.Drawing.Point(219, 166);
            this.txtAdSoyadN.Name = "txtAdSoyadN";
            this.txtAdSoyadN.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyadN.TabIndex = 4;
            // 
            // rbBay
            // 
            this.rbBay.AutoSize = true;
            this.rbBay.Location = new System.Drawing.Point(222, 199);
            this.rbBay.Name = "rbBay";
            this.rbBay.Size = new System.Drawing.Size(53, 17);
            this.rbBay.TabIndex = 5;
            this.rbBay.TabStop = true;
            this.rbBay.Text = "Erkek";
            this.rbBay.UseVisualStyleBackColor = true;
            // 
            // rbBayan
            // 
            this.rbBayan.AutoSize = true;
            this.rbBayan.Location = new System.Drawing.Point(338, 199);
            this.rbBayan.Name = "rbBayan";
            this.rbBayan.Size = new System.Drawing.Size(52, 17);
            this.rbBayan.TabIndex = 6;
            this.rbBayan.TabStop = true;
            this.rbBayan.Text = "Kadın";
            this.rbBayan.UseVisualStyleBackColor = true;
            // 
            // lbNesne
            // 
            this.lbNesne.FormattingEnabled = true;
            this.lbNesne.Location = new System.Drawing.Point(150, 240);
            this.lbNesne.Name = "lbNesne";
            this.lbNesne.Size = new System.Drawing.Size(283, 95);
            this.lbNesne.TabIndex = 7;
            // 
            // btnEkleNesne
            // 
            this.btnEkleNesne.Location = new System.Drawing.Point(356, 143);
            this.btnEkleNesne.Name = "btnEkleNesne";
            this.btnEkleNesne.Size = new System.Drawing.Size(77, 43);
            this.btnEkleNesne.TabIndex = 8;
            this.btnEkleNesne.Text = "Ekle";
            this.btnEkleNesne.UseVisualStyleBackColor = true;
            this.btnEkleNesne.Click += new System.EventHandler(this.btnEkleNesne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEkleNesne);
            this.Controls.Add(this.lbNesne);
            this.Controls.Add(this.rbBayan);
            this.Controls.Add(this.rbBay);
            this.Controls.Add(this.txtAdSoyadN);
            this.Controls.Add(this.txtNumaraN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumaraN;
        private System.Windows.Forms.TextBox txtAdSoyadN;
        private System.Windows.Forms.RadioButton rbBay;
        private System.Windows.Forms.RadioButton rbBayan;
        private System.Windows.Forms.ListBox lbNesne;
        private System.Windows.Forms.Button btnEkleNesne;
    }
}

