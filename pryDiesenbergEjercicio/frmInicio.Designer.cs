﻿namespace pryDiesenbergEjercicio
{
    partial class frmInicio
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
            lblBienvenida = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 30F);
            lblBienvenida.Location = new Point(89, 50);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(409, 54);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido al Sistema";
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 10F);
            btnAceptar.Location = new Point(237, 107);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(110, 37);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 213);
            Controls.Add(btnAceptar);
            Controls.Add(lblBienvenida);
            Name = "frmInicio";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Button btnAceptar;
    }
}