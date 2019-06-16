using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace proje1
{
    public partial class Login : Form
    {
        public static string user;
        public static int kullanıcıID;

        public Login()
        {
            InitializeComponent();
        }

         SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-U3FHIIP\\SQLEXPRESS;Initial Catalog=pc;Integrated Security=True");

     
        private void gizle()
        {
            bunifuCustomLabel1.Visible = false;
            bunifuCustomLabel2.Visible = false;
            benihatırla_lbl.Visible = false;
            bunifuMetroTextbox1.Visible = false;
            bunifuMetroTextbox2.Visible = false;
            linkLabel1.Visible = false;
            benihatırla_ckb.Visible = false;
            bunifuThinButton21.Visible = false;

            bunifuCustomLabel3.Visible = false;
            bunifuCustomLabel5.Visible = false;
            bunifuCustomLabel6.Visible = false;
            bunifuCustomLabel7.Visible = false;
            kullanıcıadı_txt.Visible = false;
            eposta_txt.Visible = false;
            sifre_txt.Visible = false;
            sifretekrar_txt.Visible = false;
            bunifuThinButton22.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            gizle();
            bunifuCustomLabel1.Visible=true;
            bunifuCustomLabel2.Visible = true;
            benihatırla_lbl.Visible = true;
            bunifuMetroTextbox1.Visible = true;
            bunifuMetroTextbox2.Visible = true;
            linkLabel1.Visible = true;
            benihatırla_ckb.Visible = true;
            bunifuThinButton21.Visible = true;

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            gizle();
            bunifuCustomLabel3.Visible = true;
            bunifuCustomLabel5.Visible = true;
            bunifuCustomLabel6.Visible = true;
            bunifuCustomLabel7.Visible = true;
            kullanıcıadı_txt.Visible = true;
            eposta_txt.Visible = true;
            sifre_txt.Visible = true;
            sifretekrar_txt.Visible = true;
            bunifuThinButton22.Visible = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            bunifuCustomLabel3.Visible = false;
            bunifuCustomLabel5.Visible = false;
            bunifuCustomLabel6.Visible = false;
            bunifuCustomLabel7.Visible = false;
            kullanıcıadı_txt.Visible = false;
            eposta_txt.Visible = false;
            sifre_txt.Visible = false;
            sifretekrar_txt.Visible = false;
            bunifuThinButton22.Visible = false;

      

            bunifuMetroTextbox1.Text = Properties.Settings.Default["kullanıcıadı"].ToString();
            bunifuMetroTextbox2.Text = Properties.Settings.Default["sifre"].ToString();
            if (bunifuMetroTextbox1.Text.Count() > 1)
                benihatırla_ckb.Checked = true;

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
         user=bunifuMetroTextbox1.Text;

            try
            {
                bağlanti.Open();
                string sql1 = "Select * from uyeol where kullanıcıAdı=@adi AND şifre=@sifre";
                SqlParameter prm1 = new SqlParameter("adi", bunifuMetroTextbox1.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifre", bunifuMetroTextbox2.Text.Trim());
               
            
                SqlCommand komut = new SqlCommand(sql1, bağlanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                using (SqlDataReader dr = komut.ExecuteReader())
                {
                    while (dr.Read())
                        kullanıcıID = Convert.ToInt32(dr["kullanıcıID"].ToString());
                }

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Anasayfa git = new Anasayfa();
                    git.Show();
                    this.Hide();
                }
                bağlanti.Close();

            }
            catch(Exception)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre yanlış", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (benihatırla_ckb.Checked)
            {
                Properties.Settings.Default["kullanıcıadı"] = bunifuMetroTextbox1.Text;
                Properties.Settings.Default["sifre"] = bunifuMetroTextbox2.Text;
            }
            else
            {
                Properties.Settings.Default[""] = bunifuMetroTextbox1.Text;
                Properties.Settings.Default[""] = bunifuMetroTextbox2.Text;
              
            }
            Properties.Settings.Default.Save();




        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
 
            string mail = eposta_txt.Text;
            bool kontrol = EmailKontrol(mail);

            kullanıcıkontrol();
            epostakontrol();
            if (durum == true)
            {
                if (durum2 == true)
                {
                    if (sifre_txt.Text == sifretekrar_txt.Text)
                    {
                        if(kontrol==true)

                        {
                            bağlanti.Open();
                            SqlCommand komut = new SqlCommand("insert into uyeol(kullanıcıAdı,şifre,eposta)values(@p1,@p2,@p3)", bağlanti);
                            komut.Parameters.AddWithValue("@p1", kullanıcıadı_txt.Text);
                            komut.Parameters.AddWithValue("@p2", sifre_txt.Text);
                            komut.Parameters.AddWithValue("@p3", eposta_txt.Text);
                            komut.ExecuteNonQuery();
                            bağlanti.Close();
                            MessageBox.Show("Kayıt oldunuz");
                        }
                        else
                             MessageBox.Show("Eposta Geçerli değil", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Şifreler uyuşmuyor", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                    MessageBox.Show("Böyle bir eposta zaten var", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Bu kullanıcı Adı zaten var", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
        bool durum;
        void kullanıcıkontrol()
        {
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("select * from uyeol where kullanıcıAdı=@p1",bağlanti);
            komut.Parameters.AddWithValue("@p1", kullanıcıadı_txt.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
                durum = false;
            else
                durum = true;
            bağlanti.Close();
        }

        bool durum2;
        void epostakontrol()
        {
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("select * from uyeol where eposta=@p2", bağlanti);
            komut.Parameters.AddWithValue("@p2", eposta_txt.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
                durum2 = false;
            else
                durum2 = true;
            bağlanti.Close();
        }
        static bool EmailKontrol(string inputEmail)
        {
            const string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            return (new Regex(strRegex)).IsMatch(inputEmail);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
