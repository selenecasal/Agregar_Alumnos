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
    public partial class FrmAgregar: Form   //creo una clase publica, llamada formagregar que hereda todo de form
    {
        Frmmain forminicio; //creo una variable del tipo Frmmain, llamda forminicio, va a guardar una instancia del frmmain
        
        public FrmAgregar(Frmmain form) //este es el constructor, que recibe un parametro llamado form
        {
            InitializeComponent();
            forminicio = form;  //la variable forminicio recibe el parametro llamado form, 
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

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            Persona nuevapersona;
            if (RbtAlumno.Checked)
            {
                nuevapersona = new Alumno(int.Parse(TxtBoxAnio.Text), int.Parse(TxtBoxCurso.Text));
            }else
            {
                Categoria newcat;
                switch (CmbProf.Text)
                {
                    case "titular":
                        newcat = Categoria.titular;
                        break;
                    case "suplente":
                        newcat = Categoria.suplente;
                        break;
                    case "interino":
                        newcat = Categoria.interino;
                        break;
                    default:
                        newcat=Categoria.titular;
                        break;
                }
                nuevapersona = new Profesor(TxtBoxMateria.Text, TxtBoxTitulo.Text, newcat);
                
            }
            nuevapersona.Nombre = TxtNom.Text;
            nuevapersona.Apellido= TxtApe.Text;
            nuevapersona.Dni= int.Parse(TxtDNI.Text);
            nuevapersona.Fechanac= DtpNacimiento.Value;
            nuevapersona.Telefono= int.Parse(TxtTel.Text);
            nuevapersona.Email= TxtEmail.Text;



            this.Hide();
            forminicio.Show();
            forminicio.listapersona.Add(nuevapersona);
        }

        private void FrmAgregar_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            forminicio.Show();
        }
    }
}
