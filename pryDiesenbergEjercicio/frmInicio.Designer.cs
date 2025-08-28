namespace pryDiesenbergEjercicio
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
            label1 = new Label();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 30F);
            lblBienvenida.Location = new Point(165, 107);
            lblBienvenida.Margin = new Padding(6, 0, 6, 0);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(814, 106);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido al Sistema";
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 10F);
            btnAceptar.Location = new Point(440, 228);
            btnAceptar.Margin = new Padding(6);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(204, 79);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(484, 339);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 454);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(lblBienvenida);
            Margin = new Padding(6);
            Name = "frmInicio";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Button btnAceptar;
        private Label label1;
    }
}