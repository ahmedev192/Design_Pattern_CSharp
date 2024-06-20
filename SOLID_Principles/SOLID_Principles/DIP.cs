using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{

    //Initial Example (Violating DIP):
    public class BadEmailService
    {
        public void SendEmail(string recipient, string message)
        {
            // Code to send email
            Console.WriteLine($"Sending email to {recipient}: {message}");
        }
    }

    public class BadOrderProcessor
    {
        private BadEmailService _emailService;

        public BadOrderProcessor()
        {
            _emailService = new BadEmailService();
        }

        public void ProcessOrder(string orderDetails)
        {
            // Process the order
            Console.WriteLine($"Processing order: {orderDetails}");

            // Send confirmation email
            _emailService.SendEmail("customer@example.com", "Your order has been processed.");
        }
    }


    //----------------------------------------------------------------------------------------------------------------------------
    // Dependency Inversion Principle (DIP) : 

    public interface IEmailService
    {
        void SendEmail(string recipient, string message);
    }
    public class EmailService : IEmailService
    {
        public void SendEmail(string recipient, string message)
        {
            // Code to send email
            Console.WriteLine($"Sending email to {recipient}: {message}");
        }
    }
    public class OrderProcessor
    {
        private readonly IEmailService _emailService;

        public OrderProcessor(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void ProcessOrder(string orderDetails)
        {
            // Process the order
            Console.WriteLine($"Processing order: {orderDetails}");

            // Send confirmation email
            _emailService.SendEmail("customer@example.com", "Your order has been processed.");
        }
    }




}
