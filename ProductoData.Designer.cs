namespace Desafio_Nuevo
{
    partial class ProductoData
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            ObtenerId = new Label();
            TxtIdProducto = new TextBox();
            BtnIdProducto = new Button();
            btnEliminarProducto = new Button();
            btnListarProductos = new Button();
            btnAgregarProducto = new Button();
            txtId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtCosto = new TextBox();
            txtPrecioVenta = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtStock = new TextBox();
            label6 = new Label();
            txtIdUsuario = new TextBox();
            btnModificarProducto = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtIdProduct = new TextBox();
            txtDescripcionProducto = new TextBox();
            txtCostoProducto = new TextBox();
            txtPrecioVentaProducto = new TextBox();
            txtStockProducto = new TextBox();
            txtIdUsuarioProducto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 421);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 188);
            dataGridView1.TabIndex = 0;
            // 
            // ObtenerId
            // 
            ObtenerId.AutoSize = true;
            ObtenerId.Location = new Point(11, 85);
            ObtenerId.Name = "ObtenerId";
            ObtenerId.Size = new Size(167, 20);
            ObtenerId.TabIndex = 2;
            ObtenerId.Text = "Ingrese Id del producto:";
            // 
            // TxtIdProducto
            // 
            TxtIdProducto.Location = new Point(195, 82);
            TxtIdProducto.Name = "TxtIdProducto";
            TxtIdProducto.Size = new Size(125, 27);
            TxtIdProducto.TabIndex = 3;
            // 
            // BtnIdProducto
            // 
            BtnIdProducto.Location = new Point(352, 69);
            BtnIdProducto.Name = "BtnIdProducto";
            BtnIdProducto.Size = new Size(107, 52);
            BtnIdProducto.TabIndex = 5;
            BtnIdProducto.Text = "OBTENER PRODUCTO";
            BtnIdProducto.UseVisualStyleBackColor = true;
            BtnIdProducto.Click += BotonIdProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(465, 69);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(107, 52);
            btnEliminarProducto.TabIndex = 6;
            btnEliminarProducto.Text = "ELIMINAR PRODUCTO";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnListarProductos
            // 
            btnListarProductos.Location = new Point(43, 12);
            btnListarProductos.Name = "btnListarProductos";
            btnListarProductos.Size = new Size(101, 56);
            btnListarProductos.TabIndex = 7;
            btnListarProductos.Text = "LISTAR PRODUCTOS";
            btnListarProductos.UseVisualStyleBackColor = true;
            btnListarProductos.Click += btnListarProductos_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(619, 203);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(94, 52);
            btnAgregarProducto.TabIndex = 8;
            btnAgregarProducto.Text = "AGREGAR PRODUCTO";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(26, 218);
            txtId.Name = "txtId";
            txtId.Size = new Size(69, 27);
            txtId.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 193);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 10;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 193);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 11;
            label2.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(111, 216);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(125, 27);
            txtDescripcion.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 193);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 13;
            label3.Text = "Costo";
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(242, 216);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(99, 27);
            txtCosto.TabIndex = 14;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(347, 216);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(99, 27);
            txtPrecioVenta.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 193);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 16;
            label4.Text = "Precio Venta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(461, 193);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 18;
            label5.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(452, 216);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(69, 27);
            txtStock.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(524, 193);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 20;
            label6.Text = "IdUsuario";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(527, 216);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(69, 27);
            txtIdUsuario.TabIndex = 19;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(619, 300);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(107, 52);
            btnModificarProducto.TabIndex = 21;
            btnModificarProducto.Text = "MODIFICAR PRODUCTO";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(525, 316);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 27;
            label7.Text = "IdUsuario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(462, 316);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 26;
            label8.Text = "Stock";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(352, 316);
            label9.Name = "label9";
            label9.Size = new Size(91, 20);
            label9.TabIndex = 25;
            label9.Text = "Precio Venta";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(268, 316);
            label10.Name = "label10";
            label10.Size = new Size(47, 20);
            label10.TabIndex = 24;
            label10.Text = "Costo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(135, 316);
            label11.Name = "label11";
            label11.Size = new Size(87, 20);
            label11.TabIndex = 23;
            label11.Text = "Descripción";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(49, 316);
            label12.Name = "label12";
            label12.Size = new Size(22, 20);
            label12.TabIndex = 22;
            label12.Text = "Id";
            // 
            // txtIdProduct
            // 
            txtIdProduct.Location = new Point(26, 339);
            txtIdProduct.Name = "txtIdProduct";
            txtIdProduct.Size = new Size(69, 27);
            txtIdProduct.TabIndex = 34;
            // 
            // txtDescripcionProducto
            // 
            txtDescripcionProducto.Location = new Point(111, 339);
            txtDescripcionProducto.Name = "txtDescripcionProducto";
            txtDescripcionProducto.Size = new Size(125, 27);
            txtDescripcionProducto.TabIndex = 35;
            // 
            // txtCostoProducto
            // 
            txtCostoProducto.Location = new Point(242, 339);
            txtCostoProducto.Name = "txtCostoProducto";
            txtCostoProducto.Size = new Size(99, 27);
            txtCostoProducto.TabIndex = 36;
            // 
            // txtPrecioVentaProducto
            // 
            txtPrecioVentaProducto.Location = new Point(347, 339);
            txtPrecioVentaProducto.Name = "txtPrecioVentaProducto";
            txtPrecioVentaProducto.Size = new Size(99, 27);
            txtPrecioVentaProducto.TabIndex = 37;
            // 
            // txtStockProducto
            // 
            txtStockProducto.Location = new Point(452, 339);
            txtStockProducto.Name = "txtStockProducto";
            txtStockProducto.Size = new Size(69, 27);
            txtStockProducto.TabIndex = 38;
            // 
            // txtIdUsuarioProducto
            // 
            txtIdUsuarioProducto.Location = new Point(527, 339);
            txtIdUsuarioProducto.Name = "txtIdUsuarioProducto";
            txtIdUsuarioProducto.Size = new Size(69, 27);
            txtIdUsuarioProducto.TabIndex = 39;
            // 
            // ProductoData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 621);
            Controls.Add(txtIdUsuarioProducto);
            Controls.Add(txtStockProducto);
            Controls.Add(txtPrecioVentaProducto);
            Controls.Add(txtCostoProducto);
            Controls.Add(txtDescripcionProducto);
            Controls.Add(txtIdProduct);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(btnModificarProducto);
            Controls.Add(label6);
            Controls.Add(txtIdUsuario);
            Controls.Add(label5);
            Controls.Add(txtStock);
            Controls.Add(label4);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtCosto);
            Controls.Add(label3);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(btnAgregarProducto);
            Controls.Add(btnListarProductos);
            Controls.Add(btnEliminarProducto);
            Controls.Add(BtnIdProducto);
            Controls.Add(TxtIdProducto);
            Controls.Add(ObtenerId);
            Controls.Add(dataGridView1);
            Name = "ProductoData";
            Text = "Form1";
            Load += ProductoData_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label ObtenerId;
        private TextBox IdProducto;
        private Button BotonIdProducto;
        private TextBox TxtIdProducto;
        private Button BtnIdProducto;
        private Button btnEliminarProducto;
        private Button btnListarProductos;
        private Button btnAgregarProducto;
        private TextBox txtId;
        private Label label1;
        private Label label2;
        private TextBox txtDescripcion;
        private Label label3;
        private TextBox txtCosto;
        private TextBox txtPrecioVenta;
        private Label label4;
        private Label label5;
        private TextBox txtStock;
        private Label label6;
        private TextBox txtIdUsuario;
        private Button btnModificarProducto;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtIdProduct;
        private TextBox txtDescripcionProducto;
        private TextBox txtCostoProducto;
        private TextBox txtPrecioVentaProducto;
        private TextBox txtStockProducto;
        private TextBox txtIdUsuarioProducto;
    }
}
