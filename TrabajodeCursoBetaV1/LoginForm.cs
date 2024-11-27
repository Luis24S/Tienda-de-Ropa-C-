namespace TrabajodeCursoBetaV1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void IniciarSesion(object sender, EventArgs e)
        {
            string username = "ABazar_24";
            string contrase�a = "2024";

            string usuarioingresado = txtUsuario.Text;
            string contrase�aingresada = txtContrase�a.Text;

            if (string.IsNullOrWhiteSpace(usuarioingresado) || string.IsNullOrWhiteSpace(contrase�aingresada))
            {
                MessageBox.Show("Campos vacios, por favor ingrese los datos solicitados", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (username == usuarioingresado && contrase�a == contrase�aingresada)
            {
                var MenuForm = new MenuForm();
                MenuForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contrase�a o nombre de usuario incorrectos", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void Salir(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("�Esta seguro que quiere cerrar sesi�n?", "Confirmaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                LoginForm formIniciarCesi�n = new LoginForm();
                formIniciarCesi�n.Show();
                this.Close();
            }


        }
    }
}
