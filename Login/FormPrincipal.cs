using SistemaGestionBussiness;
using SistemaGestionEntities;
using SistemaGestionData;



namespace SistemaGestionEF
{
    public partial class FormPrincipal : Form
    {
        private SistemaGestionContext dbContext;
        private UsuarioData usuarioData;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {
        }
        //private void Form1(object sender, EventArgs e)
        //{
        //    List<Producto> productos = ProductoBussiness.GetProductos();
        //    dgProductos.AutoGenerateColumns = true;
        //    dgProductos.DataSource = productos;

        //    List<ProductoVendido> productoVendidos = ProductoVendidoBussiness.ListarProductoVendido();
        //    dgProductosVendidos.AutoGenerateColumns = true;
        //    dgProductosVendidos.DataSource = productoVendidos;

        //    List<Usuario> usuarios = UsuarioBussiness.ListarUsuario();
        //    dgUsuarios.AutoGenerateColumns = true;
        //    dgUsuarios.DataSource = usuarios;

        //    List<Venta> ventas = VentaBussiness.ListarVentaData();
        //    dgVenta.AutoGenerateColumns = true;
        //    dgVenta.DataSource = ventas;
        //}
        //private void btnAgregar_Click(object sender, EventArgs e)
        //{
        //    string nombre = txtNombre.Text;
        //    string apellido = txtApellido.Text;
        //    string nombreUsuario = txtNombreUsuario.Text;
        //    string contraseña = txtContraseña.Text;
        //    string mail = txtMail.Text;

        //    Usuario nuevoUsuario = new Usuario
        //    {
        //        Nombre = nombre,
        //        Apellido = apellido,
        //        NombreUsuario = nombreUsuario,
        //        Contraseña = contraseña,
        //        Mail = mail
        //    };

        //    UsuarioBussiness.CrearUsuario(nuevoUsuario);

        //    txtNombre.Text = "";
        //    txtApellido.Text = "";
        //    txtNombreUsuario.Text = "";
        //    txtContraseña.Text = "";
        //    txtMail.Text = "";

        //    ActualizarListaDeUsuarios();
        //}

        //private void ActualizarListaDeUsuarios()
        //{
        //    List<Usuario> listaUsuarios = UsuarioBussiness.ListarUsuario();
        //    dgUsuarios.DataSource = listaUsuarios;
        //}

        //private void btnCancelar_Click(object sender, EventArgs e)
        //{
        //    LimpiarCamposTexto();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (dgUsuarios.SelectedRows.Count > 0)
        //    {
        //        int usuarioId = Convert.ToInt32(dgUsuarios.SelectedRows[0].Cells["Id"].Value);

        //        DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmación de eliminación", MessageBoxButtons.YesNo);

        //        if (resultado == DialogResult.Yes)
        //        {
        //            UsuarioBussiness.EliminarUsuario(usuarioId);

        //            ActualizarListaDeUsuarios();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Selecciona un usuario para eliminar.");
        //    }
        //}
        //private void button3_Click(object sender, EventArgs e)
        //{

        //}

        //private void LimpiarCamposTexto()
        //{
        //    txtNombre.Text = "";
        //    txtApellido.Text = "";
        //    txtNombreUsuario.Text = "";
        //    txtContraseña.Text = "";
        //    txtMail.Text = "";
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    string criterio = txtFiltro.Text;

        //    List<Usuario> usuarios;

        //    if (int.TryParse(criterio, out int usuarioId))
        //    {
        //        Usuario usuarioSeleccionado = UsuarioBussiness.ObtenerUsuario(usuarioId);

        //        if (usuarioSeleccionado != null)
        //        {
        //            List<Usuario> usuariosFiltrados = new List<Usuario>();
        //            usuariosFiltrados.Add(usuarioSeleccionado);
        //            usuarios = usuariosFiltrados;
        //        }
        //        else
        //        {
        //            MessageBox.Show("No se encontró ningún usuario con el ID especificado.");
        //            usuarios = new List<Usuario>();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("El criterio de búsqueda debe ser un número (ID).");
        //        usuarios = UsuarioBussiness.ListarUsuario();
        //    }

        //    dgUsuarios.DataSource = usuarios;
        //}

        //private void tabPage3_Click(object sender, EventArgs e)
        //{

        //}

        //private void dgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}






