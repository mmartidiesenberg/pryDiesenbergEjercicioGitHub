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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
        lblUsuario = new Label();
        lblContraseña = new Label();
        txtContraseña = new TextBox();
        txtUsuario = new TextBox();
        btnCancelar_click = new Button();
        btnAceptar = new Button();
        lstModulo = new ComboBox();
        lblModulo = new Label();
        SuspendLayout();
        // 
        // lblUsuario
        // 
        lblUsuario.AutoSize = true;
        lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblUsuario.Location = new Point(106, 102);
        lblUsuario.Margin = new Padding(6, 0, 6, 0);
        lblUsuario.Name = "lblUsuario";
        lblUsuario.Size = new Size(102, 32);
        lblUsuario.TabIndex = 0;
        lblUsuario.Text = "Usuario";
        // 
        // lblContraseña
        // 
        lblContraseña.AutoSize = true;
        lblContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblContraseña.Location = new Point(106, 224);
        lblContraseña.Margin = new Padding(6, 0, 6, 0);
        lblContraseña.Name = "lblContraseña";
        lblContraseña.Size = new Size(143, 32);
        lblContraseña.TabIndex = 1;
        lblContraseña.Text = "Contraseña";
        // 
        // txtContraseña
        // 
        txtContraseña.Location = new Point(266, 224);
        txtContraseña.Margin = new Padding(6);
        txtContraseña.MaxLength = 10;
        txtContraseña.Name = "txtContraseña";
        txtContraseña.PasswordChar = '#';
        txtContraseña.Size = new Size(182, 39);
        txtContraseña.TabIndex = 2;
        // 
        // txtUsuario
        // 
        txtUsuario.ForeColor = SystemColors.HotTrack;
        txtUsuario.Location = new Point(266, 96);
        txtUsuario.Margin = new Padding(6);
        txtUsuario.MaxLength = 20;
        txtUsuario.Name = "txtUsuario";
        txtUsuario.Size = new Size(182, 39);
        txtUsuario.TabIndex = 3;
        txtUsuario.TextChanged += txtUsuario_TextChanged;
        // 
        // btnCancelar_click
        // 
        btnCancelar_click.Location = new Point(553, 237);
        btnCancelar_click.Margin = new Padding(6);
        btnCancelar_click.Name = "btnCancelar_click";
        btnCancelar_click.RightToLeft = RightToLeft.Yes;
        btnCancelar_click.Size = new Size(151, 49);
        btnCancelar_click.TabIndex = 5;
        btnCancelar_click.Text = "&Cancelar";
        btnCancelar_click.UseVisualStyleBackColor = true;
        btnCancelar_click.Click += btnCancelar_click_Click_1;
        // 
        // btnAceptar
        // 
        btnAceptar.Location = new Point(553, 90);
        btnAceptar.Margin = new Padding(4, 2, 4, 2);
        btnAceptar.Name = "btnAceptar";
        btnAceptar.Size = new Size(150, 47);
        btnAceptar.TabIndex = 6;
        btnAceptar.Text = "&Aceptar";
        btnAceptar.UseVisualStyleBackColor = true;
        btnAceptar.Click += btnAceptar_Click_1;
        // 
        // lstModulo
        // 
        lstModulo.FormattingEnabled = true;
        lstModulo.Items.AddRange(new object[] { "ADM", "SIST", "COM", "VTA" });
        lstModulo.Location = new Point(266, 341);
        lstModulo.Margin = new Padding(4, 2, 4, 2);
        lstModulo.Name = "lstModulo";
        lstModulo.Size = new Size(182, 40);
        lstModulo.TabIndex = 7;
        // 
        // lblModulo
        // 
        lblModulo.AutoSize = true;
        lblModulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblModulo.Location = new Point(106, 341);
        lblModulo.Margin = new Padding(4, 0, 4, 0);
        lblModulo.Name = "lblModulo";
        lblModulo.Size = new Size(104, 32);
        lblModulo.TabIndex = 8;
        lblModulo.Text = "Módulo";
        // 
        // frmLogin
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ScrollBar;
        ClientSize = new Size(903, 422);
        Controls.Add(lblModulo);
        Controls.Add(lstModulo);
        Controls.Add(btnAceptar);
        Controls.Add(btnCancelar_click);
        Controls.Add(txtUsuario);
        Controls.Add(txtContraseña);
        Controls.Add(lblContraseña);
        Controls.Add(lblUsuario);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(6);
        Name = "frmLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "LOGIN";
        Load += frmLogin_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblUsuario;
    private Label lblContraseña;
    private TextBox txtContraseña;
    private TextBox txtUsuario;
    private Button btnCancelar_click;
    private Button btnAceptar;
    private ComboBox lstModulo;
    private Label lblModulo;
}
