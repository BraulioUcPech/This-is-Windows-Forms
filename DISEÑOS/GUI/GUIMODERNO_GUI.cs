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
using DISEÑOS.GUI;

namespace DISEÑOS
{
    public partial class GUIMODERNO_GUI : Form
    {
        public GUIMODERNO_GUI()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e){

            Application.Exit();

        }

        private void btnMaximizar_Click(object sender, EventArgs e){

            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e){

            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;

        }

        private void btnMinimizar_Click(object sender, EventArgs e){

            this.WindowState = FormWindowState.Minimized;
           

        }
        private void GUIMODERNO_GUI_Load(object sender, EventArgs e)
        {

            btnInicio_Click(null, e);

        }



        //PARA QUE LA VENTANA DE ARRASTRE
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e){
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReportes_Click(object sender, EventArgs e){

            SubMenuReportes.Visible = true;

        }

        private void btnrptventas_Click(object sender, EventArgs e){
            SubMenuReportes.Visible = false;
        }

        private void btnrptcompras_Click(object sender, EventArgs e){

            SubMenuReportes.Visible = false;

        }

        private void btnrptpagos_Click(object sender, EventArgs e){
            SubMenuReportes.Visible = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e){

            Application.Exit();
        }

        private void AbrirFormHija(object FormHija){

            if(this.PanelContenedor.Controls.Count > 0){
                this.PanelContenedor.Controls.RemoveAt(0);
            }
            Form fh = FormHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e){
            AbrirFormHija(new PRODUCTOS_GUI());
        }

        private void btnInicio_Click(object sender, EventArgs e){

            AbrirFormHija(new INICIO_GUI());

        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
