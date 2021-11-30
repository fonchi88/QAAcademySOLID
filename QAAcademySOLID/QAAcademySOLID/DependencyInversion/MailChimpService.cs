using QAAcademySOLID.SingleResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAcademySOLID.DependencyInversion
{
    public class MailChimpService
    {
        public void Send()
        {
            // TODO: código para enviar el correo
        }
    }

    public class OrderService
    {
        public readonly MailChimpService _mailService;

        public OrderService(MailChimpService mailService)
        {
            _mailService = mailService;
        }

        public void Create(Order order)
        {
            // TODO: código para crear la orden

            // Enviar notificación de la orden creada
            _mailService.Send();
        }
    }
}
