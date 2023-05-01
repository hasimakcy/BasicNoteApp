namespace BasicNotApp
{
    partial class NotEkle
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
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_cıkıs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_baslik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_KayıtNo = new System.Windows.Forms.TextBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_icerik = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(509, 345);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(92, 41);
            this.btn_Kaydet.TabIndex = 0;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_cıkıs
            // 
            this.btn_cıkıs.Location = new System.Drawing.Point(313, 345);
            this.btn_cıkıs.Name = "btn_cıkıs";
            this.btn_cıkıs.Size = new System.Drawing.Size(92, 41);
            this.btn_cıkıs.TabIndex = 1;
            this.btn_cıkıs.Text = "Çıkış";
            this.btn_cıkıs.UseVisualStyleBackColor = true;
            this.btn_cıkıs.Click += new System.EventHandler(this.btn_cıkıs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlık";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "İçerik";
            // 
            // txt_baslik
            // 
            this.txt_baslik.Location = new System.Drawing.Point(96, 109);
            this.txt_baslik.Name = "txt_baslik";
            this.txt_baslik.Size = new System.Drawing.Size(200, 23);
            this.txt_baslik.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kayıt No";
            this.label3.Visible = false;
            // 
            // txt_KayıtNo
            // 
            this.txt_KayıtNo.Location = new System.Drawing.Point(96, 41);
            this.txt_KayıtNo.Name = "txt_KayıtNo";
            this.txt_KayıtNo.Size = new System.Drawing.Size(61, 23);
            this.txt_KayıtNo.TabIndex = 7;
            this.txt_KayıtNo.Text = "0";
            this.txt_KayıtNo.Visible = false;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(411, 345);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(92, 41);
            this.btn_sil.TabIndex = 8;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tarih";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // txt_icerik
            // 
            this.txt_icerik.Location = new System.Drawing.Point(96, 141);
            this.txt_icerik.Name = "txt_icerik";
            this.txt_icerik.Size = new System.Drawing.Size(505, 198);
            this.txt_icerik.TabIndex = 11;
            this.txt_icerik.Text = "";
            // 
            // NotEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 405);
            this.Controls.Add(this.txt_icerik);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.txt_KayıtNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_baslik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cıkıs);
            this.Controls.Add(this.btn_Kaydet);
            this.Name = "NotEkle";
            this.Text = "NotEkle";
            this.Load += new System.EventHandler(this.NotEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Kaydet;
        private Button btn_cıkıs;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_sil;
        public TextBox txt_KayıtNo;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        public TextBox txt_baslik;
        public RichTextBox txt_icerik;
    }
}