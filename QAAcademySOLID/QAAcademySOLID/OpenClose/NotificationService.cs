using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAcademySOLID.OpenClose
{
    public class NotificationService
    {
        public async Task Send(List<Notification> notifications)
        {
            
            foreach (var notification in notifications)
            {
                if (notification.Type.Equals("sms"))
                {
                    await SendbySMS(notification.PhoneNumber, notification.Subject);
                }

                if (notification.Type.Equals("email"))
                {
                    await SendbyEmail(notification.Email, notification.Subject);
                }
            }
        }

        private async Task SendbySMS(string phoneNumber, string subject)
        {
            // Logica para mandar el SMS
        }

        private async Task SendbyEmail(string to, string subject)
        {
            // Logica para mandar el email
        }
    }

    public class Notification
    {
        public string Type { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }

    }

    //In the future we will need to add new if conditions for each new type
}
