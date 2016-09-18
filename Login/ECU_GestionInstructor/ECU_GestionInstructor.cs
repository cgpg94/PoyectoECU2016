using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoECU.ECU_GestionEstudiante;
using ProyectoECU.ECU_Concexion;
using Npgsql;


namespace ProyectoECU.Interfaces
{
    public partial class ECU_GestionInstructor : Form
    {
        // variable para que al momento de presionar el boton guardar determine si se inserta o se actualiza
        static int modificar = 0;
        public ECU_GestionInstructor()
        {
            InitializeComponent();
        }

        //metodo que bloquea todos los controloes del formulario
        private void bloquear()
        {
            txt_nombre.Enabled = false;
            txt_apellido.Enabled = false;
            dtp_fecha_Nac.Enabled = false;
            txt_direccion.Enabled = false;
            txt_telefono.Enabled = false;
            dtp_fecha_contrato.Enabled = false;
        }
        //metodo que desbloquea todos los controloes del formulario
        private void desbloquear()
        {
            txt_nombre.Enabled = true;
            txt_apellido.Enabled = true;
            dtp_fecha_Nac.Enabled = true;
            txt_direccion.Enabled = true;
            txt_telefono.Enabled = true;
            dtp_fecha_contrato.Enabled = true;
        }   

        //Metodo que desbloquea la cedula y el boton verificar
        private void desbloquear_verificar()
        {
            txt_cedula.Enabled = true;
            btn_verificar.Enabled = true;
        }

        //Metodo que limpia las cajas de texto
        private void limpiar()
        {
            txt_cedula.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            dtp_fecha_Nac.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
            txt_codigo.Text = "";
        }


