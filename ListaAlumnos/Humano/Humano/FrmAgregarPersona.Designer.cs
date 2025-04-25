namespace Humano
{
    partial class FrmAgregarPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrbTipo = new System.Windows.Forms.GroupBox();
            this.RbtProfesor = new System.Windows.Forms.RadioButton();
            this.RbtAlumno = new System.Windows.Forms.RadioButton();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.TxtFechaNac = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblDni = new System.Windows.Forms.Label();
            this.LblFechNac = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.GrbAlumno = new System.Windows.Forms.GroupBox();
            this.TxtDivision = new System.Windows.Forms.TextBox();
            this.LblDivision = new System.Windows.Forms.Label();
            this.LblCurso = new System.Windows.Forms.Label();
            this.TxtCurso = new System.Windows.Forms.TextBox();
            this.GrbProfesor = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.TxtMateria = new System.Windows.Forms.TextBox();
            this.LblMateria = new System.Windows.Forms.Label();
            this.Btn_enviar = new System.Windows.Forms.Button();
            this.Btn_enviar_alu = new System.Windows.Forms.Button();
            this.Btn_enviar_prof = new System.Windows.Forms.Button();
            this.Btn_volver = new System.Windows.Forms.Button();
            this.GrbTipo.SuspendLayout();
            this.GrbAlumno.SuspendLayout();
            this.GrbProfesor.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbTipo
            // 
            this.GrbTipo.Controls.Add(this.RbtProfesor);
            this.GrbTipo.Controls.Add(this.RbtAlumno);
            this.GrbTipo.Location = new System.Drawing.Point(12, 12);
            this.GrbTipo.Name = "GrbTipo";
            this.GrbTipo.Size = new System.Drawing.Size(158, 100);
            this.GrbTipo.TabIndex = 0;
            this.GrbTipo.TabStop = false;
            this.GrbTipo.Text = "Tipo";
            // 
            // RbtProfesor
            // 
            this.RbtProfesor.AutoSize = true;
            this.RbtProfesor.Location = new System.Drawing.Point(6, 58);
            this.RbtProfesor.Name = "RbtProfesor";
            this.RbtProfesor.Size = new System.Drawing.Size(64, 17);
            this.RbtProfesor.TabIndex = 1;
            this.RbtProfesor.Text = "Profesor";
            this.RbtProfesor.UseVisualStyleBackColor = true;
            this.RbtProfesor.Click += new System.EventHandler(this.RbtProfesor_Click);
            // 
            // RbtAlumno
            // 
            this.RbtAlumno.AutoSize = true;
            this.RbtAlumno.Checked = true;
            this.RbtAlumno.Location = new System.Drawing.Point(6, 19);
            this.RbtAlumno.Name = "RbtAlumno";
            this.RbtAlumno.Size = new System.Drawing.Size(60, 17);
            this.RbtAlumno.TabIndex = 0;
            this.RbtAlumno.TabStop = true;
            this.RbtAlumno.Text = "Alumno";
            this.RbtAlumno.UseVisualStyleBackColor = true;
            this.RbtAlumno.Click += new System.EventHandler(this.RbtAlumno_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(32, 142);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(185, 142);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(100, 20);
            this.TxtApellido.TabIndex = 2;
            // 
            // TxtDni
            // 
            this.TxtDni.Location = new System.Drawing.Point(326, 141);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(100, 20);
            this.TxtDni.TabIndex = 3;
            // 
            // TxtFechaNac
            // 
            this.TxtFechaNac.Location = new System.Drawing.Point(32, 231);
            this.TxtFechaNac.Name = "TxtFechaNac";
            this.TxtFechaNac.Size = new System.Drawing.Size(100, 20);
            this.TxtFechaNac.TabIndex = 4;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(185, 231);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 20);
            this.TxtEmail.TabIndex = 5;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(326, 231);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefono.TabIndex = 6;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(185, 307);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(100, 20);
            this.TxtDireccion.TabIndex = 7;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(32, 123);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 8;
            this.LblNombre.Text = "Nombre";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(185, 122);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(44, 13);
            this.LblApellido.TabIndex = 9;
            this.LblApellido.Text = "Apellido";
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Location = new System.Drawing.Point(326, 121);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(23, 13);
            this.LblDni.TabIndex = 10;
            this.LblDni.Text = "Dni";
            // 
            // LblFechNac
            // 
            this.LblFechNac.AutoSize = true;
            this.LblFechNac.Location = new System.Drawing.Point(32, 212);
            this.LblFechNac.Name = "LblFechNac";
            this.LblFechNac.Size = new System.Drawing.Size(108, 13);
            this.LblFechNac.TabIndex = 11;
            this.LblFechNac.Text = "Fecha de Nacimiento";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(185, 212);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(32, 13);
            this.LblEmail.TabIndex = 12;
            this.LblEmail.Text = "Email";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(326, 212);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(49, 13);
            this.LblTelefono.TabIndex = 13;
            this.LblTelefono.Text = "Telefono";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Location = new System.Drawing.Point(185, 288);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(52, 13);
            this.LblDireccion.TabIndex = 14;
            this.LblDireccion.Text = "Direccion";
            // 
            // GrbAlumno
            // 
            this.GrbAlumno.Controls.Add(this.Btn_enviar_alu);
            this.GrbAlumno.Controls.Add(this.TxtDivision);
            this.GrbAlumno.Controls.Add(this.LblDivision);
            this.GrbAlumno.Controls.Add(this.LblCurso);
            this.GrbAlumno.Controls.Add(this.TxtCurso);
            this.GrbAlumno.Location = new System.Drawing.Point(487, 31);
            this.GrbAlumno.Name = "GrbAlumno";
            this.GrbAlumno.Size = new System.Drawing.Size(122, 210);
            this.GrbAlumno.TabIndex = 15;
            this.GrbAlumno.TabStop = false;
            this.GrbAlumno.Text = "Alumno";
            this.GrbAlumno.Visible = false;
            // 
            // TxtDivision
            // 
            this.TxtDivision.Location = new System.Drawing.Point(10, 98);
            this.TxtDivision.Name = "TxtDivision";
            this.TxtDivision.Size = new System.Drawing.Size(100, 20);
            this.TxtDivision.TabIndex = 3;
            // 
            // LblDivision
            // 
            this.LblDivision.AutoSize = true;
            this.LblDivision.Location = new System.Drawing.Point(7, 76);
            this.LblDivision.Name = "LblDivision";
            this.LblDivision.Size = new System.Drawing.Size(44, 13);
            this.LblDivision.TabIndex = 2;
            this.LblDivision.Text = "Division";
            // 
            // LblCurso
            // 
            this.LblCurso.AutoSize = true;
            this.LblCurso.Location = new System.Drawing.Point(7, 20);
            this.LblCurso.Name = "LblCurso";
            this.LblCurso.Size = new System.Drawing.Size(34, 13);
            this.LblCurso.TabIndex = 1;
            this.LblCurso.Text = "Curso";
            // 
            // TxtCurso
            // 
            this.TxtCurso.Location = new System.Drawing.Point(7, 39);
            this.TxtCurso.Name = "TxtCurso";
            this.TxtCurso.Size = new System.Drawing.Size(100, 20);
            this.TxtCurso.TabIndex = 0;
            // 
            // GrbProfesor
            // 
            this.GrbProfesor.Controls.Add(this.Btn_enviar_prof);
            this.GrbProfesor.Controls.Add(this.textBox5);
            this.GrbProfesor.Controls.Add(this.label5);
            this.GrbProfesor.Controls.Add(this.textBox4);
            this.GrbProfesor.Controls.Add(this.LblTitulo);
            this.GrbProfesor.Controls.Add(this.TxtMateria);
            this.GrbProfesor.Controls.Add(this.LblMateria);
            this.GrbProfesor.Location = new System.Drawing.Point(650, 31);
            this.GrbProfesor.Name = "GrbProfesor";
            this.GrbProfesor.Size = new System.Drawing.Size(122, 312);
            this.GrbProfesor.TabIndex = 16;
            this.GrbProfesor.TabStop = false;
            this.GrbProfesor.Text = "Profesor";
            this.GrbProfesor.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(7, 150);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(7, 93);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Location = new System.Drawing.Point(7, 76);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(35, 13);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "label4";
            // 
            // TxtMateria
            // 
            this.TxtMateria.Location = new System.Drawing.Point(7, 37);
            this.TxtMateria.Name = "TxtMateria";
            this.TxtMateria.Size = new System.Drawing.Size(100, 20);
            this.TxtMateria.TabIndex = 1;
            // 
            // LblMateria
            // 
            this.LblMateria.AutoSize = true;
            this.LblMateria.Location = new System.Drawing.Point(7, 20);
            this.LblMateria.Name = "LblMateria";
            this.LblMateria.Size = new System.Drawing.Size(42, 13);
            this.LblMateria.TabIndex = 0;
            this.LblMateria.Text = "Materia";
            // 
            // Btn_enviar
            // 
            this.Btn_enviar.Location = new System.Drawing.Point(198, 357);
            this.Btn_enviar.Name = "Btn_enviar";
            this.Btn_enviar.Size = new System.Drawing.Size(67, 31);
            this.Btn_enviar.TabIndex = 18;
            this.Btn_enviar.Text = "Enviar";
            this.Btn_enviar.UseVisualStyleBackColor = true;
            // 
            // Btn_enviar_alu
            // 
            this.Btn_enviar_alu.Location = new System.Drawing.Point(21, 150);
            this.Btn_enviar_alu.Name = "Btn_enviar_alu";
            this.Btn_enviar_alu.Size = new System.Drawing.Size(76, 43);
            this.Btn_enviar_alu.TabIndex = 4;
            this.Btn_enviar_alu.Text = "Enviar";
            this.Btn_enviar_alu.UseVisualStyleBackColor = true;
            // 
            // Btn_enviar_prof
            // 
            this.Btn_enviar_prof.Location = new System.Drawing.Point(22, 220);
            this.Btn_enviar_prof.Name = "Btn_enviar_prof";
            this.Btn_enviar_prof.Size = new System.Drawing.Size(84, 53);
            this.Btn_enviar_prof.TabIndex = 6;
            this.Btn_enviar_prof.Text = "Enviar";
            this.Btn_enviar_prof.UseVisualStyleBackColor = true;
            // 
            // Btn_volver
            // 
            this.Btn_volver.Location = new System.Drawing.Point(612, 374);
            this.Btn_volver.Name = "Btn_volver";
            this.Btn_volver.Size = new System.Drawing.Size(159, 57);
            this.Btn_volver.TabIndex = 19;
            this.Btn_volver.Text = "Volver";
            this.Btn_volver.UseVisualStyleBackColor = true;
            this.Btn_volver.Click += new System.EventHandler(this.Btn_volver_Click);
            // 
            // FrmAgregarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_volver);
            this.Controls.Add(this.Btn_enviar);
            this.Controls.Add(this.GrbProfesor);
            this.Controls.Add(this.GrbAlumno);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblFechNac);
            this.Controls.Add(this.LblDni);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtFechaNac);
            this.Controls.Add(this.TxtDni);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.GrbTipo);
            this.Name = "FrmAgregarPersona";
            this.Text = "FrmAgregar";
            this.GrbTipo.ResumeLayout(false);
            this.GrbTipo.PerformLayout();
            this.GrbAlumno.ResumeLayout(false);
            this.GrbAlumno.PerformLayout();
            this.GrbProfesor.ResumeLayout(false);
            this.GrbProfesor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbTipo;
        private System.Windows.Forms.RadioButton RbtProfesor;
        private System.Windows.Forms.RadioButton RbtAlumno;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.TextBox TxtFechaNac;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblDni;
        private System.Windows.Forms.Label LblFechNac;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.GroupBox GrbAlumno;
        private System.Windows.Forms.GroupBox GrbProfesor;
        private System.Windows.Forms.Label LblDivision;
        private System.Windows.Forms.Label LblCurso;
        private System.Windows.Forms.TextBox TxtCurso;
        private System.Windows.Forms.TextBox TxtDivision;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.TextBox TxtMateria;
        private System.Windows.Forms.Label LblMateria;
        private System.Windows.Forms.Button Btn_enviar_alu;
        private System.Windows.Forms.Button Btn_enviar;
        private System.Windows.Forms.Button Btn_enviar_prof;
        private System.Windows.Forms.Button Btn_volver;
    }
}