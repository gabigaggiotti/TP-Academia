using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;


namespace UI_Desktop
{
    public partial class Especialidades : Form
    {
        private int _aceptar;
        public Especialidades()
        {
            InitializeComponent();
        }

        public void btn_crear_Click(object sender, EventArgs e)
        {
            HabilitarCamposCrear(); 
            _aceptar = 1;

        }
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            HabilitarCamposModificar();
            _aceptar = 2;
        }
        private void btn_consultar_Click_1(object sender, EventArgs e)
        {
           dataGridViewEsp.DataSource = Negocio.Business.GetEspecialidades();
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            HabilitarCamposEliminar();
            _aceptar = 3;
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (_aceptar == 1)
            {
                string desc = txtDescEspecialidad.Text;
                Business.CreateEspecialidad(desc);
            }else if (_aceptar == 2)
            {
                int id = Convert.ToInt32(txtIdEspecialidad.Text);
                bool exist = false;
                exist = Negocio.Business.GetEspecialidad(id);
                if (exist)
                {
                    string desc = txtDescEspecialidad.Text;
                    Business.ModifyEspecialidad(id, desc);
                }
            }else if (_aceptar == 3)
            {
                int id = Convert.ToInt32(txtIdEspecialidad.Text);                    
                Business.RemoveEspecialidad(id);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'academiaDataSet.especialidades' Puede moverla o quitarla según sea necesario.
            //this.especialidadesTableAdapter.Fill(this.academiaDataSet.especialidades);
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }        
        private void HabilitarCamposCrear()
        {
            txtDescEspecialidad.Enabled = true;
            txtIdEspecialidad.Enabled = false;
        }
        private void HabilitarCamposModificar()
        {
            txtDescEspecialidad.Enabled = true;
            txtIdEspecialidad.Enabled = true;
        }
        private void HabilitarCamposEliminar()
        {
            txtDescEspecialidad.Enabled = false;
            txtIdEspecialidad.Enabled = true;
        }                
    }
}
