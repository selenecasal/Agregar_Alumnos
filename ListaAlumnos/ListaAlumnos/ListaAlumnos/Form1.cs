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
    public partial class Frmmain: Form
    {
        FrmAgregar formagregar;
        public Frmmain()
        {
            InitializeComponent();
            formagregar = new FrmAgregar(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formagregar.Show();
            this.Hide();
        }

    }
}
