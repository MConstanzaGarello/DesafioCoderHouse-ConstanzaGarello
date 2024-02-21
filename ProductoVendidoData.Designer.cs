namespace Desafio_Nuevo
{
    partial class ProductoVendidoData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnListarProductosVendidos = new Button();
            dataGridView1 = new DataGridView();
            lblId = new Label();
            txtId = new TextBox();
            btnObtenerProductoVendido = new Button();
            btnEliminarProductoVendido = new Button();
            lblIdProducto = new Label();
            txtIdProducto = new TextBox();
            txtIdProductoVendido = new TextBox();
            lblIdProductoVendido = new Label();
            txtStock = new TextBox();
            lblStock = new Label();
            txtIdVenta = new TextBox();
            lblIdVenta = new Label();
            btnAgregarProductoVendido = new Button();
            btnModificarProductoVendido = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnListarProductosVendidos
            // 
            btnListarProductosVendidos.Location = new Point(22, 22);
            btnListarProductosVendidos.Name = "btnListarProductosVendidos";
            btnListarProductosVendidos.Size = new Size(114, 61);
            btnListarProductosVendidos.TabIndex = 0;
            btnListarProductosVendidos.Text = "LISTAR PRODUCTOS VENDIDOS";
            btnListarProductosVendidos.UseVisualStyleBackColor = true;
            btnListarProductosVendidos.Click += btnListarProductosVendidos_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 150);
            dataGridView1.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(47, 122);
            lblId.Name = "lblId";
            lblId.Size = new Size(65, 15);
            lblId.TabIndex = 2;
            lblId.Text = "Ingresar Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(145, 114);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 3;
            // 
            // btnObtenerProductoVendido
            // 
            btnObtenerProductoVendido.Location = new Point(276, 93);
            btnObtenerProductoVendido.Name = "btnObtenerProductoVendido";
            btnObtenerProductoVendido.Size = new Size(106, 62);
            btnObtenerProductoVendido.TabIndex = 4;
            btnObtenerProductoVendido.Text = "OBTENER PRODUCTO VENDIDO";
            btnObtenerProductoVendido.UseVisualStyleBackColor = true;
            btnObtenerProductoVendido.Click += btnObtenerProductoVendido_Click;
            // 
            // btnEliminarProductoVendido
            // 
            btnEliminarProductoVendido.Location = new Point(406, 93);
            btnEliminarProductoVendido.Name = "btnEliminarProductoVendido";
            btnEliminarProductoVendido.Size = new Size(106, 62);
            btnEliminarProductoVendido.TabIndex = 5;
            btnEliminarProductoVendido.Text = "ELIMINAR PRODUCTO VENDIDO";
            btnEliminarProductoVendido.UseVisualStyleBackColor = true;
            btnEliminarProductoVendido.Click += btnEliminarProductoVendido_Click;
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.Location = new Point(58, 192);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(17, 15);
            lblIdProducto.TabIndex = 6;
            lblIdProducto.Text = "Id";
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(32, 210);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(71, 23);
            txtIdProducto.TabIndex = 7;
            // 
            // txtIdProductoVendido
            // 
            txtIdProductoVendido.Location = new Point(154, 210);
            txtIdProductoVendido.Name = "txtIdProductoVendido";
            txtIdProductoVendido.Size = new Size(91, 23);
            txtIdProductoVendido.TabIndex = 9;
            // 
            // lblIdProductoVendido
            // 
            lblIdProductoVendido.AutoSize = true;
            lblIdProductoVendido.Location = new Point(167, 192);
            lblIdProductoVendido.Name = "lblIdProductoVendido";
            lblIdProductoVendido.Size = new Size(66, 15);
            lblIdProductoVendido.TabIndex = 8;
            lblIdProductoVendido.Text = "IdProducto";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(300, 210);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(71, 23);
            txtStock.TabIndex = 11;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(315, 192);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 10;
            lblStock.Text = "Stock";
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(421, 210);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(91, 23);
            txtIdVenta.TabIndex = 13;
            // 
            // lblIdVenta
            // 
            lblIdVenta.AutoSize = true;
            lblIdVenta.Location = new Point(444, 192);
            lblIdVenta.Name = "lblIdVenta";
            lblIdVenta.Size = new Size(46, 15);
            lblIdVenta.TabIndex = 12;
            lblIdVenta.Text = "IdVenta";
            // 
            // btnAgregarProductoVendido
            // 
            btnAgregarProductoVendido.Location = new Point(538, 171);
            btnAgregarProductoVendido.Name = "btnAgregarProductoVendido";
            btnAgregarProductoVendido.Size = new Size(106, 62);
            btnAgregarProductoVendido.TabIndex = 14;
            btnAgregarProductoVendido.Text = "AGREGAR PRODUCTO VENDIDO";
            btnAgregarProductoVendido.UseVisualStyleBackColor = true;
            btnAgregarProductoVendido.Click += btnAgregarProductoVendido_Click;
            // 
            // btnModificarProductoVendido
            // 
            btnModificarProductoVendido.Location = new Point(669, 171);
            btnModificarProductoVendido.Name = "btnModificarProductoVendido";
            btnModificarProductoVendido.Size = new Size(106, 62);
            btnModificarProductoVendido.TabIndex = 15;
            btnModificarProductoVendido.Text = "MODIFICAR PRODUCTO VENDIDO";
            btnModificarProductoVendido.UseVisualStyleBackColor = true;
            btnModificarProductoVendido.Click += btnModificarProductoVendido_Click;
            // 
            // ProductoVendidoData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificarProductoVendido);
            Controls.Add(btnAgregarProductoVendido);
            Controls.Add(txtIdVenta);
            Controls.Add(lblIdVenta);
            Controls.Add(txtStock);
            Controls.Add(lblStock);
            Controls.Add(txtIdProductoVendido);
            Controls.Add(lblIdProductoVendido);
            Controls.Add(txtIdProducto);
            Controls.Add(lblIdProducto);
            Controls.Add(btnEliminarProductoVendido);
            Controls.Add(btnObtenerProductoVendido);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(dataGridView1);
            Controls.Add(btnListarProductosVendidos);
            Name = "ProductoVendidoData";
            Text = "ProductoVendidoData";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListarProductosVendidos;
        private DataGridView dataGridView1;
        private Label lblId;
        private TextBox txtId;
        private Button btnObtenerProductoVendido;
        private Button btnEliminarProductoVendido;
        private Label lblIdProducto;
        private TextBox txtIdProducto;
        private TextBox txtIdProductoVendido;
        private Label lblIdProductoVendido;
        private TextBox txtStock;
        private Label lblStock;
        private TextBox txtIdVenta;
        private Label lblIdVenta;
        private Button btnAgregarProductoVendido;
        private Button btnModificarProductoVendido;
    }
}