using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QAAcademySOLID.Interfaces;

namespace QAAcademySOLID.OpenClose
{

    public class OpenCloseNotificationService
    {
        public async Task Send(List<INotification> notifications)
        {
            foreach (var notification in notifications)
            {
                await notification.Notifiy();
            }
        }
    }
    public class NotificationEmailService : INotification
    {
        private readonly string _to;
        private readonly string _subject;

        public NotificationEmailService(string to, string subject)
        {
            _to = to;
            _subject = subject;
        }

        public async Task Notifiy()
        {
            // Lógica para enviar la ntoification por e-mail
        }
    }

    public class NotificationSmsService : INotification
    {
        private readonly string _phoneNumber;
        private readonly string _subject;

        public NotificationSmsService(string phoneNumber, string subject)
        {
            _phoneNumber = phoneNumber;
            _subject = subject;
        }

        public async Task Notifiy()
        {
            // Lógica para enviar la notificación
        }
    }

}
