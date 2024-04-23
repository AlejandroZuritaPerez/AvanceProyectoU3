using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectoPRO_GestiónInventarioTAP
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        //btn cerrar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //btn maximizar
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            
        }

        //btn minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //btn restaurar
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

            btnLogoInicio_Click(null, e);

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh  = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
            {
                
            }
        }

        private void btnLogoInicio_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Principal());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Proveedores());
        }
    }
}
