using J3QQ4;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Final_Programacion_I.Clases.Menu
{
    public class ClsMensajeCovid
    {
        public string mensaje()
        {
            string mensajecovid = $"¡{ClsEmoji.Airplane} Gracias por consultar nuestros servicios de vuelo {ClsEmoji.BanderaGuat}!\n\n" +
                $"Para que tu viaje sea completamente sano para ti y los que amas te recomendamos lo siguiente {ClsEmoji.Point_Down}:\n\n" +
                $"-El uso de tu mascarilla es obligatorio {ClsEmoji.Mask}{ClsEmoji.White_Check_Mark}\n\n" +
                $"-Debes desinfectar tus manos {ClsEmoji.Manitas}{ClsEmoji.jabonito} y también tomar tu temperatura {ClsEmoji.calentura} con las señoritas encargadas {ClsEmoji.aeromosa}{ClsEmoji.White_Check_Mark}\n\n" +
                $"-Evita el contacto cercano con los demás tripulantes {ClsEmoji.distancia}{ClsEmoji.White_Check_Mark}\n\n" +
                $"Me protejo, te protejo {ClsEmoji.Star2} ";
            return mensajecovid;
        }
    }
              
}
