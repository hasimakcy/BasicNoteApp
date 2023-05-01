namespace BasicNotApp
{
    partial class NotGoster
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Baslik = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_Duzenle = new System.Windows.Forms.Button();
            this.rtxt_icerik = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbl_Baslik
            // 
            this.lbl_Baslik.AutoSize = true;
            this.lbl_Baslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Baslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Baslik.Location = new System.Drawing.Point(0, 0);
            this.lbl_Baslik.Name = "lbl_Baslik";
            this.lbl_Baslik.Size = new System.Drawing.Size(73, 30);
            this.lbl_Baslik.TabIndex = 0;
            this.lbl_Baslik.Text = "Başlık";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(145, 12);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(38, 15);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "label2";
            this.lbl_id.Visible = false;
            // 
            // btn_Duzenle
            // 
            this.btn_Duzenle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Duzenle.Location = new System.Drawing.Point(0, 154);
            this.btn_Duzenle.Name = "btn_Duzenle";
            this.btn_Duzenle.Size = new System.Drawing.Size(448, 24);
            this.btn_Duzenle.TabIndex = 3;
            this.btn_Duzenle.Text = "Düzenle";
            this.btn_Duzenle.UseVisualStyleBackColor = true;
            this.btn_Duzenle.Click += new System.EventHandler(this.btn_Duzenle_Click);
            // 
            // rtxt_icerik
            // 
            this.rtxt_icerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_icerik.Location = new System.Drawing.Point(0, 30);
            this.rtxt_icerik.Name = "rtxt_icerik";
            this.rtxt_icerik.Size = new System.Drawing.Size(448, 148);
            this.rtxt_icerik.TabIndex = 4;
            this.rtxt_icerik.Text = "";
            // 
            // NotGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_Duzenle);
            this.Controls.Add(this.rtxt_icerik);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_Baslik);
            this.MinimumSize = new System.Drawing.Size(450, 150);
            this.Name = "NotGoster";
            this.Size = new System.Drawing.Size(448, 178);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label lbl_Baslik;
        private Button btn_Duzenle;
        public Label lbl_id;
        public RichTextBox rtxt_icerik;
    }
}
