namespace BasicNotApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sonra = new System.Windows.Forms.Button();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.btn_once = new System.Windows.Forms.Button();
            this.btn_trhgit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ekle);
            this.panel1.Controls.Add(this.btn_sonra);
            this.panel1.Controls.Add(this.lbl_tarih);
            this.panel1.Controls.Add(this.btn_once);
            this.panel1.Controls.Add(this.btn_trhgit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 450);
            this.panel1.TabIndex = 0;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(13, 362);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(241, 39);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "Not Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sonra
            // 
            this.btn_sonra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sonra.Location = new System.Drawing.Point(177, 407);
            this.btn_sonra.Name = "btn_sonra";
            this.btn_sonra.Size = new System.Drawing.Size(77, 31);
            this.btn_sonra.TabIndex = 3;
            this.btn_sonra.Text = "Sonraki";
            this.btn_sonra.UseVisualStyleBackColor = true;
            this.btn_sonra.Click += new System.EventHandler(this.btn_sonra_Click);
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_tarih.Location = new System.Drawing.Point(12, 9);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(59, 25);
            this.lbl_tarih.TabIndex = 1;
            this.lbl_tarih.Text = "label1";
            // 
            // btn_once
            // 
            this.btn_once.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_once.Location = new System.Drawing.Point(12, 407);
            this.btn_once.Name = "btn_once";
            this.btn_once.Size = new System.Drawing.Size(76, 31);
            this.btn_once.TabIndex = 2;
            this.btn_once.Text = "Önceki";
            this.btn_once.UseVisualStyleBackColor = true;
            this.btn_once.Click += new System.EventHandler(this.btn_once_Click);
            // 
            // btn_trhgit
            // 
            this.btn_trhgit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_trhgit.Location = new System.Drawing.Point(94, 407);
            this.btn_trhgit.Name = "btn_trhgit";
            this.btn_trhgit.Size = new System.Drawing.Size(77, 31);
            this.btn_trhgit.TabIndex = 1;
            this.btn_trhgit.Text = "Tarihe Git";
            this.btn_trhgit.UseVisualStyleBackColor = true;
            this.btn_trhgit.Click += new System.EventHandler(this.btn_trhgit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(269, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(531, 450);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lbl_tarih;
        private Button btn_sonra;
        private Button btn_once;
        private Button btn_trhgit;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_ekle;
    }
}