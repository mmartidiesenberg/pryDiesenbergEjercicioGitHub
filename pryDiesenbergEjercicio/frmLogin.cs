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
                    txtContraseña.Text == "adm135$") ||
                    (txtUsuario.Text == "Operador" &&
                    txtContraseña.Text == "ope246$"))
                {
                    frmInicio inicio = new frmInicio();
                    inicio.Show();
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
    //pryDiesenbergEjercicioGitHub es el ejercicio de la SP1
    private void txtUsuario_TextChanged(object sender, EventArgs e)
    {

    }
}

  


