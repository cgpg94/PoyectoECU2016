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
        ProyectoECU.ECU_GestionEstudiante.Validaciones valida = new ProyectoECU.ECU_GestionEstudiante.Validaciones();
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
                txt_cedula.Focus();

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
                txt_CodMatricula.Focus();


            }
        }

        private void rbtn_nomEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_nomEstudiante.Checked)
            {
                txt_cedula.Text = "";
                txt_CodMatricula.Text = "";
                txt_nombreEstud.Enabled = true;
                txt_nombreEstud.Focus();
                txt_CodMatricula.Enabled = false;
                txt_cedula.Enabled = false;

            }
        }









        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            if (txt_CodMatricula.Text != "" && rbtn_numMatricula.Checked)
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
            else
            {

            }

            if (txt_cedula.Text != "" && rbtn_numCedula.Checked && valida.cedula_valida(txt_cedula.Text))
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
            else if (valida.cedula_valida(txt_cedula.Text) == false&& rbtn_numCedula.Checked)
            {
                MessageBox.Show("Cédula ingresada es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (valida.nombre_valido(txt_nombreEstud.Text)&& txt_nombreEstud.Text!=""&& rbtn_nomEstudiante.Checked)
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

            }else if (valida.nombre_valido(txt_nombreEstud.Text)== false && rbtn_nomEstudiante.Checked)
            {
                MessageBox.Show("Nombre ingresado es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }


    }
}
