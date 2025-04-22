using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Entity
{
    class Payment
    {
        public int paymentId { get; set; }
        public DateTime paymentDate { get; set; }
        public double paymentAmount { get; set; }
        public Client client { get; set; }

        public Payment() { }
        public Payment(int paymentId, DateTime paymentDate, double paymentAmount, Client client)
        {
            this.paymentId = paymentId;
            this.paymentDate = paymentDate;
            this.paymentAmount = paymentAmount;
            this.client = client;
        }
        public override string ToString()
        {
            return $"Payment ID: {paymentId}, Date: {paymentDate.ToShortDateString()}, Amount: {paymentAmount}, Client: {client?.clientName}";
        }

    }
}
