using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace QAAcademySOLID.SingleResponsibility
{
    public class OrderService
    {
        private readonly SmtpClient _smtpClient;

        public OrderService(SmtpClient smtpClient)
        {
            _smtpClient = smtpClient;
        }

        public async Task Add(Order order)
        {
            // 01. Código para crear la orden

            // 02. Notificar al cliente
            var message = new MailMessage("sales@admin.com", order.ClientEmail)
            {
                Subject = "Se le asignó una compra",
                Body = "Estimado,\n Hemos creado su nueva orden de compra .."
            };

            await this.SendCustomerNotification(message);
        }

        public async Task SendCustomerNotification(MailMessage message)
        {
            await _smtpClient.SendMailAsync(message);
        }
    }

    public class Order
    {
        public string ClientEmail { get; set; }
    }
}
