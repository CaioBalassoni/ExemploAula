namespace ExemploAula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtSenha.Text == "123456")
            {
                MessageBox.Show("Usu�rio logado com sucesso!");
                txtUsuario.Clear();
                txtSenha.Clear();

                Hide();
                frmMenu menu = new frmMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usu�rio/senha inv�lidos!!");
                txtUsuario.Clear();
                txtSenha.Clear();
            }
        }
    }
}
