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

namespace Login
{
    public partial class ECU_Login : Form
    {
        public ECU_Login()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {

            Form ingresoC = new ECU_Principal();//Instanciamos
            ingresoC.ShowDialog();//Mostramos 
        }

     
       
    }
}
