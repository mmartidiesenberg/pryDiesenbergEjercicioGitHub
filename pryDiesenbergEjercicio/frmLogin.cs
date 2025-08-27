namespace pryDiesenbergEjercicio;

public partial class frmLogin : Form
{
    public frmLogin()
    {
        InitializeComponent();
    }

    private void btnAceptar_click_Click(object sender, EventArgs e)
    {
        frmInicio ventanaInicio = new frmInicio();

        ventanaInicio.ShowDialog();
    }
}
