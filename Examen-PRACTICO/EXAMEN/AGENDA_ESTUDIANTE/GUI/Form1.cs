using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AGENDA_ESTUDIANTE.BO;
using AGENDA_ESTUDIANTE.DAO;

namespace AGENDA_ESTUDIANTE
{
    public partial class Form1 : Form
    {


        EstudianteBO datos = new EstudianteBO();
        EstudianteDAO SQL = new EstudianteDAO();
        public Form1()
        {
            InitializeComponent();
        }
        public void Mostrartablaestudiantes()
        {
            dgvbasededatos.DataSource = SQL.TablaEstudiante();
            txtID.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            datos.NOMBRE = txtnombre.Text;
            datos.APELLIDO = txtapellido.Text;
            datos.EDAD = int.Parse(txtedad.Text);
            datos.CORREO = txtcorreo.Text;



            if (SQL.Guardar(datos) == true)
            {
                MessageBox.Show("Datos Guardados :D ");
                Mostrartablaestudiantes();
            }
            else
            {
                MessageBox.Show("Error al guardar :( ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            datos.ID = int.Parse(txtID.Text);
            datos.NOMBRE = txtnombre.Text;
            datos.APELLIDO = txtapellido.Text;
            datos.CORREO = txtcorreo.Text;
            datos.EDAD = int.Parse(txtedad.Text);

            if (SQL.Actualizar(datos) == true)
            {
                
                MessageBox.Show("Datos Actualizados");
                Mostrartablaestudiantes();
            }
            else
            {
                MessageBox.Show("Error al Actualizar");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            datos.ID = int.Parse(txtID.Text);
            if (SQL.Elimianr(datos) == true)
            {
                
                MessageBox.Show("Datos Eliminado");
                Mostrartablaestudiantes();
            }
            else
            {
                MessageBox.Show("Error al Eliminar");
            }



        }

        private void dgvbasededatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int FilaSeleccionada = e.RowIndex;

                txtID.Text = dgvbasededatos.Rows[FilaSeleccionada].Cells[0].Value ?.ToString() ??"";
                txtnombre.Text = dgvbasededatos.Rows[FilaSeleccionada].Cells[1].Value?.ToString() ??"";
                txtapellido.Text = dgvbasededatos.Rows[FilaSeleccionada].Cells[2].Value?.ToString() ?? "";
                txtedad.Text = dgvbasededatos.Rows[FilaSeleccionada].Cells[3].Value?.ToString() ?? "";
                txtcorreo.Text = dgvbasededatos.Rows[FilaSeleccionada].Cells[4].Value?.ToString() ?? "";
            }

            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mostrartablaestudiantes();
        }

        private void dgvbasededatos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int FilaSeleccionada = e.RowIndex;

                txtID.Text = dgvbasededatos.Rows[FilaSeleccionada].Cells[0].Value?.ToString() ?? "";
                txtnombre.Text = dgvbasededatos.Rows[FilaSeleccionada].Cells[1].Value?.ToString() ?? "";
                txtapellido.Text = dgvbasededatos.Rows[FilaSeleccionada].Cells[2].Value?.ToString() ?? "";
                txtedad.Text = dgvbasededatos.Rows[FilaSeleccionada].Cells[3].Value?.ToString() ?? "";
                txtcorreo.Text = dgvbasededatos.Rows[FilaSeleccionada].Cells[4].Value?.ToString() ?? "";
            }
        }
    }
}
