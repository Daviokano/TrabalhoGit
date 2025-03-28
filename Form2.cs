using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_IsabellieDaviOkano
{
    public partial class frmmedia: Form
    {

        int[] vNotas = new int[30];
        int i, calculo = 0, auxiliar;

        public frmmedia()
        {
            InitializeComponent();
        }

        private void lblnums_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            calculo = 0;
            txtnota.Clear();
            txtmedia.Clear();
            txtnota.Focus();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            txtmedia.Text = (calculo / i).ToString();
           
            
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu Menu = new frmmenu();
            this.Hide();
            Menu.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 30; i++)
            {
                auxiliar = Convert.ToInt32(txtnota.Text);
                vNotas[i] = auxiliar;
                calculo = calculo + vNotas[i];
            }
        }
    }
}