        //metodo que verifica si existe un Estudiante
        private bool siExiste(string cedula)
        {
            int count = 0;
            // sentencia try catch para verificar los errores
            try
            {
                //abrimos la conexion
                ECU_ConexionPostgres.coneccion.Open();
                //consulta sql para verificar si hay datos
                string SQL = "SELECT COUNT(*) FROM TMAEPERECU AS PER INNER JOIN TTRAINSECU AS INS ON INS.Id_Per_Ins=PER.Id_Per WHERE PER.Ced_Per = '" + cedula + "'";
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

        
        private void bloquearbotones() {
            btn_guardar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_buscar.Enabled = false;
            btn_nuevo.Enabled = false;
        }

        private void desbloquear_botones() {
            btn_guardar.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_buscar.Enabled = true;
            btn_nuevo.Enabled = true;
        
        }


        //metodo que llena los text box para modificarde acuerdo a la consulta hecha
        private void cargarModificar(string cedula)
        {
            try
            {
                //abrimos la conexion
                ECU_ConexionPostgres.coneccion.Open();
                //sentencia sql que devuelve todos los datos de un instructo por el numero de cedula
                string SQL = "SELECT * FROM Pro_Con_Per_Ins_Cedula ('" + cedula + "');";
                // ejecutamos el comando
                NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
                //el resultado del comando que es una consulta sql lo anadimos a un Data reader
                NpgsqlDataReader dr = command.ExecuteReader();
                //verificamos si hay datos
                if (dr.Read())
                {
                    //de acuerdo a la consulta coloca en cada lugar el atributo
                    txt_nombre.Text = dr[1].ToString();
                    txt_codigo.Text = dr[6].ToString();
                    txt_apellido.Text = dr[2].ToString();
                    dtp_fecha_Nac.Text = dr[3].ToString();
                    txt_direccion.Text = dr[4].ToString();
                    txt_telefono.Text = dr[5].ToString();
                    txt_cedula.Enabled = false;
                    desbloquear();
                }
                else
                {
                    MessageBox.Show("No hay nada que mostrar");
                }
                //cerramos la conexion
                ECU_ConexionPostgres.coneccion.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Error: " + ec);
            }
        }




        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mostrarMensajeGuardado(string cedula) {

            string nombre, apellido, codigo;
            
            ECU_ConexionPostgres.coneccion.Open();
            string SQL = "SELECT nom_per, ape_per,cod_ins FROM TMAEPERECU AS PER INNER JOIN TTRAINSECU AS INS ON INS.Id_Per_Ins=PER.Id_Per WHERE PER.Ced_Per = '"+cedula+"';";
            // Execute command
            NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
            //el resultado del comando que es una consulta sql lo anadimos a un Data reader
            NpgsqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                //de acuerdo a la consulta coloca en cada lugar el atributo
                nombre = dr[0].ToString();
                apellido = dr[1].ToString();
                codigo = dr[2].ToString();
                MessageBox.Show("El Instructor "+nombre+" "+apellido+" fue guardado correctamente con el codigo "+codigo , "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay nada que mostrar");
            }
            ECU_ConexionPostgres.coneccion.Close();    
                        
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //cracion de instancia para validar
            Validaciones valida = new Validaciones();
            //declaramos las variables que vamos a utilizar el los tex boxes
            string cedula = txt_cedula.Text;
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            string fecha = dtp_fecha_Nac.Text;
            string direccion = txt_direccion.Text;
            string telefono = txt_telefono.Text;
            string fecha_contrato = dtp_fecha_contrato.Text;
           
            //validar si hay campos vacios al insertar
            if ((txt_nombre.Text == "") && (txt_apellido.Text == "") && (txt_direccion.Text == "") && (txt_telefono.Text == ""))
            {
                MessageBox.Show("Faltan Campos por llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (valida.cedula_valida(cedula) && valida.nombre_valido(nombre) && valida.apellido_valido(apellido) && valida.validar_celu(telefono))
                {
                    //preguntamos por medio de la variable de control modificar
                    if (modificar == 0)
                    {
                        try
                        {
                            ECU_ConexionPostgres.coneccion.Open();
                            string SQL = "SELECT Pro_Ins_Per_Ins ('" + cedula + "', '" + nombre + "', '" + apellido + "','" + fecha + "','" + direccion + "','" + telefono + "','" + fecha_contrato + "')";
                            // Execute command
                            NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
                            int contador = command.ExecuteNonQuery();
                            ECU_ConexionPostgres.coneccion.Close();
                            if (contador == -1)
                            {
                                mostrarMensajeGuardado(cedula);
                                MessageBox.Show("Datos guardados correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                desbloquear_verificar();
                            }
                            else
                            {
                                MessageBox.Show("Error al insertar el usuario");
                            }
                        }
                        catch (Exception ec)
                        {
                            MessageBox.Show("Error" + ec);
                            ECU_ConexionPostgres.coneccion.Close();
                        }
                        limpiar();
                        bloquear();
                    }
                    else
                    {

                        try
                        {
                            ECU_ConexionPostgres.coneccion.Open();
                            string SQL = "select *from Pro_Act_Per_Ins_Cedula('" + cedula + "', '" + nombre + "', '" + apellido + "','" + fecha + "','" + direccion + "','" + telefono + "','" + fecha_contrato + "')";
                            // Execute command
                            NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
                            int contador = command.ExecuteNonQuery();
                            ECU_ConexionPostgres.coneccion.Close();
                            if (contador == -1)
                            {
                                MessageBox.Show("Datos actualizados correctamente", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                desbloquear_verificar();
                                bloquear();
                                limpiar();
                                txt_cedula.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Error al actualizar el usuario");
                            }
                        }
                        catch (Exception ec)
                        {
                            MessageBox.Show("El error es: " + ec);
                            ECU_ConexionPostgres.coneccion.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nope", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombre_Click(object sender, EventArgs e)
        {

        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            Validaciones valida = new Validaciones();
            string cedula = txt_cedula.Text;
            if (valida.cedula_valida(cedula))
            {
                if (siExiste(cedula))
                {
                    if (MessageBox.Show("El Intructor ya existe, desea Modificarlo ", "Actualizar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        desbloquear_botones();
                        cargarModificar(cedula);
                        modificar = 1;
                        txt_cedula.Enabled = false;
                        btn_verificar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un nuevo número de cédula", "Nuevo Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        desbloquear_verificar();
                        limpiar();
                        txt_cedula.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("El instructor no existe ahora procedera a insertar uno nuevo", "Nuevo Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_cedula.Enabled = false;
                    btn_verificar.Enabled = false;
                    desbloquear();
                    txt_nombre.Focus();
                    desbloquear_botones();
                    btn_eliminar.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Debe insertar un numero de cedula valido", "Campo Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cedula.Focus();
            }
        }

        private void ECU_GestionInstructor_Load(object sender, EventArgs e)
        {
            bloquearbotones();
            bloquear();
            btn_buscar.Enabled = true;

        }


        private static DialogResult mostrardialogo(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.MaximizeBox = false;
            inputBox.MinimizeBox = false;
            inputBox.StartPosition = FormStartPosition.CenterParent;
            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Buscar Estudiante";

            System.Windows.Forms.Label label = new Label();
            label.Text = "Cedula";
            label.Size = new System.Drawing.Size(50, 23);
            label.Location = new System.Drawing.Point(10, 10);
            inputBox.Controls.Add(label);


            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.MaxLength = 10;
            //tamano del tex box
            textBox.Size = new System.Drawing.Size(100, 23);
            //localizacion del tex box en el formulario
            textBox.Location = new System.Drawing.Point(60, 7);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "btn_aceptar";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&Aceptar";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);
            //okButton.Click += new EventHandler(this.okButton_Click);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "btn_cancelar";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancelar";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            /*inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;*/

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string cedula = txt_cedula.Text;
            mostrardialogo(ref cedula);

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            modificar = 0;
            btn_verificar.Enabled = true;
            txt_cedula.Enabled = true;
            limpiar();
            bloquear();
            bloquearbotones();
            txt_cedula.Focus();
            btn_buscar.Enabled = true;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas Salir?", "Estas Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }  
        }
    }
}
