using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoECU.ECU_Ayuda;
using Login;

namespace ProyectoECU.Interfaces
{
    public partial class ECU_Principal : Form
    {
        public ECU_Principal()
        {
            InitializeComponent();
            //instancia de form2 pasandole el valor del textbox

            if ((ECU_Login.tipo.ToString()).Equals("2"))
            {
                usuarioToolStripMenuItem.Visible = false;
                btn_usuario.Visible = false;
                texto_Usuario.Visible = false;


            }
        }

        private void tab_Estudiantes_Click(object sender, EventArgs e)
        {
            Form gestionEstudiante = new ECU_GestionEstudiante();//Instanciamos
            gestionEstudiante.ShowDialog();//Mostramos 

        }

        private void tab_Instructor_Click(object sender, EventArgs e)
        {
            Form gestionInstructor = new ECU_GestionInstructor();//Instanciamos
            gestionInstructor.ShowDialog();//Mostramos 
        }

        private void tab_Matricula_Click(object sender, EventArgs e)
        {
            Form gestionMatricula = new ECU_GestionMatricula();//Instanciamos
            gestionMatricula.ShowDialog();//Mostramos 
        }

        private void tab_Pago_Click(object sender, EventArgs e)
        {
            Form gestionPago = new ECU_GestionPago();//Instanciamos
            gestionPago.ShowDialog();//Mostramos 
        }

        private void tab_Cursos_Click(object sender, EventArgs e)
        {
            if ((ECU_Login.tipo.ToString()).Equals("2"))
            {
                Form consu_cur = new ECU_ConsultaCurso();
                consu_cur.ShowDialog();

            }
            else
            {
                Form gestionCurso = new ECU_GestionCurso();//Instanciamos
                gestionCurso.ShowDialog();//Mostramos 
            }
            
        }

        private void tab_Usuario_Click(object sender, EventArgs e)
        {
            Form gestionUsuario = new ECU_GestionUsuario();//Instanciamos
            gestionUsuario.ShowDialog();//Mostramos 
        }

        private void tab_Ayuda_Click(object sender, EventArgs e)
        {
            ProyectoECU.ECU_Ayuda.ECU_Ayuda gestionAyuda = new ProyectoECU.ECU_Ayuda.ECU_Ayuda();//Instanciamos
            gestionAyuda.Show();//Mostramos 
        }

        private void ECU_Principal_KeyDown(object sender, KeyEventArgs e)
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

        private void ECU_Principal_Load(object sender, EventArgs e)
        {


        }




    }
}
