using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIDADDOS_POO.GUI
{
    public partial class DADOS_GUI : Form
    {

        private Random random = new Random();
        private int totalLanzamientos = 0;
        
        public DADOS_GUI()
        {
            InitializeComponent();
        }

        private Dictionary<int, Image> imagenesDados = new Dictionary<int, Image>()
        {
            { 1, Properties.Resources.dado1 },
            { 2, Properties.Resources.dado2 },
            { 3, Properties.Resources.dado3 },
            { 4, Properties.Resources.dado4 },
            { 5, Properties.Resources.dado5 },
            { 6, Properties.Resources.dado6 }
        };

        private void button1_Click(object sender, EventArgs e)
        {
            // Lanzar los dos dados y obtener los valores
            int dado1 = random.Next(1, 6);
            int dado2 = random.Next(1, 6);

            // Agregar los valores al DataGridView
            totalLanzamientos++;
            dataGridViewLanzamientos.Rows.Add(totalLanzamientos, dado1, dado2, dado1 + dado2);

            // Mostrar las imágenes de los dados correspondientes en el PictureBoxes
            pictureBoxDado1.Image = imagenesDados[dado1];
            pictureBoxDado2.Image = imagenesDados[dado2];


        }
    }
}
