using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QAAcademySOLID.Interfaces;
using QAAcademySOLID.SingleResponsibility;

namespace QAAcademySOLID.DependencyInversion
{


    public class DependencyInversionMailChimpService : IMailService
    {
        public void Send()
        {
            // TODO: código para enviar el correo
        }
    }

    public class SendGridService : IMailService
    {
        public void Send()
        {
            // TODO: código para enviar el correo
        }
    }

    public class DepInvOrderService
    {
        public readonly IMailService _mailService;

        public DepInvOrderService(IMailService mailService)
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
