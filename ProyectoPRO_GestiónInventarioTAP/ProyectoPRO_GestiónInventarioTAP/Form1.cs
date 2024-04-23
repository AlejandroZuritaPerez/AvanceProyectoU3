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
    public partial class Form1 : Form
    {

        LOGIN login = new LOGIN();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            if (text_Usuario.Text == login.usuario[0, 0] && text_Contraseña.Text == login.usuario[1, 0])
            {

                this.Hide();
                MessageBox.Show("¡INICIO DE SESIÓN EXITOSO!");
                Menu M = new Menu();
                M.Show();
            }
            else
            {
                MessageBox.Show("SU USUARIO O CONTRASEÑA SON INCORRECTOS" +
                    "\n Por favor, inténtalo de nuevo.");
                text_Usuario.Text = "";
                text_Contraseña.Text = "";
            }
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
            this.WindowState=FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
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
    }
}
