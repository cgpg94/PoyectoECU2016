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

namespace ProyectoECU.Interfaces
{
    public partial class ECU_GestionCurso : Form
    {
        ECU_ConsultaCurso consultaCurso = new ECU_ConsultaCurso();
        public ECU_GestionCurso()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaCurso.Show();   
        }
    }
}
