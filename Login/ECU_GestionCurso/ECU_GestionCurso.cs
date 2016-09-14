﻿using System;
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
        ECU_ConsultaCurso consultaCurso = new ECU_ConsultaCurso();
        public static bool ModificarRegistro = false;
        public static object id_curo_Modificar=0;
        public ECU_GestionCurso()
        {
            InitializeComponent();
            this.cargar_combos();

        }

       

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaCurso.Show();   
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txt_codCur.Text.Equals(""))
            {
                MessageBox.Show("Ingresar código para evaluar","Aviso", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }else
            {
                try
                {

                    //abrir la conexion
                    ECU_ConexionPostgres.coneccion.Open();
                    //consulta de usuario
                    NpgsqlCommand comando = new NpgsqlCommand("select * from Pro_cons_Cur(" + txt_codCur.Text + ");", ECU_ConexionPostgres.coneccion);

                    //ejecutar comando
                    NpgsqlDataReader resultado = comando.ExecuteReader();
                    if (resultado.Read())
                    {   //resultado de la consulta
                        id_curo_Modificar=resultado[0];
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
                                ModificarRegistro  =true; 
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
                        
                        activarControles();
                        ECU_ConexionPostgres.coneccion.Close();
                    }
                    

                }
                catch (Exception)
                {
                    
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

                if (ModificarRegistro==true)
                {
                    if (camposVacios()== false)
                    {
                        //abrir la conexion
                        ECU_ConexionPostgres.coneccion.Open();
                        NpgsqlCommand comando = new NpgsqlCommand("SELECT Pro_Act_Cur(" + id_curo_Modificar.ToString() + "," + comb_tipLic.SelectedValue + "," + comb_tipHor.SelectedValue + "," + txt_codCur.Text + ",'" + txt_descrp_curso.Text + "','" + datetime_fecha_inic.Value + "','" + datetime_fecha_fin.Value + "','" + txt_Duracion_curso.Text + "'," + txt_costo.Text + ");", ECU_ConexionPostgres.coneccion);
                        //ejecutar comando
                        NpgsqlDataReader resultado = comando.ExecuteReader();
                        ECU_ConexionPostgres.coneccion.Close();
                        MessageBox.Show("Los datos an sido guardados correctamente");
                        reiniciarControles();
                        desactivarcontroles();
                    }

                }
                else
                {
                    if (camposVacios()==false)
                    {
                        //abrir la conexion
                        ECU_ConexionPostgres.coneccion.Open();
                        NpgsqlCommand comando = new NpgsqlCommand("SELECT Pro_Ins_Cur(" + comb_tipLic.SelectedValue + "," + comb_tipHor.SelectedValue + "," + txt_codCur.Text + ",'" + txt_descrp_curso.Text + "','" + datetime_fecha_inic.Value + "','" + datetime_fecha_fin.Value + "','" + txt_Duracion_curso.Text + "'," + txt_costo.Text + ");", ECU_ConexionPostgres.coneccion);
                        //ejecutar comando
                        NpgsqlDataReader resultado = comando.ExecuteReader();
                        ECU_ConexionPostgres.coneccion.Close();
                        MessageBox.Show("Los datos an sido ingresados correctamente");
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

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (txt_codCur.Text!="")
	{
        try
        {
            //abrir la conexion
            ECU_ConexionPostgres.coneccion.Open();
            NpgsqlCommand comando1 = new NpgsqlCommand("select * from Pro_cons_Cur(" + txt_codCur.Text + ");", ECU_ConexionPostgres.coneccion);
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
                    NpgsqlCommand comando2 = new NpgsqlCommand("SELECT Pro_Eli_Cur (" + id_curo_Modificar.ToString() + ");", ECU_ConexionPostgres.coneccion);
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
        public void reiniciarControles()
        {
            txt_codCur.Text = "";
            txt_costo.Text="";
            txt_descrp_curso.Text = "";
            txt_Duracion_curso.Text = "";
        }
        //verifica los campos vacios
        public bool camposVacios() {
            bool estado = false;
            if (txt_codCur.Text.Equals(""))
            {
                estado = true;
            }
            if (txt_codCur.Text.Equals(""))
            {
                estado = true;
            }
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
        


        
       
        private void btn_buscarBarra_Click(object sender, EventArgs e)
        {

                
                try
                {
                    string texto = Microsoft.VisualBasic.Interaction.InputBox("Texto de la pregunta", "Titulo del diálogo","");
                  if (texto!="")
                    {
                        //abrir la conexion
                        ECU_ConexionPostgres.coneccion.Open();
                        //consulta de usuario
                        NpgsqlCommand comando = new NpgsqlCommand("select * from Pro_cons_Cur(" + texto.ToString() + ");", ECU_ConexionPostgres.coneccion);

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
                catch (Exception)
                {

                    throw;
                }

            

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
            txt_codCur.Clear();
            txt_costo.Clear();
            txt_descrp_curso.Clear();
            txt_Duracion_curso.Clear();
            comb_tipHor.SelectedIndex=1;
            comb_tipLic.SelectedIndex = 1;
            datetime_fecha_fin.Value = DateTime.Now;
            datetime_fecha_fin.Value = DateTime.Now;
            desactivarcontroles();


        }

      
    }
}