using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QAAcademySOLID.OpenClose;
using QAAcademySOLID.Interfaces;
using QAAcademySOLID.LiskovSubstitution;

namespace QAAcademySOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liskov Substitution
            IHunt tiger = new LiskovTiger();

            List<IHunt> hunters = new List<IHunt>();
            hunters.Add(tiger);
            GoToHunt(hunters);
            //
        }

        //Open Close Example
        public async void OpenClose() {
            var notificationsx = new List<INotification>
            {
                new NotificationEmailService("customer@email.com", "El motivo del correo"),
                new NotificationSmsService("+05199999", "El asunto del mensaje de texto"),
                // .. podemos implementar más notificaciones
            };

            var notificationService = new OpenCloseNotificationService();
            await notificationService.Send(notificationsx);
        }

        //Liskov Substitution Example
        public static void GoToHunt(List<IHunt> hunters)
        {
            // Ahora solo trabaja con todos los que sean cazadores
            foreach (var hunter in hunters)
            {
                hunter.Hunt();
            }
        }
    }
}
