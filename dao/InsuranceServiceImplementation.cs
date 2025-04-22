using InsuranceManagementSystem.Entity;
using InsuranceManagementSystem.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.dao
{
    class InsuranceServiceImplementation : IPolicyService
    {
        public bool CreatePolicy(Policy policy)
        {
            using (SqlConnection conn = DBConnectionHelper.GetConnection())
                {
                    string query = "Insert into Policy (policyId, policyName, coverageAmount) values (@PolicyId, @PolicyName, @CoverageAmount)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PolicyId", policy.policyId);
                    cmd.Parameters.AddWithValue("@PolicyName", policy.policyName);
                    cmd.Parameters.AddWithValue("@CoverageAmount", policy.coverageAmount);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
         
        }

        // Method to get a policy by PolicyId
        public Policy GetPolicy(int policyId)
        {
            using (SqlConnection conn = DBConnectionHelper.GetConnection())
            {
                string query = "Select * from Policy where policyId = @PolicyId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PolicyId", policyId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Policy
                    {
                        policyId = (int)reader["PolicyId"],
                        policyName = (string)reader["PolicyName"],
                        coverageAmount = (int)reader["CoverageAmount"]
                    };
                }
                return null;
            }
        }

        // Method to get all policies
        public List<Policy> GetAllPolicies()
        {
            List<Policy> policies = new List<Policy>();
            using (SqlConnection conn = DBConnectionHelper.GetConnection())
            {
                string query = "Select * from Policy";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    policies.Add(new Policy
                    {
                        policyId = (int)reader["PolicyId"],
                        policyName = (string)reader["PolicyName"],
                        coverageAmount = (int)reader["CoverageAmount"]
                    });
                }
            }
                return policies;
           
        }

        // Method to update an existing policy
        public bool UpdatePolicy(Policy policy)
        {
            using (SqlConnection conn = DBConnectionHelper.GetConnection())
            {
                string query = "Update Policy set policyName = @PolicyName, coverageAmount = @CoverageAmount where policyId = @PolicyId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PolicyId", policy.policyId);
                cmd.Parameters.AddWithValue("@PolicyName", policy.policyName);
                cmd.Parameters.AddWithValue("@CoverageAmount", policy.coverageAmount);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            
            
        }

        // Method to delete a policy by PolicyId
        public bool DeletePolicy(int policyId)
        {
            using (SqlConnection conn = DBConnectionHelper.GetConnection())
            {
                string query = "Delete from Policy where policyId = @PolicyId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PolicyId", policyId);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            
           
        }
    }
}
