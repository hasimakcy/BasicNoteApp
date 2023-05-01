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
    public partial class NotGoster : UserControl
    {
        public NotGoster()
        {
            InitializeComponent();
        }

        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
            NotEkle n1 = new NotEkle();
            n1.txt_KayıtNo.Text = lbl_id.Text;
            n1.ShowDialog();

            lbl_Baslik.Text = n1.txt_baslik.Text;
            rtxt_icerik.Text = n1.txt_icerik.Text;
        }
    }
}
