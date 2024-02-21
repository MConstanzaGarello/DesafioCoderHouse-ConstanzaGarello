using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Desafio_Nuevo
{
    public partial class UsuarioData : Form
    {
        public UsuarioData()
        {
            InitializeComponent();
        }

        private void btnListarUsuarios_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-COTI;Database=master;Trusted_Connection=True;";
            List<Usuario> listaUsuario = new List<Usuario>();
            var query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail FROM Usuario;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var Usuario = new Usuario();
                                Usuario.Id = Convert.ToInt32(reader["Id"]);
                                Usuario.Nombre = reader["Nombre"].ToString();
                                Usuario.Apellido = reader["Apellido"].ToString();
                                Usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                                Usuario.Contrasenia = reader["Contraseña"].ToString();
                                Usuario.Mail = reader["Mail"].ToString();
                                listaUsuario.Add(Usuario);
                            }

                        }
                    }
                }
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = listaUsuario;
                connection.Close();
            }
        }

        private void btnObtenerUsuario_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-COTI;Database=master;Trusted_Connection=True;";
            List<Usuario> listaUsuario = new List<Usuario>();
            var query = $"SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail FROM Usuario Where Id={txtId.Text}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "Id";
                    parametro.SqlDbType = SqlDbType.VarChar;
                    parametro.Value = txtId.Text;

                    command.Parameters.Add(parametro);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var Usuario = new Usuario();
                                Usuario.Id = Convert.ToInt32(reader["Id"]);
                                Usuario.Nombre = reader["Nombre"].ToString();
                                Usuario.Apellido = reader["Apellido"].ToString();
                                Usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                                Usuario.Contrasenia = reader["Contraseña"].ToString();
                                Usuario.Mail = reader["Mail"].ToString();
                                listaUsuario.Add(Usuario);
                            }
                        }
                    }
                }
                dataGridView1.DataSource = listaUsuario;
                connection.Close();
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-COTI;Database=master;Trusted_Connection=True;";
            var query = "DELETE FROM Usuario WHERE Id=@Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = int.Parse(txtId.Text);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-COTI;Database=master;Trusted_Connection=True;";
            var query = "INSERT INTO Usuario (Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail) " +
                         "VALUES(@Id, @Nombre, @Apellido, @NombreUsuario, @Contraseña, @Mail)";

            Usuario usuario = new Usuario
            {
                Id = Convert.ToInt32(txtIdUssuario.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                NombreUsuario = txtNombreUssuario.Text,
                Contrasenia = txtContraseniaUsuario.Text,
                Mail = txtMailUsuario.Text
            };

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = usuario.Id;
                    command.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = usuario.Nombre;
                    command.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = usuario.Apellido;
                    command.Parameters.Add("@NombreUsuario", SqlDbType.VarChar).Value = usuario.NombreUsuario;
                    command.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = usuario.Contrasenia;
                    command.Parameters.Add("@Mail", SqlDbType.VarChar).Value = usuario.Mail;


                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario
            {
                Id = Convert.ToInt32(txtIdUssuario.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                NombreUsuario = txtNombreUssuario.Text,
                Contrasenia = txtContraseniaUsuario.Text,
                Mail = txtMailUsuario.Text
            };

            string connectionString = @"Server=DESKTOP-COTI;Database=master;Trusted_Connection=True;";
            var query = "UPDATE Usuario SET Id=@Id, Nombre=@Nombre, Apellido=@Apellido, NombreUsuario=@NombreUsuario, " +
                        "Contraseña=@Contraseña, Mail=@Mail WHERE Id=@Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = usuario.Id;
                    command.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = usuario.Nombre;
                    command.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = usuario.Apellido;
                    command.Parameters.Add("@NombreUsuario", SqlDbType.VarChar).Value = usuario.NombreUsuario;
                    command.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = usuario.Contrasenia;
                    command.Parameters.Add("@Mail", SqlDbType.VarChar).Value = usuario.Mail;


                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
    }
}
