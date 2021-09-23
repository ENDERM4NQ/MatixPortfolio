using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CzernikDox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nr1: +48602712983 (do Starego)" + " " + "Nr2: +48664051790 (do Matki)");
        }

        private void buttonName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mateusz");
        }

        private void buttonAdress_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Chmielna 75, Rzeszow");
        }

        private void buttonMatixTanczy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("s");
        }

        private void buttonNazwisko_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Czernik");

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
