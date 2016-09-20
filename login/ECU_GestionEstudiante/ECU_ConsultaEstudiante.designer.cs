namespace ProyectoECU.ECU_GestionEstudiante
{
    partial class ECU_ConsultaEstudiante
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
            this.rd_cedula = new MetroFramework.Controls.MetroRadioButton();
            this.rd_nombre = new MetroFramework.Controls.MetroRadioButton();
            this.rd_todos = new MetroFramework.Controls.MetroRadioButton();
            this.txt_cedula = new MetroFramework.Controls.MetroTextBox();
            this.txt_nombre = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.PictureBox();
            this.dgv_estudiante = new MetroFramework.Controls.MetroGrid();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // rd_cedula
            // 
            this.rd_cedula.AutoSize = true;
            this.rd_cedula.Location = new System.Drawing.Point(487, 45);
            this.rd_cedula.Name = "rd_cedula";
            this.rd_cedula.Size = new System.Drawing.Size(60, 15);
            this.rd_cedula.TabIndex = 1;
            this.rd_cedula.Text = "Cédula";
            this.rd_cedula.UseSelectable = true;
            this.rd_cedula.CheckedChanged += new System.EventHandler(this.rd_cedula_CheckedChanged);
            // 
            // rd_nombre
            // 
            this.rd_nombre.AutoSize = true;
            this.rd_nombre.Location = new System.Drawing.Point(232, 42);
            this.rd_nombre.Name = "rd_nombre";
            this.rd_nombre.Size = new System.Drawing.Size(67, 15);
            this.rd_nombre.TabIndex = 2;
            this.rd_nombre.Text = "Nombre";
            this.rd_nombre.UseSelectable = true;
            this.rd_nombre.CheckedChanged += new System.EventHandler(this.rd_nombre_CheckedChanged);
            // 
            // rd_todos
            // 
            this.rd_todos.AutoSize = true;
            this.rd_todos.Checked = true;
            this.rd_todos.Location = new System.Drawing.Point(93, 45);
            this.rd_todos.Name = "rd_todos";
            this.rd_todos.Size = new System.Drawing.Size(55, 15);
            this.rd_todos.TabIndex = 0;
            this.rd_todos.TabStop = true;
            this.rd_todos.Text = "Todos";
            this.rd_todos.UseSelectable = true;
            this.rd_todos.CheckedChanged += new System.EventHandler(this.rd_todos_CheckedChanged);
            this.rd_todos.Click += new System.EventHandler(this.rd_todos_Click);
            // 
            // txt_cedula
            // 
            this.txt_cedula.Lines = new string[0];
            this.txt_cedula.Location = new System.Drawing.Point(553, 42);
            this.txt_cedula.MaxLength = 10;
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.PasswordChar = '\0';
            this.txt_cedula.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cedula.SelectedText = "";
            this.txt_cedula.Size = new System.Drawing.Size(113, 23);
            this.txt_cedula.TabIndex = 3;
            this.txt_cedula.UseSelectable = true;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Lines = new string[0];
            this.txt_nombre.Location = new System.Drawing.Point(314, 40);
            this.txt_nombre.MaxLength = 32767;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PasswordChar = '\0';
            this.txt_nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nombre.SelectedText = "";
            this.txt_nombre.Size = new System.Drawing.Size(113, 23);
            this.txt_nombre.TabIndex = 4;
            this.txt_nombre.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_cedula);
            this.groupBox1.Controls.Add(this.rd_todos);
            this.groupBox1.Controls.Add(this.rd_nombre);
            this.groupBox1.Controls.Add(this.rd_cedula);
            this.groupBox1.Location = new System.Drawing.Point(14, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = global::ProyectoECU.Properties.Resources.search;
            this.btn_buscar.Location = new System.Drawing.Point(723, 40);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(25, 23);
            this.btn_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_buscar.TabIndex = 45;
            this.btn_buscar.TabStop = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dgv_estudiante
            // 
            this.dgv_estudiante.AllowUserToAddRows = false;
            this.dgv_estudiante.AllowUserToDeleteRows = false;
            this.dgv_estudiante.AllowUserToResizeRows = false;
            this.dgv_estudiante.BackgroundColor = System.Drawing.Color.White;
            this.dgv_estudiante.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_estudiante.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv_estudiante.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_estudiante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_estudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_estudiante.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_estudiante.EnableHeadersVisualStyles = false;
            this.dgv_estudiante.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_estudiante.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_estudiante.Location = new System.Drawing.Point(14, 147);
            this.dgv_estudiante.Name = "dgv_estudiante";
            this.dgv_estudiante.ReadOnly = true;
            this.dgv_estudiante.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_estudiante.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_estudiante.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_estudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_estudiante.Size = new System.Drawing.Size(848, 210);
            this.dgv_estudiante.TabIndex = 4;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(279, 9);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(215, 25);
            this.metroLabel7.TabIndex = 33;
            this.metroLabel7.Text = "Consulta de estudiantes";
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::ProyectoECU.Properties.Resources._54097;
            this.btn_salir.Location = new System.Drawing.Point(822, 364);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(40, 30);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_salir.TabIndex = 48;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // ECU_ConsultaEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 406);
            this.ControlBox = false;
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.dgv_estudiante);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(891, 445);
            this.MinimumSize = new System.Drawing.Size(891, 445);
            this.Name = "ECU_ConsultaEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Estudiantes";
            this.Load += new System.EventHandler(this.ECU_ConsultaEstudiante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton rd_cedula;
        private MetroFramework.Controls.MetroRadioButton rd_nombre;
        private MetroFramework.Controls.MetroRadioButton rd_todos;
        private MetroFramework.Controls.MetroTextBox txt_cedula;
        private MetroFramework.Controls.MetroTextBox txt_nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroGrid dgv_estudiante;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.PictureBox btn_buscar;


    }
}