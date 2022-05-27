using Examen_Final_Programacion_I.Clases.BasedeDatos;
using J3QQ4;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Examen_Final_Programacion_I.Clases.Menu
{
    class ClsMenuPrincipal
    {
        public string ConsultaVuelos(string continente)
        {
            string contenido = $"Numero de Vuelo{ClsEmoji.Hash}{ClsEmoji.Airplane}➔Destino Final{ClsEmoji.meta}➔ Fecha Y Hora de Salida{ClsEmoji.Alarm_Clock}{ClsEmoji.Date}\n\n";
            ClsConexionSQL coneSQL = new ClsConexionSQL();
            DataTable dt = new DataTable();
            
            dt = coneSQL.consultaTablaDirecta($"SELECT * FROM {continente} ;");
            foreach (DataRow data in dt.Rows)
            {
                
                contenido += ($"{data[0]}➔{data[1]}➔{data[2]}\n\n");


            }
            return contenido;

        }
    }
}