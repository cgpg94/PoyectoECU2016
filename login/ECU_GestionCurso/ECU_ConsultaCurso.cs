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

namespace ProyectoECU
{
    public partial class ECU_ConsultaCurso : Form
    {
        public ECU_ConsultaCurso()
        {
            InitializeComponent();
            this.cargar_combo();
            this.cargarTodoVCurso();
        }

        private void ECU_ConsultaCurso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt || e.KeyCode == Keys.F4)
            {
                //cuadro de dialogo
                DialogResult rs = MessageBox.Show("¿ Desea cerrar esta ventana ?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    //cierra el formulario
                    Close();
                }
                else
                {
                    //no lo cierra
                    e.Handled = true;
                }

            }
        }

        public void cargar_combo()
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
            comb_tip_lic.DataSource = dsTipoLic.Tables[0];
            comb_tip_lic.DisplayMember = "des_tlc";
            comb_tip_lic.ValueMember = "id_tlc";
            ECU_ConexionPostgres.coneccion.Close();
            

            
        }




        private void rbtn_cod_cur_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtn_cod_cur.Checked)
            {
                txt_codigo_cur.Enabled = true;
                comb_tip_lic.Enabled = false;
            }
        }



        private void rbtn_ti_lic_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_ti_lic.Checked)
            {
                comb_tip_lic.Enabled = true;
                txt_codigo_cur.Text = "";
            }
           
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            if (rbtn_todo.Checked)
            {
                cargarTodoVCurso();
            }
            if (txt_codigo_cur.Text != ""&& rbtn_cod_cur.Checked)
            {
                //abre la base de datos
                ECU_ConexionPostgres.coneccion.Open();
                //llamar el procedimiento almacenadoa
                string SQL = "select * from Pro_cons_Cur_Cons_form('" + txt_codigo_cur.Text + "');";
                // Ejecuta el comando
                NpgsqlDataAdapter comando = new NpgsqlDataAdapter(SQL, ECU_ConexionPostgres.coneccion);
                DataSet ds = new DataSet();
                //agrega los datos a una tabla
                comando.Fill(ds);
                grid_datos.DataSource = ds.Tables[0];
                //cierra la coneccion
                ECU_ConexionPostgres.coneccion.Close();
            }
            if (comb_tip_lic.Enabled&&rbtn_ti_lic.Checked)
            {
                //abre la base de datos
                ECU_ConexionPostgres.coneccion.Close();
                //abre la base de datos
                ECU_ConexionPostgres.coneccion.Open();
                //llamar el procedimiento almacenadoa
                string SQL = "select * from Pro_cons_Cur_tip_Lic(" + comb_tip_lic.SelectedValue + ");";
                // Ejecuta el comando
                NpgsqlDataAdapter comando = new NpgsqlDataAdapter(SQL, ECU_ConexionPostgres.coneccion);
                DataSet ds = new DataSet();
                //agrega los datos a una tabla
                comando.Fill(ds);
                grid_datos.DataSource = ds.Tables[0];
                //cierra la coneccion
                ECU_ConexionPostgres.coneccion.Close();
            }
            

        }

        private void rbtn_todo_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        public void cargarTodoVCurso()
        {
            if (rbtn_todo.Checked)
            {
                //abre la base de datos
                ECU_ConexionPostgres.coneccion.Open();
                //llamar el procedimiento almacenadoa
                string SQL = "select* from Pro_cons_tod_Cur();";
                // Ejecuta el comando
                NpgsqlDataAdapter comando = new NpgsqlDataAdapter(SQL, ECU_ConexionPostgres.coneccion);
                DataSet ds = new DataSet();
                //agrega los datos a una tabla
                comando.Fill(ds);
                grid_datos.DataSource = ds.Tables[0];
                //cierra la coneccion
                ECU_ConexionPostgres.coneccion.Close();
            }
        }


    }
}
