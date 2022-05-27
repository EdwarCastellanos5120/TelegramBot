using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Examen_Final_Programacion_I.Clases.Archivo
{
    public class ClsArchivo
    {
        public string[] LeerArchivo(string archivo)
        {
            String[] lineas = File.ReadAllLines(archivo, Encoding.Default);
            return lineas;
        }
    }
}
