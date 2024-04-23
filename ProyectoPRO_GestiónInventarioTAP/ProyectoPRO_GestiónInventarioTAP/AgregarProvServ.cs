using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPRO_GestiónInventarioTAP
{
    public partial class AgregarProvServ : Form
    {
        public AgregarProvServ()
        {
            InitializeComponent();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMinimizar.Visible = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = ("¡GUARDADO EXITOSO!");



        }

        private void lblDetalles_Click(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            lblDetalles.Text = ("");
        }
    }
}
