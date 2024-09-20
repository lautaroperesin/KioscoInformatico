namespace KioscoInformaticoDesktop.Views
{
    partial class ClientesView
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
            panel1 = new Panel();
            label1 = new Label();
            tabControlLista = new TabControl();
            tabPageLista = new TabPage();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            dataGridLocalidades = new DataGridView();
            txtBuscar = new TextBox();
            label4 = new Label();
            tabPageAgregarEditar = new TabPage();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            tabControlLista.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLocalidades).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 63);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(95, 30);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            // 
            // tabControlLista
            // 
            tabControlLista.Controls.Add(tabPageLista);
            tabControlLista.Controls.Add(tabPageAgregarEditar);
            tabControlLista.Location = new Point(2, 68);
            tabControlLista.Name = "tabControlLista";
            tabControlLista.SelectedIndex = 0;
            tabControlLista.Size = new Size(797, 382);
            tabControlLista.TabIndex = 2;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(btnSalir);
            tabPageLista.Controls.Add(btnBuscar);
            tabPageLista.Controls.Add(btnEliminar);
            tabPageLista.Controls.Add(btnModificar);
            tabPageLista.Controls.Add(btnAgregar);
            tabPageLista.Controls.Add(dataGridLocalidades);
            tabPageLista.Controls.Add(txtBuscar);
            tabPageLista.Controls.Add(label4);
            tabPageLista.Location = new Point(4, 24);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(3);
            tabPageLista.Size = new Size(789, 354);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            tabPageLista.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 35;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(674, 250);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(109, 46);
            btnSalir.TabIndex = 31;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 35;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(674, 48);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(109, 46);
            btnBuscar.TabIndex = 30;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 35;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(674, 199);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 46);
            btnEliminar.TabIndex = 29;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnModificar.IconColor = Color.Black;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificar.IconSize = 35;
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(676, 149);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(109, 46);
            btnModificar.TabIndex = 28;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 35;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(676, 98);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(109, 46);
            btnAgregar.TabIndex = 27;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridLocalidades
            // 
            dataGridLocalidades.AllowUserToAddRows = false;
            dataGridLocalidades.AllowUserToDeleteRows = false;
            dataGridLocalidades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridLocalidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridLocalidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLocalidades.Location = new Point(0, 48);
            dataGridLocalidades.Margin = new Padding(3, 2, 3, 2);
            dataGridLocalidades.Name = "dataGridLocalidades";
            dataGridLocalidades.ReadOnly = true;
            dataGridLocalidades.RowHeadersWidth = 51;
            dataGridLocalidades.Size = new Size(667, 334);
            dataGridLocalidades.TabIndex = 26;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(60, 21);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(570, 23);
            txtBuscar.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 27);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 24;
            label4.Text = "Buscar:";
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.Controls.Add(textBox3);
            tabPageAgregarEditar.Controls.Add(label6);
            tabPageAgregarEditar.Controls.Add(textBox2);
            tabPageAgregarEditar.Controls.Add(label5);
            tabPageAgregarEditar.Controls.Add(textBox1);
            tabPageAgregarEditar.Controls.Add(label3);
            tabPageAgregarEditar.Controls.Add(btnCancelar);
            tabPageAgregarEditar.Controls.Add(btnGuardar);
            tabPageAgregarEditar.Controls.Add(txtNombre);
            tabPageAgregarEditar.Controls.Add(label2);
            tabPageAgregarEditar.Location = new Point(4, 24);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(3);
            tabPageAgregarEditar.Size = new Size(789, 354);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 35;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(401, 260);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(160, 28);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 35;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(236, 260);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(160, 28);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(302, 66);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 23);
            txtNombre.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 68);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 14;
            label2.Text = "Nombre:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(302, 99);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 23);
            textBox1.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 101);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 18;
            label3.Text = "Nombre:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(302, 176);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 23);
            textBox2.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(228, 179);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 20;
            label5.Text = "Nombre:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(302, 135);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(228, 23);
            textBox3.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(228, 137);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 22;
            label6.Text = "Nombre:";
            // 
            // ClientesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlLista);
            Controls.Add(panel1);
            Name = "ClientesView";
            Text = "Clientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControlLista.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLocalidades).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControlLista;
        private TabPage tabPageLista;
        private TabPage tabPageAgregarEditar;
        private TextBox txtBuscar;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private DataGridView dataGridLocalidades;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtNombre;
        private Label label2;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox1;
        private Label label3;
    }
}