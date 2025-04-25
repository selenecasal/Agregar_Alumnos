using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaAlumnos
{
    public partial class FrmAgregar: Form
    {
        public FrmAgregar()
        {
            InitializeComponent();
        }

        private void RbtProfesor_Click(object sender, EventArgs e)
        {
            GrbProf.Visible = true;
            GrbAlum.Visible = false;
        }

        private void RbtAlumno_Click(object sender, EventArgs e)
        {
            GrbProf.Visible = false;
            GrbAlum.Visible = true;
        }
    }
}
