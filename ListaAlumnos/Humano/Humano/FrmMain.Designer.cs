﻿namespace Humano
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAgregarPersona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAgregarPersona
            // 
            this.BtnAgregarPersona.Location = new System.Drawing.Point(12, 29);
            this.BtnAgregarPersona.Name = "BtnAgregarPersona";
            this.BtnAgregarPersona.Size = new System.Drawing.Size(94, 36);
            this.BtnAgregarPersona.TabIndex = 0;
            this.BtnAgregarPersona.Text = "Agregar";
            this.BtnAgregarPersona.UseVisualStyleBackColor = true;
            this.BtnAgregarPersona.Click += new System.EventHandler(this.BtnAgregarPersona_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAgregarPersona);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregarPersona;
    }
}

