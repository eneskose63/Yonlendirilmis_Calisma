using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proje1
{
    public partial class islemci : UserControl
    {
        public islemci()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U3FHIIP\\SQLEXPRESS;Initial Catalog=pc;Integrated Security=True");

        void griddoldur()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from toplama where kullanıcıİD='" + Login.kullanıcıID+"' ", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "toplama");
            dataGridView1.DataSource = ds.Tables["toplama"];
            baglanti.Close();
        }

        private void islemci_Load(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;


            islemci_img.Visible = false;
            anakart_img.Visible = false;
            ekrankkartı_img.Visible = false;
            ram_img.Visible = false;
            gückaynağı_img.Visible = false;
            hdd_img.Visible = false;
            ssd_img.Visible = false;

            griddoldur();
          

            SqlCommand komut2 = new SqlCommand();
            komut2.CommandText = "SELECT *FROM islemci";
            komut2.Connection = baglanti;
            komut2.CommandType = CommandType.Text;

            SqlDataReader dr2;
            baglanti.Open();
            dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2["işlemciModel"]);             
            }
            baglanti.Close();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=DESKTOP-U3FHIIP\\SQLEXPRESS;Initial Catalog=pc;Integrated Security=True";
            
            if (comboBox1.Text == "İntel i9 ( 9.nesil )" || comboBox1.Text == "İnteli i9 ( 8.nesil )" || comboBox1.Text == "İntel i7 ( 9.nesil )" || comboBox1.Text == "İntel i7 ( 8.nesil ) " || comboBox1.Text == "İntel i7 (7.nesil )" || comboBox1.Text == "İntel i5 ( 9.nesil )" || comboBox1.Text == "Amd ryzen threadripper 2950x" || comboBox1.Text == "Amd ryzen R7 1800" || comboBox1.Text == "Amd ryzen R7 2700" || comboBox1.Text == "Amd ryzen R5 2600")
            {

                comboBox3.Items.Clear();
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "SELECT *FROM ekrankartı";
                komut.Connection = baglanti;
                komut.CommandType = CommandType.Text;

                SqlDataReader dr;
                baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    comboBox3.Items.Add(dr["ekrankartıModel"]);

                }
                baglanti.Close();
            }
            else
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Amd Rx560 4gb");
                comboBox3.Items.Add("Amd Rx570 8gb");
                comboBox3.Items.Add("Amd Rx580 8gb");
                comboBox3.Items.Add("Nvidia gtx 1050ti 4gb");
                comboBox3.Items.Add("Nvidia gtx 1060 6gb");
            }
            islemci_img.Visible = true;

            if (comboBox1.Text == "İntel i9 ( 9.nesil )" || comboBox1.Text == "İnteli i9 ( 8.nesil )" || comboBox1.Text == "İntel i7 ( 9.nesil )" || comboBox1.Text == "İntel i7 ( 8.nesil ) " || comboBox1.Text == "İntel i7 (7.nesil )" || comboBox1.Text == "İntel i5 ( 9.nesil )")
            {
                comboBox2.Items.Clear();            
                comboBox2.Items.Add("Z390 Anakart");
                comboBox2.Items.Add("Z370 Anakart");
                comboBox2.Items.Add("H310 Anakart");
            }
            else
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("B320M Anakart");
                comboBox2.Items.Add("B350 Anakart");
                comboBox2.Items.Add("B460 Anakart");
                comboBox2.Items.Add("x470 Anakart");
            }

            comboBox2.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox3.Enabled = true;
            anakart_img.Visible = true;

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Enabled = true;
            ekrankkartı_img.Visible = true;
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ram_img.Visible = true;
            comboBox5.Enabled = true;
            if (comboBox3.Text == "Nvidia gtx 2060 8gb" || comboBox3.Text == "Nvidia gtx 2070ti 11gb" || comboBox3.Text == "Nvidia gtx 2080ti 11gb" || comboBox3.Text == "Nvidia gtx 1080ti 8gb" || comboBox3.Text == "Nvidia gtx 1070ti 8gb" || comboBox3.Text == "Amd Vega56 8gb" || comboBox3.Text == "Amd Rx590 8gb")
            {
                comboBox5.Items.Clear();
                comboBox5.Items.Add("600W +80 plus güç kaynağı");
                comboBox5.Items.Add("650W +80 plus güç kaynağı");
                comboBox5.Items.Add("700W +80 plus güç kaynağı");
                comboBox5.Items.Add("750W +80 plus güç kaynağı");
                comboBox5.Items.Add("800W +80 plus güç kaynağı");
            }
            else
            {
                comboBox5.Items.Clear();
                comboBox5.Items.Add("450W +80 plus güç kaynağı");
                comboBox5.Items.Add("500W +80 plus güç kaynağı");
                comboBox5.Items.Add("550W +80 plus güç kaynağı");
                comboBox5.Items.Add("650W +80 plus güç kaynağı");
                comboBox5.Items.Add("600W +80 plus güç kaynağı");           
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox6.Enabled = true;
            gückaynağı_img.Visible = true;

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox7.Enabled = true;
            hdd_img.Visible = true;
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            ssd_img.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into toplama(kullanıcıİD,işlemci,anakart,ekrankartı,ram,güçkaynağı,harddisk,ssd)values(@kullanıcıİD,@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
            komut.Parameters.AddWithValue("@p1", comboBox1.Text);
            komut.Parameters.AddWithValue("@p2", comboBox2.Text);
            komut.Parameters.AddWithValue("@p3", comboBox3.Text);
            komut.Parameters.AddWithValue("@p4", comboBox4.Text);
            komut.Parameters.AddWithValue("@p5", comboBox5.Text);
            komut.Parameters.AddWithValue("@p6", comboBox6.Text);
            komut.Parameters.AddWithValue("@p7", comboBox7.Text);
            komut.Parameters.AddWithValue("@kullanıcıİD", Login.kullanıcıID);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Toplama Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            griddoldur();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
