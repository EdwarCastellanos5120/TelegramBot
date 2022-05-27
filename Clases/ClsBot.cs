using Examen_Final_Programacion_I.Clases.Archivo;
using Examen_Final_Programacion_I.Clases.Funciones;
using Examen_Final_Programacion_I.Clases.Menu;
using J3QQ4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Examen_Final_Programacion_I.Clases
{
    class ClsBot
    {
        private static TelegramBotClient Bot;


        public async Task InicioBot()
        {
            ClsContinentes Continentes = new ClsContinentes();
            Bot = new TelegramBotClient("Aqui va el Hash");
            var me = await Bot.GetMeAsync();
            Console.Title = me.Username;
            Bot.OnMessage += MensajeRecibido;
            Bot.OnMessageEdited += MensajeRecibido;
            Bot.OnReceiveError += Error;
            Bot.StartReceiving(Array.Empty<UpdateType>());
            Console.WriteLine($"Listo para Usar el Bot de siguiente Nombre @{me.Username}");
            Console.WriteLine($"Los Datos estan Cargados");
            Continentes.CargarArchivo();
            Console.ReadLine();
            Bot.StopReceiving();
        }
        private static void Error(object sender, ReceiveErrorEventArgs receiveErrorEventArgs)
        {
            Console.WriteLine("Received error: {0} — {1}",
                receiveErrorEventArgs.ApiRequestException.ErrorCode,
                receiveErrorEventArgs.ApiRequestException.Message
            );
        }

        static async Task Usage(Message message)
        {
            const string usage = "MENU DE OPCIONES:\n Instrucciones: Presiona sobre la opcion que desees\n" +
                                    "/Informacion  - Mostrar informacion\n" +
                                    "/America      -Vuelos por el Continente de America\n" +
                                    "/Europa       -Vuelos por el Continente de Europa\n" +
                                    "/Africa       -Vuelos por el Continente de Africa\n" +
                                    "/Asia         -Vuelos por el Continente de Asia\n" +
                                    "/Oceania      -Vuelos por el Continente de Oceania";
            await Bot.SendTextMessageAsync(chatId: message.Chat.Id, text: usage);
        }

        private static async void MensajeRecibido(object sender, MessageEventArgs messageEventArgs)
        {
            var message = messageEventArgs.Message;
            var ObjetoMensaje = messageEventArgs;
            string respuesta = "";
            if (message == null || message.Type != MessageType.Text)
                return;
            Console.WriteLine("\n");
            Console.WriteLine($"La fecha de Envio del Mensaje es: {ObjetoMensaje.Message.Date}");
            Console.WriteLine($"El id del usuario es: {ObjetoMensaje.Message.Chat.Id} ");
            Console.WriteLine($"El Contenido del Mensaje es: {ObjetoMensaje.Message.Text}.");


            if (message.Text != "/start" && message.Text != "Menu" && message.Text != "/Informacion" && message.Text != "/America" && message.Text != "/Europa" && message.Text != "/Africa" && message.Text != "/Asia" && message.Text != "/Oceania" && message.Text != "Hola" && message.Text != "Adios")
            {
                respuesta = $"No te entiendo pasajero{ClsEmoji.Cop} que tal si colocas coloca la instruccion clave /start{ClsEmoji.White_Check_Mark}{ClsEmoji.Wink}";
                await Bot.SendTextMessageAsync(chatId: message.Chat.Id, text: respuesta);
            }

            if (message.Text == "/start" || message.Text == "Menu")
            {
                respuesta = $"¡ {ClsEmoji.Cop}‍ Saludos querido tripulante {ClsEmoji.Star2} !\n\n" +
                    $"Es un gusto para nosotros el que hayas elegido a Aerolínea Quetzal {ClsEmoji.BanderaGuat} como el medio que te permita llegar sano y salvo a tu destino.\n\n" +
                    $"Recuerda que: Aerolínea Quetzal vela por tu bienestar para poder hacerte llegar sano y salvo a tu hogar{ClsEmoji.House_With_Garden}{ClsEmoji.Heart}";
                await Bot.SendTextMessageAsync(chatId: message.Chat.Id, text: respuesta);
                await Usage(message);
            }
            if (message.Text == "/Informacion")
            {
                respuesta = $"¡Hola Pasajero {ClsEmoji.Cop}! somos una empresa que cruza fronteras, proporcionando una experiencia inolvidable para usted como pasajero\n\n{ClsEmoji.Smile}" +
                    $"Puedes seguirnos en nuestro instagram : @aerolineaquetzal{ClsEmoji.Airplane} o comunicarse para hacer tu reservacion al telefono 5625-9729{ClsEmoji.Telephone_Receiver}\n\n" +
                    $"Igualmente comunicate a nuestro correo electronico: aerolineaquetzal@gmail.com {ClsEmoji.E_Mail}";
                await Bot.SendTextMessageAsync(chatId: message.Chat.Id, text: respuesta);
            }

            if (message.Text == "Hola")
            {
                respuesta = $" ¡Hola! es un gusto saludarte{ClsEmoji.Scream}, si deseas usar nuestros servicios coloca la palabra /start {ClsEmoji.White_Check_Mark}";
                await Bot.SendTextMessageAsync(chatId: message.Chat.Id, text: respuesta);
            }

            if (message.Text == "Adios")
            {
                respuesta = $"Adios Pasajero Buen Viaje {ClsEmoji.Airplane}";
                await Bot.SendTextMessageAsync(chatId: message.Chat.Id, text: respuesta);
            }

            ClsMensajeCovid covid = new ClsMensajeCovid();
            string mensajecovid = "";
            mensajecovid = covid.mensaje();

            ClsMenuPrincipal Menu = new ClsMenuPrincipal();
            string respuesta2 = "";

            if (message.Text == "/America")
            {
                respuesta2 = Menu.ConsultaVuelos("tb_CAmerica");
                await Bot.SendTextMessageAsync(chatId: message.Chat.Id, text: respuesta2);
                await Bot.SendTextMessageAsync(chatId: message.Chat.Id, text: mensajecovid);
            }

            if (message.Text == "/Europa")
            {
                respuesta2 = Menu.ConsultaVuelos("tb_CEuropa");
                await Bot.SendTextMessageAsync(chatId: message.Chat.Id, text: respuesta2);
                await Bot.SendTextMessageAsync(chatId: message.Chat.Id, text: mensajecovid);
            }

            if (message.Text == "/Africa")
            {
                respuesta2 = Menu.ConsultaVuelos("tb_CAfrica");
                await Bot.SendTextMessageAsync(chatId: message.Chat.Id, text: respuesta2);
                await Bot.SendTextMessageAsync(chatId: message.Chat.Id, text: mensajecovid);
            }

            if (message.Text == "/Asia")
            {
                respuesta2 = Menu.ConsultaVuelos("tb_CAsia");
                await Bot.SendTextMessageAsync(chatId: message.Chat.Id, text: respuesta2);
                await Bot.SendTextMessageAsync(chatId: message.Chat.Id, text: mensajecovid);
            }
            if (message.Text == "/Oceania")
            {
                respuesta2 = Menu.ConsultaVuelos("tb_COceania");
                await Bot.SendTextMessageAsync(chatId: message.Chat.Id, text: respuesta2);
                await Bot.SendTextMessageAsync(chatId: message.Chat.Id, text: mensajecovid);
            }











        }

    }
}
