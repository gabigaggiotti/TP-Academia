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

        }
        public void btnCrear_Click(object sender, EventArgs e)
        {
            HabilitarCamposCrear();
            _aceptar = 1;

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            HabilitarCamposModificar();
            _aceptar = 2;
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dataGridViewPlanes.DataSource = Negocio.Business.GetPlanes();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            HabilitarCamposEliminar();
            _aceptar = 3;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (_aceptar == 1)
            {
                
                
            }
            else if (_aceptar == 2)
            {
                
            }
            else if (_aceptar == 3)
            {
                
            }
        }
        private void HabilitarCamposCrear()
        {
            txtDescPlan.Enabled = true;
            txtIdPlan.Enabled = false;
        }
        private void HabilitarCamposModificar()
        {
            txtDescPlan.Enabled = true;
            txtIdPlan.Enabled = true;
        }
        private void HabilitarCamposEliminar()
        {
            txtDescPlan.Enabled = false;
            txtIdPlan.Enabled = true;
        }


    }
}
