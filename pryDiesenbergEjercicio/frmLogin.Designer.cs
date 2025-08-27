namespace pryDiesenbergEjercicio;

partial class frmLogin
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblUsuario = new Label();
        lblContraseña = new Label();
        txtContraseña = new TextBox();
        txtUsuario = new TextBox();
        btnAceptar_click = new Button();
        btnCancelar_click = new Button();
        SuspendLayout();
        // 
        // lblUsuario
        // 
        lblUsuario.AutoSize = true;
        lblUsuario.Location = new Point(57, 48);
        lblUsuario.Name = "lblUsuario";
        lblUsuario.Size = new Size(47, 15);
        lblUsuario.TabIndex = 0;
        lblUsuario.Text = "Usuario";
        // 
        // lblContraseña
        // 
        lblContraseña.AutoSize = true;
        lblContraseña.Location = new Point(57, 111);
        lblContraseña.Name = "lblContraseña";
        lblContraseña.Size = new Size(67, 15);
        lblContraseña.TabIndex = 1;
        lblContraseña.Text = "Contraseña";
        // 
        // txtContraseña
        // 
        txtContraseña.Location = new Point(143, 111);
        txtContraseña.Name = "txtContraseña";
        txtContraseña.Size = new Size(100, 23);
        txtContraseña.TabIndex = 2;
        // 
        // txtUsuario
        // 
        txtUsuario.Location = new Point(143, 45);
        txtUsuario.Name = "txtUsuario";
        txtUsuario.Size = new Size(100, 23);
        txtUsuario.TabIndex = 3;
        // 
        // btnAceptar_click
        // 
        btnAceptar_click.Location = new Point(304, 44);
        btnAceptar_click.Name = "btnAceptar_click";
        btnAceptar_click.RightToLeft = RightToLeft.No;
        btnAceptar_click.Size = new Size(75, 23);
        btnAceptar_click.TabIndex = 4;
        btnAceptar_click.Text = "Aceptar";
        btnAceptar_click.UseVisualStyleBackColor = true;
        btnAceptar_click.Click += btnAceptar_click_Click;
        // 
        // btnCancelar_click
        // 
        btnCancelar_click.Location = new Point(304, 111);
        btnCancelar_click.Name = "btnCancelar_click";
        btnCancelar_click.RightToLeft = RightToLeft.Yes;
        btnCancelar_click.Size = new Size(75, 23);
        btnCancelar_click.TabIndex = 5;
        btnCancelar_click.Text = "Cancelar";
        btnCancelar_click.UseVisualStyleBackColor = true;
        // 
        // frmLogin
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(486, 198);
        Controls.Add(btnCancelar_click);
        Controls.Add(btnAceptar_click);
        Controls.Add(txtUsuario);
        Controls.Add(txtContraseña);
        Controls.Add(lblContraseña);
        Controls.Add(lblUsuario);
        Name = "frmLogin";
        Text = "LOGIN";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblUsuario;
    private Label lblContraseña;
    private TextBox txtContraseña;
    private TextBox txtUsuario;
    private Button btnAceptar_click;
    private Button btnCancelar_click;
}
