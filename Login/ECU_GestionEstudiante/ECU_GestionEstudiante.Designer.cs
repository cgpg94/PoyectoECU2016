namespace ProyectoECU.Interfaces
{
    partial class ECU_GestionEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ECU_GestionEstudiante));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menu_archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoCtrlGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarCtrlGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarCtrlBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCtrlEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_consultar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_buscar = new System.Windows.Forms.ToolStripButton();
            this.btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.btn_eliminar = new System.Windows.Forms.ToolStripButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txt_direccion = new MetroFramework.Controls.MetroTextBox();
            this.lbl_direccion = new MetroFramework.Controls.MetroLabel();
            this.cbx_tipoSangre = new MetroFramework.Controls.MetroComboBox();
            this.txt_telefono = new MetroFramework.Controls.MetroTextBox();
            this.dtp_fecha_Nac = new MetroFramework.Controls.MetroDateTime();
            this.txt_apellido = new MetroFramework.Controls.MetroTextBox();
            this.txt_nombre = new MetroFramework.Controls.MetroTextBox();
            this.txt_cedula = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btn_verificar = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_verificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_archivo,
            this.menu_consultar,
            this.menu_ayuda});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(577, 24);
            this.menu.TabIndex = 14;
            this.menu.Text = "menu";
            // 
            // menu_archivo
            // 
            this.menu_archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoCtrlGToolStripMenuItem,
            this.guardarCtrlGToolStripMenuItem,
            this.buscarCtrlBToolStripMenuItem,
            this.eliminarCtrlEToolStripMenuItem});
            this.menu_archivo.Name = "menu_archivo";
            this.menu_archivo.Size = new System.Drawing.Size(60, 20);
            this.menu_archivo.Text = "Archivo";
            // 
            // nuevoCtrlGToolStripMenuItem
            // 
            this.nuevoCtrlGToolStripMenuItem.Name = "nuevoCtrlGToolStripMenuItem";
            this.nuevoCtrlGToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoCtrlGToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.nuevoCtrlGToolStripMenuItem.Text = "Nuevo";
            this.nuevoCtrlGToolStripMenuItem.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // guardarCtrlGToolStripMenuItem
            // 
            this.guardarCtrlGToolStripMenuItem.Name = "guardarCtrlGToolStripMenuItem";
            this.guardarCtrlGToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.guardarCtrlGToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.guardarCtrlGToolStripMenuItem.Text = "Guardar";
            this.guardarCtrlGToolStripMenuItem.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // buscarCtrlBToolStripMenuItem
            // 
            this.buscarCtrlBToolStripMenuItem.Name = "buscarCtrlBToolStripMenuItem";
            this.buscarCtrlBToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.buscarCtrlBToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.buscarCtrlBToolStripMenuItem.Text = "Buscar";
            this.buscarCtrlBToolStripMenuItem.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // eliminarCtrlEToolStripMenuItem
            // 
            this.eliminarCtrlEToolStripMenuItem.Name = "eliminarCtrlEToolStripMenuItem";
            this.eliminarCtrlEToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.eliminarCtrlEToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.eliminarCtrlEToolStripMenuItem.Text = "Eliminar";
            this.eliminarCtrlEToolStripMenuItem.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // menu_consultar
            // 
            this.menu_consultar.Name = "menu_consultar";
            this.menu_consultar.Size = new System.Drawing.Size(66, 20);
            this.menu_consultar.Text = "Consulta";
            this.menu_consultar.Click += new System.EventHandler(this.menu_consultar_Click);
            // 
            // menu_ayuda
            // 
            this.menu_ayuda.Name = "menu_ayuda";
            this.menu_ayuda.Size = new System.Drawing.Size(53, 20);
            this.menu_ayuda.Text = "Ayuda";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_guardar,
            this.btn_buscar,
            this.btn_nuevo,
            this.btn_eliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(577, 25);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_guardar
            // 
            this.btn_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(23, 22);
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(23, 22);
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.Image")));
            this.btn_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(23, 22);
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(23, 22);
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.btn_salir);
            this.metroPanel1.Controls.Add(this.btn_verificar);
            this.metroPanel1.Controls.Add(this.txt_direccion);
            this.metroPanel1.Controls.Add(this.lbl_direccion);
            this.metroPanel1.Controls.Add(this.cbx_tipoSangre);
            this.metroPanel1.Controls.Add(this.txt_telefono);
            this.metroPanel1.Controls.Add(this.dtp_fecha_Nac);
            this.metroPanel1.Controls.Add(this.txt_apellido);
            this.metroPanel1.Controls.Add(this.txt_nombre);
            this.metroPanel1.Controls.Add(this.txt_cedula);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(26, 93);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(539, 232);
            this.metroPanel1.TabIndex = 30;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Lines = new string[0];
            this.txt_direccion.Location = new System.Drawing.Point(381, 24);
            this.txt_direccion.MaxLength = 25;
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.PasswordChar = '\0';
            this.txt_direccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_direccion.SelectedText = "";
            this.txt_direccion.Size = new System.Drawing.Size(141, 47);
            this.txt_direccion.TabIndex = 39;
            this.txt_direccion.UseSelectable = true;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(312, 37);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(63, 19);
            this.lbl_direccion.TabIndex = 43;
            this.lbl_direccion.Text = "Direccion";
            // 
            // cbx_tipoSangre
            // 
            this.cbx_tipoSangre.FormattingEnabled = true;
            this.cbx_tipoSangre.ItemHeight = 23;
            this.cbx_tipoSangre.Location = new System.Drawing.Point(397, 129);
            this.cbx_tipoSangre.Name = "cbx_tipoSangre";
            this.cbx_tipoSangre.Size = new System.Drawing.Size(125, 29);
            this.cbx_tipoSangre.TabIndex = 41;
            this.cbx_tipoSangre.UseSelectable = true;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Lines = new string[0];
            this.txt_telefono.Location = new System.Drawing.Point(384, 90);
            this.txt_telefono.MaxLength = 10;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.PasswordChar = '\0';
            this.txt_telefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_telefono.SelectedText = "";
            this.txt_telefono.Size = new System.Drawing.Size(138, 23);
            this.txt_telefono.TabIndex = 40;
            this.txt_telefono.UseSelectable = true;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // dtp_fecha_Nac
            // 
            this.dtp_fecha_Nac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_Nac.Location = new System.Drawing.Point(140, 180);
            this.dtp_fecha_Nac.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtp_fecha_Nac.Name = "dtp_fecha_Nac";
            this.dtp_fecha_Nac.Size = new System.Drawing.Size(143, 29);
            this.dtp_fecha_Nac.TabIndex = 38;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Lines = new string[0];
            this.txt_apellido.Location = new System.Drawing.Point(140, 127);
            this.txt_apellido.MaxLength = 25;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.PasswordChar = '\0';
            this.txt_apellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_apellido.SelectedText = "";
            this.txt_apellido.Size = new System.Drawing.Size(143, 23);
            this.txt_apellido.TabIndex = 37;
            this.txt_apellido.UseSelectable = true;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Lines = new string[0];
            this.txt_nombre.Location = new System.Drawing.Point(140, 82);
            this.txt_nombre.MaxLength = 25;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PasswordChar = '\0';
            this.txt_nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nombre.SelectedText = "";
            this.txt_nombre.Size = new System.Drawing.Size(143, 23);
            this.txt_nombre.TabIndex = 36;
            this.txt_nombre.UseSelectable = true;
            // 
            // txt_cedula
            // 
            this.txt_cedula.Lines = new string[0];
            this.txt_cedula.Location = new System.Drawing.Point(140, 37);
            this.txt_cedula.MaxLength = 10;
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.PasswordChar = '\0';
            this.txt_cedula.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cedula.SelectedText = "";
            this.txt_cedula.Size = new System.Drawing.Size(111, 23);
            this.txt_cedula.TabIndex = 34;
            this.txt_cedula.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(311, 90);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(50, 19);
            this.metroLabel6.TabIndex = 34;
            this.metroLabel6.Text = "Celular";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(311, 133);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(80, 19);
            this.metroLabel5.TabIndex = 33;
            this.metroLabel5.Text = "Tipo Sangre";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(25, 183);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(114, 19);
            this.metroLabel4.TabIndex = 32;
            this.metroLabel4.Text = "Fecha Nacimiento";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(25, 131);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 31;
            this.metroLabel3.Text = "Apellido";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 86);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Nombre";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 37);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 29;
            this.metroLabel1.Text = "Cédula";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(16, 92);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(10, 233);
            this.metroTile1.TabIndex = 31;
            this.metroTile1.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(182, 65);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(206, 25);
            this.metroLabel7.TabIndex = 32;
            this.metroLabel7.Text = "Gestión de Estudiantes";
            // 
            // btn_verificar
            // 
            this.btn_verificar.Image = global::ProyectoECU.Properties.Resources.search;
            this.btn_verificar.Location = new System.Drawing.Point(257, 37);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(25, 23);
            this.btn_verificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_verificar.TabIndex = 44;
            this.btn_verificar.TabStop = false;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::ProyectoECU.Properties.Resources._54097;
            this.btn_salir.Location = new System.Drawing.Point(466, 197);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(40, 30);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_salir.TabIndex = 47;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // ECU_GestionEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 351);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.MaximumSize = new System.Drawing.Size(593, 390);
            this.MinimumSize = new System.Drawing.Size(593, 390);
            this.Name = "ECU_GestionEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Estudiantes";
            this.Load += new System.EventHandler(this.ECU_GestionEstudiante_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_verificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menu_archivo;
        private System.Windows.Forms.ToolStripMenuItem nuevoCtrlGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarCtrlGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarCtrlBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCtrlEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_consultar;
        private System.Windows.Forms.ToolStripMenuItem menu_ayuda;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripButton btn_nuevo;
        private System.Windows.Forms.ToolStripButton btn_buscar;
        private System.Windows.Forms.ToolStripButton btn_eliminar;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroDateTime dtp_fecha_Nac;
        private MetroFramework.Controls.MetroTextBox txt_apellido;
        private MetroFramework.Controls.MetroTextBox txt_nombre;
        private MetroFramework.Controls.MetroTextBox txt_cedula;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cbx_tipoSangre;
        private MetroFramework.Controls.MetroTextBox txt_telefono;
        private MetroFramework.Controls.MetroTextBox txt_direccion;
        private MetroFramework.Controls.MetroLabel lbl_direccion;
        private System.Windows.Forms.PictureBox btn_verificar;
        private System.Windows.Forms.PictureBox btn_salir;
    }
}