using Npgsql;
using ProyectoECU.ECU_Concexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoECU
{
    public partial class ECU_GestionMatricula : Form
    {
        public ECU_GestionMatricula()
        {
            InitializeComponent();
        }

        

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                //abrir la conexion
                ECU_ConexionPostgres.coneccion.Open();
                //consulta de usuario
                NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM Pro_Con_Per_Est_Cedula ('"+txt_Cedula.Text+"')", ECU_ConexionPostgres.coneccion);
                //ejecutar comando
                NpgsqlDataReader resultado = comando.ExecuteReader();
                if (resultado.Read())
                {   //resultado de la consulta
                    object ced_Est = resultado[0];
                    object nomb_estu = resultado[1];
                    object apel_estu = resultado[2];
                    object fec_estu = resultado[3];
                    //compara resultado con el dato ingresado
                    if (ced_Est.Equals(txt_Cedula.Text))
                    {
                        //mensaje de dialogo
                       DialogResult respuesta= MessageBox.Show("El estudiante ya existe,¿Desea modificarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        //si es si entonces llena los texbox
                       if (respuesta == DialogResult.Yes)
                       {
                           txt_nombre.Text=  nomb_estu.ToString();
                           txtApellido.Text = apel_estu.ToString();
                           datePFecha.Text = fec_estu.ToString();


                          
                       }

                       else if (respuesta == DialogResult.No)
                       {
                           MessageBox.Show("You chose No.");
                       }

                    }
                }
                ECU_ConexionPostgres.coneccion.Close();

            }
            catch (Exception)
            {
                
                throw;
            }
           


        }
    }
}
