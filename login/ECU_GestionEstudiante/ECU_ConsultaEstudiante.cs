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
            string SQL = "SELECT vced_per as Cédula ,vnom_per as Nombre,vape_per as Apellido ,vfn_per as Fecha_nacimiento,vdir_per as dirección, vtel_per as Telefono,vid_tsa_est as Tipo_sangre  FROM Pro_Con_Per_Est_Todo ()";
            // Execute command
            NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(command);
            DataSet ds = new DataSet();
            ada.Fill(ds);
            dgv_estudiante.DataSource = ds.Tables[0];
            ECU_ConexionPostgres.coneccion.Close();
        }

        private void rd_todos_Click(object sender, EventArgs e)
        {
            txt_cedula.Enabled = false;
            txt_nombre.Enabled = false;
        }

        private void rd_cedula_CheckedChanged(object sender, EventArgs e)
        {
            txt_cedula.Enabled = true;
            txt_nombre.Enabled = false;
            txt_cedula.Focus();
        }

        private void rd_nombre_CheckedChanged(object sender, EventArgs e)
        {
            txt_cedula.Enabled = false;
            txt_nombre.Enabled = true;
            txt_nombre.Focus();
        }

        private void btn_salir_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            if (rd_todos.Checked)
            {
                try
                {
                    ECU_ConexionPostgres.coneccion.Open();
                    string SQL = "SELECT vced_per as Cédula ,vnom_per as Nombre,vape_per as Apellido ,vfn_per as Fecha_nacimiento,vdir_per as dirección, vtel_per as Telefono,vid_tsa_est as Tipo_sangre FROM Pro_Con_Per_Est_Todo ()";
                    // Execute command
                    NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
                    NpgsqlDataAdapter ada = new NpgsqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    ada.Fill(ds);
                    if (ds.Tables.Count >= 1)
                    {
                        dgv_estudiante.DataSource = ds.Tables[0];
                        ECU_ConexionPostgres.coneccion.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros", "Aviso", MessageBoxButtons.OK);
                        ECU_ConexionPostgres.coneccion.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Test" + ex);
                    ECU_ConexionPostgres.coneccion.Close();
                }

            }
            else if (rd_cedula.Checked)
            {
                string cedula = txt_cedula.Text;
                if (validar.cedula_valida(cedula) == true)
                {
                    MessageBox.Show("Cédula incorrecta", "Aviso", MessageBoxButtons.OK);

                }
                else
                {
                    try
                    {
                        ECU_ConexionPostgres.coneccion.Open();
                        string SQL = "SELECT vced_per as Cédula ,vnom_per as Nombre,vape_per as Apellido ,vfn_per as Fecha_nacimiento,vdir_per as dirección, vtel_per as Telefono,vid_tsa_est as Tipo_sangre FROM Pro_Con_Per_Est_Cedula ('" + cedula + "');";
                        // Execute command
                        NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
                        NpgsqlDataAdapter ada = new NpgsqlDataAdapter(command);
                        DataSet ds = new DataSet();
                        ada.Fill(ds);
                        if (ds.Tables[0].Rows.Count == 0)
                        {

                            ECU_ConexionPostgres.coneccion.Close();
                            MessageBox.Show("No se encontraron registros con la cédula " + cedula + "", "Aviso", MessageBoxButtons.OK);
                        }
                        else
                        {
                            dgv_estudiante.DataSource = ds.Tables[0];
                            ECU_ConexionPostgres.coneccion.Close();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Test" + ex);
                        ECU_ConexionPostgres.coneccion.Close();
                    }
                }
            }
            else if (rd_nombre.Checked)
            {
                string nombre = txt_nombre.Text;
                if (validar.nombre_valido(nombre) == false)
                {
                    MessageBox.Show("Nombre incorrecto", "Aviso", MessageBoxButtons.OK);

                }
                else
                {
                    try
                    {
                        ECU_ConexionPostgres.coneccion.Open();
                        string SQL = "SELECT vced_per as Cédula ,vnom_per as Nombre,vape_per as Apellido ,vfn_per as Fecha_nacimiento,vdir_per as dirección, vtel_per as Telefono,vid_tsa_est as Tipo_sangre FROM Pro_Con_Per_Est_Nombre ('" + nombre + "');";
                        // Execute command
                        NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
                        NpgsqlDataAdapter ada = new NpgsqlDataAdapter(command);
                        DataSet ds = new DataSet();
                        ada.Fill(ds);
                        if (ds.Tables[0].Rows.Count == 0)
                        {

                            ECU_ConexionPostgres.coneccion.Close();
                            MessageBox.Show("No se encontraron registros con la cédula " + nombre + "", "Aviso", MessageBoxButtons.OK);
                        }
                        else
                        {
                            dgv_estudiante.DataSource = ds.Tables[0];
                            ECU_ConexionPostgres.coneccion.Close();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Test" + ex);
                        ECU_ConexionPostgres.coneccion.Close();
                    }
                }

            }
        }





    }
}
