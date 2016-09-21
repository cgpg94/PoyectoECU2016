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
using Microsoft.VisualBasic;

namespace ProyectoECU.Interfaces
{
    public partial class ECU_GestionEstudiante : Form
    {

        //Instancia para las validaciones
        Validaciones validar = new Validaciones();

        // variable para que al momento de presionar el boton guardar determine si se inserta o se actualiza
        static int modificar=0;
        public ECU_GestionEstudiante()
        {
            InitializeComponent();
        }
        
        //Boton para abrir ventana de consultar
        private void menu_consultar_Click(object sender, EventArgs e)
        {
            ECU_ConsultaEstudiante consulta = new ECU_ConsultaEstudiante();
            consulta.Show();
        }

        //metodo que bloquea todos los controloes del formulario
        private void bloquear()
        {
            txt_nombre.Enabled = false;
            txt_apellido.Enabled = false;
            dtp_fecha_Nac.Enabled = false;
            txt_direccion.Enabled = false;
            txt_telefono.Enabled = false;
            cbx_tipoSangre.Enabled = false;

        }
        //metodo que desbloquea todos los controloes del formulario
        private void desbloquear()
        {
            txt_nombre.Enabled = true;
            txt_apellido.Enabled = true;
            dtp_fecha_Nac.Enabled = true;
            txt_direccion.Enabled = true;
            txt_telefono.Enabled = true;
            cbx_tipoSangre.Enabled = true;

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
            cbx_tipoSangre.SelectedValue = 1;
        }

        //metodo que llena el combo box del tipo de sangre
        private void cargarTipoSangre()
        {
            cbx_tipoSangre.DisplayMember = "des_tsa";
            cbx_tipoSangre.ValueMember = "id_tsa";           
            //abrimos la conexion
            ECU_ConexionPostgres.coneccion.Open();
            //definimos la consulta sql
            string SQL = "select *from TMAETSAECU";
            // Ejecutamos el comando
            NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(command);
            //creamos un data set
            DataSet ds = new DataSet();
            //agregamos los datos almacenados en el data set al combo box
            ada.Fill(ds);
            cbx_tipoSangre.DataSource = ds.Tables[0];
            //cerramos la conexion
            ECU_ConexionPostgres.coneccion.Close();
        }

        private void bloquearbotones() {
            btn_guardar.Enabled = false;
            btn_eliminar.Enabled = false;
           // btn_buscar.Enabled = false;
            btn_nuevo.Enabled = false;
        }

        private void desbloquear_botones() {
            btn_guardar.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_buscar.Enabled = true;
            btn_nuevo.Enabled = true;
        
        }

       //metodo que on load que se ejecuta al momento que se inicializa la aplicacion
        private void ECU_GestionEstudiante_Load(object sender, EventArgs e)
        {
            bloquearbotones();
            bloquear();
            cargarTipoSangre();
        }

