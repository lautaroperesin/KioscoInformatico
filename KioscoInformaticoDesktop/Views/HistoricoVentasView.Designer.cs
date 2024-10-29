namespace KioscoInformaticoDesktop.Views
{
    partial class HistoricoVentasView
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
            panel1 = new Panel();
            label1 = new Label();
            dataGridVentas = new DataGridView();
            panelFiltrado = new Panel();
            btnFiltrar = new Button();
            dtpHasta = new DateTimePicker();
            label3 = new Label();
            dtpDesde = new DateTimePicker();
            label2 = new Label();
            checkFiltrado = new CheckBox();
            numericTotalFacturado = new NumericUpDown();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVentas).BeginInit();
            panelFiltrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericTotalFacturado).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 84);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(226, 37);
            label1.TabIndex = 0;
            label1.Text = "Histórico ventas";
            // 
            // dataGridVentas
            // 
            dataGridVentas.AllowUserToAddRows = false;
            dataGridVentas.AllowUserToDeleteRows = false;
            dataGridVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridVentas.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridVentas.Location = new Point(24, 166);
            dataGridVentas.Name = "dataGridVentas";
            dataGridVentas.ReadOnly = true;
            dataGridVentas.RowHeadersWidth = 51;
            dataGridVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridVentas.Size = new Size(749, 237);
            dataGridVentas.TabIndex = 3;
            // 
            // panelFiltrado
            // 
            panelFiltrado.BorderStyle = BorderStyle.Fixed3D;
            panelFiltrado.Controls.Add(btnFiltrar);
            panelFiltrado.Controls.Add(dtpHasta);
            panelFiltrado.Controls.Add(label3);
            panelFiltrado.Controls.Add(dtpDesde);
            panelFiltrado.Controls.Add(label2);
            panelFiltrado.Enabled = false;
            panelFiltrado.Location = new Point(160, 105);
            panelFiltrado.Name = "panelFiltrado";
            panelFiltrado.Size = new Size(613, 55);
            panelFiltrado.TabIndex = 4;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(445, 12);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(94, 29);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(310, 12);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(110, 27);
            dtpHasta.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 19);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Hasta:";
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(103, 12);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(110, 27);
            dtpDesde.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 19);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 0;
            label2.Text = "Desde:";
            // 
            // checkFiltrado
            // 
            checkFiltrado.AutoSize = true;
            checkFiltrado.Location = new Point(24, 105);
            checkFiltrado.Name = "checkFiltrado";
            checkFiltrado.Size = new Size(130, 24);
            checkFiltrado.TabIndex = 0;
            checkFiltrado.Text = "Activar filtrado";
            checkFiltrado.UseVisualStyleBackColor = true;
            checkFiltrado.CheckedChanged += checkFiltrado_CheckedChanged;
            // 
            // numericTotalFacturado
            // 
            numericTotalFacturado.Anchor = AnchorStyles.None;
            numericTotalFacturado.DecimalPlaces = 2;
            numericTotalFacturado.Enabled = false;
            numericTotalFacturado.Location = new Point(665, 411);
            numericTotalFacturado.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericTotalFacturado.Name = "numericTotalFacturado";
            numericTotalFacturado.ReadOnly = true;
            numericTotalFacturado.Size = new Size(108, 27);
            numericTotalFacturado.TabIndex = 22;
            numericTotalFacturado.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(549, 418);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 23;
            label4.Text = "Total facturado";
            // 
            // HistoricoVentasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(numericTotalFacturado);
            Controls.Add(checkFiltrado);
            Controls.Add(panelFiltrado);
            Controls.Add(dataGridVentas);
            Controls.Add(panel1);
            Name = "HistoricoVentasView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Historico Ventas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVentas).EndInit();
            panelFiltrado.ResumeLayout(false);
            panelFiltrado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericTotalFacturado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridVentas;
        private Panel panelFiltrado;
        private DateTimePicker dtpHasta;
        private Label label3;
        private DateTimePicker dtpDesde;
        private Label label2;
        private CheckBox checkFiltrado;
        private Button btnFiltrar;
        private NumericUpDown numericTotalFacturado;
        private Label label4;
    }
}