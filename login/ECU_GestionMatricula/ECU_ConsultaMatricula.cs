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

       

        private void rbtn_numCedula_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_numCedula.Checked)
            {
                txt_nombreEstud.Text = "";
                txt_CodMatricula.Text = "";
                txt_CodMatricula.Enabled = false;
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
                txt_CodMatricula.Enabled = true;
                

            }
        }

        private void rbtn_nomEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_nomEstudiante.Checked)
            {
                txt_cedula.Text = "";
                txt_CodMatricula.Text = "";
                txt_nombreEstud.Enabled = true;
                txt_CodMatricula.Enabled = false;
                txt_cedula.Enabled = false;
            }
        }



        private void txt_CodMatricula_KeyUp(object sender, KeyEventArgs e)
        {
            //abre la base de datos
            ECU_ConexionPostgres.coneccion.Open();
            //llamar el procedimiento almacenadoa
            string SQL = "select * from Pro_Con_Matr_Num('" + txt_CodMatricula.Text + "');";
            // Ejecuta el comando
            NpgsqlDataAdapter comando = new NpgsqlDataAdapter(SQL, ECU_ConexionPostgres.coneccion);
            DataSet ds = new DataSet();
            //agrega los datos a una tabla
            comando.Fill(ds);
            g_datos.DataSource = ds.Tables[0];
            //cierra la coneccion
            ECU_ConexionPostgres.coneccion.Close();

        }

        private void txt_cedula_KeyUp(object sender, KeyEventArgs e)
        {
            //abre la base de datos
            ECU_ConexionPostgres.coneccion.Open();
            //llamar el procedimiento almacenadoa
            string SQL = "select * from Pro_Con_Matr_Cedu('" + txt_cedula.Text + "');;";
            // Ejecuta el comando
            NpgsqlDataAdapter comando = new NpgsqlDataAdapter(SQL, ECU_ConexionPostgres.coneccion);
            DataSet ds = new DataSet();
            //agrega los datos a una tabla
            comando.Fill(ds);
            g_datos.DataSource = ds.Tables[0];
            //cierra la coneccion
            ECU_ConexionPostgres.coneccion.Close();
                

        }

        private void txt_nombreEstud_Click(object sender, EventArgs e)
        {
            //abre la base de datos
            ECU_ConexionPostgres.coneccion.Open();
            //llamar el procedimiento almacenadoa
            string SQL = " select * from Pro_Con_Matr_Nomb('" + txt_nombreEstud.Text + "');";
            // Ejecuta el comando
            NpgsqlDataAdapter comando = new NpgsqlDataAdapter(SQL, ECU_ConexionPostgres.coneccion);
            DataSet ds = new DataSet();
            //agrega los datos a una tabla
            comando.Fill(ds);
            g_datos.DataSource = ds.Tables[0];
            //cierra la coneccion
            ECU_ConexionPostgres.coneccion.Close();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
