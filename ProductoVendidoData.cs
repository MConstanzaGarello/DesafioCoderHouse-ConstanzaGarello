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
    public partial class ProductoVendidoData : Form
    {
        public ProductoVendidoData()
        {
            InitializeComponent();
        }

        private void btnListarProductosVendidos_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-COTI;Database=master;Trusted_Connection=True;";
            List<ProductoVendido> listaProductoVendido = new List<ProductoVendido>();
            var query = "SELECT Id, IdProducto, Stock, IdVenta FROM ProductoVendido;";

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
                                var productoVendido = new ProductoVendido();
                                productoVendido.Id = Convert.ToInt32(reader["Id"]);
                                productoVendido.IdProducto = Convert.ToInt32(reader["IdProducto"]);
                                productoVendido.Stock = Convert.ToInt32(reader["Stock"]);
                                productoVendido.IdVenta = Convert.ToInt32(reader["IdVenta"]);
                                listaProductoVendido.Add(productoVendido);
                            }

                        }
                    }
                }
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = listaProductoVendido;
                connection.Close();
            }
        }

        private void btnObtenerProductoVendido_Click(object sender, EventArgs e)
        {
            List<ProductoVendido> listaProducto = new List<ProductoVendido>();
            string connectionString = @"Server=DESKTOP-COTI;Database=master;Trusted_Connection=True;";
            var query = $"SELECT Id, IdProducto, Stock, IdVenta FROM ProductoVendido Where Id={txtId.Text}";

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
                                var productoVendido = new ProductoVendido();
                                productoVendido.Id = Convert.ToInt32(reader["Id"]);
                                productoVendido.IdProducto = Convert.ToInt32(reader["IdProducto"]);
                                productoVendido.Stock = Convert.ToInt32(reader["Stock"]);
                                productoVendido.IdVenta = Convert.ToInt32(reader["IdVenta"]);
                                listaProducto.Add(productoVendido);
                            }
                        }
                    }
                }
                dataGridView1.DataSource = listaProducto;
                connection.Close();
            }
        }

        private void btnEliminarProductoVendido_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-COTI;Database=master;Trusted_Connection=True;";
            var query = "DELETE FROM ProductoVendido WHERE Id=@Id";

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

        private void btnAgregarProductoVendido_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-COTI;Database=master;Trusted_Connection=True;";
            var query = "INSERT INTO ProductoVendido (Id, IdProducto, Stock, IdVenta) " +
                         "VALUES(@Id, @IdProducto,@Stock,@IdVenta)";

            ProductoVendido productoVendido = new ProductoVendido
            {
                Id = Convert.ToInt32(txtIdProducto.Text),
                IdProducto = Convert.ToInt32(txtIdProductoVendido.Text),
                Stock = Convert.ToInt32(txtStock.Text),
                IdVenta = Convert.ToInt32(txtIdVenta.Text)
            };

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = productoVendido.Id;
                    command.Parameters.Add("@IdProducto", SqlDbType.Int).Value = productoVendido.IdProducto;
                    command.Parameters.Add("@Stock", SqlDbType.Int).Value = productoVendido.Stock;
                    command.Parameters.Add("@IdVenta", SqlDbType.Int).Value = productoVendido.IdVenta;


                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }

        private void btnModificarProductoVendido_Click(object sender, EventArgs e)
        {
            ProductoVendido productoVendido = new ProductoVendido
            {
                Id = Convert.ToInt32(txtIdProducto.Text),
                IdProducto = Convert.ToInt32(txtIdProductoVendido.Text),
                Stock = Convert.ToInt32(txtStock.Text),
                IdVenta = Convert.ToInt32(txtIdVenta.Text)
            };

            string connectionString = @"Server=DESKTOP-COTI;Database=master;Trusted_Connection=True;";
            var query = "UPDATE ProductoVendido SET Id=@Id, IdProducto=@IdProducto, Stock=@Stock, IdVenta=@IdVenta WHERE Id=@Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = productoVendido.Id;
                    command.Parameters.Add("@IdProducto", SqlDbType.Int).Value = productoVendido.IdProducto;
                    command.Parameters.Add("@Stock", SqlDbType.Int).Value = productoVendido.Stock;
                    command.Parameters.Add("@IdVenta", SqlDbType.Int).Value = productoVendido.IdVenta;

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
