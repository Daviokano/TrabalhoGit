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
    public partial class frmmenu: Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void mediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmedia media = new frmmedia(); 
            this.Hide();
            media.Show();
        }

        private void sorteioParToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnotas Notas = new frmnotas();
            this.Hide();
            Notas.Show();
        }
    }
}
