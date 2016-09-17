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
        public static bool ModificarRegistro = false;
        public static object id_persona;
        public static object id_curso;
        public ECU_GestionMatricula()
        {
            InitializeComponent();
            this.cargar_combos();
        }

        

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            this.buscarEstudiante();
            
        }



        //metodo buscar estudiante
        public void buscarEstudiante()
        {
            if (txt_Cedula.Text.Equals(""))
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
                    NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM Pro_Con_Per_Est_Cedula_2 ('" + txt_Cedula.Text + "')", ECU_ConexionPostgres.coneccion);
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
                        if (ced_Est.Equals(txt_Cedula.Text))
                        {
                            //mensaje de dialogo
                            DialogResult respuesta = MessageBox.Show("El estudiante ya existe,¿Desea modificarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            //si es si entonces llena los texbox
                            if (respuesta == DialogResult.Yes)
                            {
                                //si es si entonces llena los texbox
                                txt_nombre.Text = nomb_estu.ToString();
                                txtApellido.Text = apel_estu.ToString();
                                datePFecha.Text = fech_naci.ToString();
                                txt_telefono.Text = telef_estu.ToString();
                                comb_tip_sangre.SelectedIndex = Int32.Parse(tip_sangre_estu.ToString());
                                txt_direcion.Text = direc_estu.ToString();
                                this.activarControles();
                                ModificarRegistro = true;
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
                                ModificarRegistro = false;
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
                        MessageBox.Show("El estudiante no se encuentra registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            txt_Cedula.Text="";
            txt_nombre.Text="";
            txtApellido.Text = "";
            dateP_fecha_nacim.Value = DateTime.Now;
            txt_telefono.Text = "";
            comb_tip_sangre.SelectedValue= 1;
            comb_Cod_Curso.SelectedValue = 1;
            txt_tipo_lic.Text = "";
            txt_horario_cur.Text = "";
            comb_Instructor.SelectedValue = 1;
            txt_prec_curso.Text = "";
            txt_prec_curso.Text = "";
            datePFecha.Value = DateTime.Now;
            txt_direcion.Text = "";
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
            DialogResult respuesta = MessageBox.Show("Desea agregar un nuevo registro?","Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //si es si entonces llena los texbox
            if (respuesta == DialogResult.Yes)
            {

                this.reiniciarControles();
                this.desactivarcontroles();
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
                NpgsqlCommand comando = new NpgsqlCommand("select * from Pro_cons_Cur(" + comb_Cod_Curso.SelectedValue + ");", ECU_ConexionPostgres.coneccion);
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
                    txt_prec_curso.Text = cod_curs.ToString();
                }
                ECU_ConexionPostgres.coneccion.Close();
                
            }
                   


            
            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (ModificarRegistro == true)
                {
                    if (camposVacios() == false)
                    {
                        //abrir la conexion
                        ECU_ConexionPostgres.coneccion.Open();
                        NpgsqlCommand comando1 = new NpgsqlCommand("SELECT Pro_Act_Per_Est_Cedula ('"+txt_Cedula.Text+"', '"+txt_nombre.Text+"', '"+txtApellido.Text+"','"+dateP_fecha_nacim.Value+"','"+txt_direcion.Text+"','"+txt_telefono.Text+"',"+comb_tip_sangre.SelectedValue+");", ECU_ConexionPostgres.coneccion);
                        //ejecutar comando
                        NpgsqlDataReader resultado1 = comando1.ExecuteReader();
                        ECU_ConexionPostgres.coneccion.Close();


                        //abrir la conexion
                        ECU_ConexionPostgres.coneccion.Open();
                        NpgsqlCommand comando2 = new NpgsqlCommand("select from Pro_Ins_Matri("+id_persona.ToString()+","+id_curso.ToString()+","+comb_Instructor.SelectedValue+",'"+datePFecha.Text+"',"+txx_precio_Matri.Text+");", ECU_ConexionPostgres.coneccion);
                        //ejecutar comando
                        NpgsqlDataReader resultado2 = comando2.ExecuteReader();
                        ECU_ConexionPostgres.coneccion.Close();
                        MessageBox.Show("Los datos an sido guardados correctamente");
                        reiniciarControles();
                        desactivarcontroles();
                    }

                }
                else
                {
                    if (camposVacios() == false)
                    {
                        //abrir la conexion
                        ECU_ConexionPostgres.coneccion.Open();
                        NpgsqlCommand comando2 = new NpgsqlCommand("select from Pro_Ins_Matri(" + id_persona.ToString() + "," + id_curso.ToString() + "," + comb_Instructor.SelectedValue + ",'" + datePFecha.Value + "'," + txx_precio_Matri.Text + ");", ECU_ConexionPostgres.coneccion);
                        //ejecutar comando
                        NpgsqlDataReader resultado2 = comando2.ExecuteReader();
                        ECU_ConexionPostgres.coneccion.Close();
                        MessageBox.Show("Los datos an sido guardados correctamente");
                        reiniciarControles();
                        desactivarcontroles();
                    }


                }


            }
            catch (Exception)
            {
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
    }
}
