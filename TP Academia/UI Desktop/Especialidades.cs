using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace UI_Desktop
{
    public partial class Especialidades : Form
    {
        //private Especialidad EspecialidadActual;
        public Especialidades()
        {
            InitializeComponent();
        }
        /*public Especialidades(ModoForm modo) : this()
        {
            this.modo = modo;

            MapearDeDatos();
        }

        public Especialidades(int ID, ModoForm modo) : this()
        {
            this.modo = modo;
            EspecialidadLogic el = new EspecialidadLogic();
            this.EspecialidadActual = el.GetOne(ID);
            MapearDeDatos();
        }        
        private new void MapearDeDatos()
        {
            if (modo == ModoForm.Alta)
            {
                this.txtID.Text = "";//Cuando hace el save lo genera automaticamente autoincremental
            }
            else
            {
                this.txtID.Text = this.EspecialidadActual.ID.ToString();
                this.txtDescripcion.Text = this.EspecialidadActual.Descripcion;
            }

            switch (modo)
            {
                case ModoForm.Alta:
                    this.Text = "Alta";
                    this.btnAceptar.Text = "Guardar";
                    break;

                case ModoForm.Baja:
                    this.Text = "Baja";
                    this.btnAceptar.Text = "Eliminar";

                    this.txtDescripcion.ReadOnly = true;
                    this.txtDescripcion.TabStop = false;
                    break;

                case ModoForm.Modificacion:
                    this.Text = "Modificación";
                    this.btnAceptar.Text = "Guardar";
                    break;

                case ModoForm.Consulta:
                    this.Text = "Consulta";
                    this.btnAceptar.Text = "Aceptar";
                    break;

                default:
                    break;
            }
        }*/
        public void btn_crear_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void btn_consultar_Click(object sender, EventArgs e)
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dataGridViewEsp.DataSource = Negocio.Business.Get();
        }
    }
}
