namespace ProyectoECU.Interfaces
{
    partial class ECU_GestionCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ECU_GestionCurso));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_buscarBarra = new System.Windows.Forms.ToolStripButton();
            this.btn_nuevoBarra = new System.Windows.Forms.ToolStripButton();
            this.btn_EliminarBarra = new System.Windows.Forms.ToolStripButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.datetime_fecha_fin = new MetroFramework.Controls.MetroDateTime();
            this.datetime_fecha_inic = new MetroFramework.Controls.MetroDateTime();
            this.txt_costo = new MetroFramework.Controls.MetroTextBox();
            this.txt_Duracion_curso = new MetroFramework.Controls.MetroTextBox();
            this.txt_descrp_curso = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_codCur = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.comb_tipHor = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.comb_tipLic = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.nuevoToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.btn_buscarBarra_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_guardar,
            this.btn_buscarBarra,
            this.btn_nuevoBarra,
            this.btn_EliminarBarra});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(718, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_guardar
            // 
            this.btn_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(23, 22);
            this.btn_guardar.Text = "toolStripButton1";
            this.btn_guardar.ToolTipText = "Guardar";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_buscarBarra
            // 
            this.btn_buscarBarra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_buscarBarra.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscarBarra.Image")));
            this.btn_buscarBarra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_buscarBarra.Name = "btn_buscarBarra";
            this.btn_buscarBarra.Size = new System.Drawing.Size(23, 22);
            this.btn_buscarBarra.Text = "toolStripButton3";
            this.btn_buscarBarra.ToolTipText = "Buscar";
            this.btn_buscarBarra.Click += new System.EventHandler(this.btn_buscarBarra_Click);
            // 
            // btn_nuevoBarra
            // 
            this.btn_nuevoBarra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_nuevoBarra.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevoBarra.Image")));
            this.btn_nuevoBarra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nuevoBarra.Name = "btn_nuevoBarra";
            this.btn_nuevoBarra.Size = new System.Drawing.Size(23, 22);
            this.btn_nuevoBarra.Text = "toolStripButton2";
            this.btn_nuevoBarra.ToolTipText = "Nuevo";
            this.btn_nuevoBarra.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btn_EliminarBarra
            // 
            this.btn_EliminarBarra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_EliminarBarra.Image = ((System.Drawing.Image)(resources.GetObject("btn_EliminarBarra.Image")));
            this.btn_EliminarBarra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_EliminarBarra.Name = "btn_EliminarBarra";
            this.btn_EliminarBarra.Size = new System.Drawing.Size(23, 22);
            this.btn_EliminarBarra.Text = "toolStripButton4";
            this.btn_EliminarBarra.ToolTipText = "Eliminar";
            this.btn_EliminarBarra.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(291, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(156, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Gestión de Curso";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.Controls.Add(this.btnBuscar);
            this.metroPanel1.Controls.Add(this.datetime_fecha_fin);
            this.metroPanel1.Controls.Add(this.datetime_fecha_inic);
            this.metroPanel1.Controls.Add(this.txt_costo);
            this.metroPanel1.Controls.Add(this.txt_Duracion_curso);
            this.metroPanel1.Controls.Add(this.txt_descrp_curso);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.txt_codCur);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.comb_tipHor);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.comb_tipLic);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 106);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(696, 283);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile1.Location = new System.Drawing.Point(-14, -1);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(10, 287);
            this.metroTile1.TabIndex = 40;
            this.metroTile1.UseSelectable = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::ProyectoECU.Properties.Resources.search;
            this.btnBuscar.Location = new System.Drawing.Point(254, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 23);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscar.TabIndex = 40;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // datetime_fecha_fin
            // 
            this.datetime_fecha_fin.CustomFormat = "";
            this.datetime_fecha_fin.Enabled = false;
            this.datetime_fecha_fin.Location = new System.Drawing.Point(398, 97);
            this.datetime_fecha_fin.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.datetime_fecha_fin.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.datetime_fecha_fin.MinimumSize = new System.Drawing.Size(0, 29);
            this.datetime_fecha_fin.Name = "datetime_fecha_fin";
            this.datetime_fecha_fin.Size = new System.Drawing.Size(230, 29);
            this.datetime_fecha_fin.TabIndex = 39;
            this.datetime_fecha_fin.Value = new System.DateTime(2016, 9, 12, 14, 56, 0, 0);
            this.datetime_fecha_fin.CloseUp += new System.EventHandler(this.datetime_fecha_fin_CloseUp);
            // 
            // datetime_fecha_inic
            // 
            this.datetime_fecha_inic.CustomFormat = "";
            this.datetime_fecha_inic.Enabled = false;
            this.datetime_fecha_inic.Location = new System.Drawing.Point(398, 61);
            this.datetime_fecha_inic.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.datetime_fecha_inic.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.datetime_fecha_inic.MinimumSize = new System.Drawing.Size(0, 29);
            this.datetime_fecha_inic.Name = "datetime_fecha_inic";
            this.datetime_fecha_inic.Size = new System.Drawing.Size(230, 29);
            this.datetime_fecha_inic.TabIndex = 38;
            this.datetime_fecha_inic.Value = new System.DateTime(2016, 9, 14, 12, 4, 14, 0);
            // 
            // txt_costo
            // 
            this.txt_costo.Enabled = false;
            this.txt_costo.Lines = new string[0];
            this.txt_costo.Location = new System.Drawing.Point(440, 225);
            this.txt_costo.MaxLength = 10;
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.PasswordChar = '\0';
            this.txt_costo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_costo.SelectedText = "";
            this.txt_costo.Size = new System.Drawing.Size(188, 23);
            this.txt_costo.TabIndex = 37;
            this.txt_costo.UseSelectable = true;
            // 
            // txt_Duracion_curso
            // 
            this.txt_Duracion_curso.Enabled = false;
            this.txt_Duracion_curso.Lines = new string[0];
            this.txt_Duracion_curso.Location = new System.Drawing.Point(440, 181);
            this.txt_Duracion_curso.MaxLength = 10;
            this.txt_Duracion_curso.Name = "txt_Duracion_curso";
            this.txt_Duracion_curso.PasswordChar = '\0';
            this.txt_Duracion_curso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Duracion_curso.SelectedText = "";
            this.txt_Duracion_curso.Size = new System.Drawing.Size(188, 23);
            this.txt_Duracion_curso.TabIndex = 35;
            this.txt_Duracion_curso.UseSelectable = true;
            // 
            // txt_descrp_curso
            // 
            this.txt_descrp_curso.Enabled = false;
            this.txt_descrp_curso.Lines = new string[0];
            this.txt_descrp_curso.Location = new System.Drawing.Point(43, 181);
            this.txt_descrp_curso.MaxLength = 100;
            this.txt_descrp_curso.Multiline = true;
            this.txt_descrp_curso.Name = "txt_descrp_curso";
            this.txt_descrp_curso.PasswordChar = '\0';
            this.txt_descrp_curso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_descrp_curso.SelectedText = "";
            this.txt_descrp_curso.Size = new System.Drawing.Size(235, 67);
            this.txt_descrp_curso.TabIndex = 34;
            this.txt_descrp_curso.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(30, 151);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(136, 19);
            this.metroLabel10.TabIndex = 33;
            this.metroLabel10.Text = "Descripción del Curso";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(313, 229);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(43, 19);
            this.metroLabel8.TabIndex = 31;
            this.metroLabel8.Text = "Costo";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(313, 185);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(121, 19);
            this.metroLabel7.TabIndex = 30;
            this.metroLabel7.Text = "Duración del Curso";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(313, 103);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(74, 19);
            this.metroLabel6.TabIndex = 29;
            this.metroLabel6.Text = "Fecha Final";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(313, 64);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(79, 19);
            this.metroLabel5.TabIndex = 28;
            this.metroLabel5.Text = "Fecha Inicial";
            // 
            // txt_codCur
            // 
            this.txt_codCur.Lines = new string[0];
            this.txt_codCur.Location = new System.Drawing.Point(146, 13);
            this.txt_codCur.MaxLength = 32767;
            this.txt_codCur.Name = "txt_codCur";
            this.txt_codCur.PasswordChar = '\0';
            this.txt_codCur.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_codCur.SelectedText = "";
            this.txt_codCur.Size = new System.Drawing.Size(102, 23);
            this.txt_codCur.TabIndex = 27;
            this.txt_codCur.TabStop = false;
            this.txt_codCur.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(30, 17);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(110, 19);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "Código de Curso";
            // 
            // comb_tipHor
            // 
            this.comb_tipHor.Enabled = false;
            this.comb_tipHor.FormattingEnabled = true;
            this.comb_tipHor.ItemHeight = 23;
            this.comb_tipHor.Location = new System.Drawing.Point(146, 97);
            this.comb_tipHor.Name = "comb_tipHor";
            this.comb_tipHor.Size = new System.Drawing.Size(132, 29);
            this.comb_tipHor.TabIndex = 25;
            this.comb_tipHor.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(30, 103);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(103, 19);
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "Tipo de Horario";
            // 
            // comb_tipLic
            // 
            this.comb_tipLic.Enabled = false;
            this.comb_tipLic.FormattingEnabled = true;
            this.comb_tipLic.ItemHeight = 23;
            this.comb_tipLic.Location = new System.Drawing.Point(146, 61);
            this.comb_tipLic.Name = "comb_tipLic";
            this.comb_tipLic.Size = new System.Drawing.Size(132, 29);
            this.comb_tipLic.TabIndex = 23;
            this.comb_tipLic.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(30, 64);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(103, 19);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "Tipo de Licencia";
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::ProyectoECU.Properties.Resources._54097;
            this.btn_salir.Location = new System.Drawing.Point(665, 395);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(40, 30);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_salir.TabIndex = 46;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // ECU_GestionCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 437);
            this.ControlBox = false;
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(734, 476);
            this.MinimumSize = new System.Drawing.Size(734, 476);
            this.Name = "ECU_GestionCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Curso";
            this.Load += new System.EventHandler(this.ECU_GestionCurso_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ECU_GestionCurso_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ECU_GestionCurso_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripButton btn_nuevoBarra;
        private System.Windows.Forms.ToolStripButton btn_buscarBarra;
        private System.Windows.Forms.ToolStripButton btn_EliminarBarra;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroDateTime datetime_fecha_fin;
        private MetroFramework.Controls.MetroDateTime datetime_fecha_inic;
        private MetroFramework.Controls.MetroTextBox txt_costo;
        private MetroFramework.Controls.MetroTextBox txt_Duracion_curso;
        private MetroFramework.Controls.MetroTextBox txt_descrp_curso;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txt_codCur;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox comb_tipHor;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox comb_tipLic;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.PictureBox btn_salir;
    }
}