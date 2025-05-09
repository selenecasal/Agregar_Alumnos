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
        public List<Persona>listapersona = new List<Persona>();
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
        public void RefrescarDatagrid()
        {
            if (listapersona == null)
            {
                return;
            }
            if(listapersona.Count <= 0) { 
                return; 
            }
            DgvPersonas.Rows.Clear();
            foreach (Persona p in listapersona)
            {
                DgvPersonas.Rows.Add(p.Nombre, p.Apellido, p.Dni);
            }

        }

        private void Frmmain_Activated(object sender, EventArgs e)
        {
            RefrescarDatagrid();
        }
    }
}
