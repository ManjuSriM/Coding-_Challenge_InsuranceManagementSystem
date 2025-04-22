using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Entity
{
    class Claim
    {
        public int claimId { get; set; }
        public string claimNumber { get; set; }
        public DateTime dateFiled { get; set; }
        public int claimAmount { get; set; }
        public string status { get; set; }
        public Policy policy { get; set; }
        public Client client { get; set; }
        public Claim() { }
        public Claim(int claimId, string claimNumber, DateTime dateFiled, int claimAmount, string status, Policy policy, Client client)
        {
            this.claimId = claimId;
            this.claimNumber = claimNumber;
            this.dateFiled = dateFiled;
            this.claimAmount = claimAmount;
            this.status = status;
            this.policy = policy;
            this.client = client;
        }
        public override string ToString()
        {
            return $"Claim ID: {claimId}, Number: {claimNumber}, Date Filed: {dateFiled.ToShortDateString()}, " +
                   $"Amount: {claimAmount}, Status: {status}, " +
                   $"Policy: {policy.policyName}, Client: {client.clientName}";
        }
    }
}
