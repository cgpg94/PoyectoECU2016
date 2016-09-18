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
    public partial class ECU_GestionUsuario : Form
    {

        public static int check = 0;
         
        public ECU_GestionUsuario()
        {
            InitializeComponent();
        }

        //CONSULTA DINAMICA AL PRESIONAR TECLA
        private void txtBuscar_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            String Busqueda = txtBuscar.Text;
            ECU_ConexionPostgres.coneccion.Open();

            string SQL = "select id_uss as \"ID\", usi_uss as \"USUARIO \", csi_uss as \"CONTRASENA\", id_tus_uss as \"TIPO\" from TMAEUSSECU where usi_uss like '" + Busqueda + "%';";
            NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(command);

            DataSet ds = new DataSet();
            ada.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];

            ECU_ConexionPostgres.coneccion.Close();
        }

        //METODO AL CARGAR EL FORMULARIO
        private void ECU_GestionUsuario_Load(object sender, EventArgs e)
        {
            //CONSULTA GENERADA AL INICIAR EL FORMULARIO (LLENAR DATAGRID)
            ECU_ConexionPostgres.coneccion.Open();

            string SQL = "select id_uss as \"ID\", usi_uss as \"USUARIO \", csi_uss as \"CONTRASENA\", id_tus_uss as \"TIPO\" from TMAEUSSECU;";
            // Execute command
            NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(command);

            DataSet ds = new DataSet();
            ada.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];
            
            ECU_ConexionPostgres.coneccion.Close();
            

        }

        //ASIGNAR VALORES A RADIO BUTTONS
        private void Admin_Click(object sender, EventArgs e)
        {
            check = 1;
        }
        private void Secretaria_Click(object sender, EventArgs e)
        {
            check = 2;
        }
        private void AdminModi_Click(object sender, EventArgs e)
        {
            check = 1;
        }
        private void SecretariaModi_Click(object sender, EventArgs e)
        {
            check = 2;
        }


        private void brn_guardarBarra_Click(object sender, EventArgs e)
        {
            String Usuario = txtUsuario.Text;
            String Contrasena = txtContrasena.Text;

            String UsuarioModi = txtUsuarioModi.Text;
            String NuevaContrasena = txtNuevaContrasena.Text;
            String ContrasenaModi = txtContrasenaActual.Text;

            //PREGUNTA EN QUE PESTAÑA SE ENCUENTRA
            if (TabControl.SelectedTab == TabControl.TabPages["metroIngresar"])
            {
                //VERIFICA CAMPOS VACIOS
                if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasena.Text))            
                {
                    MessageBox.Show("No ha rellenado todos los campos", "Aviso",MessageBoxButtons.OK);
                } else
                    try
                    {
                        ECU_ConexionPostgres.coneccion.Open();
                        string SQL = "select * from TMAEUSSECU where usi_uss='" + Usuario + "' ";

                        NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
                        NpgsqlDataAdapter ada = new NpgsqlDataAdapter(command);

                        DataSet ds = new DataSet();
                        ada.Fill(ds);
                        dataGrid.DataSource = ds.Tables[0];
                        ECU_ConexionPostgres.coneccion.Close();

                        //SI USUARIO EXISTE NO INGRESA
                        if (dataGrid.RowCount == 2)
                        {
                            MessageBox.Show("Ya existe este usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (dataGrid.RowCount == 1)
                        {

                            string Query = "insert into TMAEUSSECU (id_tus_uss,usi_uss,csi_uss) values (" + check + ",'" + Usuario + "','" + Contrasena + "');";
                            NpgsqlCommand MyCommand2 = new NpgsqlCommand(Query, ECU_ConexionPostgres.coneccion);
                            NpgsqlDataReader MyReader2;
                            ECU_ConexionPostgres.coneccion.Open();
                            MyReader2 = MyCommand2.ExecuteReader();
                            MessageBox.Show("Datos guardados Correctamente");
                            while (MyReader2.Read())
                            {
                            }
                            ECU_ConexionPostgres.coneccion.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        ECU_ConexionPostgres.coneccion.Close();
                    }

            }
            //MODIFICAR USUARIO
            else
            {
                //VERIFICA CAMPOS VACIOS
                if (string.IsNullOrEmpty(txtUsuarioModi.Text) || string.IsNullOrEmpty(txtContrasenaActual.Text)
                    || string.IsNullOrEmpty(txtNuevaContrasena.Text) || !AdministradorModi.Checked || !SecretariaModi.Checked)
                {
                    MessageBox.Show("No ha rellenado todos los campos", "Aviso", MessageBoxButtons.OK);
                }
                else
                    try
                    {
                        string Query = "update TMAEUSSECU set csi_uss='" + NuevaContrasena + "', id_tus_uss='" + check + "' where usi_uss='" + UsuarioModi + "' and csi_uss='" + ContrasenaModi + "';";
                        NpgsqlCommand MyCommand2 = new NpgsqlCommand(Query, ECU_ConexionPostgres.coneccion);
                        NpgsqlDataReader MyReader2;
                        ECU_ConexionPostgres.coneccion.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Datos modificados Correctamente");
                        while (MyReader2.Read())
                        {
                        }
                        ECU_ConexionPostgres.coneccion.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

            }

        }

        //LIMPIAR CAMPOS
        private void btn_nuevoBarra_Click(object sender, EventArgs e)
        {
            if (TabControl.SelectedTab == TabControl.TabPages["metroIngresar"])
            {
                txtUsuario.Clear();
                txtContrasena.Clear();
            }
            else
            {
                txtUsuarioModi.Clear();
                txtNuevaContrasena.Clear();
                txtContrasenaActual.Clear();
            }
        }

        //ELIMINAR USUARIO
        private void btn_eliminarBarra_Click(object sender, EventArgs e)
        {
            String DeleteUsuario = txtUsuario.Text;

            //PREGUNTA EN QUE PESTAÑA (SOLO PUEDE ELIMINAR EN PESTAÑA INSERTAR)
            if (TabControl.SelectedTab == TabControl.TabPages["metroIngresar"])
            {
                //CAMPOS VACIOS
                if (string.IsNullOrEmpty(txtUsuario.Text))
                {
                    MessageBox.Show("No ha se a ingresado el usuario", "Aviso", MessageBoxButtons.OK);
                }
                else
                    //CONFIRMACION
                    if (MessageBox.Show("Seguro que desea eliminar el usuario: " + DeleteUsuario + "?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        //NO SE PUEDE ELIMINAR USUARIO POR DEFECTO
                        if (DeleteUsuario.Equals("admin"))
                        {
                            MessageBox.Show("No se puede eliminar el usuario principal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            ECU_ConexionPostgres.coneccion.Open();
                            string SQL = "select * from TMAEUSSECU where usi_uss='" + DeleteUsuario + "' ";

                            NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
                            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(command);

                            DataSet ds = new DataSet();
                            ada.Fill(ds);
                            dataGrid.DataSource = ds.Tables[0];
                            ECU_ConexionPostgres.coneccion.Close();

                            //SI NO EXISTE NINGUN USUARIO CON ESE NOMBRE NO ELIMINA
                            if (dataGrid.RowCount == 1)
                            {
                                MessageBox.Show("No existe este usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (dataGrid.RowCount == 2)
                            {

                                try
                                {
                                    string Query = "delete from TMAEUSSECU where usi_uss='" + DeleteUsuario + "';";
                                    NpgsqlCommand MyCommand = new NpgsqlCommand(Query, ECU_ConexionPostgres.coneccion);
                                    NpgsqlDataReader MyReader;
                                    ECU_ConexionPostgres.coneccion.Open();
                                    MyReader = MyCommand.ExecuteReader();
                                    MessageBox.Show("Eliminado con Éxito");
                                    while (MyReader.Read())
                                    {
                                    }
                                    ECU_ConexionPostgres.coneccion.Close();
                                }

                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                            }

                        }
                    }

            }
            else
            {
                //NO SE PUEDE ELIMINAR EN PESTAÑA MODIFICAR
                MessageBox.Show("No se puede eliminar en esta pantalla, por favor vuelva a la pestaña insertar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //CONSULTAR AL DAR CLICK EN PLAY
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            String Busqueda = txtBuscar.Text;
            ECU_ConexionPostgres.coneccion.Open();

            string SQL = "select id_uss as \"ID\", usi_uss as \"USUARIO \", csi_uss as \"CONTRASENA\", id_tus_uss as \"TIPO\" from TMAEUSSECU where usi_uss like '" + Busqueda + "%';";
            // Execute command
            NpgsqlCommand command = new NpgsqlCommand(SQL, ECU_ConexionPostgres.coneccion);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(command);
            DataSet ds = new DataSet();
            ada.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];
            ECU_ConexionPostgres.coneccion.Close();
        
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas Salir?", "Estas Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ProyectoECU.ECU_Ayuda.ECU_Ayuda gestionAyuda = new ProyectoECU.ECU_Ayuda.ECU_Ayuda();//Instanciamos
            gestionAyuda.Show();//Mostramos 
        }

    }
}
