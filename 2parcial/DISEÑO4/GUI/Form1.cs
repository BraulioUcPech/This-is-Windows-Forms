using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DISEÑO4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int tamañogrid = 10;
        private const int areamouse = 132;
        private const int botonizquierdo = 17;

        private Rectangle restangulogrid;

        protected override void OnSizeChanged(EventArgs e) {

            base.OnSizeChanged(e);


            var region = new Region(new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height));

            restangulogrid = new Rectangle(ClientRectangle.Width - tamañogrid, ClientRectangle.Height - tamañogrid, tamañogrid, tamañogrid);


            region.Exclude(restangulogrid);
            pnPrincipal.Region = region;
            Invalidate();



        }

        protected override void WndProc(ref Message sms) {

            switch (sms.Msg) {
                case areamouse:
                    base.WndProc(ref sms);

                    var RefPoint = PointToClient(new Point(sms.LParam.ToInt32() & 0xffff, sms.LParam.ToInt32() >> 16));

                    if (!restangulogrid.Contains(RefPoint))
                    {
                        break;
                    }

                    sms.Result = new IntPtr(botonizquierdo);
                    break;

                default:
                    base.WndProc(ref sms);
                    break;

            }
        }


        protected override void OnPaint(PaintEventArgs e) {

            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(solidBrush, restangulogrid);

            base.OnPaint(e);

            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, restangulogrid);

        }

        int lx, ly;
        int sw, sh;
        private void btnRestaurar_Click(object sender, EventArgs e){

            Size = new Size(sw, sh);
            Location = new Point(lx, ly);
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMinimizar.Visible = true;

        }

        private void btnMaximizar_Click(object sender, EventArgs e){

            lx = Location.X;
            ly = Location.Y;
            sw = Size.Width;
            sh = Size.Height;

            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;



        }

        private void btnMinimizar_Click(object sender, EventArgs e){

            WindowState = FormWindowState.Minimized;

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //AbrirFormularios<un formulario >();
        }

        private void btnCerrar_Click(object sender, EventArgs e){

            if(MessageBox.Show("¿Estas seguro de cerrar el programa?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes){
                Application.Exit();
            }
        }

        

        private void AbrirFormularios<FormularioAbrir>() where FormularioAbrir:Form, new()
        {
            Form Formularios;

            Formularios = pnContenedor.Controls.OfType<FormularioAbrir>().FirstOrDefault();

            if(Formularios == null)
            {
                Formularios = new FormularioAbrir
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };
                pnContenedor.Controls.Add(Formularios);

                pnContenedor.Tag = Formularios;

                Formularios.Show();
            }
            else
            {
                Formularios.BringToFront();
            }

            
        }

    }
}
