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
    public partial class ECU_Principal : Form
    {
        public ECU_Principal()
        {
            InitializeComponent();
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
            Form gestionCurso = new ECU_GestionCurso();//Instanciamos
            gestionCurso.ShowDialog();//Mostramos 
        }

        private void tab_Usuario_Click(object sender, EventArgs e)
        {
            Form gestionUsuario = new ECU_GestionUsuario();//Instanciamos
            gestionUsuario.ShowDialog();//Mostramos 
        }

        private void tab_Ayuda_Click(object sender, EventArgs e)
        {
            Form gestionAyuda = new ECU_Ayuda();//Instanciamos
            gestionAyuda.ShowDialog();//Mostramos 
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

       
    
       
    }
}
