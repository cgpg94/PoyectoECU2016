using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoECU.ECU_Concexion
{
    class ECU_ConexionPostgres
    {
        //Ruta de connecion a la BD
        public static NpgsqlConnection coneccion = new NpgsqlConnection("Server=localhost; Database=ecu_uleam; " +
            "" + "User id=postgres; password=1234gonzalop%;");
    }
}
