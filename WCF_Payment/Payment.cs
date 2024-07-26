using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCF_Payment
{
    [ServiceContract]
    public interface IPaymentServices
    {
        [OperationContract]
        bool AddNewPayment(Payment payment);

        [OperationContract]
        Payment SearchPaymentByID(int paymentId);

        [OperationContract]
        void UpdatePaymentStatus(int paymentId, string newStatus);
        [OperationContract]
        bool DeletePayment(int paymentId);
    }

    [DataContract]
    public class Payment
    {
        [DataMember] public int PaymentId { get; set; }
        [DataMember] public int AuctionResultId { get; set; }
        [DataMember] public string PaymentMethod { get; set; }
        [DataMember] public decimal TotalPrice { get; set; }
        [DataMember] public DateTime PaymentTime { get; set; }
        [DataMember] public int CustomerId { get; set; }
        [DataMember] public decimal FinalPrice { get; set; }
        [DataMember] public int JewelryId { get; set; }
        [DataMember] public decimal Fees { get; set; }
        [DataMember] public decimal Percent { get; set; }
        [DataMember] public string PaymentStatus { get; set; }
    }
}
