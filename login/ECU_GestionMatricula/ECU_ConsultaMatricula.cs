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

namespace ProyectoECU.Interfaces
{
    public partial class ECU_ConsultaMatricula : Form
    {
        public ECU_ConsultaMatricula()
        {
            InitializeComponent();
        }

        private void rbtn_todo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbtn_todo.Checked)
            {
                //abre la base de datos
                ECU_ConexionPostgres.coneccion.Open();
                //llamar el procedimiento almacenadoa
                string SQL = "select * from Pro_Con_Mat_Todo();";
                // Ejecuta el comando
                NpgsqlDataAdapter comando = new NpgsqlDataAdapter(SQL, ECU_ConexionPostgres.coneccion);
                DataSet ds = new DataSet();
                //agrega los datos a una tabla
                comando.Fill(ds);
                g_datos.DataSource = ds.Tables[0];
                //cierra la coneccion
                ECU_ConexionPostgres.coneccion.Close();
            }
            if (txt_cedula.Enabled&& txt_cedula.Text!="")
            {
                //abre la base de datos
                ECU_ConexionPostgres.coneccion.Open();
                //llamar el procedimiento almacenadoa
                string SQL = "select * from Pro_Con_Matr_Cedu('"+txt_cedula.Text+"');;";
                // Ejecuta el comando
                NpgsqlDataAdapter comando = new NpgsqlDataAdapter(SQL, ECU_ConexionPostgres.coneccion);
                DataSet ds = new DataSet();
                //agrega los datos a una tabla
                comando.Fill(ds);
                g_datos.DataSource = ds.Tables[0];
                //cierra la coneccion
                ECU_ConexionPostgres.coneccion.Close();
                
            }
            if (txt_nombreEstud.Enabled && txt_nombreEstud.Text != "")
            {
               
                 //abre la base de datos
                ECU_ConexionPostgres.coneccion.Open();
                //llamar el procedimiento almacenadoa
                string SQL = " select * from Pro_Con_Matr_Nomb('"+ txt_nombreEstud.Text + "');";
                // Ejecuta el comando
                NpgsqlDataAdapter comando = new NpgsqlDataAdapter(SQL, ECU_ConexionPostgres.coneccion);
                DataSet ds = new DataSet();
                //agrega los datos a una tabla
                comando.Fill(ds);
                g_datos.DataSource = ds.Tables[0];
                //cierra la coneccion
                ECU_ConexionPostgres.coneccion.Close();
            }
            if (txt_numMatricula.Enabled&& txt_numMatricula.Text!="")
            {
                //abre la base de datos
                ECU_ConexionPostgres.coneccion.Open();
                //llamar el procedimiento almacenadoa
                string SQL = "select * from Pro_Con_Matr_Num(" + txt_numMatricula.Text + ");";
                // Ejecuta el comando
                NpgsqlDataAdapter comando = new NpgsqlDataAdapter(SQL, ECU_ConexionPostgres.coneccion);
                DataSet ds = new DataSet();
                //agrega los datos a una tabla
                comando.Fill(ds);
                g_datos.DataSource = ds.Tables[0];
                //cierra la coneccion
                ECU_ConexionPostgres.coneccion.Close();

            }
             

        }

        private void rbtn_numCedula_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_numCedula.Checked)
            {
                txt_nombreEstud.Text = "";
                txt_numMatricula.Text = "";
                txt_numMatricula.Enabled = false;
                txt_nombreEstud.Enabled = false;
                txt_cedula.Enabled = true;
                
            }
        }

        private void rbtn_numMatricula_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_numMatricula.Checked)
            {
                txt_cedula.Text = "";
                txt_nombreEstud.Text = "";
                txt_cedula.Enabled = false;
                txt_nombreEstud.Enabled = false;
                txt_numMatricula.Enabled = true;
                

            }
        }

        private void rbtn_nomEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_nomEstudiante.Checked)
            {
                txt_cedula.Text = "";
                txt_numMatricula.Text = "";
                txt_nombreEstud.Enabled = true;
                txt_numMatricula.Enabled = false;
                txt_cedula.Enabled = false;
            }
        }

    }
}
