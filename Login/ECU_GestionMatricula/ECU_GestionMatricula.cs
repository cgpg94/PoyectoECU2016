using Npgsql;
using ProyectoECU.ECU_Concexion;
using ProyectoECU.Interfaces;
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
        public static int ModificarRegistro = 0;
        public static object id_persona;
        public static object id_curso;
        public static object codi_matri;
        public static object fecha_matricula;
        ECU_GestionEstudiante.Validaciones valida = new ECU_GestionEstudiante.Validaciones();

        public ECU_GestionMatricula()
        {
            InitializeComponent();
            this.cargar_combos();
            txt_Cedula.Focus();
        }



        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            buscarEstudiante(txt_Cedula.Text);

        }



        //metodo buscar estudiante
        public void buscarEstudiante(string cedula)
        {
            if (cedula.Equals(""))
            {
                MessageBox.Show("Ingresar cédula para evaluar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    //abrir la conexion
                    ECU_ConexionPostgres.coneccion.Open();
                    //consulta de usuario
                    NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM Pro_Con_Per_Est_Cedula_2 ('" + cedula + "')", ECU_ConexionPostgres.coneccion);
                    //ejecutar comando
                    NpgsqlDataReader resultado = comando.ExecuteReader();

                    if (resultado.Read())
                    {   //resultado de la consulta
                        id_persona = resultado[0];
                        object ced_Est = resultado[1];
                        object nomb_estu = resultado[2];
                        object apel_estu = resultado[3];
                        object fech_naci = resultado[4];
                        object direc_estu = resultado[5];
                        object telef_estu = resultado[6];
                        object tip_sangre_estu = resultado[7];
                        //compara resultado con el dato ingresado
                        if (ced_Est.Equals(cedula))
                        {
                            //mensaje de dialogo
                            DialogResult respuesta = MessageBox.Show("El estudiante ya existe, ¿Desea modificarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            //si es si entonces llena los texbox
                            if (respuesta == DialogResult.Yes)
                            {
                                //si es si entonces llena los texbox
                                txt_nombre.Text = nomb_estu.ToString();
                                txtApellido.Text = apel_estu.ToString();
                                dateP_fecha_nacim.Text = fech_naci.ToString();
                                txt_telefono.Text = telef_estu.ToString();
                                comb_tip_sangre.SelectedIndex = Int32.Parse(tip_sangre_estu.ToString());
                                txt_direcion.Text = direc_estu.ToString();
                                this.activarControles();
                                ModificarRegistro = 1;
                            }
                            else if (respuesta == DialogResult.No)
                            {
                                //si es si entonces llena los texbox
                                txt_nombre.Text = nomb_estu.ToString();
                                txtApellido.Text = apel_estu.ToString();
                                datePFecha.Text = fech_naci.ToString();
                                txt_telefono.Text = telef_estu.ToString();
                                comb_tip_sangre.SelectedIndex = Int32.Parse(tip_sangre_estu.ToString());
                                txt_direcion.Text = direc_estu.ToString();
                                this.activarControles();
                                ModificarRegistro = 2;
                                txt_nombre.Enabled = false;
                                txtApellido.Enabled = false;
                                dateP_fecha_nacim.Enabled = false;
                                txt_telefono.Enabled = false;
                                comb_tip_sangre.Enabled = false;
                                txt_direcion.Enabled = false;
                            }
                            ECU_ConexionPostgres.coneccion.Close();
                        }
                        ECU_ConexionPostgres.coneccion.Close();
                    }
                    else
                    {
                        this.activarControles();
                        this.reiniciarControles();
                        //mensaje de dialogo
                        DialogResult respuesta = MessageBox.Show("El estudiante no se encuentra registrado, ¿Desea agregar uno nuevo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        //si es si entonces llena los texbox
                        if (respuesta == DialogResult.Yes)
                        {
                            ECU_ConexionPostgres.coneccion.Close();
                            Interfaces.ECU_GestionEstudiante EC = new Interfaces.ECU_GestionEstudiante();
                            EC.ShowDialog();

                        }

                        ECU_ConexionPostgres.coneccion.Close();
                    }
                    ECU_ConexionPostgres.coneccion.Close();

                }
                catch (Exception)
                {

                    throw;
                }
            }


        }
        //desactiva los controles
        public void desactivarcontroles()
        {

            txt_nombre.Enabled = false;
            txtApellido.Enabled = false;
            dateP_fecha_nacim.Enabled = false;
            txt_telefono.Enabled = false;
            comb_tip_sangre.Enabled = false;
            txt_direcion.Enabled = false;
            txt_horario_cur.Enabled = false;
            txt_prec_curso.Enabled = false;
            txt_tipo_lic.Enabled = false;
            txx_precio_Matri.Enabled = false;
            comb_Cod_Curso.Enabled = false;
            comb_Instructor.Enabled = false;
            datePFecha.Enabled = false;
            btn_guardar.Enabled = false;


        }

        //activa los controles 
        public void activarControles()
        {
            txt_nombre.Enabled = true;
            txtApellido.Enabled = true;
            dateP_fecha_nacim.Enabled = true;
            txt_telefono.Enabled = true;
            comb_tip_sangre.Enabled = true;
            txt_direcion.Enabled = true;
            txt_prec_curso.Enabled = true;
            txx_precio_Matri.Enabled = true;
            comb_Cod_Curso.Enabled = true;
            comb_Instructor.Enabled = true;
            datePFecha.Enabled = true;
            comb_Instructor.Enabled = true;
        }

        public void reiniciarControles()
        {
            txt_Cedula.Text = "";
            txt_nombre.Text = "";
            txtApellido.Text = "";
            dateP_fecha_nacim.Value = DateTime.Now;
            txt_telefono.Text = "";
            comb_tip_sangre.SelectedValue = 1;
            comb_Cod_Curso.SelectedValue = 1;
            txt_tipo_lic.Text = "";
            txt_horario_cur.Text = "";
            comb_Instructor.SelectedValue = 1;
            txt_prec_curso.Text = "";
            txt_prec_curso.Text = "";
            datePFecha.Value = DateTime.Now;
            txt_direcion.Text = "";
            txt_codMatri.Text = "";
            txx_precio_Matri.Text = "";
            txt_Cedula.Focus();
        }
        public void cargar_combos()
        {
            //abrir la conexion
            ECU_ConexionPostgres.coneccion.Open();
            //consulta de usuario
            NpgsqlDataAdapter comando1 = new NpgsqlDataAdapter("select id_tsa, des_tsa from public.TMAETSAECU;", ECU_ConexionPostgres.coneccion);
            //código para llenar el comboBox
            DataSet dsTipoSan = new DataSet();
            //agrega los datos a una tabla
            comando1.Fill(dsTipoSan);
            //cierra la coneccion
            comb_tip_sangre.DataSource = dsTipoSan.Tables[0];
            comb_tip_sangre.DisplayMember = "des_tsa";
            comb_tip_sangre.ValueMember = "id_tsa";
            ECU_ConexionPostgres.coneccion.Close();

            //abrir la conexion
            ECU_ConexionPostgres.coneccion.Open();
            //consulta de usuario
            NpgsqlDataAdapter comando2 = new NpgsqlDataAdapter("SELECT  id_cur, cod_cur FROM TMAECURECU", ECU_ConexionPostgres.coneccion);
            //código para llenar el comboBox
            DataSet dsCurso = new DataSet();
            //agrega los datos a una tabla
            comando2.Fill(dsCurso);
            //cierra la coneccion
            comb_Cod_Curso.DataSource = dsCurso.Tables[0];
            comb_Cod_Curso.DisplayMember = "cod_cur";
            comb_Cod_Curso.ValueMember = "id_cur";
            ECU_ConexionPostgres.coneccion.Close();


            //abrir la conexion
            ECU_ConexionPostgres.coneccion.Open();
            //consulta de usuario
            NpgsqlDataAdapter comando3 = new NpgsqlDataAdapter("select * from Pro_Con_Per_Ins_Cedula_Nombres();", ECU_ConexionPostgres.coneccion);
            //código para llenar el comboBox
            DataSet dsIntructor = new DataSet();
            //agrega los datos a una tabla
            comando3.Fill(dsIntructor);
            //cierra la coneccion
            comb_Instructor.DataSource = dsIntructor.Tables[0];
            comb_Instructor.ValueMember = "id_instruc";
            comb_Instructor.DisplayMember = "nom_instruc";

            ECU_ConexionPostgres.coneccion.Close();
        }
        private void btn_nuevoBarra_Click(object sender, EventArgs e)
        {
            //mensaje de dialogo
            DialogResult respuesta = MessageBox.Show("Desea agregar un nuevo registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //si es si entonces llena los texbox
            if (respuesta == DialogResult.Yes)
            {

                this.reiniciarControles();
                this.desactivarcontroles();
                txt_Cedula.Enabled = true;
                btn_guardar.Enabled = true;
                txt_Cedula.Focus();
                btn_guardar.Enabled = false;
            }
        }

        private void comb_Cod_Curso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comb_Cod_Curso.Enabled)
            {
                ECU_ConexionPostgres.coneccion.Close();
                //abrir la conexion
                ECU_ConexionPostgres.coneccion.Open();
                //consulta de usuario
                NpgsqlCommand comando = new NpgsqlCommand("select * from pro_cons_cur(" + comb_Cod_Curso.SelectedValue + ");", ECU_ConexionPostgres.coneccion);
                //ejecutar comando
                NpgsqlDataReader resultado = comando.ExecuteReader();
                if (resultado.Read())
                {   //resultado de la consulta
                    id_curso = resultado[0];
                    object cod_curs = resultado[1];
                    object tipo_licencia = resultado[3];
                    object horario = resultado[5];
                    object fecha_inicio = resultado[6];
                    object fecha_fin = resultado[7];
                    object descripcion_curso = resultado[8];
                    object duracion_curso = resultado[9];
                    object costo_curso = resultado[10];
                    //cierra la conexion
                    ECU_ConexionPostgres.coneccion.Close();
                    //compara resultado con el dato ingresado
                    txt_tipo_lic.Text = tipo_licencia.ToString();
                    txt_horario_cur.Text = horario.ToString();
                    txt_prec_curso.Text = costo_curso.ToString();
                    btn_guardar.Enabled = true;

                }
                ECU_ConexionPostgres.coneccion.Close();

            }

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (ModificarRegistro == 1)
                {
                    if (camposVacios() == false && valida.cedula_valida(txt_Cedula.Text)&& valida.apellido_valido(txtApellido.Text) && valida.nombre_valido(txt_nombre.Text)&& txx_precio_Matri.Text!="")
                    {
                        //abrir la conexion
                        ECU_ConexionPostgres.coneccion.Open();
                        NpgsqlCommand comando1 = new NpgsqlCommand("SELECT Pro_Act_Per_Est_Cedula ('" + txt_Cedula.Text + "', '" + txt_nombre.Text + "', '" + txtApellido.Text + "','" + dateP_fecha_nacim.Value + "','" + txt_direcion.Text + "','" + txt_telefono.Text + "'," + comb_tip_sangre.SelectedValue + ");", ECU_ConexionPostgres.coneccion);
                        //ejecutar comando
                        NpgsqlDataReader resultado1 = comando1.ExecuteReader();
                        ECU_ConexionPostgres.coneccion.Close();


                        //abrir la conexion
                        ECU_ConexionPostgres.coneccion.Open();
                        NpgsqlCommand comando2 = new NpgsqlCommand("select from Pro_Ins_Mat(" + id_persona.ToString() + "," + id_curso.ToString() + "," + comb_Instructor.SelectedValue + "," + txx_precio_Matri.Text + ");", ECU_ConexionPostgres.coneccion);
                        //ejecutar comando
                        NpgsqlDataReader resultado2 = comando2.ExecuteReader();
                        ECU_ConexionPostgres.coneccion.Close();
                        MessageBox.Show("Los datos an sido guardados correctamente");
                        reiniciarControles();
                        desactivarcontroles();
                    }
                    else
                    {
                        MessageBox.Show("Existen campos vacios no se puede guardar", "Aviso", MessageBoxButtons.OK);
                    }
                }

                if (ModificarRegistro == 2)
                {
                    if (camposVacios() == false && txx_precio_Matri.Text!="")
                    {
                        //abrir la conexion
                        ECU_ConexionPostgres.coneccion.Open();
                        NpgsqlCommand comando2 = new NpgsqlCommand("select from Pro_Ins_Mat(" + id_persona.ToString() + "," + id_curso.ToString() + "," + comb_Instructor.SelectedValue + "," + txx_precio_Matri.Text + ");", ECU_ConexionPostgres.coneccion);
                        //ejecutar comando
                        NpgsqlDataReader resultado2 = comando2.ExecuteReader();
                        ECU_ConexionPostgres.coneccion.Close();
                        MessageBox.Show("Los datos an sido guardados correctamente");
                        reiniciarControles();
                        desactivarcontroles();
                    }
                    else
                    {
                        MessageBox.Show("Existen campos vacios no se puede guardar", "Aviso", MessageBoxButtons.OK);
                    }

                }
                if (ModificarRegistro == 3)
                {
                    if (camposVacios() == false)
                    {
                        //abrir la conexion
                        ECU_ConexionPostgres.coneccion.Open();
                        NpgsqlCommand comando2 = new NpgsqlCommand("select from pro_act_mat('" + codi_matri.ToString() + "'," + id_persona.ToString() + "," + id_curso.ToString() + "," + comb_Instructor.SelectedValue + ",'" + fecha_matricula.ToString() + "'," + txx_precio_Matri.Text + ");", ECU_ConexionPostgres.coneccion);
                        //ejecutar comando
                        NpgsqlDataReader resultado2 = comando2.ExecuteReader();
                        ECU_ConexionPostgres.coneccion.Close();
                        MessageBox.Show("Los datos an sido guardados correctamente");
                        reiniciarControles();
                        desactivarcontroles();
                    }
                    else
                    {
                        MessageBox.Show("Existen campos vacios no se puede guardar", "Aviso", MessageBoxButtons.OK);
                    }

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
                ECU_ConexionPostgres.coneccion.Close();
                throw;
            }
        }
        //verifica los campos vacios
        public bool camposVacios()
        {
            bool estado = false;
            if (txt_nombre.Text.Equals(""))
            {
                estado = true;
            }
            if (txtApellido.Text.Equals(""))
            {
                estado = true;
            }
            if (txt_telefono.Text.Equals(""))
            {
                estado = true;
            }
            if (txt_direcion.Equals(""))
            {
                estado = true;
            }
            if (txx_precio_Matri.Equals(""))
            {
                estado = true;
            }
            return estado;
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ECU_ConsultaMatricula consultaMatricula = new ECU_ConsultaMatricula();
            consultaMatricula.ShowDialog();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas Salir?", "Estas Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //buscar por codigo de matricula
        public void buscarMatriCodi()
        {
            try
            {

                //abrir la conexion
                ECU_ConexionPostgres.coneccion.Open();
                //consulta de usuario
                NpgsqlCommand comando = new NpgsqlCommand("select * from Pro_Con_Matr_Num_2('" + txt_codMatri.Text + "');", ECU_ConexionPostgres.coneccion);
                //ejecutar comando
                NpgsqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {   //resultado de la consulta
                    codi_matri = resultado[0];
                    object ced_Est = resultado[1];
                    object nomb_estu = resultado[2];
                    object apel_estu = resultado[3];
                    object fech_nacim_estu = resultado[4];
                    object direcion_estud = resultado[5];
                    object telefono_estu = resultado[6];
                    fecha_matricula = resultado[7];
                    id_curso = resultado[8];
                    object id_instructor = resultado[9];
                    object precio_matricula = resultado[10];
                    object id_tipo_sangre = resultado[11];
                    object cost_curso = resultado[12];
                    object horario_curso = resultado[13];
                    object tip_licen = resultado[14];
                    id_persona = resultado[15];
                    //compara resultado con el dato ingresado
                    if (codi_matri.Equals(txt_codMatri.Text))
                    {
                        //mensaje de dialogo
                        DialogResult respuesta = MessageBox.Show("La matrícula ya existe, ¿Desea modificarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        //si es si entonces llena los texbox
                        if (respuesta == DialogResult.Yes)
                        {
                            ECU_ConexionPostgres.coneccion.Close();
                            txt_Cedula.Text = ced_Est.ToString();
                            txt_nombre.Text = nomb_estu.ToString();
                            txtApellido.Text = apel_estu.ToString();
                            dateP_fecha_nacim.Text = fech_nacim_estu.ToString();
                            txt_direcion.Text = direcion_estud.ToString();
                            txt_telefono.Text = telefono_estu.ToString();
                            comb_tip_sangre.SelectedIndex = Int32.Parse(id_tipo_sangre.ToString());
                            datePFecha.Text = fecha_matricula.ToString();
                            comb_Cod_Curso.SelectedValue = Int32.Parse(id_curso.ToString());
                            comb_Instructor.SelectedValue = Int32.Parse(id_instructor.ToString());
                            txt_prec_curso.Text = cost_curso.ToString();
                            txx_precio_Matri.Text = precio_matricula.ToString();
                            txt_tipo_lic.Text = tip_licen.ToString();
                            txt_horario_cur.Text = horario_curso.ToString();
                            activarControles();
                            ModificarRegistro = 3;
                            btn_guardar.Enabled = true;


                        }
                        else if (respuesta == DialogResult.No)
                        {
                            ECU_ConexionPostgres.coneccion.Close();
                            txt_Cedula.Text = ced_Est.ToString();
                            txt_nombre.Text = nomb_estu.ToString();
                            txtApellido.Text = apel_estu.ToString();
                            dateP_fecha_nacim.Text = fech_nacim_estu.ToString();
                            txt_direcion.Text = direcion_estud.ToString();
                            txt_telefono.Text = telefono_estu.ToString();
                            comb_tip_sangre.SelectedIndex = Int32.Parse(id_tipo_sangre.ToString());
                            datePFecha.Text = fecha_matricula.ToString();
                            comb_Cod_Curso.SelectedValue = Int32.Parse(id_curso.ToString());
                            comb_Instructor.SelectedValue = Int32.Parse(id_instructor.ToString());
                            txt_prec_curso.Text = cost_curso.ToString();
                            txx_precio_Matri.Text = precio_matricula.ToString();
                            txt_tipo_lic.Text = tip_licen.ToString();
                            txt_horario_cur.Text = horario_curso.ToString();
                            desactivarcontroles();
                            btn_guardar.Enabled = false;
                            txt_Cedula.Enabled = false;

                        }

                    }
                }
                else
                {
                    ECU_ConexionPostgres.coneccion.Close();
                    MessageBox.Show("La matricula con cdigo: " + txt_codMatri.Text + " no se encuentra registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }


            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btn_buscarBarra_Click(object sender, EventArgs e)
        {
            this.buscarMatriCodi();

        }

        //BOTTON ELIMINAR
        private void btn_EliminarBarra_Click(object sender, EventArgs e)
        {

            if (txt_codMatri.Text != "")
            {
                try
                {
                    //abrir la conexion
                    ECU_ConexionPostgres.coneccion.Open();
                    NpgsqlCommand comando1 = new NpgsqlCommand("select * from Pro_Con_Matr_Num_2('" + txt_codMatri.Text + "');", ECU_ConexionPostgres.coneccion);
                    //ejecutar comando
                    NpgsqlDataReader resultado = comando1.ExecuteReader();
                    //  ECU_ConexionPostgres.coneccion.Close();
                    if (resultado.Read())
                    {
                        //mensaje de dialogo
                        DialogResult respuesta = MessageBox.Show("Desea eliminar el curso: " + txt_codMatri.Text + "", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        //si es si entonces llena los texbox
                        if (respuesta == DialogResult.Yes)
                        {
                            ECU_ConexionPostgres.coneccion.Close();
                            ECU_ConexionPostgres.coneccion.Open();
                            NpgsqlCommand comando2 = new NpgsqlCommand("SELECT Pro_Eli_Mat_Cod ('" + txt_codMatri.Text + "');", ECU_ConexionPostgres.coneccion);
                            //ejecutar comando
                            NpgsqlDataReader resultado2 = comando2.ExecuteReader();
                            ECU_ConexionPostgres.coneccion.Close();
                            MessageBox.Show("La matrícula  a sido eliminado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reiniciarControles();
                            desactivarcontroles();
                        }


                    }
                    else
                    {
                        MessageBox.Show("La matricula " + txt_codMatri.Text + " no esta registrada, no se puede eliminar ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ECU_ConexionPostgres.coneccion.Close();
                    }
                    ECU_ConexionPostgres.coneccion.Close();
                }
                catch (Exception)
                {
                    ECU_ConexionPostgres.coneccion.Close();
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Ingrese el código para poder eliminar el curso ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProyectoECU.ECU_Ayuda.ECU_Ayuda gestionAyuda = new ProyectoECU.ECU_Ayuda.ECU_Ayuda();//Instanciamos
            gestionAyuda.Show();//Mostramos 
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.soloNumeros(e);
        }

        private void ECU_GestionMatricula_Load(object sender, EventArgs e)
        {

        }
    }
}
