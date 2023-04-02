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
    public partial class CARTAS_GUI : Form
    {

        Image[] cards = new Image[] { Properties.Resources.carta_1, Properties.Resources.carta_2, Properties.Resources.carta_3, Properties.Resources.carta_4, Properties.Resources.carta_5 };


     




        public CARTAS_GUI()
        {
            InitializeComponent();
        }



       
        private void SeleccionarCarta(object sender, EventArgs e)
        {
            
        }

        private void CARTAS_GUI_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int computerCardIndex = random.Next(cards.Length);
            pictureBox1.Image = cards[computerCardIndex];
            int userCardIndex = cards.Length;

            if (userCardIndex > computerCardIndex)
            {
                MessageBox.Show("¡Ganaste!");
            }
            else if (userCardIndex < computerCardIndex)
            {
                MessageBox.Show("Perdiste :(");
            }
            else
            {
                MessageBox.Show("Empate.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int computerCardIndex = random.Next(cards.Length);
            pictureBox2.Image = cards[computerCardIndex];
            int userCardIndex = cards.Length;

            if (userCardIndex > computerCardIndex)
            {
                MessageBox.Show("¡Ganaste!");
            }
            else if (userCardIndex < computerCardIndex)
            {
                MessageBox.Show("Perdiste :(");
            }
            else
            {
                MessageBox.Show("Empate.");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int computerCardIndex = random.Next(cards.Length);
            pictureBox3.Image = cards[computerCardIndex];
            int userCardIndex = cards.Length;

            if (userCardIndex > computerCardIndex)
            {
                MessageBox.Show("¡Ganaste!");
            }
            else if (userCardIndex < computerCardIndex)
            {
                MessageBox.Show("Perdiste :(");
            }
            else
            {
                MessageBox.Show("Empate.");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int computerCardIndex = random.Next(cards.Length);
            pictureBox4.Image = cards[computerCardIndex];
            int userCardIndex = cards.Length;

            if (userCardIndex > computerCardIndex)
            {
                MessageBox.Show("¡Ganaste!");
            }
            else if (userCardIndex < computerCardIndex)
            {
                MessageBox.Show("Perdiste :(");
            }
            else
            {
                MessageBox.Show("Empate.");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int computerCardIndex = random.Next(cards.Length);
            pictureBox5.Image = cards[computerCardIndex];

            int userCardIndex = cards.Length; 

            if (userCardIndex > computerCardIndex)
            {
                MessageBox.Show("¡Ganaste!");
            }
            else if (userCardIndex < computerCardIndex)
            {
                MessageBox.Show("Perdiste :(");
            }
            else
            {
                MessageBox.Show("Empate.");
            }


        }

        private void picttucarta_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int computerCardIndex = random.Next(cards.Length);
            pictureBox5.Image = cards[computerCardIndex];

            int userCardIndex = cards.Length;

            if (userCardIndex > computerCardIndex)
            {
                MessageBox.Show("¡Ganaste!");
            }
            else if (userCardIndex < computerCardIndex)
            {
                MessageBox.Show("Perdiste :(");
            }
            else
            {
                MessageBox.Show("Empate.");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}

