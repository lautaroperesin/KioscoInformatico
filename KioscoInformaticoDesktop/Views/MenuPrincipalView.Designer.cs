namespace KioscoInformaticoDesktop
{
    partial class MenuPrincipalView
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
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            menuItemLocalidades = new FontAwesome.Sharp.IconMenuItem();
            menuItemProductos = new FontAwesome.Sharp.IconMenuItem();
            iconMenuClientes = new FontAwesome.Sharp.IconMenuItem();
            iconMenuProveedores = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuLocalidades = new FontAwesome.Sharp.IconMenuItem();
            iconMenuListadoClientes = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            menuItemSalirDelSistema = new FontAwesome.Sharp.IconMenuItem();
            iconMenuVentas = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, iconMenuItem3, iconMenuItem4, iconMenuVentas, iconMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(800, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(100, 24);
            iconMenuItem1.Text = "Principal";
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { menuItemLocalidades, menuItemProductos, iconMenuClientes, iconMenuProveedores });
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.Database;
            iconMenuItem3.IconColor = Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(80, 24);
            iconMenuItem3.Text = "Bases";
            // 
            // menuItemLocalidades
            // 
            menuItemLocalidades.IconChar = FontAwesome.Sharp.IconChar.LocationPin;
            menuItemLocalidades.IconColor = Color.Black;
            menuItemLocalidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuItemLocalidades.Name = "menuItemLocalidades";
            menuItemLocalidades.Size = new Size(224, 26);
            menuItemLocalidades.Text = "Localidades";
            menuItemLocalidades.Click += menuItemLocalidades_Click;
            // 
            // menuItemProductos
            // 
            menuItemProductos.IconChar = FontAwesome.Sharp.IconChar.Computer;
            menuItemProductos.IconColor = Color.Black;
            menuItemProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuItemProductos.Name = "menuItemProductos";
            menuItemProductos.Size = new Size(224, 26);
            menuItemProductos.Text = "Productos";
            menuItemProductos.Click += menuItemProductos_Click;
            // 
            // iconMenuClientes
            // 
            iconMenuClientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            iconMenuClientes.IconColor = Color.Black;
            iconMenuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuClientes.Name = "iconMenuClientes";
            iconMenuClientes.Size = new Size(224, 26);
            iconMenuClientes.Text = "Clientes";
            iconMenuClientes.Click += iconMenuClientes_Click;
            // 
            // iconMenuProveedores
            // 
            iconMenuProveedores.IconChar = FontAwesome.Sharp.IconChar.PersonRays;
            iconMenuProveedores.IconColor = Color.Black;
            iconMenuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuProveedores.Name = "iconMenuProveedores";
            iconMenuProveedores.Size = new Size(224, 26);
            iconMenuProveedores.Text = "Proveedores";
            iconMenuProveedores.Click += iconMenuProveedores_Click;
            // 
            // iconMenuItem4
            // 
            iconMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { iconMenuLocalidades, iconMenuListadoClientes });
            iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            iconMenuItem4.IconColor = Color.Black;
            iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem4.Name = "iconMenuItem4";
            iconMenuItem4.Size = new Size(91, 24);
            iconMenuItem4.Text = "Listado";
            // 
            // iconMenuLocalidades
            // 
            iconMenuLocalidades.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuLocalidades.IconColor = Color.Black;
            iconMenuLocalidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuLocalidades.Name = "iconMenuLocalidades";
            iconMenuLocalidades.Size = new Size(224, 26);
            iconMenuLocalidades.Text = "Localidades";
            iconMenuLocalidades.Click += iconMenuLocalidades_Click;
            // 
            // iconMenuListadoClientes
            // 
            iconMenuListadoClientes.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuListadoClientes.IconColor = Color.Black;
            iconMenuListadoClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuListadoClientes.Name = "iconMenuListadoClientes";
            iconMenuListadoClientes.Size = new Size(224, 26);
            iconMenuListadoClientes.Text = "Clientes";
            iconMenuListadoClientes.Click += iconMenuListadoClientes_Click;
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { menuItemSalirDelSistema });
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(72, 24);
            iconMenuItem2.Text = "Salir";
            // 
            // menuItemSalirDelSistema
            // 
            menuItemSalirDelSistema.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            menuItemSalirDelSistema.IconColor = Color.Black;
            menuItemSalirDelSistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuItemSalirDelSistema.Name = "menuItemSalirDelSistema";
            menuItemSalirDelSistema.Size = new Size(200, 26);
            menuItemSalirDelSistema.Text = "Salir del sistema";
            menuItemSalirDelSistema.Click += menuItemSalirDelSistema_Click;
            // 
            // iconMenuVentas
            // 
            iconMenuVentas.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            iconMenuVentas.IconColor = Color.Black;
            iconMenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuVentas.Name = "iconMenuVentas";
            iconMenuVentas.Size = new Size(86, 24);
            iconMenuVentas.Text = "Ventas";
            iconMenuVentas.Click += iconMenuVentas_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipalView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KioscoInformaticoDesktop";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem menuItemSalirDelSistema;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem menuItemLocalidades;
        private FontAwesome.Sharp.IconMenuItem menuItemProductos;
        private FontAwesome.Sharp.IconMenuItem iconMenuClientes;
        private FontAwesome.Sharp.IconMenuItem iconMenuProveedores;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem iconMenuLocalidades;
        private FontAwesome.Sharp.IconMenuItem iconMenuListadoClientes;
        private FontAwesome.Sharp.IconMenuItem iconMenuVentas;
    }
}
