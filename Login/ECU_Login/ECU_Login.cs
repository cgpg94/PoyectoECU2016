using Npgsql;
using ProyectoECU.ECU_Concexion;
using ProyectoECU.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class ECU_Login : Form 
    {
        public ECU_Login()
        {
            InitializeComponent();
        }

        private void txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txt_Contraseña.Focus();
            }

        }

        private void txt_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btn_Entrar.Focus();
            }

        }

        private void RunPrincipal()
        {
            ECU_GestionUsuario frm = new ECU_GestionUsuario();
            frm.ShowDialog();
        }


            private void btn_Entrar_Click(object sender, EventArgs e){

            String username = txt_Usuario.Text;
            String password = txt_Contraseña.Text;

            if (string.IsNullOrEmpty(txt_Usuario.Text))
            {
                MessageBox.Show("Falta ingresar el nombre de usuario", "Aviso",MessageBoxButtons.OK);
            }
            else if (string.IsNullOrEmpty(txt_Contraseña.Text))
            {
                MessageBox.Show("Falta ingresar la contraceña", "Aviso", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    ECU_ConexionPostgres.coneccion.Open();
                    string SQL = "select * from TMAEUSSECU where usi_uss='" + username + "' and csi_uss='" + password + "' ";
                    NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
                    NpgsqlDataReader resultado = command.ExecuteReader();



                    if (resultado.Read())
                    {
                        //FORMULARIO PRINCIPAL 
                        Form formularioprincipal = new ECU_Principal();
                        ECU_ConexionPostgres.coneccion.Close();
                        this.Hide();
                        formularioprincipal.ShowDialog();
                        this.Close();
                    }
                    else
                    {

                        MessageBox.Show("Contraceña o Usuario incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    ECU_ConexionPostgres.coneccion.Close();

                }
                catch (Exception)
                {
                    //cierra la conexion
                    ECU_ConexionPostgres.coneccion.Close();
                }  

            }
            
        }


          
    }
}
