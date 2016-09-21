using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using ProyectoECU.ECU_Concexion;
using ProyectoECU.Interfaces;
using ProyectoECU.ECU_GestionEstudiante;

namespace ProyectoECU.ECU_GestionInstructor
{
    public partial class ECU_ConsultaInstructor : Form
    {
        Validaciones validar = new Validaciones();
        public ECU_ConsultaInstructor()
        {
            InitializeComponent();
        }

        //click en el boton para salir
        private void btn_salir_Click(object sender, EventArgs e)
        {
            //condicion si el usuario presiona en ok el formulario se cerrara
            if (MessageBox.Show("Estas seguro que deseas Salir?", "Estas Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }   
        }
        //metodo que permite verificar si existe un instructor con un determinado numero de cedula
        public bool siExiste(string cedula)
        {
            int count = 0;
            // sentencia try catch para verificar los errores
            try
            {
                //abrimos la conexion
                ECU_ConexionPostgres.coneccion.Open();
                //consulta sql para verificar si hay datos
                string SQL = "SELECT Count(*) FROM TMAEPERECU AS PER INNER JOIN TTRAINSECU AS INS ON PER.Id_Per=INS.Id_Per_Ins WHERE PER.Ced_Per = '"+cedula+"';";
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


        //evento click que se produce cuando se presiona el radio button todos
        private void rd_todos_Click(object sender, EventArgs e)
        {
            //bloqueamos el txt cedula
            txt_cedula.Enabled = false;
            //bloqueamos el txt nombre
            txt_nombre.Enabled = false;
            //limpiamos los campos de cedula y nombre
            txt_cedula.Text = "";
            txt_nombre.Text = "";
        }

        //evento click que se produce cuando se presiona el radio button cedula
        private void rd_cedula_CheckedChanged(object sender, EventArgs e)
        {
            //habilitamos el txt cedula 
            txt_cedula.Enabled = true;
            txt_nombre.Enabled = false;
            txt_nombre.Text = "";
            //establecemos que el cursor se ponga automatica mente en el txt cedula
            txt_cedula.Focus();
        }

        //evento click que se produce cuando se presiona el radio button nombre
        private void rd_nombre_CheckedChanged(object sender, EventArgs e)
        {
            txt_cedula.Enabled = false;
            txt_nombre.Enabled = true;
            txt_cedula.Text = "";
            txt_nombre.Focus();
        }

        //envento click al boton buscar
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            // condicion si esta presionado el radio buton todos
            if (rd_todos.Checked)
            {
                //sentencia try chat para manejar errores
                try
                {
                    //abrimos la conexion
                    ECU_ConexionPostgres.coneccion.Open();
                    // consulta sql que nos devuelve todos los instructores
                    string SQL = "SELECT vced_per as cedula,vnom_per as nombre,vape_per as apellido ,vfn_per as fecha_nacimiento,vdir_per as direccion ,vtel_per as telefono,vcod_ins as codigo_registro,vfec_ins as fecha_contrato FROM pro_Con_Per_Ins_Todo ()";
                    // ejecutamos el comando
                    NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
                    //adaptador para guardar los datos de la consulta
                    NpgsqlDataAdapter ada = new NpgsqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    ada.Fill(ds);
                    dgv_estudiante.DataSource = ds.Tables[0];
                    //cerramos la conexion
                    ECU_ConexionPostgres.coneccion.Close();
                }
                catch (Exception ex)
                {
                    //devuelve el mensaje de error
                    MessageBox.Show("Test" + ex);
                    //cerramos la conexion
                    ECU_ConexionPostgres.coneccion.Close();
                }

            }
            else
            {
                //condicion si el radio button esta seleccionado
                if (rd_cedula.Checked)
                {
                    //creamos variable cedula 
                    string cedula = txt_cedula.Text;
                    //verificamos si es una cedula valida
                    if (validar.cedula_valida(cedula))
                    {
                        //verificamos si la cedula existe
                        if (siExiste(cedula))
                        {
                            //sentecia para manejar errores
                            try
                            {
                                ECU_ConexionPostgres.coneccion.Open();
                                //sentecia sql que devuelce el instructor por medio de la cedula
                                string SQL = "SELECT vced_per as cedula,vnom_per as nombre,vape_per as apellido ,vfn_per as fecha_nacimiento,vdir_per as direccion ,vtel_per as telefono,vcod_ins as codigo_registro,vfec_ins as fecha_contrato FROM Pro_Con_Per_Ins_Cedula ('" + cedula + "');";
                                // ejecutamos el comando
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
                    //si el radio button nombre esta seleccionado
                    if (rd_nombre.Checked)
                    {
                        //variable nombre
                        string nombre = txt_nombre.Text;

                        //si es un nombre valido
                        if (validar.nombre_valido(nombre))
                        {
                            try
                            {
                                ECU_ConexionPostgres.coneccion.Open();
                                //consulta sql por medio del nombre del instructor
                                string SQL = "SELECT vced_per as cedula,vnom_per as nombre,vape_per as apellido ,vfn_per as fecha_nacimiento,vdir_per as direccion ,vtel_per as telefono,vcod_ins as codigo_registro,vfec_ins as fecha_contrato FROM Pro_Con_Per_Ins_Nombre ('" + nombre + "');";
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
                            MessageBox.Show("Ingrese un número de cedula válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
        }

        //evento on load se ejecuta cuando abrimos el formulario
        private void ECU_ConsultaInstructor_Load(object sender, EventArgs e)
        {
            ECU_ConexionPostgres.coneccion.Open();
            //consulta sql que devuelve a todos los instructores
            string SQL = "SELECT vced_per as cedula,vnom_per as nombre,vape_per as apellido ,vfn_per as fecha_nacimiento,vdir_per as direccion ,vtel_per as telefono,vcod_ins as codigo_registro,vfec_ins as fecha_contrato FROM pro_Con_Per_Ins_Todo ()";
            // Execute command
            NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(command);
            DataSet ds = new DataSet();
            ada.Fill(ds);
            dgv_estudiante.DataSource = ds.Tables[0];
            ECU_ConexionPostgres.coneccion.Close();
        }

   
     /// <summary>
     /// metodo q desactiva u antiva controles
     /// </summary>
     /// <param name="sender"></param>
     /// <param name="e"></param>
        private void rd_todos_CheckedChanged(object sender, EventArgs e)
        {
            txt_cedula.Enabled = false;
            txt_nombre.Enabled = false;
            txt_cedula.Text = "";
            txt_nombre.Text = "";
        }
        /// <summary>
        /// metodo q desactiva u antiva controles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rd_cedula_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_cedula.Enabled = true;
            txt_nombre.Enabled = false;
            txt_nombre.Text = "";
            txt_cedula.Focus();
        }
        /// <summary>
        /// metodo q desactiva u antiva controles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rd_nombre_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_cedula.Enabled = false;
            txt_nombre.Enabled = true;
            txt_cedula.Text = "";
            txt_nombre.Focus();
        }
        /// <summary>
        /// Metodo que se activa cada ves q puslsamos y llama a a un metodo de validacion de numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros(e);
        }
        /// <summary>
        /// Metodo que se activa cada ves q puslsamos y llama a a un metodo de validacion de letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloLetras(e);
        }

      

        
    }
}
