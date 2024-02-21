using System.Data;
using System.Data.SqlClient;

namespace Desafio_Nuevo
{
    public partial class ProductoData : Form
    {
        public ProductoData()
        {
            InitializeComponent();
        }

        private void ProductoData_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-COTI;Database=master;Trusted_Connection=True;";
            List<Producto> listaProducto = new List<Producto>();
            var query = "SELECT Id, Descripcion, Costo, PrecioVenta, Stock, IdUsuario FROM Producto;";

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
                                var Producto = new Producto();
                                Producto.Id = Convert.ToInt32(reader["Id"]);
                                Producto.Descripcion = reader["Descripcion"].ToString();
                                Producto.Costo = (double)Convert.ToDecimal(reader["Costo"]);
                                Producto.PrecioVenta = (double)Convert.ToDecimal(reader["PrecioVenta"]);
                                Producto.Stock = Convert.ToInt32(reader["Stock"]);
                                Producto.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                                listaProducto.Add(Producto);
                            }

                        }
                    }
                }
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = listaProducto;
                connection.Close();
            }
        }

        private void BotonIdProducto_Click(object sender, EventArgs e)
        {
            List<Producto> listaProducto = new List<Producto>();
            string connectionString = @"Server=DESKTOP-COTI;Database=master;Trusted_Connection=True;";
            var query = $"SELECT Id, Descripcion, Costo, PrecioVenta, Stock, IdUsuario FROM Producto Where Id={TxtIdProducto.Text}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "IdProducto";
                    parametro.SqlDbType = SqlDbType.VarChar;
                    parametro.Value = TxtIdProducto.Text;

                    command.Parameters.Add(parametro);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var producto = new Producto();
                                producto.Id = Convert.ToInt32(reader["Id"]);
                                producto.Descripcion = reader["Descripcion"].ToString();
                                producto.Costo = (double)Convert.ToDecimal(reader["Costo"]);
                                producto.PrecioVenta = (double)Convert.ToDecimal(reader["PrecioVenta"]);
                                producto.Stock = Convert.ToInt32(reader["Stock"]);
                                producto.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                                listaProducto.Add(producto);
                            }
                        }
                    }
                }
                dataGridView1.DataSource = listaProducto;
                connection.Close();
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-COTI;Database=master;Trusted_Connection=True;";
            var query = "DELETE FROM Producto WHERE Id=@Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = int.Parse(TxtIdProducto.Text);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-COTI;Database=master;Trusted_Connection=True;";
            List<Producto> listaProducto = new List<Producto>();
            var query = "SELECT Id, Descripcion, Costo, PrecioVenta, Stock, IdUsuario FROM Producto;";

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
                                var Producto = new Producto();
                                Producto.Id = Convert.ToInt32(reader["Id"]);
                                Producto.Descripcion = reader["Descripcion"].ToString();
                                Producto.Costo = (double)Convert.ToDecimal(reader["Costo"]);
                                Producto.PrecioVenta = (double)Convert.ToDecimal(reader["PrecioVenta"]);
                                Producto.Stock = Convert.ToInt32(reader["Stock"]);
                                Producto.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                                listaProducto.Add((Producto)Producto);
                            }

                        }
                    }
                }
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = listaProducto;
                connection.Close();
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-COTI;Database=master;Trusted_Connection=True;";
            var query = "INSERT INTO Producto (Id, Descripcion,Costo,PrecioVenta,Stock, IdUsuario) " +
                         "VALUES(@Id, @Descripcion,@Costo,@PrecioVenta,@Stock, @IdUsuario)";

            Producto producto = new Producto
            {
                Id = Convert.ToInt32(txtId.Text),
                Descripcion = txtDescripcion.Text,
                Costo = double.Parse(txtCosto.Text),
                PrecioVenta = double.Parse(txtPrecioVenta.Text),
                Stock = int.Parse(txtStock.Text),
                IdUsuario = int.Parse(txtIdUsuario.Text)
            };

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = producto.Id;
                    command.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = producto.Descripcion;
                    command.Parameters.Add("@Costo", SqlDbType.Float).Value = producto.Costo;
                    command.Parameters.Add("@PrecioVenta", SqlDbType.Float).Value = producto.PrecioVenta;
                    command.Parameters.Add("@Stock", SqlDbType.Int).Value = producto.Stock;
                    command.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = producto.IdUsuario;

                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto
            {
                Id = int.Parse(txtIdProduct.Text),
                Descripcion = txtDescripcionProducto.Text,
                Costo = double.Parse(txtCostoProducto.Text),
                PrecioVenta = double.Parse(txtPrecioVentaProducto.Text),
                Stock = int.Parse(txtStockProducto.Text),
                IdUsuario = int.Parse(txtIdUsuarioProducto.Text)
            };

            string connectionString = @"Server=DESKTOP-COTI;Database=master;Trusted_Connection=True;";
            var query = "UPDATE Producto SET Id=@Id, Descripcion=@Descripcion, Costo=@Costo, PrecioVenta=@PrecioVenta, " +
                        "Stock=@Stock, IdUsuario=@IdUsuario WHERE Id=@Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = producto.Descripcion;
                    command.Parameters.Add("@Costo", SqlDbType.Float).Value = producto.Costo;
                    command.Parameters.Add("@PrecioVenta", SqlDbType.Float).Value = producto.PrecioVenta;
                    command.Parameters.Add("@Stock", SqlDbType.Int).Value = producto.Stock;
                    command.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = producto.IdUsuario;
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = producto.Id;

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}