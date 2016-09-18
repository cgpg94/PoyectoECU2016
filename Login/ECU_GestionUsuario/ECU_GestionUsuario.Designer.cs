namespace ProyectoECU.Interfaces
{
    partial class ECU_GestionUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ECU_GestionUsuario));
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroIngresar = new MetroFramework.Controls.MetroTabPage();
            this.Secretaria = new MetroFramework.Controls.MetroRadioButton();
            this.Administrador = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtContrasena = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroModificar = new MetroFramework.Controls.MetroTabPage();
            this.SecretariaModi = new MetroFramework.Controls.MetroRadioButton();
            this.AdministradorModi = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtNuevaContrasena = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtContrasenaActual = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtUsuarioModi = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.txtBuscar = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btn_buscar = new System.Windows.Forms.PictureBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.brn_guardarBarra = new System.Windows.Forms.ToolStripButton();
            this.btn_nuevoBarra = new System.Windows.Forms.ToolStripButton();
            this.btn_eliminarBarra = new System.Windows.Forms.ToolStripButton();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.TabControl.SuspendLayout();
            this.metroIngresar.SuspendLayout();
            this.metroModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.metroIngresar);
            this.TabControl.Controls.Add(this.metroModificar);
            this.TabControl.Location = new System.Drawing.Point(20, 77);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(689, 202);
            this.TabControl.TabIndex = 0;
            this.TabControl.UseSelectable = true;
            // 
            // metroIngresar
            // 
            this.metroIngresar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroIngresar.Controls.Add(this.Secretaria);
            this.metroIngresar.Controls.Add(this.Administrador);
            this.metroIngresar.Controls.Add(this.metroLabel5);
            this.metroIngresar.Controls.Add(this.txtContrasena);
            this.metroIngresar.Controls.Add(this.metroLabel4);
            this.metroIngresar.Controls.Add(this.txtUsuario);
            this.metroIngresar.Controls.Add(this.metroLabel3);
            this.metroIngresar.HorizontalScrollbarBarColor = true;
            this.metroIngresar.HorizontalScrollbarHighlightOnWheel = false;
            this.metroIngresar.HorizontalScrollbarSize = 10;
            this.metroIngresar.Location = new System.Drawing.Point(4, 38);
            this.metroIngresar.Name = "metroIngresar";
            this.metroIngresar.Size = new System.Drawing.Size(681, 160);
            this.metroIngresar.TabIndex = 0;
            this.metroIngresar.Text = "INGRESAR";
            this.metroIngresar.VerticalScrollbarBarColor = true;
            this.metroIngresar.VerticalScrollbarHighlightOnWheel = false;
            this.metroIngresar.VerticalScrollbarSize = 10;
            // 
            // Secretaria
            // 
            this.Secretaria.AutoSize = true;
            this.Secretaria.Location = new System.Drawing.Point(364, 59);
            this.Secretaria.Name = "Secretaria";
            this.Secretaria.Size = new System.Drawing.Size(74, 15);
            this.Secretaria.TabIndex = 8;
            this.Secretaria.Text = "Secretaria";
            this.Secretaria.UseSelectable = true;
            this.Secretaria.Click += new System.EventHandler(this.Secretaria_Click);
            // 
            // Administrador
            // 
            this.Administrador.AutoSize = true;
            this.Administrador.Checked = true;
            this.Administrador.Location = new System.Drawing.Point(364, 38);
            this.Administrador.Name = "Administrador";
            this.Administrador.Size = new System.Drawing.Size(99, 15);
            this.Administrador.TabIndex = 7;
            this.Administrador.TabStop = true;
            this.Administrador.Text = "Administrador";
            this.Administrador.UseSelectable = true;
            this.Administrador.Click += new System.EventHandler(this.Admin_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(344, 14);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(105, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Tipo de Usuario:";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Lines = new string[0];
            this.txtContrasena.Location = new System.Drawing.Point(37, 101);
            this.txtContrasena.MaxLength = 32767;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContrasena.SelectedText = "";
            this.txtContrasena.Size = new System.Drawing.Size(166, 23);
            this.txtContrasena.TabIndex = 5;
            this.txtContrasena.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(21, 78);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(37, 38);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(166, 23);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(21, 15);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(129, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Nombre de Usuario:";
            // 
            // metroModificar
            // 
            this.metroModificar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroModificar.Controls.Add(this.SecretariaModi);
            this.metroModificar.Controls.Add(this.AdministradorModi);
            this.metroModificar.Controls.Add(this.metroLabel9);
            this.metroModificar.Controls.Add(this.txtNuevaContrasena);
            this.metroModificar.Controls.Add(this.metroLabel8);
            this.metroModificar.Controls.Add(this.txtContrasenaActual);
            this.metroModificar.Controls.Add(this.metroLabel6);
            this.metroModificar.Controls.Add(this.txtUsuarioModi);
            this.metroModificar.Controls.Add(this.metroLabel7);
            this.metroModificar.HorizontalScrollbarBarColor = true;
            this.metroModificar.HorizontalScrollbarHighlightOnWheel = false;
            this.metroModificar.HorizontalScrollbarSize = 10;
            this.metroModificar.Location = new System.Drawing.Point(4, 38);
            this.metroModificar.Name = "metroModificar";
            this.metroModificar.Size = new System.Drawing.Size(681, 160);
            this.metroModificar.TabIndex = 1;
            this.metroModificar.Text = "MODIFICAR";
            this.metroModificar.VerticalScrollbarBarColor = true;
            this.metroModificar.VerticalScrollbarHighlightOnWheel = false;
            this.metroModificar.VerticalScrollbarSize = 10;
            // 
            // SecretariaModi
            // 
            this.SecretariaModi.AutoSize = true;
            this.SecretariaModi.Location = new System.Drawing.Point(371, 65);
            this.SecretariaModi.Name = "SecretariaModi";
            this.SecretariaModi.Size = new System.Drawing.Size(74, 15);
            this.SecretariaModi.TabIndex = 14;
            this.SecretariaModi.Text = "Secretaria";
            this.SecretariaModi.UseSelectable = true;
            this.SecretariaModi.Click += new System.EventHandler(this.SecretariaModi_Click);
            // 
            // AdministradorModi
            // 
            this.AdministradorModi.AutoSize = true;
            this.AdministradorModi.Checked = true;
            this.AdministradorModi.Location = new System.Drawing.Point(371, 44);
            this.AdministradorModi.Name = "AdministradorModi";
            this.AdministradorModi.Size = new System.Drawing.Size(99, 15);
            this.AdministradorModi.TabIndex = 13;
            this.AdministradorModi.TabStop = true;
            this.AdministradorModi.Text = "Administrador";
            this.AdministradorModi.UseSelectable = true;
            this.AdministradorModi.Click += new System.EventHandler(this.AdminModi_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(351, 20);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(105, 19);
            this.metroLabel9.TabIndex = 12;
            this.metroLabel9.Text = "Tipo de Usuario:";
            // 
            // txtNuevaContrasena
            // 
            this.txtNuevaContrasena.Lines = new string[0];
            this.txtNuevaContrasena.Location = new System.Drawing.Point(39, 126);
            this.txtNuevaContrasena.MaxLength = 32767;
            this.txtNuevaContrasena.Name = "txtNuevaContrasena";
            this.txtNuevaContrasena.PasswordChar = '*';
            this.txtNuevaContrasena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNuevaContrasena.SelectedText = "";
            this.txtNuevaContrasena.Size = new System.Drawing.Size(166, 23);
            this.txtNuevaContrasena.TabIndex = 11;
            this.txtNuevaContrasena.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(23, 104);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(119, 19);
            this.metroLabel8.TabIndex = 10;
            this.metroLabel8.Text = "Nueva Contraseña:";
            // 
            // txtContrasenaActual
            // 
            this.txtContrasenaActual.Lines = new string[0];
            this.txtContrasenaActual.Location = new System.Drawing.Point(39, 78);
            this.txtContrasenaActual.MaxLength = 32767;
            this.txtContrasenaActual.Name = "txtContrasenaActual";
            this.txtContrasenaActual.PasswordChar = '*';
            this.txtContrasenaActual.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContrasenaActual.SelectedText = "";
            this.txtContrasenaActual.Size = new System.Drawing.Size(166, 23);
            this.txtContrasenaActual.TabIndex = 9;
            this.txtContrasenaActual.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 56);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(118, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Contraseña Actual:";
            // 
            // txtUsuarioModi
            // 
            this.txtUsuarioModi.Lines = new string[0];
            this.txtUsuarioModi.Location = new System.Drawing.Point(39, 30);
            this.txtUsuarioModi.MaxLength = 32767;
            this.txtUsuarioModi.Name = "txtUsuarioModi";
            this.txtUsuarioModi.PasswordChar = '\0';
            this.txtUsuarioModi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuarioModi.SelectedText = "";
            this.txtUsuarioModi.Size = new System.Drawing.Size(166, 23);
            this.txtUsuarioModi.TabIndex = 7;
            this.txtUsuarioModi.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 7);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(129, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Nombre de Usuario:";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(16, 327);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(689, 138);
            this.metroGrid1.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Lines = new string[0];
            this.txtBuscar.Location = new System.Drawing.Point(547, 295);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.Size = new System.Drawing.Size(158, 23);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.UseSelectable = true;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(490, 297);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Buscar:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(20, 304);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "USUARIOS:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = global::ProyectoECU.Properties.Resources.search;
            this.btn_buscar.Location = new System.Drawing.Point(681, 291);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(28, 30);
            this.btn_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.TabStop = false;
            this.btn_buscar.Visible = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(486, 304);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(10, 10);
            this.dataGrid.TabIndex = 9;
            this.dataGrid.Visible = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(743, 24);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.nuevoToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.brn_guardarBarra_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.btn_nuevoBarra_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.btn_eliminarBarra_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.toolStripMenuItem2.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItem2.Text = "Ayuda";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brn_guardarBarra,
            this.btn_nuevoBarra,
            this.btn_eliminarBarra});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(743, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // brn_guardarBarra
            // 
            this.brn_guardarBarra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brn_guardarBarra.Image = ((System.Drawing.Image)(resources.GetObject("brn_guardarBarra.Image")));
            this.brn_guardarBarra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.brn_guardarBarra.Name = "brn_guardarBarra";
            this.brn_guardarBarra.Size = new System.Drawing.Size(23, 22);
            this.brn_guardarBarra.Text = "toolStripButton1";
            this.brn_guardarBarra.ToolTipText = "Guardar";
            this.brn_guardarBarra.Click += new System.EventHandler(this.brn_guardarBarra_Click);
            // 
            // btn_nuevoBarra
            // 
            this.btn_nuevoBarra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_nuevoBarra.Image = global::ProyectoECU.Properties.Resources.file;
            this.btn_nuevoBarra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nuevoBarra.Name = "btn_nuevoBarra";
            this.btn_nuevoBarra.Size = new System.Drawing.Size(23, 22);
            this.btn_nuevoBarra.Text = "Nuevo";
            this.btn_nuevoBarra.Click += new System.EventHandler(this.btn_nuevoBarra_Click);
            // 
            // btn_eliminarBarra
            // 
            this.btn_eliminarBarra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_eliminarBarra.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminarBarra.Image")));
            this.btn_eliminarBarra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_eliminarBarra.Name = "btn_eliminarBarra";
            this.btn_eliminarBarra.Size = new System.Drawing.Size(23, 22);
            this.btn_eliminarBarra.Text = "Eliminar";
            this.btn_eliminarBarra.ToolTipText = "Eliminar";
            this.btn_eliminarBarra.Click += new System.EventHandler(this.btn_eliminarBarra_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::ProyectoECU.Properties.Resources._54097;
            this.btn_salir.Location = new System.Drawing.Point(669, 476);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(40, 30);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_salir.TabIndex = 46;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(269, 52);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(181, 25);
            this.metroLabel10.TabIndex = 47;
            this.metroLabel10.Text = "Gestión de Usuarios";
            // 
            // ECU_GestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 511);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.TabControl);
            this.MaximumSize = new System.Drawing.Size(759, 550);
            this.MinimumSize = new System.Drawing.Size(759, 550);
            this.Name = "ECU_GestionUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Usuarios";
            this.Load += new System.EventHandler(this.ECU_GestionUsuario_Load);
            this.TabControl.ResumeLayout(false);
            this.metroIngresar.ResumeLayout(false);
            this.metroIngresar.PerformLayout();
            this.metroModificar.ResumeLayout(false);
            this.metroModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage metroIngresar;
        private MetroFramework.Controls.MetroTabPage metroModificar;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTextBox txtBuscar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtContrasena;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroRadioButton Secretaria;
        private MetroFramework.Controls.MetroRadioButton Administrador;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroRadioButton SecretariaModi;
        private MetroFramework.Controls.MetroRadioButton AdministradorModi;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtNuevaContrasena;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtContrasenaActual;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtUsuarioModi;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.PictureBox btn_buscar;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton brn_guardarBarra;
        private System.Windows.Forms.ToolStripButton btn_nuevoBarra;
        private System.Windows.Forms.ToolStripButton btn_eliminarBarra;
        private System.Windows.Forms.PictureBox btn_salir;
        private MetroFramework.Controls.MetroLabel metroLabel10;
    }
}