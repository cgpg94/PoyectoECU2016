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
    public partial class ECU_GestionPago : Form
    {
        public object idmatricula;
        public object saldoPorPagar;
        public ECU_GestionPago()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            buscarMatriCodi();
        }

        /// <summary>
        /// Boton salir 
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
        /// Para salir 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProyectoECU.ECU_Ayuda.ECU_Ayuda gestionAyuda = new ProyectoECU.ECU_Ayuda.ECU_Ayuda();//Instanciamos
            gestionAyuda.Show();//Mostramos 
        }

        private void ECU_GestionPago_Load(object sender, EventArgs e)
        {

        }
        //para obtener el saldo por pagar
        public void saldo()
        {
            try
            {
                //abrir la conexion
                ECU_ConexionPostgres.coneccion.Open();
                //consulta de usuario
                NpgsqlCommand comando = new NpgsqlCommand("select  srs_pag from TMOVPAGECU where id_mat_pag=" + idmatricula + " order by srs_pag asc limit 1;", ECU_ConexionPostgres.coneccion);
                //ejecutar comando
                NpgsqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {   //resultado de la consulta
                    saldoPorPagar = resultado[0];
                    txt_saldo.Text = saldoPorPagar.ToString();
                }
                //abrir la conexion
                ECU_ConexionPostgres.coneccion.Close();

            }
            catch (Exception)
            {

                throw;
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
                NpgsqlCommand comando = new NpgsqlCommand("select * from pro_con_matr_num_3('" + txt_codigo_mat.Text + "');", ECU_ConexionPostgres.coneccion);
                //ejecutar comando
                NpgsqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {   //resultado de la consulta
                    idmatricula = resultado[0];
                    object codi_matri = resultado[1];
                    object ced_Est = resultado[2];
                    object nomb_estu = resultado[3];
                    object apel_estu = resultado[4];
                    object precio_matricula = resultado[11];
                    object cost_curso = resultado[13];
                    object licencia = resultado[15];
                    //compara resultado con el dato ingresado
                    if (codi_matri.Equals(txt_codigo_mat.Text))
                    {
                        ECU_ConexionPostgres.coneccion.Close();
                        txt_apellido.Text = apel_estu.ToString();
                        txt_Cedula.Text = ced_Est.ToString();
                        txt_codigo_mat.Text = codi_matri.ToString();
                        txt_nombre.Text = nomb_estu.ToString();
                        txt_tipo_lice.Text = licencia.ToString();
                        txt_valor_matri.Text = precio_matricula.ToString();
                        txt_valor_curso.Text = cost_curso.ToString();
                        saldo();
                        txt_valor_pagar.Enabled = true;
                        btn_confirmar.Enabled = true;

                    }
                }
                else
                {
                    ECU_ConexionPostgres.coneccion.Close();
                    MessageBox.Show("La matricula con cdigo: " + txt_codigo_mat.Text + " no se encuentra registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }


            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            inicializarElementos();
        }
        public void inicializarElementos()
        {
            txt_apellido.Text = "";
            txt_Cedula.Text = "";
            txt_codigo_mat.Text = "";
            txt_nombre.Text = "";
            txt_saldo.Text = "";
            txt_tipo_lice.Text = "";
            txt_valor_curso.Text = "";
            txt_valor_matri.Text = "";
            txt_valor_pagar.Text = "";
            txt_valor_pagar.Enabled = false;
            btn_confirmar.Enabled = false;

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Decimal.Parse(txt_valor_pagar.Text) <= Decimal.Parse(txt_saldo.Text))
                {
                    //abrir la conexion
                    ECU_ConexionPostgres.coneccion.Open();
                    //consulta de usuario
                    NpgsqlCommand comando = new NpgsqlCommand("select pro_ins_pag(" + idmatricula + "," + txt_valor_pagar.Text + ");", ECU_ConexionPostgres.coneccion);
                    //ejecutar comando
                    NpgsqlDataReader resultado = comando.ExecuteReader();
                    //abrir la conexion
                    ECU_ConexionPostgres.coneccion.Close();
                    saldo();
                    MessageBox.Show("El pago de "+ txt_valor_pagar.Text+" se a registrado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("La cantidad de dinero por ingresar supera el saldo, por favor ingrese una cantidad menor o igual a la del Saldo restante", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("Test"+(Decimal.Parse(txt_valor_pagar.Text)+"   "+ Decimal.Parse(txt_saldo.Text));
                }


            }
            catch (Exception EX)
            {
                MessageBox.Show("Test" + EX);
                throw;
            }

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
