using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Desktop
{
    public partial class Planes : Form
    {
        private int _aceptar;
        public Planes()
        {
            InitializeComponent();
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'academiaDataSet.especialidades' Puede moverla o quitarla según sea necesario.
            this.especialidadesTableAdapter.Fill(this.academiaDataSet.especialidades);

        }

        public void btnCrear_Click(object sender, EventArgs e)
        {
            HabilitarCamposCrear();
            _aceptar = 1;

        }
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            HabilitarCamposModificar();
            _aceptar = 2;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            HabilitarCamposEliminar();
            _aceptar = 3;
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dataGridViewPlanes.DataSource = Negocio.Business.GetPlanes();
        }
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (_aceptar == 1)
            {
                string desc = txtDescPlan.Text;
                int idEsp = Convert.ToInt32(txtIdEspecialidad.Text);
                bool existe = Business.GetEspecialidad(idEsp);
                if (existe)
                {
                    Business.CreatePlan(desc, idEsp);
                } else ShowDialog(); //ver excepcion
            }
            else if (_aceptar == 2)
            {
                int id = Convert.ToInt32(txtIdPlan.Text);
                bool existePlan = Negocio.Business.GetPlan(id);
                if (existePlan)
                {
                    int idEsp = Convert.ToInt32(txtIdEspecialidad.Text);
                    bool existeEsp = Business.GetEspecialidad(idEsp);
                    if (existeEsp)
                    {
                        string desc = txtDescPlan.Text;
                        Negocio.Business.ModifyPlan(id, idEsp, desc);
                    } else ShowDialog(); //ver excepcion                    
                } else ShowDialog(); //ver excepcion
            }
            else if (_aceptar == 3)
            {
                int id = Convert.ToInt32(txtIdPlan.Text);
                Business.RemovePlan(id);
            }
        }
        private void HabilitarCamposCrear()
        {
            txtDescPlan.Enabled = true;
            txtIdPlan.Enabled = false;
            txtIdEspecialidad.Enabled = true;
        }
        private void HabilitarCamposModificar()
        {
            txtDescPlan.Enabled = true;
            txtIdPlan.Enabled = true;
            txtIdEspecialidad.Enabled = true;
        }
        private void HabilitarCamposEliminar()
        {
            txtDescPlan.Enabled = false;
            txtIdPlan.Enabled = true;
            txtIdEspecialidad.Enabled = false;
        }
        private void dataGridViewEsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewEsp.DataSource = Negocio.Business.GetEspecialidades();
        }

        private void txtIdPlan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
