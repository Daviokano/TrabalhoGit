using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_IsabellieDaviOkano
{
    public partial class frmnotas : Form
    {
        public frmnotas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnApresentar_Click(object sender, EventArgs e)
        {
            int[] vetorNumeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            int i;
            for (i = 0; i < 15; i++) 
            {
                if (vetorNumeros[i] % 2 == 0) 
                {
                    txtNumber.Text += vetorNumeros[i].ToString() + Environment.NewLine; 
                }
            }

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu Menu = new frmmenu();
            this.Hide();
            Menu.Show();
        }
    }
}
