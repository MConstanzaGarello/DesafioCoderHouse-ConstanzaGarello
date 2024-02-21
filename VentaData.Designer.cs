namespace Desafio_Nuevo
{
    partial class VentaData
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
            dataGridView1 = new DataGridView();
            btnListarVentas = new Button();
            lblId = new Label();
            btnObtenerVenta = new Button();
            btnEliminarVenta = new Button();
            txtId = new TextBox();
            lblIdVenta = new Label();
            lblComentarios = new Label();
            lblIdUsuario = new Label();
            txtIdVenta = new TextBox();
            txtComentarios = new TextBox();
            txtIdUsuario = new TextBox();
            btnAgregarVenta = new Button();
            btnModificarVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 321);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 117);
            dataGridView1.TabIndex = 0;
            // 
            // btnListarVentas
            // 
            btnListarVentas.Location = new Point(27, 25);
            btnListarVentas.Name = "btnListarVentas";
            btnListarVentas.Size = new Size(75, 52);
            btnListarVentas.TabIndex = 1;
            btnListarVentas.Text = "LISTAR VENTAS";
            btnListarVentas.UseVisualStyleBackColor = true;
            btnListarVentas.Click += btnListarVentas_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(27, 112);
            lblId.Name = "lblId";
            lblId.Size = new Size(65, 15);
            lblId.TabIndex = 2;
            lblId.Text = "Ingresar Id:";
            // 
            // btnObtenerVenta
            // 
            btnObtenerVenta.Location = new Point(229, 88);
            btnObtenerVenta.Name = "btnObtenerVenta";
            btnObtenerVenta.Size = new Size(75, 52);
            btnObtenerVenta.TabIndex = 3;
            btnObtenerVenta.Text = "OBTENER VENTA";
            btnObtenerVenta.UseVisualStyleBackColor = true;
            btnObtenerVenta.Click += btnObtenerVenta_Click;
            // 
            // btnEliminarVenta
            // 
            btnEliminarVenta.Location = new Point(327, 88);
            btnEliminarVenta.Name = "btnEliminarVenta";
            btnEliminarVenta.Size = new Size(75, 52);
            btnEliminarVenta.TabIndex = 4;
            btnEliminarVenta.Text = "ELIMINAR VENTA";
            btnEliminarVenta.UseVisualStyleBackColor = true;
            btnEliminarVenta.Click += btnEliminarVenta_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(112, 104);
            txtId.Name = "txtId";
            txtId.Size = new Size(83, 23);
            txtId.TabIndex = 5;
            // 
            // lblIdVenta
            // 
            lblIdVenta.AutoSize = true;
            lblIdVenta.Location = new Point(67, 193);
            lblIdVenta.Name = "lblIdVenta";
            lblIdVenta.Size = new Size(17, 15);
            lblIdVenta.TabIndex = 6;
            lblIdVenta.Text = "Id";
            // 
            // lblComentarios
            // 
            lblComentarios.AutoSize = true;
            lblComentarios.Location = new Point(157, 193);
            lblComentarios.Name = "lblComentarios";
            lblComentarios.Size = new Size(75, 15);
            lblComentarios.TabIndex = 7;
            lblComentarios.Text = "Comentarios";
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.Location = new Point(297, 193);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(57, 15);
            lblIdUsuario.TabIndex = 8;
            lblIdUsuario.Text = "IdUsuario";
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(51, 211);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(51, 23);
            txtIdVenta.TabIndex = 9;
            // 
            // txtComentarios
            // 
            txtComentarios.Location = new Point(148, 211);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(96, 23);
            txtComentarios.TabIndex = 10;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(297, 211);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(51, 23);
            txtIdUsuario.TabIndex = 11;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.Location = new Point(411, 182);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(75, 52);
            btnAgregarVenta.TabIndex = 12;
            btnAgregarVenta.Text = "AGREGAR VENTA";
            btnAgregarVenta.UseVisualStyleBackColor = true;
            btnAgregarVenta.Click += btnAgregarVenta_Click;
            // 
            // btnModificarVenta
            // 
            btnModificarVenta.Location = new Point(508, 182);
            btnModificarVenta.Name = "btnModificarVenta";
            btnModificarVenta.Size = new Size(78, 52);
            btnModificarVenta.TabIndex = 13;
            btnModificarVenta.Text = "MODIFICAR VENTA";
            btnModificarVenta.UseVisualStyleBackColor = true;
            btnModificarVenta.Click += btnModificarVenta_Click;
            // 
            // VentaData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificarVenta);
            Controls.Add(btnAgregarVenta);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtComentarios);
            Controls.Add(txtIdVenta);
            Controls.Add(lblIdUsuario);
            Controls.Add(lblComentarios);
            Controls.Add(lblIdVenta);
            Controls.Add(txtId);
            Controls.Add(btnEliminarVenta);
            Controls.Add(btnObtenerVenta);
            Controls.Add(lblId);
            Controls.Add(btnListarVentas);
            Controls.Add(dataGridView1);
            Name = "VentaData";
            Text = "VentaData";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnListarVentas;
        private Label lblId;
        private Button btnObtenerVenta;
        private Button btnEliminarVenta;
        private TextBox txtId;
        private Label lblIdVenta;
        private Label lblComentarios;
        private Label lblIdUsuario;
        private TextBox txtIdVenta;
        private TextBox txtComentarios;
        private TextBox txtIdUsuario;
        private Button btnAgregarVenta;
        private Button btnModificarVenta;
    }
}