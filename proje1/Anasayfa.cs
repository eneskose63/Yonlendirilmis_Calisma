using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje1
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        void clear()
        {
            islemci1.Visible = false;
            userControl11.Visible = false;
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            islemci1.Visible = false;
            label2.Text = "Bu kısımda işlemcilerin ve ekrankartlarının güçlerini kıyaslama yapabildiğiniz yerdir";
           
            label1.Text = Login.user;

            label3.Text = Login.kullanıcıID.ToString();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }

        private void karsılastır_btn_Click(object sender, EventArgs e)
        {
            clear();
            userControl11.Visible = true;            
            label2.Text = "Bu kısımda işlemcilerin ve ekrankartlarının güçlerini kıyaslama yapabildiğiniz yerdir";
        }

        private void toplama_btn_Click(object sender, EventArgs e)
        {
            clear();
            islemci1.Visible = true;
            label2.Text = "Toplama sihirbazın da istediğiniz ürünü seçtiğiniz zaman ona uyumlu parçaları listeler, stabil ve düzgün çalışabilen bilgisayar toplamanıza yardımcı olur";
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void islemci1_Load(object sender, EventArgs e)
        {

        }
    }
}
