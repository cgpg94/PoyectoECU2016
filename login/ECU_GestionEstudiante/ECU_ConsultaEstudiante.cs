using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoECU.ECU_Concexion;
using Npgsql;
using ProyectoECU.Interfaces;

namespace ProyectoECU.ECU_GestionEstudiante
{
    public partial class ECU_ConsultaEstudiante : Form
    {
        Validaciones validar = new Validaciones();
        public ECU_ConsultaEstudiante()
        {
            InitializeComponent();
        }

        private void ECU_ConsultaEstudiante_Load(object sender, EventArgs e)
        {
            ECU_ConexionPostgres.coneccion.Open();
            string SQL = "SELECT vced_per as cedula,vnom_per as nombre,vape_per as apellido ,vfn_per as fecha_nacimiento,vdir_per,vtel_per,vid_tsa_est FROM Pro_Con_Per_Est_Todo ()";
            // Execute command
            NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(command);
            DataSet ds = new DataSet();
            ada.Fill(ds);
            dgv_estudiante.DataSource = ds.Tables[0];
            ECU_ConexionPostgres.coneccion.Close();
        }

        public bool siExiste(string cedula)
        {
            int count = 0;
            // sentencia try catch para verificar los errores
            try
            {
                //abrimos la conexion
                ECU_ConexionPostgres.coneccion.Open();
                //consulta sql para verificar si hay datos
                string SQL = "SELECT Count(*)FROM TMAEPERECU AS PER INNER JOIN TTRAESTECU AS EST ON EST.Id_Per_Est=PER.Id_Per INNER JOIN TMAETSAECU AS TPS ON TPS.Id_TSa=EST.Id_TSa_Est WHERE PER.Ced_Per = '" + cedula + "'";
                // Ejecutamos el comando
                NpgsqlCommand consulta = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
                //variable contador para que al momento de que se ejecute la consulta si devuelve 1 el dato existe si no el dato no existe
                count = Convert.ToInt32(consulta.ExecuteScalar());
                //cerramos conexion
                ECU_ConexionPostgres.coneccion.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show("El error es: " + ec);
            }
            //verificamos si el dato existe
            //si devuelve 1 el dato existe si no el dato no existe
            if (count == 0)
            {
                //el dato no existe
                return false;
            }
            else
            {
                //el dato existe
                return true;
            }
        }


        private void rd_todos_Click(object sender, EventArgs e)
        {
            txt_cedula.Enabled = false;
            txt_nombre.Enabled = false;
            txt_cedula.Text = "";
            txt_nombre.Text = "";
        }

        private void rd_cedula_CheckedChanged(object sender, EventArgs e)
        {
            txt_cedula.Enabled = true;
            txt_nombre.Enabled = false;
            txt_nombre.Text = "";
            txt_cedula.Focus();
        }

        private void rd_nombre_CheckedChanged(object sender, EventArgs e)
        {
            txt_cedula.Enabled = false;
            txt_nombre.Enabled = true;
            txt_cedula.Text = "";
            txt_nombre.Focus();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas Salir?", "Estas Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }   
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (rd_todos.Checked)
            {
                try
                {
                    ECU_ConexionPostgres.coneccion.Open();
                    string SQL = "SELECT vced_per as cedula,vnom_per as nombre,vape_per as apellido ,vfn_per as fecha_nacimiento,vdir_per,vtel_per,vid_tsa_est FROM Pro_Con_Per_Est_Todo ()";
                    // Execute command
                    NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
                    NpgsqlDataAdapter ada = new NpgsqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    ada.Fill(ds);
                    dgv_estudiante.DataSource = ds.Tables[0];
                    ECU_ConexionPostgres.coneccion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Test" + ex);
                    ECU_ConexionPostgres.coneccion.Close();
                }

            }
            else
            {
                if (rd_cedula.Checked)
                {
                    string cedula = txt_cedula.Text;
                    if (validar.cedula_valida(cedula))
                    {
                        if (siExiste(cedula))
                        {
                            try
                            {
                                ECU_ConexionPostgres.coneccion.Open();
                                string SQL = "SELECT vced_per as cedula,vnom_per as nombre,vape_per as apellido ,vfn_per as fecha_nacimiento,vdir_per,vtel_per,vid_tsa_est  FROM Pro_Con_Per_Est_Cedula ('" + cedula + "');";
                                // Execute command
                                NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
                                NpgsqlDataAdapter ada = new NpgsqlDataAdapter(command);
                                DataSet ds = new DataSet();
                                ada.Fill(ds);
                                dgv_estudiante.DataSource = ds.Tables[0];
                                ECU_ConexionPostgres.coneccion.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error" + ex);
                                ECU_ConexionPostgres.coneccion.Close();
                            }

                        }
                        else
                        {
                            MessageBox.Show("No Hay datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un número de cédula válido ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_cedula.Focus();
                    }
                }
                else
                {
                    if (rd_nombre.Checked)
                    {

                        string nombre = txt_nombre.Text;

                        if (validar.nombre_valido(nombre))
                        {
                            try
                            {
                                ECU_ConexionPostgres.coneccion.Open();
                                string SQL = "SELECT vced_per as cedula,vnom_per as nombre,vape_per as apellido ,vfn_per as fecha_nacimiento,vdir_per,vtel_per,vid_tsa_est  FROM Pro_Con_Per_Est_Nombre ('" + nombre + "');";
                                // Execute command
                                NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
                                NpgsqlDataAdapter ada = new NpgsqlDataAdapter(command);
                                DataSet ds = new DataSet();
                                ada.Fill(ds);
                                dgv_estudiante.DataSource = ds.Tables[0];
                                ECU_ConexionPostgres.coneccion.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex);
                                ECU_ConexionPostgres.coneccion.Close();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Ingrese un nombre válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
        }

        private void rd_todos_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
