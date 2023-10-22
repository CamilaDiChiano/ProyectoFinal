using SistemaGestionEF;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtUsuario.TabStop = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtPassword.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (txtUsuario.Text == "CoderC" && txtPassword.Text == "Proyecto")
            {
                FormPrincipal form = new FormPrincipal();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos, porfavor vuelva a intentarlo");
                txtUsuario.Clear();
                txtPassword.Clear();
            }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}