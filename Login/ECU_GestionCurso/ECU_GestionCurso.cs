using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using ProyectoECU.ECU_Concexion;
using Npgsql;

namespace ProyectoECU.Interfaces
{
    public partial class ECU_GestionCurso : Form
    {

        public static bool ModificarRegistro = false;
        public static object id_curo_Modificar = 0;
        /// <summary>
        /// PARA INICIALIZAR COMPINENTES DEL FORM
        /// </summary>
        public ECU_GestionCurso()
        {
            InitializeComponent();
            this.cargar_combos();
            txt_Duracion_curso.Enabled = false;
            txt_Duracion_curso.Text = (MonthDifference(datetime_fecha_fin.Value, datetime_fecha_inic.Value)).ToString() + " Meses";
        }


        /// <summary>
        /// METODO PARA LLAMAR EL FORMULARIO CONSULTA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ECU_ConsultaCurso consultaCurso = new ECU_ConsultaCurso();
            consultaCurso.ShowDialog();
        }
        /// <summary>
        /// METODO BUSCAR CURSO POR CODIGO DE CURSO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txt_codCur.Text.Equals(""))
            {
                MessageBox.Show("Ingresar código para evaluar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    //abrir la conexion
                    ECU_ConexionPostgres.coneccion.Open();
                    //consulta de usuario
                    NpgsqlCommand comando = new NpgsqlCommand("select * from pro_cons_cur_codi('" + txt_codCur.Text + "');", ECU_ConexionPostgres.coneccion);

                    //ejecutar comando
                    NpgsqlDataReader resultado = comando.ExecuteReader();
                    if (resultado.Read())
                    {   //resultado de la consulta
                        id_curo_Modificar = resultado[0];
                        object cod_curs = resultado[1];
                        object id_tipo_licencia = resultado[2];
                        object tipo_licencia = resultado[3];
                        object id_horario = resultado[4];
                        object horario = resultado[5];
                        object fecha_inicio = resultado[6];
                        object fecha_fin = resultado[7];
                        object descripcion_curso = resultado[8];
                        object duracion_curso = resultado[9];
                        object costo_curso = resultado[10];
                        //cierra la conexion
                        ECU_ConexionPostgres.coneccion.Close();
                        //compara resultado con el dato ingresado
                        if (cod_curs.ToString() == txt_codCur.Text)
                        {

                            //mensaje de dialogo
                            DialogResult respuesta = MessageBox.Show("El curso ya existe,¿Desea modificarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            //si es si entonces llena los texbox
                            if (respuesta == DialogResult.Yes)
                            {
                                //llena los valores del cuaro en el formulario
                                comb_tipLic.SelectedValue = id_tipo_licencia.ToString();
                                comb_tipHor.SelectedValue = id_horario.ToString();
                                datetime_fecha_inic.Text = fecha_inicio.ToString();
                                datetime_fecha_fin.Text = fecha_fin.ToString();
                                txt_descrp_curso.Text = descripcion_curso.ToString();
                                txt_Duracion_curso.Text = duracion_curso.ToString();
                                txt_costo.Text = costo_curso.ToString();

                                activarControles();
                                ModificarRegistro = true;
                            }

                            else if (respuesta == DialogResult.No)
                            {
                                desactivarcontroles();
                                ModificarRegistro = false;
                            }

                            ECU_ConexionPostgres.coneccion.Close();
                        }

                        ECU_ConexionPostgres.coneccion.Close();
                    }

                    else
                    {
                        MessageBox.Show("El curso no se encuentra registrado, proceda a ingresar los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_codCur.Text = "";
                        txt_codCur.Enabled = false;
                        activarControles();
                        ECU_ConexionPostgres.coneccion.Close();
                    }


                }
                catch (Exception ddd)
                {
                    MessageBox.Show("2" + ddd);
                    throw;
                }

            }


        }


        public void cargar_combos()
        {
            //abrir la conexion
            ECU_ConexionPostgres.coneccion.Open();
            //consulta de usuario
            NpgsqlDataAdapter comando1 = new NpgsqlDataAdapter("SELECT  id_tlc, des_tlc FROM public.tmaetlcecu", ECU_ConexionPostgres.coneccion);
            //código para llenar el comboBox
            DataSet dsTipoLic = new DataSet();
            //agrega los datos a una tabla
            comando1.Fill(dsTipoLic);
            //cierra la coneccion
            comb_tipLic.DataSource = dsTipoLic.Tables[0];
            comb_tipLic.DisplayMember = "des_tlc";
            comb_tipLic.ValueMember = "id_tlc";
            ECU_ConexionPostgres.coneccion.Close();

            //abrir la conexion
            ECU_ConexionPostgres.coneccion.Open();
            //consulta de usuario
            NpgsqlDataAdapter comando2 = new NpgsqlDataAdapter("SELECT id_tho, des_tho FROM public.tmaethoecu;", ECU_ConexionPostgres.coneccion);
            //código para llenar el comboBox
            DataSet dsHorario = new DataSet();
            //agrega los datos a una tabla
            comando2.Fill(dsHorario);
            //cierra la coneccion
            comb_tipHor.DataSource = dsHorario.Tables[0];
            comb_tipHor.DisplayMember = "des_tho";
            comb_tipHor.ValueMember = "id_tho";
            ECU_ConexionPostgres.coneccion.Close();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (ModificarRegistro == true)
                {

                    if (camposVacios() == false && txt_Duracion_curso.Text!="0 Meses")
                    {
                        //abrir la conexion
                        ECU_ConexionPostgres.coneccion.Open();
                        NpgsqlCommand comando = new NpgsqlCommand("SELECT Pro_Act_Cur(" + id_curo_Modificar.ToString() + "," + comb_tipLic.SelectedValue + "," + comb_tipHor.SelectedValue + ",'" + txt_descrp_curso.Text + "','" + datetime_fecha_inic.Value + "','" + datetime_fecha_fin.Value + "','" + txt_Duracion_curso.Text + "'," + txt_costo.Text + ");", ECU_ConexionPostgres.coneccion);
                        //ejecutar comando
                        NpgsqlDataReader resultado = comando.ExecuteReader();
                        ECU_ConexionPostgres.coneccion.Close();
                        MessageBox.Show("Los datos an sido guardados correctamente");
                        reiniciarControles();
                        desactivarcontroles();
                    }
                    else
                    {
                        MessageBox.Show("Existen campos vacios no se puede guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }
                else
                {
                    if (camposVacios() == false && txt_Duracion_curso.Text != "0 Meses")
                    {
                        //abrir la conexion
                        ECU_ConexionPostgres.coneccion.Open();
                        NpgsqlCommand comando = new NpgsqlCommand("SELECT Pro_Ins_Cur(" + comb_tipLic.SelectedValue + "," + comb_tipHor.SelectedValue + ",'" + txt_descrp_curso.Text + "','" + datetime_fecha_inic.Value + "','" + datetime_fecha_fin.Value + "','" + txt_Duracion_curso.Text + "'," + txt_costo.Text + ");", ECU_ConexionPostgres.coneccion);
                        //ejecutar comando
                        NpgsqlDataReader resultado = comando.ExecuteReader();
                        ECU_ConexionPostgres.coneccion.Close();
                        MessageBox.Show("Los datos an sido ingresados correctamente");
                        reiniciarControles();
                        desactivarcontroles();
                        datetime_fecha_fin.Value = DateTime.Now;
                        datetime_fecha_fin.Value = DateTime.Now;
                    }
                    else
                    {
                        MessageBox.Show("Existen campos vacios no se puede guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Test"+ ex);
                ECU_ConexionPostgres.coneccion.Close();
                throw;
            }

        }
        /// <summary>
        /// METODO PARA ELIMINAR CURSO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (txt_codCur.Text != "")
            {
                try
                {
                    //abrir la conexion
                    ECU_ConexionPostgres.coneccion.Open();
                    NpgsqlCommand comando1 = new NpgsqlCommand("select * from Pro_cons_Cur('" + txt_codCur.Text + "');", ECU_ConexionPostgres.coneccion);
                    //ejecutar comando
                    NpgsqlDataReader resultado = comando1.ExecuteReader();
                    //  ECU_ConexionPostgres.coneccion.Close();
                    if (resultado.Read())
                    {   //resultado de la consulta
                        id_curo_Modificar = resultado[0];
                        //mensaje de dialogo
                        DialogResult respuesta = MessageBox.Show("Desea eliminar el curso: " + txt_codCur.Text + "", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        //si es si entonces llena los texbox
                        if (respuesta == DialogResult.Yes)
                        {
                            ECU_ConexionPostgres.coneccion.Close();
                            ECU_ConexionPostgres.coneccion.Open();
                            NpgsqlCommand comando2 = new NpgsqlCommand("SELECT Pro_Eli_Cur_Codigo ('" + id_curo_Modificar.ToString() + "');", ECU_ConexionPostgres.coneccion);
                            MessageBox.Show("" + id_curo_Modificar.ToString() + "");
                            //ejecutar comando
                            NpgsqlDataReader resultado2 = comando2.ExecuteReader();
                            ECU_ConexionPostgres.coneccion.Close();
                            MessageBox.Show("El curso a sido eliminado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            reiniciarControles();
                            desactivarcontroles();

                        }


                    }
                    else
                    {
                        MessageBox.Show("El curso " + txt_codCur.Text + " no esta registrado, no se puede eliminar ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //desactiva los controles
        public void desactivarcontroles()
        {
            comb_tipHor.Enabled = false;
            comb_tipLic.Enabled = false;
            datetime_fecha_fin.Enabled = false;
            datetime_fecha_inic.Enabled = false;
            txt_costo.Enabled = false;
            txt_Duracion_curso.Enabled = false;
            txt_descrp_curso.Enabled = false;
            txt_Duracion_curso.Enabled = false;
            ModificarRegistro = false;
        }

        //activa los controles 
        public void activarControles()
        {
            comb_tipHor.Enabled = true;
            comb_tipLic.Enabled = true;
            datetime_fecha_fin.Enabled = true;
            datetime_fecha_inic.Enabled = true;
            txt_costo.Enabled = true;
            txt_descrp_curso.Enabled = true;
            txt_Duracion_curso.Enabled = true;

        }
        /// <summary>
        /// REINICIA LOS CONTROLES
        /// </summary>
        public void reiniciarControles()
        {
            txt_codCur.Text = "";
            txt_costo.Text = "";
            txt_descrp_curso.Text = "";
            txt_Duracion_curso.Text = "";
        }
        /// <summary>
        /// / //verifica los campos vacios
        /// </summary>
        /// <returns></returns>

        public bool camposVacios()
        {
            bool estado = false;
            if (txt_descrp_curso.Text.Equals(""))
            {
                estado = true;
            }
            if (txt_Duracion_curso.Equals(""))
            {
                estado = true;
            }
            return estado;
        }




        /// <summary>
        /// METODO BUSCAR MEDIANTE LA BARRA 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_buscarBarra_Click(object sender, EventArgs e)
        {


            try
            {
                string texto = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el código del curso", "Consulta por código", "");
                if (texto != "")
                {
                    //abrir la conexion
                    ECU_ConexionPostgres.coneccion.Open();
                    //consulta de usuario
                    NpgsqlCommand comando = new NpgsqlCommand("select * from pro_cons_cur_codi('" + texto.ToString() + "');", ECU_ConexionPostgres.coneccion);

                    //ejecutar comando
                    NpgsqlDataReader resultado = comando.ExecuteReader();
                    if (resultado.Read())
                    {   //resultado de la consulta
                        id_curo_Modificar = resultado[0];
                        object cod_curs = resultado[1];
                        object id_tipo_licencia = resultado[2];
                        object tipo_licencia = resultado[3];
                        object id_horario = resultado[4];
                        object horario = resultado[5];
                        object fecha_inicio = resultado[6];
                        object fecha_fin = resultado[7];
                        object descripcion_curso = resultado[8];
                        object duracion_curso = resultado[9];
                        object costo_curso = resultado[10];

                        //llena los valores del cuaro en el formulario
                        txt_codCur.Text = cod_curs.ToString();
                        comb_tipLic.SelectedValue = id_tipo_licencia.ToString();
                        comb_tipHor.SelectedValue = id_horario.ToString();
                        datetime_fecha_inic.Text = fecha_inicio.ToString();
                        datetime_fecha_fin.Text = fecha_fin.ToString();
                        txt_descrp_curso.Text = descripcion_curso.ToString();
                        txt_Duracion_curso.Text = duracion_curso.ToString();
                        txt_costo.Text = costo_curso.ToString();
                        activarControles();
                        ModificarRegistro = true;
                        //cierra la conexion
                        ECU_ConexionPostgres.coneccion.Close();
                    }

                    else
                    {
                        MessageBox.Show("El curso " + texto + " no esta registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ECU_ConexionPostgres.coneccion.Close();
                    }


                }


            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: 0"+EX);
                throw;
            }



        }
        /// <summary>
        /// PARA REINICIAR LOS CONTROLES DEL FORMULARIO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //mensaje de dialogo
            DialogResult respuesta = MessageBox.Show("Desea agregar un nuevo registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //si es si entonces llena los texbox
            if (respuesta == DialogResult.Yes)
            {


                txt_codCur.Clear();
                txt_costo.Clear();
                txt_descrp_curso.Clear();
                txt_Duracion_curso.Clear();
                comb_tipHor.SelectedIndex = 1;
                comb_tipLic.SelectedIndex = 1;
                datetime_fecha_fin.Value = DateTime.Now;
                datetime_fecha_fin.Value = DateTime.Now;
                desactivarcontroles();
                btn_nuevoBarra.Enabled=true;
                

            }


        }

        /// <summary>
        /// boton salir para salir xD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas Salir?", "Estas Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        /// <summary>
        /// calcula la duracion del curso
        /// </summary>
        /// <param name="FechaFin"></param>
        /// <param name="FechaInicio"></param>
        /// <returns></returns>
        public static decimal MonthDifference(DateTime FechaFin, DateTime FechaInicio)
        {
            return Math.Abs((FechaFin.Month - FechaInicio.Month) + 12 * (FechaFin.Year - FechaInicio.Year));

        }
        /// <summary>
        /// vvalidacion de fecha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void datetime_fecha_fin_CloseUp(object sender, EventArgs e)
        {
            txt_Duracion_curso.Enabled = false;
            txt_Duracion_curso.Text = (MonthDifference(datetime_fecha_fin.Value, datetime_fecha_inic.Value)).ToString() + " Meses ";

        }
        /// <summary>
        /// ayuda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProyectoECU.ECU_Ayuda.ECU_Ayuda gestionAyuda = new ProyectoECU.ECU_Ayuda.ECU_Ayuda();//Instanciamos
            gestionAyuda.Show();//Mostramos 
        }

        /// <summary>
        /// para validar el precio 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_costo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txt_costo.Text.Length; i++)
            {
                if (txt_costo.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

     
    }
}
