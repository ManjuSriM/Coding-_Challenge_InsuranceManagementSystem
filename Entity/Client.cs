using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Entity
{
    class Client
    {
        public int clientId { get; set; }
        public String clientName { get; set; }
        public String contactInfo { get; set; }
        public Policy policy { get; set; }
        public Client() { }
        public Client(int clientId, String clientName, String contactInfo, Policy policy)
        {
            this.clientId = clientId;
            this.clientName = clientName;
            this.contactInfo = contactInfo;
            this.policy = policy;
        }
        public override string ToString()
        {
            return $"Client ID: {clientId}, Name: {clientName}, Contact: {contactInfo}, Policy: {policy?.policyName}";
        }

    }
}
