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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void gizle()
        {
            ryzen3_img.Visible = false;
            Ryzen5_img.Visible = false;
            ryzenth_img.Visible = false;
            ryzenr7_img.Visible = false;     
            inteli3_img2.Visible = false;        
            inteli5_img2.Visible = false;        
            inteli7_img2.Visible = false;         
            inteli9_img2.Visible = false;
        }
        private void gizle2()
        {
            inteli9_img.Visible = false;
            inteli7_img.Visible = false;
            inteli5_img.Visible = false;
            inteli3_img.Visible = false;
            pictureBox3.Visible = false;
            ryzenr7sol_img.Visible = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
        }

        private void temizle()
        {
            rx560_pb.Visible = false;
            rx570_PB.Visible = false;
            rx580_pb.Visible = false;
            rx590_pb.Visible = false;
            vega56_pb.Visible = false;
            gtx1050ti_pb.Visible = false;
            gtx1060_pb.Visible = false;
            gtx1070ti_pb.Visible = false;
            gtx1080ti_pb.Visible = false;
            gtx2060_pb.Visible = false;
            gtx2070_pb.Visible = false;
            gtx2080_pb.Visible = false;
        }
        private void temizle2()
        {
            rx560_pb2.Visible = false;
            rx570_pb2.Visible = false;
            rx580_pb2.Visible = false;
            rx590_pb2.Visible = false;
            vega56_pb2.Visible = false;
            gtx1050ti_pb2.Visible = false;
            gtx1060_pb2.Visible = false;
            gtx1070ti_pb2.Visible = false;
            gtx1080ti_pb2.Visible = false;
            gtx2060_pb2.Visible = false;
            gtx2070_pb2.Visible = false;
            gtx2080_pb2.Visible = false;
        }


        private void UserControl1_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=DESKTOP-U3FHIIP\\SQLEXPRESS;Initial Catalog=pc;Integrated Security=True";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM ekrankartı";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox4.Items.Add(dr["ekrankartıModel"]);
                comboBox3.Items.Add(dr["ekrankartıModel"]);
            }
            baglanti.Close();
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
                comboBox2.Items.Add(dr2["işlemciModel"]);
            }
            baglanti.Close();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = (comboBox1.Text);

            if(x == "İntel i9 ( 9.nesil )")
            {
                gizle();
                inteli9_img2.Visible = true;
                bunifuGauge2.Value =90;
            }
            else if (x == "İnteli i9 ( 8.nesil )")
            {
                gizle();
                inteli9_img2.Visible = true;
                bunifuGauge2.Value = 80;
            }
            else if (x == "İntel i7 ( 9.nesil )")
            {
                gizle();
                inteli7_img2.Visible = true;
                bunifuGauge2.Value = 70;
            }
            else if (x == "İntel i7 ( 8.nesil ) ") 
            {
                gizle();
                inteli7_img2.Visible = true;
                bunifuGauge2.Value = 60;
            }
            else if (x == "İntel i7 (7.nesil )")
            {
                gizle();
                inteli7_img2.Visible = true;
                bunifuGauge2.Value = 50;
            }
            else if (x == "İntel i5 ( 9.nesil )")
            {
                gizle();
                inteli5_img2.Visible = true;
                bunifuGauge2.Value = 52;
            }
            else if (x == "İntel i5 ( 8.nesil )")
            {
                gizle();
                inteli5_img2.Visible = true;
                bunifuGauge2.Value = 40;
            }
            else if (x == "İntel i5 ( 7.nesil )")
            {
                gizle();
                inteli5_img2.Visible = true;
                bunifuGauge2.Value = 30;
            }
            else if (x == "İntel i3 (7.nesil)")
            {
                gizle();
                inteli3_img2.Visible = true;
                bunifuGauge2.Value = 20;
            }
            else if (x == "Amd ryzen threadripper 2950x")
            {
                gizle();
                ryzenth_img.Visible = true;
                bunifuGauge2.Value = 100;
            }
            else if (x == "Amd ryzen R7 1800")
            {
                gizle();
                ryzenr7_img.Visible = true;
                bunifuGauge2.Value = 75;
            }
            else if (x == "Amd ryzen R7 2700")
            {
                gizle();
                ryzenr7_img.Visible = true;
                bunifuGauge2.Value = 65;
            }
            else if (x == "Amd ryzen R5 2600")
            {
                gizle();
                Ryzen5_img.Visible = true;
                bunifuGauge2.Value = 55;
            }
            else if (x == "Amd ryzen R5 2400g")
            {
                gizle();
                Ryzen5_img.Visible = true;
                bunifuGauge2.Value = 44;
            }
            else if (x == "Amd ryzen R5 1500")
            {
                gizle();
                Ryzen5_img.Visible = true;
                bunifuGauge2.Value = 40;
            }
            else if (x == "Amd ryzen R3 2200g")
            {
                gizle();
                ryzen3_img.Visible = true;
                bunifuGauge2.Value = 38;
            }
            else if (x == "Amd ryzen R3 1300")
            {
                gizle();
                ryzen3_img.Visible = true;
                bunifuGauge2.Value = 35;
            }
            else if (x == "Amd ryzen 1200")
            {
                gizle();
                ryzen3_img.Visible = true;
                bunifuGauge2.Value = 30;
            }
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            string y = (comboBox2.Text);

            if (y == "İntel i9 ( 9.nesil )")
            {
                gizle2();
                inteli9_img.Visible = true;
                bunifuGauge1.Value = 90;
            }
            else if (y == "İnteli i9 ( 8.nesil )")
            {
                gizle2();
                inteli9_img.Visible = true;
                bunifuGauge1.Value = 80;
            }
            else if (y == "İntel i7 ( 9.nesil )")
            {
                gizle2();
                inteli7_img.Visible = true;
                bunifuGauge1.Value = 70;
            }
            else if (y == "İntel i7 ( 8.nesil ) ")
            {
                gizle2();
                inteli7_img.Visible = true;
                bunifuGauge1.Value = 60;
            }
            else if (y == "İntel i7 (7.nesil )")
            {
                gizle2();
                inteli7_img.Visible = true;
                bunifuGauge1.Value = 50;
            }
            else if (y == "İntel i5 ( 9.nesil )")
            {
                gizle2();
                inteli5_img.Visible = true;
                bunifuGauge1.Value = 52;
            }
            else if (y == "İntel i5 ( 8.nesil )")
            {
                gizle2();
                inteli5_img.Visible = true;
                bunifuGauge1.Value = 40;
            }
            else if (y == "İntel i5 ( 7.nesil )")
            {
                gizle2();
                inteli5_img.Visible = true;
                bunifuGauge1.Value = 30;
            }
            else if (y == "İntel i3 (7.nesil)")
            {
                gizle2();
                inteli3_img.Visible = true;
                bunifuGauge1.Value = 20;
            }
            else if (y == "Amd ryzen threadripper 2950x")
            {
                gizle2();
                pictureBox3.Visible = true;
                bunifuGauge1.Value = 100;
            }
            else if (y == "Amd ryzen R7 1800")
            {
                gizle2();
                ryzenr7sol_img.Visible = true;
                bunifuGauge1.Value = 75;
            }
            else if (y == "Amd ryzen R7 2700")
            {
                gizle2();
                ryzenr7sol_img.Visible = true;
                bunifuGauge1.Value = 65;
            }
            else if (y == "Amd ryzen R5 2600")
            {
                gizle2();
                pictureBox2.Visible = true;
                bunifuGauge1.Value = 55;
            }
            else if (y == "Amd ryzen R5 2400g")
            {
                gizle2();
                pictureBox2.Visible = true;
                bunifuGauge1.Value = 44;
            }
            else if (y == "Amd ryzen R5 1500")
            {
                gizle2();
                pictureBox2.Visible = true;
                bunifuGauge1.Value = 40;
            }
            else if (y == "Amd ryzen R3 2200g")
            {
                gizle2();
                pictureBox1.Visible = true;
                bunifuGauge1.Value = 35;
            }
            else if (y == "Amd ryzen R3 1300")
            {
                gizle2();
                pictureBox1.Visible = true;
                bunifuGauge1.Value = 20;
            }
            else if (y == "Amd ryzen 1200")
            {
                gizle2();
                pictureBox1.Visible = true;
                bunifuGauge1.Value = 16;
            }


            if (bunifuGauge1.Value < bunifuGauge2.Value)
            {
                label1.Text = "";
                label2.Text = "";
                label1.Text = "Daha iyi";
            }
            else if (bunifuGauge1.Value > bunifuGauge2.Value)
            {
                label1.Text = "";
                label2.Text = "";
                label2.Text = "Daha iyi";
            }
            else if(bunifuGauge1.Value == bunifuGauge2.Value)
            {
                label1.Text = "";
                label2.Text = "";
                label2.Text = "Eşit";
                label1.Text = "Eşit";
               
            }



        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          string x=(comboBox4.Text);
            if (x == "Amd Rx560 4gb")
            {
                temizle();
                rx560_pb.Visible = true;
                bunifuGauge3.Value =35;
            }
           else if (x == "Amd Rx570 8gb")
            {
                temizle();
                rx570_PB.Visible = true;
                bunifuGauge3.Value = 45;
            }
           else if (x == "Amd Rx580 8gb")
            {
                temizle();
                rx580_pb.Visible = true;
                bunifuGauge3.Value = 55;
            }
          else  if (x == "Amd Rx590 8gb")
            {
                temizle();
                rx590_pb.Visible = true;
                bunifuGauge3.Value = 60;
            }
           else if (x == "Amd Vega56 8gb")
            {
                temizle();
                vega56_pb.Visible = true;
                bunifuGauge3.Value = 68;
            }
          else  if (x == "Nvidia gtx 1050ti 4gb")
            {
                temizle();
                gtx1050ti_pb.Visible = true;
                bunifuGauge3.Value = 40;
            }
          else  if (x == "Nvidia gtx 1060 6gb")
            {
                temizle();
                gtx1060_pb.Visible = true;
                bunifuGauge3.Value = 50;
            }
          else if (x == "Nvidia gtx 1070ti 8gb")
            {
                temizle();
                gtx1070ti_pb.Visible = true;
                bunifuGauge3.Value = 70;
            }
           else if (x == "Nvidia gtx 1080ti 8gb")
            {
                temizle();
                gtx1080ti_pb.Visible = true;
                bunifuGauge3.Value = 80;
            }
           else if (x == "Nvidia gtx 2060 8gb")
            {
                temizle();
                gtx2060_pb.Visible = true;
                bunifuGauge3.Value = 65;
            }
           else if (x == "Nvidia gtx 2070ti 11gb")
            {
                temizle();
                gtx2070_pb.Visible = true;
                bunifuGauge3.Value = 90;
            }
           else if (x == "Nvidia gtx 2080ti 11gb")
            {
                temizle();
                gtx2080_pb.Visible = true;
                bunifuGauge3.Value = 100;
            }

            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            string z = (comboBox3.Text);
            if (z == "Amd Rx560 4gb")
            {
                temizle2();
                rx560_pb2.Visible = true;
                bunifuGauge4.Value = 35;
            }
            else if (z == "Amd Rx570 8gb")
            {
                temizle2();
                rx570_pb2.Visible = true;
                bunifuGauge4.Value = 45;
            }
            else if (z == "Amd Rx580 8gb")
            {
                temizle2();
                rx580_pb2.Visible = true;
                bunifuGauge4.Value = 55;
            }
            else if (z == "Amd Rx590 8gb")
            {
                temizle2();
                rx590_pb2.Visible = true;
                bunifuGauge4.Value = 60;
            }
            else if (z == "Amd Vega56 8gb")
            {
                temizle2();
                vega56_pb2.Visible = true;
                bunifuGauge4.Value = 68;
            }
            else if (z == "Nvidia gtx 1050ti 4gb")
            {
                temizle2();
                gtx1050ti_pb2.Visible = true;
                bunifuGauge4.Value = 40;
            }
            else if (z == "Nvidia gtx 1060 6gb")
            {
                temizle2();
                gtx1060_pb2.Visible = true;
                bunifuGauge4.Value = 50;
            }
            else if (z == "Nvidia gtx 1070ti 8gb")
            {
                temizle2();
                gtx1070ti_pb2.Visible = true;
                bunifuGauge4.Value = 70;
            }
            else if (z == "Nvidia gtx 1080ti 8gb")
            {
                temizle2();
                gtx1080ti_pb2.Visible = true;
                bunifuGauge4.Value = 80;
            }
            else if (z == "Nvidia gtx 2060 8gb")
            {
                temizle2();
                gtx2060_pb2.Visible = true;
                bunifuGauge4.Value = 65;
            }
            else if (z == "Nvidia gtx 2070ti 11gb")
            {
                temizle2();
                gtx2070_pb2.Visible = true;
                bunifuGauge4.Value = 90;
            }
            else if (z == "Nvidia gtx 2080ti 11gb")
            {
                temizle2();
                gtx2080_pb2.Visible = true;
                bunifuGauge4.Value = 100;
            }
            if(comboBox3.Text==comboBox4.Text)
            {
                bunifuGauge4.Value = 0;
                bunifuGauge3.Value = 0;
            }
            if (bunifuGauge3.Value > bunifuGauge4.Value)
            {
                label3.Text = "";
                label4.Text = "";
                label3.Text = "Daha iyi";
            }
            else if (bunifuGauge3.Value < bunifuGauge4.Value)
            {
                label4.Text = "";
                label3.Text = "";
                label4.Text = "Daha iyi";
            }
            else if(bunifuGauge3.Value == bunifuGauge4.Value)
            {
                label3.Text = "";
                label4.Text = "";
                label3.Text = "Eşit";
                label4.Text = "Eşit";

            }

        }

    }
}
