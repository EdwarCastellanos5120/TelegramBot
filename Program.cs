using Examen_Final_Programacion_I.Clases;
using Examen_Final_Programacion_I.Clases.Archivo;
using Examen_Final_Programacion_I.Clases.Funciones;
using System;
using System.Threading.Tasks;

namespace Examen_Final_Programacion_I
{
    class Program
    {
        
        public static async Task Main()
        {
            await new ClsBot().InicioBot();
        }
    }
}
