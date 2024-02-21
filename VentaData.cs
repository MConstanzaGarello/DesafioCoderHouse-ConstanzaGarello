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

namespace Desafio_Nuevo
{
    public partial class VentaData : Form
    {
        public VentaData()
        {
            InitializeComponent();
        }

        private void btnListarVentas_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-COTI;Database=master;Trusted_Connection=True;";
            List<Venta> listaVenta = new List<Venta>();
            var query = "SELECT Id, Comentarios, IdUsuario FROM Venta;";

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
                                var venta = new Venta();
                                venta.Id = Convert.ToInt32(reader["Id"]);
                                venta.Comentarios = reader["Comentarios"].ToString();
                                venta.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                                listaVenta.Add(venta);
                            }

                        }
                    }
                }
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = listaVenta;
                connection.Close();
            }
        }

        private void btnObtenerVenta_Click(object sender, EventArgs e)
        {
            List<Venta> listaVenta = new List<Venta>();
            string connectionString = @"Server=DESKTOP-COTI;Database=master;Trusted_Connection=True;";
            var query = $"SELECT Id, Comentarios, IdUsuario FROM Venta Where Id={txtId.Text}";

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
                                var venta = new Venta();
                                venta.Id = Convert.ToInt32(reader["Id"]);
                                venta.Comentarios = reader["Comentarios"].ToString();
                                venta.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                                listaVenta.Add(venta);
                            }
                        }
                    }
                }
                dataGridView1.DataSource = listaVenta;
                connection.Close();
            }
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-COTI;Database=master;Trusted_Connection=True;";
            var query = "DELETE FROM Venta WHERE Id=@Id";

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

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-COTI;Database=master;Trusted_Connection=True;";
            var query = "INSERT INTO Venta (Id, Comentarios, IdUsuario) " +
                         "VALUES(@Id, @Comentarios,@IdUsuario)";

            Venta venta = new Venta
            {
                Id = Convert.ToInt32(txtIdVenta.Text),
                Comentarios = txtComentarios.Text,
                IdUsuario = Convert.ToInt32(txtIdUsuario.Text)
            };

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = venta.Id;
                    command.Parameters.Add("@Comentarios", SqlDbType.VarChar).Value = venta.Comentarios;
                    command.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = venta.IdUsuario;


                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }

        private void btnModificarVenta_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta
            {
                Id = Convert.ToInt32(txtIdVenta.Text),
                Comentarios = txtComentarios.Text,
                IdUsuario = Convert.ToInt32(txtIdUsuario.Text)
            };

            string connectionString = @"Server=DESKTOP-COTI;Database=master;Trusted_Connection=True;";
            var query = "UPDATE Venta SET Id=@Id, Comentarios=@Comentarios, IdUsuario=@IdUsuario WHERE Id=@Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = venta.Id;
                    command.Parameters.Add("@Comentarios", SqlDbType.VarChar).Value = venta.Comentarios;
                    command.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = venta.IdUsuario;

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
