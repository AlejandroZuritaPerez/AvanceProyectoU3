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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            
            InitializeComponent();
            
        }



        private void Proveedores_Load(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarProvServ_Click(object sender, EventArgs e)
        {
            AgregarProvServ APS = new AgregarProvServ();
            APS.Show();
            
        }
    }
}
