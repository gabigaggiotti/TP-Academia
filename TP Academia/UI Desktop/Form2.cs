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
    public partial class Form2 : Form
    {
        public enum ModoForm
        {
            Baja = 0, Alta = 1, Modificacion = 2, Consulta = 3
        }

        public ModoForm modo;
        public Form2()
        {
            InitializeComponent();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Especialidades Especialidades = new Especialidades();
            Especialidades.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
