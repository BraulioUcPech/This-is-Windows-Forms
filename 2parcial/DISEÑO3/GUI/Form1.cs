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
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;

namespace DISEÑO3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void elContainer1_Click(object sender, EventArgs e)
        {

        }

        private void elContainer16_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            string[] series = { "Mini Rellenitas", "Fideos", "Calletas Margarita", "Inka Cola", "Pisco Vargas", "Tallarin" };
            int[] puntos = { 25, 56, 100, 67, 45, 20 };

            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            chart1.Titles.Add("Stock de productos");

            for(int i = 0; i < series.Length; i++){

                Series Serie = chart1.Series.Add(series[i]);

                Serie.Label = puntos[i].ToString();
                Serie.Points.Add(puntos[i]);


            }
        }
        //PARA QUE LA VENTANA DE ARRASTRE
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void elContainer9_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void elContainer9_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox9.Visible = false;
            pictureBox9.Visible = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox11.Visible = false;
            pictureBox11.Visible = true;
        }
    }
}
