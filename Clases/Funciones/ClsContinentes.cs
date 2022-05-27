using Examen_Final_Programacion_I.Clases.Archivo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Final_Programacion_I.Clases.Funciones
{
    class ClsContinentes
    {
        public void CargarArchivo()
        {
            ClsArchivo archivo = new ClsArchivo();
            ClsCargaInfo Carga = new ClsCargaInfo();
            //America
            string america = @"C:\Users\alumno\Desktop\America.csv";
            string[] ContAmerica = archivo.LeerArchivo(america);
            string NameAmerica = "tb_CAmerica";
            Carga.CargarArcivo(ContAmerica, NameAmerica);
            //Europa
            string europa = @"C:\Users\alumno\Desktop\Europa.csv";
            string[] ContEuropa = archivo.LeerArchivo(europa);
            string NameEuropa = "tb_CEuropa";
            Carga.CargarArcivo(ContEuropa, NameEuropa);
            //Asia
            string asia = @"C:\Users\alumno\Desktop\Asia.csv";
            string[] ContAsia = archivo.LeerArchivo(asia);
            string NameAsia = "tb_CAsia";
            Carga.CargarArcivo(ContAsia, NameAsia);
            //Africa
            string africa = @"C:\Users\alumno\Desktop\Africa.csv";
            string[] ContAfrica = archivo.LeerArchivo(africa);
            string NameAfrica = "tb_CAfrica";
            Carga.CargarArcivo(ContAfrica, NameAfrica);
            //Oceania
            string oceania = @"C:\Users\alumno\Desktop\Oceania.csv";
            string[] ContOcenia = archivo.LeerArchivo(oceania);
            string NameOceania = "tb_COceania";
            Carga.CargarArcivo(ContOcenia, NameOceania);


        }
    }
}
