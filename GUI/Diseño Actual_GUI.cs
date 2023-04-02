using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace DiseñodeInterfazdeUsuario.GUI
{
    public partial class Diseño_Actual_GUI : MetroForm
    {
        public Diseño_Actual_GUI()
        {
            InitializeComponent();
        }
   
        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
       
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Diseño_Actual_en_el_mercado_GUI PP = new Diseño_Actual_en_el_mercado_GUI();
            
            PP.Show();

        }
    }
}
