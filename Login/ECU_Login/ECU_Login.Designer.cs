namespace Login
{
    partial class ECU_Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ECU_Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_Usuario = new MetroFramework.Controls.MetroTextBox();
            this.txt_Contraceña = new MetroFramework.Controls.MetroTextBox();
            this.btn_Entrar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoECU.Properties.Resources.ImagenuSUARIOS;
            this.pictureBox1.Location = new System.Drawing.Point(103, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 111);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(103, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Inicio Sesión";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(130, 155);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Usuario";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(121, 203);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Contraceña";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Lines = new string[0];
            this.txt_Usuario.Location = new System.Drawing.Point(86, 177);
            this.txt_Usuario.MaxLength = 32767;
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.PasswordChar = '\0';
            this.txt_Usuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Usuario.SelectedText = "";
            this.txt_Usuario.Size = new System.Drawing.Size(141, 23);
            this.txt_Usuario.TabIndex = 4;
            this.txt_Usuario.UseSelectable = true;
            // 
            // txt_Contraceña
            // 
            this.txt_Contraceña.Lines = new string[0];
            this.txt_Contraceña.Location = new System.Drawing.Point(86, 225);
            this.txt_Contraceña.MaxLength = 32767;
            this.txt_Contraceña.Name = "txt_Contraceña";
            this.txt_Contraceña.PasswordChar = '*';
            this.txt_Contraceña.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Contraceña.SelectedText = "";
            this.txt_Contraceña.Size = new System.Drawing.Size(141, 23);
            this.txt_Contraceña.TabIndex = 5;
            this.txt_Contraceña.UseSelectable = true;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.Location = new System.Drawing.Point(121, 267);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Entrar.TabIndex = 6;
            this.btn_Entrar.Text = "ENTRAR";
            this.btn_Entrar.UseSelectable = true;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // ECU_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(314, 311);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.txt_Contraceña);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(330, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(330, 350);
            this.Name = "ECU_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_Usuario;
        private MetroFramework.Controls.MetroTextBox txt_Contraceña;
        private MetroFramework.Controls.MetroButton btn_Entrar;





    }
}

