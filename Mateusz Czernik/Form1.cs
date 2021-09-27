using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mateusz_Czernik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mateusz");
        }

        private void btnSurname_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Czernik");
        }

        private void btnCallme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nr1: +48602712983 (do Starego)" + " " + "Nr2: +48664051790 (do Matki)");
        }

        private void btnAdress_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chmielna 75, Rzeszow");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tool Dev: ENDERMANQ");
        }

        private void btnAboutMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am a Minecraft Skid developer, Liar, scammer, Powerfull DDoser, Hypocrite");
        }
    }
}
