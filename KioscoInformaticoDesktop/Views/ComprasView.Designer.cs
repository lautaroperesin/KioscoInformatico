﻿namespace KioscoInformaticoDesktop.Views
{
    partial class ComprasView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnFinalizarCompra = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            numericTotal = new NumericUpDown();
            btnQuitar = new FontAwesome.Sharp.IconButton();
            gridDetallesCompra = new DataGridView();
            cboProveedores = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            cboFormaPago = new ComboBox();
            label1 = new Label();
            dateTimeFecha = new DateTimePicker();
            panel1 = new Panel();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            numericSubtotal = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            numericCantidad = new NumericUpDown();
            numericPrecio = new NumericUpDown();
            label4 = new Label();
            cboProductos = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridDetallesCompra).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericSubtotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).BeginInit();
            SuspendLayout();
            // 
            // btnFinalizarCompra
            // 
            btnFinalizarCompra.Anchor = AnchorStyles.None;
            btnFinalizarCompra.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnFinalizarCompra.IconColor = Color.Black;
            btnFinalizarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFinalizarCompra.IconSize = 35;
            btnFinalizarCompra.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizarCompra.Location = new Point(737, 517);
            btnFinalizarCompra.Name = "btnFinalizarCompra";
            btnFinalizarCompra.Size = new Size(182, 61);
            btnFinalizarCompra.TabIndex = 35;
            btnFinalizarCompra.Text = "Finalizar compra";
            btnFinalizarCompra.UseVisualStyleBackColor = true;
            btnFinalizarCompra.Click += btnFinalizarCompra_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(592, 524);
            label8.Name = "label8";
            label8.Size = new Size(95, 20);
            label8.TabIndex = 34;
            label8.Text = "Total factura:";
            // 
            // numericTotal
            // 
            numericTotal.Anchor = AnchorStyles.None;
            numericTotal.DecimalPlaces = 2;
            numericTotal.Enabled = false;
            numericTotal.Location = new Point(593, 547);
            numericTotal.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericTotal.Name = "numericTotal";
            numericTotal.ReadOnly = true;
            numericTotal.Size = new Size(107, 27);
            numericTotal.TabIndex = 33;
            numericTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // btnQuitar
            // 
            btnQuitar.Anchor = AnchorStyles.None;
            btnQuitar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnQuitar.IconColor = Color.Black;
            btnQuitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuitar.IconSize = 35;
            btnQuitar.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuitar.Location = new Point(794, 280);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(125, 61);
            btnQuitar.TabIndex = 32;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // gridDetallesCompra
            // 
            gridDetallesCompra.AllowUserToAddRows = false;
            gridDetallesCompra.AllowUserToDeleteRows = false;
            gridDetallesCompra.Anchor = AnchorStyles.None;
            gridDetallesCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridDetallesCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridDetallesCompra.DefaultCellStyle = dataGridViewCellStyle1;
            gridDetallesCompra.Location = new Point(17, 259);
            gridDetallesCompra.Name = "gridDetallesCompra";
            gridDetallesCompra.ReadOnly = true;
            gridDetallesCompra.RowHeadersWidth = 51;
            gridDetallesCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridDetallesCompra.Size = new Size(751, 248);
            gridDetallesCompra.TabIndex = 31;
            gridDetallesCompra.DataBindingComplete += gridDetallesCompra_DataBindingComplete;
            // 
            // cboProveedores
            // 
            cboProveedores.Anchor = AnchorStyles.None;
            cboProveedores.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboProveedores.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboProveedores.FormattingEnabled = true;
            cboProveedores.Location = new Point(378, 109);
            cboProveedores.Name = "cboProveedores";
            cboProveedores.Size = new Size(286, 28);
            cboProveedores.TabIndex = 29;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(298, 117);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 28;
            label3.Text = "Proveedor:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(11, 117);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 27;
            label2.Text = "Forma de pago:";
            // 
            // cboFormaPago
            // 
            cboFormaPago.Anchor = AnchorStyles.None;
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(131, 109);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(151, 28);
            cboFormaPago.TabIndex = 26;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(794, 67);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 25;
            label1.Text = "Fecha:";
            // 
            // dateTimeFecha
            // 
            dateTimeFecha.Anchor = AnchorStyles.None;
            dateTimeFecha.Enabled = false;
            dateTimeFecha.Format = DateTimePickerFormat.Short;
            dateTimeFecha.Location = new Point(850, 60);
            dateTimeFecha.Name = "dateTimeFecha";
            dateTimeFecha.Size = new Size(106, 27);
            dateTimeFecha.TabIndex = 24;
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
            panel1.Location = new Point(11, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 88);
            panel1.TabIndex = 30;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 35;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(781, 11);
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
            numericSubtotal.Location = new Point(581, 41);
            numericSubtotal.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericSubtotal.Name = "numericSubtotal";
            numericSubtotal.ReadOnly = true;
            numericSubtotal.Size = new Size(107, 27);
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
            label5.Location = new Point(299, 17);
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
            numericCantidad.Size = new Size(107, 27);
            numericCantidad.TabIndex = 10;
            numericCantidad.TextAlign = HorizontalAlignment.Right;
            numericCantidad.ValueChanged += numericCantidad_ValueChanged;
            // 
            // numericPrecio
            // 
            numericPrecio.DecimalPlaces = 2;
            numericPrecio.Enabled = false;
            numericPrecio.Location = new Point(299, 40);
            numericPrecio.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericPrecio.Name = "numericPrecio";
            numericPrecio.ReadOnly = true;
            numericPrecio.Size = new Size(107, 27);
            numericPrecio.TabIndex = 9;
            numericPrecio.TextAlign = HorizontalAlignment.Right;
            numericPrecio.ValueChanged += numericPrecio_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 17);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 7;
            label4.Text = "Producto:";
            // 
            // cboProductos
            // 
            cboProductos.FormattingEnabled = true;
            cboProductos.Location = new Point(5, 40);
            cboProductos.Name = "cboProductos";
            cboProductos.Size = new Size(271, 28);
            cboProductos.TabIndex = 6;
            cboProductos.SelectedIndexChanged += cboProductos_SelectedIndexChanged;
            // 
            // ComprasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 639);
            Controls.Add(btnFinalizarCompra);
            Controls.Add(label8);
            Controls.Add(numericTotal);
            Controls.Add(btnQuitar);
            Controls.Add(gridDetallesCompra);
            Controls.Add(cboProveedores);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboFormaPago);
            Controls.Add(label1);
            Controls.Add(dateTimeFecha);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ComprasView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)numericTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridDetallesCompra).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericSubtotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnFinalizarCompra;
        private Label label8;
        private NumericUpDown numericTotal;
        private FontAwesome.Sharp.IconButton btnQuitar;
        private DataGridView gridDetallesCompra;
        private ComboBox cboProveedores;
        private Label label3;
        private Label label2;
        private ComboBox cboFormaPago;
        private Label label1;
        private DateTimePicker dateTimeFecha;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private Label label7;
        private NumericUpDown numericSubtotal;
        private Label label6;
        private Label label5;
        private NumericUpDown numericCantidad;
        private NumericUpDown numericPrecio;
        private Label label4;
        private ComboBox cboProductos;
    }
}