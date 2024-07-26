using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WCF_Payment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(WCF_Payment.PaymentServices), new Uri("http://localhost:8080/paymentservice")))
            {
                host.AddServiceEndpoint(typeof(WCF_Payment.IPaymentServices), new WebHttpBinding(), "").Behaviors.Add(new WebHttpBehavior());

                host.Open();
                Console.WriteLine("Service is running...");
                Console.WriteLine("Press enter to quit...");
                Console.ReadLine();
            }
        }
    }
}
