using Examen_Final_Programacion_I.Clases.BasedeDatos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace Examen_Final_Programacion_I.Clases.Funciones
{
    class ClsCargaInfo
    {
        public void CargarArcivo(string[] archivo, string continente)
        {
            ClsConexionSQL conexionSQL = new ClsConexionSQL();
            int NumeroLinea = 0;
            string sentencia = "";
            foreach (string Linea in archivo)
            {
                string[] datos = Linea.Split(';');
                if (NumeroLinea >= 0)
                {
                    sentencia += $"insert into {continente} values('{datos[0]}','{datos[1]}','{datos[2]} {datos[3]}')\n";
                }
                NumeroLinea++;
            }
            NumeroLinea = 0;
            conexionSQL.EjecutaSQLDirecto(sentencia);
        }
    }
}