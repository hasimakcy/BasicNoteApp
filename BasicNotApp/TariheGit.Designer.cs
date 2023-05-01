namespace BasicNotApp
{
    partial class TariheGit
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_git = new System.Windows.Forms.Button();
            this.btn_cıkıs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(93, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tarih";
            // 
            // btn_git
            // 
            this.btn_git.Location = new System.Drawing.Point(259, 69);
            this.btn_git.Name = "btn_git";
            this.btn_git.Size = new System.Drawing.Size(66, 26);
            this.btn_git.TabIndex = 13;
            this.btn_git.Text = "Git";
            this.btn_git.UseVisualStyleBackColor = true;
            this.btn_git.Click += new System.EventHandler(this.btn_git_Click);
            // 
            // btn_cıkıs
            // 
            this.btn_cıkıs.Location = new System.Drawing.Point(187, 69);
            this.btn_cıkıs.Name = "btn_cıkıs";
            this.btn_cıkıs.Size = new System.Drawing.Size(66, 26);
            this.btn_cıkıs.TabIndex = 14;
            this.btn_cıkıs.Text = "Çıkış";
            this.btn_cıkıs.UseVisualStyleBackColor = true;
            this.btn_cıkıs.Click += new System.EventHandler(this.btn_cıkıs_Click);
            // 
            // TariheGit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 110);
            this.Controls.Add(this.btn_cıkıs);
            this.Controls.Add(this.btn_git);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Name = "TariheGit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TariheGit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Button btn_git;
        private Button btn_cıkıs;
    }
}