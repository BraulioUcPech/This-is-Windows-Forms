using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNIDADDOS_POO.BO;

namespace UNIDADDOS_POO.GUI
{
    public partial class ECUACIONMATE_GUI : Form
    {
        public ECUACIONMATE_GUI()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e){

            ECUACIONMATE_BO objS = new ECUACIONMATE_BO();

            objS.X = double.Parse(txtX.Text);
            objS.Y = double.Parse(txtY.Text);
            objS.Z = double.Parse(txtZ.Text);

            
            txtResultado.Text = objS.RESULTADO().ToString();
        }
    }
}
