namespace pryDiesenbergEjercicio;

public partial class frmLogin : Form
{
    public frmLogin()
    {
        InitializeComponent();
    }



    private void btnAceptar_Click_1(object sender, EventArgs e)
    {
        {
            {
                if ((txtUsuario.Text == "Administrador" &&
                    txtContrase�a.Text == "adm135$") ||
                    (txtUsuario.Text == "Operador" &&
                    txtContrase�a.Text == "ope246$"))

                {
                    this.Hide(); // oculta este formualrio
                    frmInicio f = new frmInicio(); // crea el frmInicio
                    f.Text = txtUsuario.Text; // asigna el texto de t�tulo
                    f.ShowDialog(); // visualiza y ejecuta el frmInicio
                    this.Show(); // visualiza nuevamente este formulario
                }
                else
                {
                    MessageBox.Show("Datos incorrectos. Acceso Denegado.");
                }
            }

        }
    }

    private void btnCancelar_click_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}

