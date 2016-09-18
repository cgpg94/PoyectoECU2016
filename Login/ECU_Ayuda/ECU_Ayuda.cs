using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoECU.ECU_Ayuda
{
    public partial class ECU_Ayuda : Form
    {
        public ECU_Ayuda()
        {
            InitializeComponent();
            
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {
            
        }

        private void ECU_Ayuda_Load(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(@"C:\Users\Christian\Desktop\ProyectoECU_2016_2\ProyectoECU_2016\login\Resources\ATRIBUTO_MATENIMIENTO-2016.pdf");
            

            


        }
    }
}
