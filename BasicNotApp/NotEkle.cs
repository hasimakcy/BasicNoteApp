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
    public partial class NotEkle : Form
    {
        public NotEkle()
        {
            InitializeComponent();
        }

        private void NotEkle_Load(object sender, EventArgs e)
        {
            //Form1.ActiveForm.Hide();

            notOku();
        }

        void notOku()
        {
            if (Convert.ToInt32(txt_KayıtNo.Text) > 0)
            {
                DataTable dt = Cls.SQLConnectionClass.Table("select not_RecNo, not_Baslik, not_Icerik from NOTLAR where not_RecNo = " + Convert.ToInt32(txt_KayıtNo.Text) + " ");
                txt_baslik.Text = dt.Rows[0]["not_Baslik"].ToString();
                txt_icerik.Text = dt.Rows[0]["not_Icerik"].ToString();        
               
            }
            else
            {

            }

        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txt_KayıtNo.Text) == 0)
            {
                Cls.SQLConnectionClass.Command(""
                    + "  INSERT INTO [dbo].[NOTLAR] "
                    + "          ([not_KayitTarih] "
                    + "             ,[not_Baslik] "
                    + "             ,[not_Tarih] "
                    + "              ,[not_Icerik]) "
                    + "           VALUES "
                    + "           ( getdate()  "
                    + "           , '" + txt_baslik.Text + "'"
                    + "           , '" + Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyyMMdd HH:mm") + "'"
                    + "           , '" + txt_icerik.Text + "' )"
                          );
                if(Cls.SQLConnectionClass.exception == null)
                {
                    MessageBox.Show("Kayıt Başarılı");
                    Close();
                }
            }
            else
            {
                Cls.SQLConnectionClass.Command(""
                    + " update [dbo].[NOTLAR] set"
                    + " not_DegistirmeTarih = getdate() "
                    + " ,[not_Baslik] = '" + txt_baslik.Text + "' "
                    + " ,[not_Tarih] = '" + Convert.ToDateTime( dateTimePicker1.Value).ToString("yyyyMMdd HH:mm") + "' "
                    + " ,[not_Icerik] = '" + txt_icerik.Text + "' "
                    + " where not_RecNo = " + Convert.ToInt32(txt_KayıtNo.Text) + " "
                       );
                if (Cls.SQLConnectionClass.exception == null)
                {
                    MessageBox.Show("Güncelleme Başarılı");
                    Close();
                }               
            }
            
            //Form1 frm = new Form1();
            //frm.ShowDialog();
            //this.Refresh();
            
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Cls.SQLConnectionClass.Command("delete from [dbo].[NOTLAR] where not_RecNo = " + Convert.ToInt32(txt_KayıtNo.Text) + " ");
            if (Cls.SQLConnectionClass.exception == null)
            {
                MessageBox.Show("Silme Başarılı");
                Close();
            }
        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
