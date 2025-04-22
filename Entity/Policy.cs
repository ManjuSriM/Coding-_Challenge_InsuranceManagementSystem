using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Entity
{
    class Policy
    {
        public int policyId;
        public string policyName;
        public int coverageAmount;
        public Policy() { }
        public Policy(int id, string name, int amount)
        {
            policyId = id;
            policyName = name;
            coverageAmount = amount;
        }
        public override string ToString()
        {
            return $"Policy ID: {policyId}, Name: {policyName}, Coverage: {coverageAmount}";
        }

    }
}
