using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicNotApp
{
    public partial class TariheGit : Form
    {
        public TariheGit()
        {
            InitializeComponent();
        }
        public DateTime Tarih = DateTime.Now;
        public int devam = 0;
        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_git_Click(object sender, EventArgs e)
        {
            devam = 1;
            Tarih = Convert.ToDateTime(dateTimePicker1.Value);
            Close();
        }
    }
}
