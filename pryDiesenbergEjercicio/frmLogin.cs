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
                    this.Show(); // visualiza nuevamente este formulario
                }
                else
                {
                    MessageBox.Show("Datos incorrectos. Acceso Denegado.");
                }
            }

        }
    }
    private void frmLogin_Load(object sender, EventArgs e)
    {

    }

    private void btnCancelar_click_Click_1(object sender, EventArgs e)
    {
        this.Close();
    }

    private void txtUsuario_TextChanged(object sender, EventArgs e)
    {

    }
}

  


