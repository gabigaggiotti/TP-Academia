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
    public partial class MenuPrincipal : Form
    {     
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Especialidades Especialidades = new Especialidades();
            Especialidades.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planes planes = new Planes();
            planes.Show();
        }
    }
}
