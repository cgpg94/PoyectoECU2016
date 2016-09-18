namespace ProyectoECU.Interfaces
{
    partial class ECU_GestionInstructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ECU_GestionInstructor));
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_buscar = new System.Windows.Forms.ToolStripButton();
            this.btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.btn_eliminar = new System.Windows.Forms.ToolStripButton();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menu_archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoCtrlGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarCtrlGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarCtrlBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCtrlEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aYUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txt_codigo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txt_telefono = new MetroFramework.Controls.MetroTextBox();
            this.txt_direccion = new MetroFramework.Controls.MetroTextBox();
            this.dtp_fecha_contrato = new MetroFramework.Controls.MetroDateTime();
            this.dtp_fecha_Nac = new MetroFramework.Controls.MetroDateTime();
            this.txt_apellido = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_nombre = new MetroFramework.Controls.MetroTextBox();
            this.btn_verificar = new MetroFramework.Controls.MetroButton();
            this.txt_cedula = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.menu.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(195, 61);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(173, 25);
            this.metroLabel7.TabIndex = 35;
            this.metroLabel7.Text = "Registro de Instructor";
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
            this.toolStrip1.Size = new System.Drawing.Size(576, 25);
            this.toolStrip1.TabIndex = 34;
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
            this.btn_guardar.Click += new System.EventHandler(this.btnguardar_Click);
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
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_archivo,
            this.cONSULTARToolStripMenuItem,
            this.aYUDAToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(576, 24);
            this.menu.TabIndex = 33;
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
            this.menu_archivo.Size = new System.Drawing.Size(70, 20);
            this.menu_archivo.Text = "ARCHIVO";
            // 
            // nuevoCtrlGToolStripMenuItem
            // 
            this.nuevoCtrlGToolStripMenuItem.Name = "nuevoCtrlGToolStripMenuItem";
            this.nuevoCtrlGToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.nuevoCtrlGToolStripMenuItem.Text = "Nuevo Ctrl + N";
            // 
            // guardarCtrlGToolStripMenuItem
            // 
            this.guardarCtrlGToolStripMenuItem.Name = "guardarCtrlGToolStripMenuItem";
            this.guardarCtrlGToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.guardarCtrlGToolStripMenuItem.Text = "Guardar Ctrl + G";
            // 
            // buscarCtrlBToolStripMenuItem
            // 
            this.buscarCtrlBToolStripMenuItem.Name = "buscarCtrlBToolStripMenuItem";
            this.buscarCtrlBToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.buscarCtrlBToolStripMenuItem.Text = "Buscar Ctrl + B";
            // 
            // eliminarCtrlEToolStripMenuItem
            // 
            this.eliminarCtrlEToolStripMenuItem.Name = "eliminarCtrlEToolStripMenuItem";
            this.eliminarCtrlEToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.eliminarCtrlEToolStripMenuItem.Text = "Eliminar Ctrl + E";
            // 
            // cONSULTARToolStripMenuItem
            // 
            this.cONSULTARToolStripMenuItem.Name = "cONSULTARToolStripMenuItem";
            this.cONSULTARToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.cONSULTARToolStripMenuItem.Text = "CONSULTAR";
            // 
            // aYUDAToolStripMenuItem
            // 
            this.aYUDAToolStripMenuItem.Name = "aYUDAToolStripMenuItem";
            this.aYUDAToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.aYUDAToolStripMenuItem.Text = "AYUDA";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.txt_codigo);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.txt_telefono);
            this.metroPanel1.Controls.Add(this.txt_direccion);
            this.metroPanel1.Controls.Add(this.dtp_fecha_contrato);
            this.metroPanel1.Controls.Add(this.dtp_fecha_Nac);
            this.metroPanel1.Controls.Add(this.txt_apellido);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txt_nombre);
            this.metroPanel1.Controls.Add(this.btn_verificar);
            this.metroPanel1.Controls.Add(this.txt_cedula);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 104);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(536, 224);
            this.metroPanel1.TabIndex = 36;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Lines = new string[0];
            this.txt_codigo.Location = new System.Drawing.Point(90, 64);
            this.txt_codigo.MaxLength = 5;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.PasswordChar = '\0';
            this.txt_codigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_codigo.SelectedText = "";
            this.txt_codigo.Size = new System.Drawing.Size(75, 23);
            this.txt_codigo.TabIndex = 64;
            this.txt_codigo.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(20, 64);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(53, 19);
            this.metroLabel9.TabIndex = 63;
            this.metroLabel9.Text = "Código";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Lines = new string[0];
            this.txt_telefono.Location = new System.Drawing.Point(354, 82);
            this.txt_telefono.MaxLength = 10;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.PasswordChar = '\0';
            this.txt_telefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_telefono.SelectedText = "";
            this.txt_telefono.Size = new System.Drawing.Size(156, 23);
            this.txt_telefono.TabIndex = 60;
            this.txt_telefono.UseSelectable = true;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Lines = new string[0];
            this.txt_direccion.Location = new System.Drawing.Point(354, 13);
            this.txt_direccion.MaxLength = 32767;
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.PasswordChar = '\0';
            this.txt_direccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_direccion.SelectedText = "";
            this.txt_direccion.Size = new System.Drawing.Size(160, 56);
            this.txt_direccion.TabIndex = 59;
            this.txt_direccion.UseSelectable = true;
            // 
            // dtp_fecha_contrato
            // 
            this.dtp_fecha_contrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_contrato.Location = new System.Drawing.Point(404, 129);
            this.dtp_fecha_contrato.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtp_fecha_contrato.Name = "dtp_fecha_contrato";
            this.dtp_fecha_contrato.Size = new System.Drawing.Size(110, 29);
            this.dtp_fecha_contrato.TabIndex = 61;
            // 
            // dtp_fecha_Nac
            // 
            this.dtp_fecha_Nac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_Nac.Location = new System.Drawing.Point(141, 169);
            this.dtp_fecha_Nac.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtp_fecha_Nac.Name = "dtp_fecha_Nac";
            this.dtp_fecha_Nac.Size = new System.Drawing.Size(110, 29);
            this.dtp_fecha_Nac.TabIndex = 58;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Lines = new string[0];
            this.txt_apellido.Location = new System.Drawing.Point(90, 135);
            this.txt_apellido.MaxLength = 32767;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.PasswordChar = '\0';
            this.txt_apellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_apellido.SelectedText = "";
            this.txt_apellido.Size = new System.Drawing.Size(161, 23);
            this.txt_apellido.TabIndex = 57;
            this.txt_apellido.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(283, 28);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(63, 19);
            this.metroLabel8.TabIndex = 56;
            this.metroLabel8.Text = "Direccion";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(283, 129);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(118, 19);
            this.metroLabel5.TabIndex = 55;
            this.metroLabel5.Text = "Fecha de Contrato";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(286, 86);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(50, 19);
            this.metroLabel6.TabIndex = 54;
            this.metroLabel6.Text = "Celular";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(20, 173);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(114, 19);
            this.metroLabel4.TabIndex = 53;
            this.metroLabel4.Text = "Fecha Nacimiento";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(21, 139);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 52;
            this.metroLabel3.Text = "Apellidos";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(21, 104);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 51;
            this.metroLabel2.Text = "Nombres";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 50;
            this.metroLabel1.Text = "Cédula";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Lines = new string[0];
            this.txt_nombre.Location = new System.Drawing.Point(91, 100);
            this.txt_nombre.MaxLength = 32767;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PasswordChar = '\0';
            this.txt_nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nombre.SelectedText = "";
            this.txt_nombre.Size = new System.Drawing.Size(161, 23);
            this.txt_nombre.TabIndex = 56;
            this.txt_nombre.UseSelectable = true;
            this.txt_nombre.Click += new System.EventHandler(this.txt_nombre_Click);
            // 
            // btn_verificar
            // 
            this.btn_verificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_verificar.BackgroundImage")));
            this.btn_verificar.Location = new System.Drawing.Point(226, 27);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(25, 23);
            this.btn_verificar.TabIndex = 55;
            this.btn_verificar.UseSelectable = true;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // txt_cedula
            // 
            this.txt_cedula.Lines = new string[0];
            this.txt_cedula.Location = new System.Drawing.Point(90, 27);
            this.txt_cedula.MaxLength = 10;
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.PasswordChar = '\0';
            this.txt_cedula.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cedula.SelectedText = "";
            this.txt_cedula.Size = new System.Drawing.Size(130, 23);
            this.txt_cedula.TabIndex = 54;
            this.txt_cedula.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(13, 104);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(10, 223);
            this.metroTile1.TabIndex = 37;
            this.metroTile1.UseSelectable = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::ProyectoECU.Properties.Resources._54097;
            this.btn_salir.Location = new System.Drawing.Point(498, 334);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(40, 30);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_salir.TabIndex = 65;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // ECU_GestionInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 376);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menu);
            this.Name = "ECU_GestionInstructor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Instructor";
            this.Load += new System.EventHandler(this.ECU_GestionInstructor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripButton btn_buscar;
        private System.Windows.Forms.ToolStripButton btn_nuevo;
        private System.Windows.Forms.ToolStripButton btn_eliminar;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menu_archivo;
        private System.Windows.Forms.ToolStripMenuItem nuevoCtrlGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarCtrlGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarCtrlBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCtrlEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aYUDAToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txt_cedula;
        private MetroFramework.Controls.MetroButton btn_verificar;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_telefono;
        private MetroFramework.Controls.MetroTextBox txt_direccion;
        private MetroFramework.Controls.MetroDateTime dtp_fecha_contrato;
        private MetroFramework.Controls.MetroDateTime dtp_fecha_Nac;
        private MetroFramework.Controls.MetroTextBox txt_apellido;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTextBox txt_codigo;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_nombre;
        private System.Windows.Forms.PictureBox btn_salir;
    }
}