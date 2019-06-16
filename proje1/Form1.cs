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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Login a = new Login();

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
         

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Width += 5;
            if (pictureBox2.Width >= 200)
            {
                timer1.Stop();
                a.Show();
                this.Hide();
            }


        }
    }
}
