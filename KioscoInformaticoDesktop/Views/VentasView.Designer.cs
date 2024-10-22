namespace KioscoInformaticoDesktop.Views
{
    partial class VentasView
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dateTimeFecha = new DateTimePicker();
            label1 = new Label();
            cboFormaPago = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cboClientes = new ComboBox();
            label4 = new Label();
            cboProductos = new ComboBox();
            panel1 = new Panel();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            numericSubtotal = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            numericCantidad = new NumericUpDown();
            numericPrecio = new NumericUpDown();
            gridDetallesVenta = new DataGridView();
            btnQuitar = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            numericTotal = new NumericUpDown();
            btnFinalizarVenta = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericSubtotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridDetallesVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericTotal).BeginInit();
            SuspendLayout();
            // 
            // dateTimeFecha
            // 
            dateTimeFecha.Anchor = AnchorStyles.None;
            dateTimeFecha.Enabled = false;
            dateTimeFecha.Format = DateTimePickerFormat.Short;
            dateTimeFecha.Location = new Point(861, 60);
            dateTimeFecha.Name = "dateTimeFecha";
            dateTimeFecha.Size = new Size(106, 27);
            dateTimeFecha.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(805, 67);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "Fecha:";
            // 
            // cboFormaPago
            // 
            cboFormaPago.Anchor = AnchorStyles.None;
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(142, 109);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(151, 28);
            cboFormaPago.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(22, 117);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 3;
            label2.Text = "Forma de pago:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(324, 117);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 4;
            label3.Text = "Cliente:";
            // 
            // cboClientes
            // 
            cboClientes.Anchor = AnchorStyles.None;
            cboClientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboClientes.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(388, 109);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(286, 28);
            cboClientes.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 17);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 7;
            label4.Text = "Producto:";
            // 
            // cboProductos
            // 
            cboProductos.FormattingEnabled = true;
            cboProductos.Location = new Point(4, 40);
            cboProductos.Name = "cboProductos";
            cboProductos.Size = new Size(271, 28);
            cboProductos.TabIndex = 6;
            cboProductos.SelectedIndexChanged += cboProductos_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(numericSubtotal);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(numericCantidad);
            panel1.Controls.Add(numericPrecio);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cboProductos);
            panel1.Location = new Point(22, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 88);
            panel1.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 35;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(781, 17);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(125, 61);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(578, 17);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 14;
            label7.Text = "Subtotal:";
            // 
            // numericSubtotal
            // 
            numericSubtotal.DecimalPlaces = 2;
            numericSubtotal.Enabled = false;
            numericSubtotal.Location = new Point(580, 41);
            numericSubtotal.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericSubtotal.Name = "numericSubtotal";
            numericSubtotal.ReadOnly = true;
            numericSubtotal.Size = new Size(108, 27);
            numericSubtotal.TabIndex = 13;
            numericSubtotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(445, 17);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 12;
            label6.Text = "Cantidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(300, 17);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 11;
            label5.Text = "Precio:";
            // 
            // numericCantidad
            // 
            numericCantidad.DecimalPlaces = 2;
            numericCantidad.Location = new Point(445, 40);
            numericCantidad.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericCantidad.Name = "numericCantidad";
            numericCantidad.Size = new Size(108, 27);
            numericCantidad.TabIndex = 10;
            numericCantidad.TextAlign = HorizontalAlignment.Right;
            numericCantidad.ValueChanged += numericCantidad_ValueChanged;
            // 
            // numericPrecio
            // 
            numericPrecio.DecimalPlaces = 2;
            numericPrecio.Enabled = false;
            numericPrecio.Location = new Point(300, 40);
            numericPrecio.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericPrecio.Name = "numericPrecio";
            numericPrecio.ReadOnly = true;
            numericPrecio.Size = new Size(108, 27);
            numericPrecio.TabIndex = 9;
            numericPrecio.TextAlign = HorizontalAlignment.Right;
            numericPrecio.ValueChanged += numericPrecio_ValueChanged;
            // 
            // gridDetallesVenta
            // 
            gridDetallesVenta.AllowUserToAddRows = false;
            gridDetallesVenta.AllowUserToDeleteRows = false;
            gridDetallesVenta.Anchor = AnchorStyles.None;
            gridDetallesVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridDetallesVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridDetallesVenta.DefaultCellStyle = dataGridViewCellStyle2;
            gridDetallesVenta.Location = new Point(28, 258);
            gridDetallesVenta.Name = "gridDetallesVenta";
            gridDetallesVenta.ReadOnly = true;
            gridDetallesVenta.RowHeadersWidth = 51;
            gridDetallesVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridDetallesVenta.Size = new Size(751, 248);
            gridDetallesVenta.TabIndex = 9;
            gridDetallesVenta.DataBindingComplete += gridDetallesVenta_DataBindingComplete;
            // 
            // btnQuitar
            // 
            btnQuitar.Anchor = AnchorStyles.None;
            btnQuitar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnQuitar.IconColor = Color.Black;
            btnQuitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuitar.IconSize = 35;
            btnQuitar.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuitar.Location = new Point(805, 280);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(125, 61);
            btnQuitar.TabIndex = 20;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(602, 524);
            label8.Name = "label8";
            label8.Size = new Size(95, 20);
            label8.TabIndex = 22;
            label8.Text = "Total factura:";
            // 
            // numericTotal
            // 
            numericTotal.Anchor = AnchorStyles.None;
            numericTotal.DecimalPlaces = 2;
            numericTotal.Enabled = false;
            numericTotal.Location = new Point(604, 547);
            numericTotal.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericTotal.Name = "numericTotal";
            numericTotal.ReadOnly = true;
            numericTotal.Size = new Size(108, 27);
            numericTotal.TabIndex = 21;
            numericTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // btnFinalizarVenta
            // 
            btnFinalizarVenta.Anchor = AnchorStyles.None;
            btnFinalizarVenta.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnFinalizarVenta.IconColor = Color.Black;
            btnFinalizarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFinalizarVenta.IconSize = 35;
            btnFinalizarVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizarVenta.Location = new Point(748, 518);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(182, 61);
            btnFinalizarVenta.TabIndex = 23;
            btnFinalizarVenta.Text = "Finalizar venta";
            btnFinalizarVenta.UseVisualStyleBackColor = true;
            btnFinalizarVenta.Click += btnFinalizarVenta_Click;
            // 
            // VentasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 591);
            Controls.Add(btnFinalizarVenta);
            Controls.Add(label8);
            Controls.Add(numericTotal);
            Controls.Add(btnQuitar);
            Controls.Add(gridDetallesVenta);
            Controls.Add(cboClientes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboFormaPago);
            Controls.Add(label1);
            Controls.Add(dateTimeFecha);
            Controls.Add(panel1);
            Name = "VentasView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ventas";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericSubtotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridDetallesVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimeFecha;
        private Label label1;
        private ComboBox cboFormaPago;
        private Label label2;
        private Label label3;
        private ComboBox cboClientes;
        private Label label4;
        private ComboBox cboProductos;
        private Panel panel1;
        private NumericUpDown numericPrecio;
        private Label label7;
        private NumericUpDown numericSubtotal;
        private Label label6;
        private Label label5;
        private NumericUpDown numericCantidad;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private DataGridView gridDetallesVenta;
        private FontAwesome.Sharp.IconButton btnQuitar;
        private Label label8;
        private NumericUpDown numericTotal;
        private FontAwesome.Sharp.IconButton btnFinalizarVenta;
    }
}