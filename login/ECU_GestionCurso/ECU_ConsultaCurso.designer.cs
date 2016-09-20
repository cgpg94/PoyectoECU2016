namespace ProyectoECU
{
    partial class ECU_ConsultaCurso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_verificar = new System.Windows.Forms.PictureBox();
            this.comb_tip_lic = new MetroFramework.Controls.MetroComboBox();
            this.txt_codigo_cur = new MetroFramework.Controls.MetroTextBox();
            this.rbtn_ti_lic = new MetroFramework.Controls.MetroRadioButton();
            this.rbtn_cod_cur = new MetroFramework.Controls.MetroRadioButton();
            this.rbtn_todo = new MetroFramework.Controls.MetroRadioButton();
            this.grid_datos = new MetroFramework.Controls.MetroGrid();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_verificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(352, -27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(173, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Consulta de Cursos";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btn_verificar);
            this.groupBox1.Controls.Add(this.comb_tip_lic);
            this.groupBox1.Controls.Add(this.txt_codigo_cur);
            this.groupBox1.Controls.Add(this.rbtn_ti_lic);
            this.groupBox1.Controls.Add(this.rbtn_cod_cur);
            this.groupBox1.Controls.Add(this.rbtn_todo);
            this.groupBox1.Location = new System.Drawing.Point(15, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btn_verificar
            // 
            this.btn_verificar.Image = global::ProyectoECU.Properties.Resources.search;
            this.btn_verificar.Location = new System.Drawing.Point(790, 37);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(25, 23);
            this.btn_verificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_verificar.TabIndex = 68;
            this.btn_verificar.TabStop = false;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // comb_tip_lic
            // 
            this.comb_tip_lic.Enabled = false;
            this.comb_tip_lic.FormattingEnabled = true;
            this.comb_tip_lic.ItemHeight = 23;
            this.comb_tip_lic.Location = new System.Drawing.Point(593, 29);
            this.comb_tip_lic.Name = "comb_tip_lic";
            this.comb_tip_lic.Size = new System.Drawing.Size(142, 29);
            this.comb_tip_lic.TabIndex = 4;
            this.comb_tip_lic.UseSelectable = true;
            // 
            // txt_codigo_cur
            // 
            this.txt_codigo_cur.Enabled = false;
            this.txt_codigo_cur.Lines = new string[0];
            this.txt_codigo_cur.Location = new System.Drawing.Point(285, 29);
            this.txt_codigo_cur.MaxLength = 25;
            this.txt_codigo_cur.Name = "txt_codigo_cur";
            this.txt_codigo_cur.PasswordChar = '\0';
            this.txt_codigo_cur.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_codigo_cur.SelectedText = "";
            this.txt_codigo_cur.Size = new System.Drawing.Size(127, 23);
            this.txt_codigo_cur.TabIndex = 3;
            this.txt_codigo_cur.UseSelectable = true;
            // 
            // rbtn_ti_lic
            // 
            this.rbtn_ti_lic.AutoSize = true;
            this.rbtn_ti_lic.Location = new System.Drawing.Point(478, 37);
            this.rbtn_ti_lic.Name = "rbtn_ti_lic";
            this.rbtn_ti_lic.Size = new System.Drawing.Size(109, 15);
            this.rbtn_ti_lic.TabIndex = 2;
            this.rbtn_ti_lic.Text = "Tipo de Licencia";
            this.rbtn_ti_lic.UseSelectable = true;
            this.rbtn_ti_lic.CheckedChanged += new System.EventHandler(this.rbtn_ti_lic_CheckedChanged);
            // 
            // rbtn_cod_cur
            // 
            this.rbtn_cod_cur.AutoSize = true;
            this.rbtn_cod_cur.Location = new System.Drawing.Point(167, 37);
            this.rbtn_cod_cur.Name = "rbtn_cod_cur";
            this.rbtn_cod_cur.Size = new System.Drawing.Size(112, 15);
            this.rbtn_cod_cur.TabIndex = 1;
            this.rbtn_cod_cur.Text = "Codigo de Curso";
            this.rbtn_cod_cur.UseSelectable = true;
            this.rbtn_cod_cur.CheckedChanged += new System.EventHandler(this.rbtn_cod_cur_CheckedChanged);
            // 
            // rbtn_todo
            // 
            this.rbtn_todo.AutoSize = true;
            this.rbtn_todo.Checked = true;
            this.rbtn_todo.Location = new System.Drawing.Point(60, 37);
            this.rbtn_todo.Name = "rbtn_todo";
            this.rbtn_todo.Size = new System.Drawing.Size(50, 15);
            this.rbtn_todo.TabIndex = 0;
            this.rbtn_todo.TabStop = true;
            this.rbtn_todo.Text = "Todo";
            this.rbtn_todo.UseSelectable = true;
            this.rbtn_todo.CheckedChanged += new System.EventHandler(this.rbtn_todo_CheckedChanged);
            // 
            // grid_datos
            // 
            this.grid_datos.AllowUserToAddRows = false;
            this.grid_datos.AllowUserToDeleteRows = false;
            this.grid_datos.AllowUserToResizeRows = false;
            this.grid_datos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grid_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_datos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.grid_datos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_datos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_datos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_datos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_datos.EnableHeadersVisualStyles = false;
            this.grid_datos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_datos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_datos.Location = new System.Drawing.Point(15, 148);
            this.grid_datos.Name = "grid_datos";
            this.grid_datos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_datos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_datos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.grid_datos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_datos.Size = new System.Drawing.Size(848, 210);
            this.grid_datos.TabIndex = 5;
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::ProyectoECU.Properties.Resources._54097;
            this.btn_salir.Location = new System.Drawing.Point(823, 364);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(40, 30);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_salir.TabIndex = 47;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(343, 14);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(171, 25);
            this.metroLabel2.TabIndex = 68;
            this.metroLabel2.Text = "Consulta de cursos";
            // 
            // ECU_ConsultaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 406);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.grid_datos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "ECU_ConsultaCurso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Cursos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ECU_ConsultaCurso_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_verificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton rbtn_ti_lic;
        private MetroFramework.Controls.MetroRadioButton rbtn_cod_cur;
        private MetroFramework.Controls.MetroRadioButton rbtn_todo;
        private MetroFramework.Controls.MetroComboBox comb_tip_lic;
        private MetroFramework.Controls.MetroTextBox txt_codigo_cur;
        private MetroFramework.Controls.MetroGrid grid_datos;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.PictureBox btn_verificar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}