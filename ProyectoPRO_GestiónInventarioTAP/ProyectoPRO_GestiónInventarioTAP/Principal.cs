using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPRO_GestiónInventarioTAP
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongDateString();
            lblFecha.Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
