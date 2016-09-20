namespace ProyectoECU.Interfaces
{
    partial class ECU_GestionPago
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_buscar_barra = new System.Windows.Forms.ToolStripButton();
            this.btn_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Buscar = new System.Windows.Forms.PictureBox();
            this.txt_valor_matri = new MetroFramework.Controls.MetroTextBox();
            this.txt_nombre = new MetroFramework.Controls.MetroTextBox();
            this.txt_apellido = new MetroFramework.Controls.MetroTextBox();
            this.txt_codigo_mat = new MetroFramework.Controls.MetroTextBox();
            this.txt_tipo_lice = new MetroFramework.Controls.MetroTextBox();
            this.txt_saldo = new MetroFramework.Controls.MetroTextBox();
            this.txt_valor_curso = new MetroFramework.Controls.MetroTextBox();
            this.txt_Cedula = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_confirmar = new MetroFramework.Controls.MetroButton();
            this.txt_valor_pagar = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buscar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Guardar,
            this.btn_buscar_barra,
            this.btn_Nuevo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(718, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Guardar
            // 
            this.Guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Guardar.Enabled = false;
            this.Guardar.Image = global::ProyectoECU.Properties.Resources.save;
            this.Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(23, 22);
            this.Guardar.Text = "toolStripButton1";
            // 
            // btn_buscar_barra
            // 
            this.btn_buscar_barra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_buscar_barra.Image = global::ProyectoECU.Properties.Resources.search;
            this.btn_buscar_barra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_buscar_barra.Name = "btn_buscar_barra";
            this.btn_buscar_barra.Size = new System.Drawing.Size(23, 22);
            this.btn_buscar_barra.Text = "toolStripButton3";
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Nuevo.Image = global::ProyectoECU.Properties.Resources.file;
            this.btn_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(23, 22);
            this.btn_Nuevo.Text = "toolStripButton2";
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
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
            this.menuStrip1.TabIndex = 2;
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
            this.guardarToolStripMenuItem.Enabled = false;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Enabled = false;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
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
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Controls.Add(this.txt_valor_matri);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.txt_codigo_mat);
            this.groupBox1.Controls.Add(this.txt_tipo_lice);
            this.groupBox1.Controls.Add(this.txt_saldo);
            this.groupBox1.Controls.Add(this.txt_valor_curso);
            this.groupBox1.Controls.Add(this.txt_Cedula);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(29, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 192);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Image = global::ProyectoECU.Properties.Resources.search;
            this.btn_Buscar.Location = new System.Drawing.Point(257, 28);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(21, 23);
            this.btn_Buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Buscar.TabIndex = 36;
            this.btn_Buscar.TabStop = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_valor_matri
            // 
            this.txt_valor_matri.Enabled = false;
            this.txt_valor_matri.Lines = new string[0];
            this.txt_valor_matri.Location = new System.Drawing.Point(473, 57);
            this.txt_valor_matri.MaxLength = 32767;
            this.txt_valor_matri.Name = "txt_valor_matri";
            this.txt_valor_matri.PasswordChar = '\0';
            this.txt_valor_matri.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_valor_matri.SelectedText = "";
            this.txt_valor_matri.Size = new System.Drawing.Size(128, 23);
            this.txt_valor_matri.TabIndex = 35;
            this.txt_valor_matri.UseSelectable = true;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Lines = new string[0];
            this.txt_nombre.Location = new System.Drawing.Point(100, 94);
            this.txt_nombre.MaxLength = 32767;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PasswordChar = '\0';
            this.txt_nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nombre.SelectedText = "";
            this.txt_nombre.Size = new System.Drawing.Size(214, 23);
            this.txt_nombre.TabIndex = 34;
            this.txt_nombre.UseSelectable = true;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Enabled = false;
            this.txt_apellido.Lines = new string[0];
            this.txt_apellido.Location = new System.Drawing.Point(100, 123);
            this.txt_apellido.MaxLength = 32767;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.PasswordChar = '\0';
            this.txt_apellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_apellido.SelectedText = "";
            this.txt_apellido.Size = new System.Drawing.Size(214, 23);
            this.txt_apellido.TabIndex = 33;
            this.txt_apellido.UseSelectable = true;
            // 
            // txt_codigo_mat
            // 
            this.txt_codigo_mat.Lines = new string[0];
            this.txt_codigo_mat.Location = new System.Drawing.Point(146, 28);
            this.txt_codigo_mat.MaxLength = 25;
            this.txt_codigo_mat.Name = "txt_codigo_mat";
            this.txt_codigo_mat.PasswordChar = '\0';
            this.txt_codigo_mat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_codigo_mat.SelectedText = "";
            this.txt_codigo_mat.Size = new System.Drawing.Size(105, 23);
            this.txt_codigo_mat.TabIndex = 32;
            this.txt_codigo_mat.UseSelectable = true;
            // 
            // txt_tipo_lice
            // 
            this.txt_tipo_lice.Enabled = false;
            this.txt_tipo_lice.Lines = new string[0];
            this.txt_tipo_lice.Location = new System.Drawing.Point(473, 28);
            this.txt_tipo_lice.MaxLength = 32767;
            this.txt_tipo_lice.Name = "txt_tipo_lice";
            this.txt_tipo_lice.PasswordChar = '\0';
            this.txt_tipo_lice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_tipo_lice.SelectedText = "";
            this.txt_tipo_lice.Size = new System.Drawing.Size(128, 23);
            this.txt_tipo_lice.TabIndex = 31;
            this.txt_tipo_lice.UseSelectable = true;
            // 
            // txt_saldo
            // 
            this.txt_saldo.Enabled = false;
            this.txt_saldo.Lines = new string[0];
            this.txt_saldo.Location = new System.Drawing.Point(473, 127);
            this.txt_saldo.MaxLength = 32767;
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.PasswordChar = '\0';
            this.txt_saldo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_saldo.SelectedText = "";
            this.txt_saldo.Size = new System.Drawing.Size(128, 23);
            this.txt_saldo.TabIndex = 30;
            this.txt_saldo.UseSelectable = true;
            // 
            // txt_valor_curso
            // 
            this.txt_valor_curso.Enabled = false;
            this.txt_valor_curso.Lines = new string[0];
            this.txt_valor_curso.Location = new System.Drawing.Point(473, 87);
            this.txt_valor_curso.MaxLength = 32767;
            this.txt_valor_curso.Name = "txt_valor_curso";
            this.txt_valor_curso.PasswordChar = '\0';
            this.txt_valor_curso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_valor_curso.SelectedText = "";
            this.txt_valor_curso.Size = new System.Drawing.Size(128, 23);
            this.txt_valor_curso.TabIndex = 29;
            this.txt_valor_curso.UseSelectable = true;
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.Enabled = false;
            this.txt_Cedula.Lines = new string[0];
            this.txt_Cedula.Location = new System.Drawing.Point(100, 65);
            this.txt_Cedula.MaxLength = 32767;
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.PasswordChar = '\0';
            this.txt_Cedula.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Cedula.SelectedText = "";
            this.txt_Cedula.Size = new System.Drawing.Size(151, 23);
            this.txt_Cedula.TabIndex = 28;
            this.txt_Cedula.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(372, 127);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(95, 19);
            this.metroLabel8.TabIndex = 8;
            this.metroLabel8.Text = "Saldo Restante";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(372, 87);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(76, 19);
            this.metroLabel7.TabIndex = 7;
            this.metroLabel7.Text = "Valor Curso";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(372, 57);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(96, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Valor Matrícula";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(372, 28);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(84, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Tipo Licencia";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(25, 28);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(115, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Código  Matrícula";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(25, 125);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Apellidos";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(25, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Nombres";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Cédula";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.btn_confirmar);
            this.groupBox2.Controls.Add(this.txt_valor_pagar);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Controls.Add(this.metroLabel10);
            this.groupBox2.Location = new System.Drawing.Point(29, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 80);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pago";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Enabled = false;
            this.btn_confirmar.Location = new System.Drawing.Point(449, 29);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmar.TabIndex = 38;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseSelectable = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // txt_valor_pagar
            // 
            this.txt_valor_pagar.Enabled = false;
            this.txt_valor_pagar.Lines = new string[0];
            this.txt_valor_pagar.Location = new System.Drawing.Point(276, 29);
            this.txt_valor_pagar.MaxLength = 10;
            this.txt_valor_pagar.Name = "txt_valor_pagar";
            this.txt_valor_pagar.PasswordChar = '\0';
            this.txt_valor_pagar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_valor_pagar.SelectedText = "";
            this.txt_valor_pagar.Size = new System.Drawing.Size(136, 23);
            this.txt_valor_pagar.TabIndex = 37;
            this.txt_valor_pagar.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(142, 29);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(88, 19);
            this.metroLabel9.TabIndex = 36;
            this.metroLabel9.Text = "Valor a pagar";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(254, 29);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(16, 19);
            this.metroLabel10.TabIndex = 36;
            this.metroLabel10.Text = "$";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(337, 69);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(72, 25);
            this.metroLabel11.TabIndex = 6;
            this.metroLabel11.Text = "PAGOS";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(19, 97);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(10, 192);
            this.metroTile1.TabIndex = 7;
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(19, 299);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(10, 73);
            this.metroTile2.TabIndex = 8;
            this.metroTile2.UseSelectable = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::ProyectoECU.Properties.Resources._54097;
            this.btn_salir.Location = new System.Drawing.Point(656, 395);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(40, 30);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_salir.TabIndex = 48;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // ECU_GestionPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 437);
            this.ControlBox = false;
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(734, 476);
            this.MinimumSize = new System.Drawing.Size(734, 476);
            this.Name = "ECU_GestionPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Pago";
            this.Load += new System.EventHandler(this.ECU_GestionPago_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buscar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Guardar;
        private System.Windows.Forms.ToolStripButton btn_buscar_barra;
        private System.Windows.Forms.ToolStripButton btn_Nuevo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_Cedula;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_valor_matri;
        private MetroFramework.Controls.MetroTextBox txt_nombre;
        private MetroFramework.Controls.MetroTextBox txt_apellido;
        private MetroFramework.Controls.MetroTextBox txt_codigo_mat;
        private MetroFramework.Controls.MetroTextBox txt_tipo_lice;
        private MetroFramework.Controls.MetroTextBox txt_saldo;
        private MetroFramework.Controls.MetroTextBox txt_valor_curso;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btn_confirmar;
        private MetroFramework.Controls.MetroTextBox txt_valor_pagar;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.PictureBox btn_Buscar;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.PictureBox btn_salir;
    }
}