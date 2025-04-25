namespace ListaAlumnos
{
    partial class FrmAgregar
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
            this.GrbSelector = new System.Windows.Forms.GroupBox();
            this.RbtProfesor = new System.Windows.Forms.RadioButton();
            this.RbtAlumno = new System.Windows.Forms.RadioButton();
            this.LblNom = new System.Windows.Forms.Label();
            this.LblApe = new System.Windows.Forms.Label();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxtApe = new System.Windows.Forms.TextBox();
            this.TxtBoxTitulo = new System.Windows.Forms.TextBox();
            this.LblMateria = new System.Windows.Forms.Label();
            this.TxtBoxMateria = new System.Windows.Forms.TextBox();
            this.Lbltitu = new System.Windows.Forms.Label();
            this.TxtBoxCurso = new System.Windows.Forms.TextBox();
            this.TxtBoxAnio = new System.Windows.Forms.TextBox();
            this.LblAnio = new System.Windows.Forms.Label();
            this.LblCurso = new System.Windows.Forms.Label();
            this.TxtDNI = new System.Windows.Forms.TextBox();
            this.LblDNI = new System.Windows.Forms.Label();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.TxtBoxFecha = new System.Windows.Forms.TextBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.GrbProf = new System.Windows.Forms.GroupBox();
            this.GrbAlum = new System.Windows.Forms.GroupBox();
            this.GrbSelector.SuspendLayout();
            this.GrbProf.SuspendLayout();
            this.GrbAlum.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbSelector
            // 
            this.GrbSelector.Controls.Add(this.RbtProfesor);
            this.GrbSelector.Controls.Add(this.RbtAlumno);
            this.GrbSelector.Location = new System.Drawing.Point(19, 12);
            this.GrbSelector.Name = "GrbSelector";
            this.GrbSelector.Size = new System.Drawing.Size(209, 135);
            this.GrbSelector.TabIndex = 0;
            this.GrbSelector.TabStop = false;
            // 
            // RbtProfesor
            // 
            this.RbtProfesor.AutoSize = true;
            this.RbtProfesor.Location = new System.Drawing.Point(26, 65);
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
            this.RbtAlumno.Location = new System.Drawing.Point(26, 25);
            this.RbtAlumno.Name = "RbtAlumno";
            this.RbtAlumno.Size = new System.Drawing.Size(60, 17);
            this.RbtAlumno.TabIndex = 0;
            this.RbtAlumno.TabStop = true;
            this.RbtAlumno.Text = "Alumno";
            this.RbtAlumno.UseVisualStyleBackColor = true;
            this.RbtAlumno.Click += new System.EventHandler(this.RbtAlumno_Click);
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(19, 166);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(47, 13);
            this.LblNom.TabIndex = 1;
            this.LblNom.Text = "Nombre:";
            // 
            // LblApe
            // 
            this.LblApe.AutoSize = true;
            this.LblApe.Location = new System.Drawing.Point(16, 215);
            this.LblApe.Name = "LblApe";
            this.LblApe.Size = new System.Drawing.Size(50, 13);
            this.LblApe.TabIndex = 2;
            this.LblApe.Text = "Apellido: ";
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(19, 182);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(164, 20);
            this.TxtNom.TabIndex = 3;
            // 
            // TxtApe
            // 
            this.TxtApe.Location = new System.Drawing.Point(19, 235);
            this.TxtApe.Name = "TxtApe";
            this.TxtApe.Size = new System.Drawing.Size(164, 20);
            this.TxtApe.TabIndex = 4;
            // 
            // TxtBoxTitulo
            // 
            this.TxtBoxTitulo.Location = new System.Drawing.Point(18, 79);
            this.TxtBoxTitulo.Name = "TxtBoxTitulo";
            this.TxtBoxTitulo.Size = new System.Drawing.Size(164, 20);
            this.TxtBoxTitulo.TabIndex = 10;
            // 
            // LblMateria
            // 
            this.LblMateria.AutoSize = true;
            this.LblMateria.Location = new System.Drawing.Point(15, 16);
            this.LblMateria.Name = "LblMateria";
            this.LblMateria.Size = new System.Drawing.Size(45, 13);
            this.LblMateria.TabIndex = 7;
            this.LblMateria.Text = "Materia:";
            // 
            // TxtBoxMateria
            // 
            this.TxtBoxMateria.Location = new System.Drawing.Point(18, 32);
            this.TxtBoxMateria.Name = "TxtBoxMateria";
            this.TxtBoxMateria.Size = new System.Drawing.Size(164, 20);
            this.TxtBoxMateria.TabIndex = 9;
            // 
            // Lbltitu
            // 
            this.Lbltitu.AutoSize = true;
            this.Lbltitu.Location = new System.Drawing.Point(15, 55);
            this.Lbltitu.Name = "Lbltitu";
            this.Lbltitu.Size = new System.Drawing.Size(36, 13);
            this.Lbltitu.TabIndex = 8;
            this.Lbltitu.Text = "Titulo:";
            // 
            // TxtBoxCurso
            // 
            this.TxtBoxCurso.Location = new System.Drawing.Point(25, 70);
            this.TxtBoxCurso.Name = "TxtBoxCurso";
            this.TxtBoxCurso.Size = new System.Drawing.Size(164, 20);
            this.TxtBoxCurso.TabIndex = 14;
            // 
            // TxtBoxAnio
            // 
            this.TxtBoxAnio.Location = new System.Drawing.Point(25, 31);
            this.TxtBoxAnio.Name = "TxtBoxAnio";
            this.TxtBoxAnio.Size = new System.Drawing.Size(164, 20);
            this.TxtBoxAnio.TabIndex = 13;
            // 
            // LblAnio
            // 
            this.LblAnio.AutoSize = true;
            this.LblAnio.Location = new System.Drawing.Point(25, 15);
            this.LblAnio.Name = "LblAnio";
            this.LblAnio.Size = new System.Drawing.Size(29, 13);
            this.LblAnio.TabIndex = 11;
            this.LblAnio.Text = "Año:";
            // 
            // LblCurso
            // 
            this.LblCurso.AutoSize = true;
            this.LblCurso.Location = new System.Drawing.Point(25, 54);
            this.LblCurso.Name = "LblCurso";
            this.LblCurso.Size = new System.Drawing.Size(37, 13);
            this.LblCurso.TabIndex = 12;
            this.LblCurso.Text = "Curso:";
            // 
            // TxtDNI
            // 
            this.TxtDNI.Location = new System.Drawing.Point(19, 281);
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.Size = new System.Drawing.Size(164, 20);
            this.TxtDNI.TabIndex = 9;
            // 
            // LblDNI
            // 
            this.LblDNI.AutoSize = true;
            this.LblDNI.Location = new System.Drawing.Point(16, 265);
            this.LblDNI.Name = "LblDNI";
            this.LblDNI.Size = new System.Drawing.Size(29, 13);
            this.LblDNI.TabIndex = 7;
            this.LblDNI.Text = "DNI:";
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(327, 339);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(149, 59);
            this.BtnEnviar.TabIndex = 11;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(220, 281);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 20);
            this.textBox3.TabIndex = 17;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(217, 265);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(35, 13);
            this.LblEmail.TabIndex = 16;
            this.LblEmail.Text = "Email:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(220, 235);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(164, 20);
            this.textBox6.TabIndex = 15;
            // 
            // TxtBoxFecha
            // 
            this.TxtBoxFecha.Location = new System.Drawing.Point(220, 182);
            this.TxtBoxFecha.Name = "TxtBoxFecha";
            this.TxtBoxFecha.Size = new System.Drawing.Size(164, 20);
            this.TxtBoxFecha.TabIndex = 14;
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(217, 215);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(52, 13);
            this.LblTelefono.TabIndex = 13;
            this.LblTelefono.Text = "Telefono:";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(220, 166);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(112, 13);
            this.LblFecha.TabIndex = 12;
            this.LblFecha.Text = "Fecha de nacimiento: ";
            // 
            // GrbProf
            // 
            this.GrbProf.Controls.Add(this.TxtBoxTitulo);
            this.GrbProf.Controls.Add(this.Lbltitu);
            this.GrbProf.Controls.Add(this.LblMateria);
            this.GrbProf.Controls.Add(this.TxtBoxMateria);
            this.GrbProf.Location = new System.Drawing.Point(561, 30);
            this.GrbProf.Name = "GrbProf";
            this.GrbProf.Size = new System.Drawing.Size(221, 126);
            this.GrbProf.TabIndex = 18;
            this.GrbProf.TabStop = false;
            // 
            // GrbAlum
            // 
            this.GrbAlum.Controls.Add(this.TxtBoxAnio);
            this.GrbAlum.Controls.Add(this.LblCurso);
            this.GrbAlum.Controls.Add(this.TxtBoxCurso);
            this.GrbAlum.Controls.Add(this.LblAnio);
            this.GrbAlum.Location = new System.Drawing.Point(565, 204);
            this.GrbAlum.Name = "GrbAlum";
            this.GrbAlum.Size = new System.Drawing.Size(216, 117);
            this.GrbAlum.TabIndex = 19;
            this.GrbAlum.TabStop = false;
            // 
            // FrmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrbAlum);
            this.Controls.Add(this.GrbProf);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.TxtBoxFecha);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.TxtDNI);
            this.Controls.Add(this.LblDNI);
            this.Controls.Add(this.TxtApe);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.LblApe);
            this.Controls.Add(this.LblNom);
            this.Controls.Add(this.GrbSelector);
            this.Name = "FrmAgregar";
            this.Text = "Materia:";
            this.GrbSelector.ResumeLayout(false);
            this.GrbSelector.PerformLayout();
            this.GrbProf.ResumeLayout(false);
            this.GrbProf.PerformLayout();
            this.GrbAlum.ResumeLayout(false);
            this.GrbAlum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbSelector;
        private System.Windows.Forms.RadioButton RbtProfesor;
        private System.Windows.Forms.RadioButton RbtAlumno;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Label LblApe;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.TextBox TxtApe;
        private System.Windows.Forms.Label LblMateria;
        private System.Windows.Forms.TextBox TxtBoxMateria;
        private System.Windows.Forms.TextBox TxtBoxTitulo;
        private System.Windows.Forms.Label Lbltitu;
        private System.Windows.Forms.TextBox TxtDNI;
        private System.Windows.Forms.Label LblDNI;
        private System.Windows.Forms.TextBox TxtBoxCurso;
        private System.Windows.Forms.TextBox TxtBoxAnio;
        private System.Windows.Forms.Label LblAnio;
        private System.Windows.Forms.Label LblCurso;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox TxtBoxFecha;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.GroupBox GrbProf;
        private System.Windows.Forms.GroupBox GrbAlum;
    }
}