using System;
using System.Collections.Generic;

namespace WCF_Payment
{
    public class PaymentServices : IPaymentServices
    {
        private static readonly Dictionary<int, Payment> payments = new Dictionary<int, Payment>();

        public bool AddNewPayment(Payment payment)
        {
            if (payments.ContainsKey(payment.PaymentId))
                return false;
            payments[payment.PaymentId] = payment;
            return true;
        }

        public Payment SearchPaymentByID(int paymentId)
        {
            payments.TryGetValue(paymentId, out var payment);
            return payment;
        }

        public void UpdatePaymentStatus(int paymentId, string newStatus)
        {
            if (payments.TryGetValue(paymentId, out var payment))
            {
                payment.PaymentStatus = newStatus;
            }
        }
        public bool DeletePayment(int paymentId)
        {
            return payments.Remove(paymentId); 
        }
    }
}
