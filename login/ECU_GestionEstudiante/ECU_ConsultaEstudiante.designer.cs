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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rd_cedula = new MetroFramework.Controls.MetroRadioButton();
            this.rd_nombre = new MetroFramework.Controls.MetroRadioButton();
            this.rd_todos = new MetroFramework.Controls.MetroRadioButton();
            this.txt_cedula = new MetroFramework.Controls.MetroTextBox();
            this.txt_nombre = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_verificar = new System.Windows.Forms.PictureBox();
            this.dgv_estudiante = new MetroFramework.Controls.MetroGrid();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_verificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // rd_cedula
            // 
            this.rd_cedula.AutoSize = true;
            this.rd_cedula.Location = new System.Drawing.Point(207, 22);
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
            this.rd_nombre.Location = new System.Drawing.Point(468, 24);
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
            this.rd_todos.Location = new System.Drawing.Point(77, 24);
            this.rd_todos.Name = "rd_todos";
            this.rd_todos.Size = new System.Drawing.Size(55, 15);
            this.rd_todos.TabIndex = 0;
            this.rd_todos.TabStop = true;
            this.rd_todos.Text = "Todos";
            this.rd_todos.UseSelectable = true;
            this.rd_todos.Click += new System.EventHandler(this.rd_todos_Click);
            // 
            // txt_cedula
            // 
            this.txt_cedula.Lines = new string[0];
            this.txt_cedula.Location = new System.Drawing.Point(273, 19);
            this.txt_cedula.MaxLength = 32767;
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.PasswordChar = '\0';
            this.txt_cedula.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cedula.SelectedText = "";
            this.txt_cedula.Size = new System.Drawing.Size(141, 23);
            this.txt_cedula.TabIndex = 3;
            this.txt_cedula.UseSelectable = true;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Lines = new string[0];
            this.txt_nombre.Location = new System.Drawing.Point(541, 19);
            this.txt_nombre.MaxLength = 32767;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PasswordChar = '\0';
            this.txt_nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nombre.SelectedText = "";
            this.txt_nombre.Size = new System.Drawing.Size(154, 23);
            this.txt_nombre.TabIndex = 4;
            this.txt_nombre.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_verificar);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_cedula);
            this.groupBox1.Controls.Add(this.rd_todos);
            this.groupBox1.Controls.Add(this.rd_nombre);
            this.groupBox1.Controls.Add(this.rd_cedula);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 84);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // btn_verificar
            // 
            this.btn_verificar.Image = global::ProyectoECU.Properties.Resources.search;
            this.btn_verificar.Location = new System.Drawing.Point(357, 48);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(25, 23);
            this.btn_verificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_verificar.TabIndex = 45;
            this.btn_verificar.TabStop = false;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // dgv_estudiante
            // 
            this.dgv_estudiante.AllowUserToAddRows = false;
            this.dgv_estudiante.AllowUserToDeleteRows = false;
            this.dgv_estudiante.AllowUserToResizeRows = false;
            this.dgv_estudiante.BackgroundColor = System.Drawing.Color.White;
            this.dgv_estudiante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_estudiante.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_estudiante.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_estudiante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_estudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_estudiante.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_estudiante.EnableHeadersVisualStyles = false;
            this.dgv_estudiante.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_estudiante.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_estudiante.Location = new System.Drawing.Point(12, 120);
            this.dgv_estudiante.Name = "dgv_estudiante";
            this.dgv_estudiante.ReadOnly = true;
            this.dgv_estudiante.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_estudiante.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_estudiante.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_estudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_estudiante.Size = new System.Drawing.Size(753, 211);
            this.dgv_estudiante.TabIndex = 4;
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::ProyectoECU.Properties.Resources._54097;
            this.btn_salir.Location = new System.Drawing.Point(707, 337);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(40, 30);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_salir.TabIndex = 46;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_DoubleClick);
            this.btn_salir.DoubleClick += new System.EventHandler(this.btn_salir_DoubleClick);
            // 
            // ECU_ConsultaEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 383);
            this.ControlBox = false;
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.dgv_estudiante);
            this.Controls.Add(this.groupBox1);
            this.Name = "ECU_ConsultaEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Estudiantes";
            this.Load += new System.EventHandler(this.ECU_ConsultaEstudiante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_verificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton rd_cedula;
        private MetroFramework.Controls.MetroRadioButton rd_nombre;
        private MetroFramework.Controls.MetroRadioButton rd_todos;
        private MetroFramework.Controls.MetroTextBox txt_cedula;
        private MetroFramework.Controls.MetroTextBox txt_nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroGrid dgv_estudiante;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.PictureBox btn_verificar;


    }
}