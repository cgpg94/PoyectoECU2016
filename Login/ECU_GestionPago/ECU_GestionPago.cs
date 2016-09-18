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
        public ECU_GestionPago()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas Salir?", "Estas Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProyectoECU.ECU_Ayuda.ECU_Ayuda gestionAyuda = new ProyectoECU.ECU_Ayuda.ECU_Ayuda();//Instanciamos
            gestionAyuda.Show();//Mostramos 
        }
    }
}
