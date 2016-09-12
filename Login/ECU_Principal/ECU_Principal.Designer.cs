namespace ProyectoECU.Interfaces
{
    partial class ECU_Principal
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
            this.estudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrículaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // estudianteToolStripMenuItem
            // 
            this.estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            this.estudianteToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.estudianteToolStripMenuItem.Text = "Estudiante";
            this.estudianteToolStripMenuItem.Click += new System.EventHandler(this.tab_Estudiantes_Click);
            // 
            // instructorToolStripMenuItem
            // 
            this.instructorToolStripMenuItem.Name = "instructorToolStripMenuItem";
            this.instructorToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.instructorToolStripMenuItem.Text = "Instructor";
            this.instructorToolStripMenuItem.Click += new System.EventHandler(this.tab_Instructor_Click);
            // 
            // matrículaToolStripMenuItem
            // 
            this.matrículaToolStripMenuItem.Name = "matrículaToolStripMenuItem";
            this.matrículaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.matrículaToolStripMenuItem.Text = "Matricula";
            this.matrículaToolStripMenuItem.Click += new System.EventHandler(this.tab_Matricula_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.pagosToolStripMenuItem.Text = "Pagos";
            this.pagosToolStripMenuItem.Click += new System.EventHandler(this.tab_Pago_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cursosToolStripMenuItem.Text = "Cursos";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.tab_Cursos_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.tab_Usuario_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.tab_Ayuda_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudianteToolStripMenuItem,
            this.instructorToolStripMenuItem,
            this.matrículaToolStripMenuItem,
            this.pagosToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ECU_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 424);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ECU_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Matriculación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem estudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrículaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;






    }
}