        //metodo que verifica si existe un Estudiante
        public bool siExiste(string cedula){
            int count =0;
            // sentencia try catch para verificar los errores
            try
            {
                //abrimos la conexion
                ECU_ConexionPostgres.coneccion.Open();
                //consulta sql para verificar si hay datos
                string SQL = "SELECT Count(*)FROM TMAEPERECU AS PER INNER JOIN TTRAESTECU AS EST ON EST.Id_Per_Est=PER.Id_Per INNER JOIN TMAETSAECU AS TPS ON TPS.Id_TSa=EST.Id_TSa_Est WHERE PER.Ced_Per = '" + cedula+"'";
                // Ejecutamos el comando
                NpgsqlCommand consulta = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
                //variable contador para que al momento de que se ejecute la consulta si devuelve 1 el dato existe si no el dato no existe
                count = Convert.ToInt32(consulta.ExecuteScalar());
               //cerramos conexion
                ECU_ConexionPostgres.coneccion.Close();
                
            }
            catch (Exception ec)
            {
                MessageBox.Show("El error es: "+ec);
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

       //metodo que llena los text box para modificarde acuerdo a la consulta hecha
        private void cargarModificar(string cedula) {

            try
            {
                //abrimos la conexion
                ECU_ConexionPostgres.coneccion.Open();
                //sentencia sql que devuelve todos los datos de un estudiante por el numero de cedula
                string SQL = "select *from Pro_Con_Per_Est_Cedula('"+cedula+"');";
                // ejecutamos el comando
                NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
                //el resultado del comando que es una consulta sql lo anadimos a un Data reader
                NpgsqlDataReader dr = command.ExecuteReader();
                //verificamos si hay datos
                if (dr.Read())
                {
                    //de acuerdo a la consulta coloca en cada lugar el atributo
                    txt_cedula.Text = dr[0].ToString();
                    txt_nombre.Text = dr[1].ToString();
                    txt_apellido.Text = dr[2].ToString();
                    dtp_fecha_Nac.Text = dr[3].ToString();
                    txt_direccion.Text = dr[4].ToString();
                    txt_telefono.Text = dr[5].ToString();
                    cbx_tipoSangre.Text = dr[6].ToString();
                    txt_cedula.Enabled = false;
                    desbloquear();
                }
                else
                {
                    MessageBox.Show("El estudiante no esta registrado ");
                }
                //cerramos la conexion
                ECU_ConexionPostgres.coneccion.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Error: "+ec);
            }           
        }
        /// <summary>
        /// Metodo de guardar datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //cracion de instancia para validar
            Validaciones valida = new Validaciones();
            //declaramos las variables que vamos a utilizar el los tex boxes
            string cedula = txt_cedula.Text;
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            string fecha = dtp_fecha_Nac.Text;
            string direccion = txt_direccion.Text;
            string telefono = txt_telefono.Text.Trim();
            int tipo = Convert.ToInt32(cbx_tipoSangre.SelectedValue);

            //validar si hay campos vacios al insertar
            if ((txt_nombre.Text == "") && (txt_apellido.Text == "") && (txt_direccion.Text == "") && (txt_telefono.Text == ""))
            {
                MessageBox.Show("Faltan Campos por llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);          
            }
            else {
                if (valida.cedula_valida(cedula) && valida.nombre_valido(nombre) && valida.apellido_valido(apellido) && valida.validar_celu(telefono))
                {
                    //preguntamos por medio de la variable de control modificar
                    if (modificar == 0)
                    {
                        try
                        {
                            ECU_ConexionPostgres.coneccion.Open();
                            string SQL = "SELECT Pro_Ins_Per_Est ('" + cedula + "', '" + nombre + "', '" + apellido + "','" + fecha + "','" + direccion + "','" + telefono + "'," + tipo + ")";
                            // Execute command
                            NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
                            int contador = command.ExecuteNonQuery();
                            ECU_ConexionPostgres.coneccion.Close();
                            if (contador == -1)
                            {
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
                        bloquearbotones();
                    }
                    else
                    {

                        try
                        {
                            ECU_ConexionPostgres.coneccion.Open();
                            string SQL = "SELECT Pro_Act_Per_Est_Cedula ('" + cedula + "', '" + nombre + "', '" + apellido + "','" + fecha + "','" + direccion + "','" + telefono + "'," + tipo + ")";
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
                else {
                    MessageBox.Show("Campos Incorrectos", "No se puede guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);     
                }    
           } 
        }


       /// <summary>
        ///  //boton eliminar
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            //verificamos si la cedula no esta vacia
            if (txt_cedula.Text != "")
            {
                //prefuntamos si deseamos eliminar el Estudiante
                if (MessageBox.Show("Desea eliminar el Estudiante?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        ECU_ConexionPostgres.coneccion.Open();
                        string SQL = "SELECT Pro_Eli_Per_Est_Ced('"+txt_cedula.Text+"')";
                        // Execute command
                        NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
                        int contador = command.ExecuteNonQuery();
                        ECU_ConexionPostgres.coneccion.Close();
                        MessageBox.Show("Eliminado Correctamente", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        desbloquear_verificar();
                        bloquear();
                        limpiar();
                        txt_cedula.Focus();
                    }
                    catch (Exception ec)
                    {
                        MessageBox.Show(""+ec);
                        ECU_ConexionPostgres.coneccion.Close();
                    }
                }
            }
            else {
                MessageBox.Show("Ingrese el número de cédula a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }     
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btn_verificar_Click(object sender, EventArgs e)
        {
            Validaciones valida = new Validaciones();
            string cedula = txt_cedula.Text;
            if (valida.cedula_valida(cedula))
            {
                if (siExiste(cedula))
                {
                    if (MessageBox.Show("El Estudiante ya existe, desea Modificarlo ? ", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    MessageBox.Show("El estudiante no existe ahora procedera a insertar uno nuevo", "Nuevo Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_cedula.Enabled = false;
                    btn_verificar.Enabled = false;
                    desbloquear();
                    txt_nombre.Focus();
                    desbloquear_botones();
                    btn_eliminar.Enabled = false;
                }
            }
            else {
                MessageBox.Show("Debe insertar un número de cédula valido", "Campo Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cedula.Focus();
            }       
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="promptText"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string cedula = "";
            if (InputBox("Consulta cedula", "Ingrese el número de cedula:", ref cedula) == DialogResult.OK)
            {
                if (validar.cedula_valida(cedula))
                {
                    if (siExiste(cedula))
                    {
                        if (MessageBox.Show("El Estudiante ya existe, desea Modificarlo ", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            desbloquear_botones();
                            cargarModificar(cedula);
                            modificar = 1;
                            txt_cedula.Enabled = true;
                            btn_verificar.Enabled = false;
                        }
                        else
                        {
                            
                            desbloquear_verificar();
                            limpiar();
                            txt_cedula.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("El estudiante no existe ahora procedera a insertar uno nuevo", "Nuevo Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        btn_verificar.Enabled = false;
                        desbloquear();
                        txt_cedula.Focus();
                        desbloquear_botones();
                        btn_eliminar.Enabled = false;
                        txt_cedula.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Debe insertar un número de cédula valido", "Campo Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_cedula.Focus();
                }      
                //cargarModificar(cedula);
               
            }
        }
        
      
        /// <summary>
        /// prara borrar todos los datos del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            modificar = 0;
            btn_verificar.Enabled = true;
            txt_cedula.Enabled = true;
            limpiar();
            bloquear();
            bloquearbotones();
            txt_cedula.Focus();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Estas seguro que deseas Salir?", "Estas Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             {
                 this.Close();
             }                    
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ECU_GestionEstudiante_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros(e);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {

            validar.soloNumeros(e);
        
        }
        /// <summary>
        /// pARA VALIDAR SI ES MAYOR DE EDAD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtp_fecha_Nac_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_fecha_Nac.Value.AddYears(18) > DateTime.Today)
            {
                MessageBox.Show("Error, tiene que ser persona mayor a 18 años", "Se requiere persona mayor de edad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// valida cedula solo numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros(e);
        }         
    }
}
