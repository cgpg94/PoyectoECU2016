using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ProyectoECU.ECU_GestionEstudiante
{
    public class Validaciones
    {
        public bool cedula_valida(string cedula) {        
            //Expresion regular que valida los 10 numeros
            Regex Val = new Regex(@"^\+?\d{1,3}?[- .]?\(?(?:\d{2,3})\)?[- .]?\d\d\d[- .]?\d\d\d\d$");
            //si es una cedula correcta
            if (Val.IsMatch(cedula))
            {
                return true;
            }
            else {
                return false;
            }
        }
        public bool apellido_valido(string nombre)
        {
            Regex Val = new Regex(@"[a-zA-Z]");
            //si es un nombre correcta
            if (Val.IsMatch(nombre))
            {
                //MessageBox.Show("Apellido valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);          
                return true;
            }
            else
            {
                //MessageBox.Show("Faltan Campos por llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);          
                return true;
            }
        }

        public bool nombre_valido(string nombre)
        {
            Regex Val = new Regex(@"[a-zA-Z]");
            //si es un nombre correcta
            if (Val.IsMatch(nombre))
            {
                //MessageBox.Show("Nombre valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                //MessageBox.Show("Faltan Campos por llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        public bool validar_celu(string celular)
        {
            //Expresion regular que valida los 10 numeros
            Regex Val = new Regex(@"^\+?\d{1,3}?[- .]?\(?(?:\d{2,3})\)?[- .]?\d\d\d[- .]?\d\d\d\d$");
            //si es una cedula correcta
            if (Val.IsMatch(celular))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
