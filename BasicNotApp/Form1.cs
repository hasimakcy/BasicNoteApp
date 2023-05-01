using System.Data;

namespace BasicNotApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            lbl_tarih.Text = DateTime.Now.ToString("dd.MM.yyyy hh:mm");

            NotlariGetir();

        }



        private void btn_ekle_Click(object sender, EventArgs e)
        {
            new NotEkle() { }.ShowDialog();

        }

        void NotlariGetir()
        {
            flowLayoutPanel1.Controls.Clear();

            DataTable dt = Cls.SQLConnectionClass.Table("select not_RecNo, not_Baslik, not_Icerik from NOTLAR" +
                " where not_Tarih >= '" + Convert.ToDateTime(lbl_tarih.Text).ToString("yyyyMMdd") + "' + ' 00:00:00 ' " +
                " and not_Tarih <= '" + Convert.ToDateTime(lbl_tarih.Text).ToString("yyyyMMdd") + "' + ' 23:59:59 '");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NotGoster not = new NotGoster();
                not.lbl_Baslik.Text = dt.Rows[i]["not_Baslik"].ToString();
                not.rtxt_icerik.Text = dt.Rows[i]["not_Icerik"].ToString();
                not.lbl_id.Text = dt.Rows[i]["not_RecNo"].ToString();
                flowLayoutPanel1.Controls.Add(not);
               
            }

           
        }

        private void btn_sonra_Click(object sender, EventArgs e)
        {
   
            lbl_tarih.Text = Convert.ToDateTime(lbl_tarih.Text).AddDays(1).ToString("dd.MM.yyyy hh:mm");
            NotlariGetir();
        }

        private void btn_once_Click(object sender, EventArgs e)
        {

            lbl_tarih.Text = Convert.ToDateTime(lbl_tarih.Text).AddDays(-1).ToString("dd.MM.yyyy hh:mm");
            NotlariGetir();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_trhgit_Click(object sender, EventArgs e)
        {
            TariheGit t1 = new TariheGit();
            t1.ShowDialog();
            if(t1.devam == 1)
            {
                lbl_tarih.Text = t1.Tarih.ToString("dd.MM.yyyy hh:mm");
                NotlariGetir();
            }
        }
    }
}