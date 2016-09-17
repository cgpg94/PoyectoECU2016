namespace ProyectoECU.Interfaces
{
    partial class ECU_ConsultaMatricula
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
            this.g_datos = new MetroFramework.Controls.MetroGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.txt_nombreEstud = new MetroFramework.Controls.MetroTextBox();
            this.txt_cedula = new MetroFramework.Controls.MetroTextBox();
            this.rbtn_numCedula = new MetroFramework.Controls.MetroRadioButton();
            this.txt_numMatricula = new MetroFramework.Controls.MetroTextBox();
            this.rbtn_nomEstudiante = new MetroFramework.Controls.MetroRadioButton();
            this.rbtn_numMatricula = new MetroFramework.Controls.MetroRadioButton();
            this.rbtn_todo = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.g_datos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // g_datos
            // 
            this.g_datos.AllowUserToAddRows = false;
            this.g_datos.AllowUserToDeleteRows = false;
            this.g_datos.AllowUserToResizeRows = false;
            this.g_datos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.g_datos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.g_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.g_datos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.g_datos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.g_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.g_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.g_datos.DefaultCellStyle = dataGridViewCellStyle2;
            this.g_datos.EnableHeadersVisualStyles = false;
            this.g_datos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.g_datos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.g_datos.Location = new System.Drawing.Point(202, 53);
            this.g_datos.MaximumSize = new System.Drawing.Size(597, 298);
            this.g_datos.MinimumSize = new System.Drawing.Size(597, 298);
            this.g_datos.Name = "g_datos";
            this.g_datos.ReadOnly = true;
            this.g_datos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.g_datos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.g_datos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.g_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.g_datos.Size = new System.Drawing.Size(597, 298);
            this.g_datos.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txt_nombreEstud);
            this.groupBox1.Controls.Add(this.txt_cedula);
            this.groupBox1.Controls.Add(this.rbtn_numCedula);
            this.groupBox1.Controls.Add(this.txt_numMatricula);
            this.groupBox1.Controls.Add(this.rbtn_nomEstudiante);
            this.groupBox1.Controls.Add(this.rbtn_numMatricula);
            this.groupBox1.Controls.Add(this.rbtn_todo);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 306);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::ProyectoECU.Properties.Resources.search;
            this.btnBuscar.Location = new System.Drawing.Point(56, 256);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 44);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscar.TabIndex = 41;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txt_nombreEstud
            // 
            this.txt_nombreEstud.Enabled = false;
            this.txt_nombreEstud.Lines = new string[0];
            this.txt_nombreEstud.Location = new System.Drawing.Point(26, 217);
            this.txt_nombreEstud.MaxLength = 32767;
            this.txt_nombreEstud.Name = "txt_nombreEstud";
            this.txt_nombreEstud.PasswordChar = '\0';
            this.txt_nombreEstud.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nombreEstud.SelectedText = "";
            this.txt_nombreEstud.Size = new System.Drawing.Size(140, 23);
            this.txt_nombreEstud.TabIndex = 7;
            this.txt_nombreEstud.UseSelectable = true;
            // 
            // txt_cedula
            // 
            this.txt_cedula.Enabled = false;
            this.txt_cedula.Lines = new string[0];
            this.txt_cedula.Location = new System.Drawing.Point(26, 161);
            this.txt_cedula.MaxLength = 32767;
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.PasswordChar = '\0';
            this.txt_cedula.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cedula.SelectedText = "";
            this.txt_cedula.Size = new System.Drawing.Size(140, 23);
            this.txt_cedula.TabIndex = 6;
            this.txt_cedula.UseSelectable = true;
            // 
            // rbtn_numCedula
            // 
            this.rbtn_numCedula.AutoSize = true;
            this.rbtn_numCedula.Location = new System.Drawing.Point(6, 140);
            this.rbtn_numCedula.Name = "rbtn_numCedula";
            this.rbtn_numCedula.Size = new System.Drawing.Size(134, 15);
            this.rbtn_numCedula.TabIndex = 5;
            this.rbtn_numCedula.Text = "Cédula de estudiante";
            this.rbtn_numCedula.UseSelectable = true;
            this.rbtn_numCedula.CheckedChanged += new System.EventHandler(this.rbtn_numCedula_CheckedChanged);
            // 
            // txt_numMatricula
            // 
            this.txt_numMatricula.Enabled = false;
            this.txt_numMatricula.Lines = new string[0];
            this.txt_numMatricula.Location = new System.Drawing.Point(26, 106);
            this.txt_numMatricula.MaxLength = 32767;
            this.txt_numMatricula.Name = "txt_numMatricula";
            this.txt_numMatricula.PasswordChar = '\0';
            this.txt_numMatricula.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_numMatricula.SelectedText = "";
            this.txt_numMatricula.Size = new System.Drawing.Size(140, 23);
            this.txt_numMatricula.TabIndex = 3;
            this.txt_numMatricula.UseSelectable = true;
            // 
            // rbtn_nomEstudiante
            // 
            this.rbtn_nomEstudiante.AutoSize = true;
            this.rbtn_nomEstudiante.Location = new System.Drawing.Point(6, 196);
            this.rbtn_nomEstudiante.Name = "rbtn_nomEstudiante";
            this.rbtn_nomEstudiante.Size = new System.Drawing.Size(141, 15);
            this.rbtn_nomEstudiante.TabIndex = 2;
            this.rbtn_nomEstudiante.Text = "Nombre de estudiante";
            this.rbtn_nomEstudiante.UseSelectable = true;
            this.rbtn_nomEstudiante.CheckedChanged += new System.EventHandler(this.rbtn_nomEstudiante_CheckedChanged);
            // 
            // rbtn_numMatricula
            // 
            this.rbtn_numMatricula.AutoSize = true;
            this.rbtn_numMatricula.Location = new System.Drawing.Point(6, 85);
            this.rbtn_numMatricula.Name = "rbtn_numMatricula";
            this.rbtn_numMatricula.Size = new System.Drawing.Size(136, 15);
            this.rbtn_numMatricula.TabIndex = 1;
            this.rbtn_numMatricula.Text = "Número de matrícula";
            this.rbtn_numMatricula.UseSelectable = true;
            this.rbtn_numMatricula.CheckedChanged += new System.EventHandler(this.rbtn_numMatricula_CheckedChanged);
            // 
            // rbtn_todo
            // 
            this.rbtn_todo.AutoSize = true;
            this.rbtn_todo.Location = new System.Drawing.Point(6, 34);
            this.rbtn_todo.Name = "rbtn_todo";
            this.rbtn_todo.Size = new System.Drawing.Size(50, 15);
            this.rbtn_todo.TabIndex = 0;
            this.rbtn_todo.Text = "Todo";
            this.rbtn_todo.UseSelectable = true;
            this.rbtn_todo.CheckedChanged += new System.EventHandler(this.rbtn_todo_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(318, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(183, 25);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Consulta de Matrícula";
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(2, 50);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(10, 298);
            this.metroTile2.TabIndex = 45;
            this.metroTile2.UseSelectable = true;
            // 
            // ECU_ConsultaMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 377);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.g_datos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel1);
            this.MaximumSize = new System.Drawing.Size(827, 416);
            this.MinimumSize = new System.Drawing.Size(827, 416);
            this.Name = "ECU_ConsultaMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Matrícula";
            ((System.ComponentModel.ISupportInitialize)(this.g_datos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid g_datos;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txt_numMatricula;
        private MetroFramework.Controls.MetroRadioButton rbtn_nomEstudiante;
        private MetroFramework.Controls.MetroRadioButton rbtn_numMatricula;
        private MetroFramework.Controls.MetroRadioButton rbtn_todo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_nombreEstud;
        private MetroFramework.Controls.MetroTextBox txt_cedula;
        private MetroFramework.Controls.MetroRadioButton rbtn_numCedula;
        private System.Windows.Forms.PictureBox btnBuscar;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}