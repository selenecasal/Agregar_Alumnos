using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Humano
{
    public partial class FrmAgregarPersona: Form
    {
        public FrmAgregarPersona()
        {
            InitializeComponent();
        }

        private void RbtAlumno_Click(object sender, EventArgs e)
        {
            GrbAlumno.Show();
            GrbProfesor.Hide();
        }

        private void RbtProfesor_Click(object sender, EventArgs e)
        {
            GrbProfesor.Show();
            GrbAlumno.Hide();
        }

        private void Btn_volver_Click(object sender, EventArgs e)
        {
            FrmMain.Show();
            this.Hide();
        }

    }
    }
}
