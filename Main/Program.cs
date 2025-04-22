using InsuranceManagementSystem.dao;
using InsuranceManagementSystem.Entity;
using InsuranceManagementSystem.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of InsuranceServiceImpl
            IPolicyService policyService = new InsuranceServiceImplementation();

            bool exit = false;
            while (!exit)
            {
                // Menu-driven interface
                Console.WriteLine("\n--- Insurance Management System ---");
                Console.WriteLine("1. Create Policy");
                Console.WriteLine("2. Get Policy by ID");
                Console.WriteLine("3. Get All Policies");
                Console.WriteLine("4. Update Policy");
                Console.WriteLine("5. Delete Policy");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                try
                {
                    switch (choice)
                    {
                        case 1:
                            try
                            {
                                // Create Policy
                                Console.Write("Enter Policy ID: ");
                                int policyId = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter Policy Name: ");
                                string policyName = Console.ReadLine();
                                Console.Write("Enter Coverage Amount: ");
                                int amount = Convert.ToInt32(Console.ReadLine());

                                Policy newPolicy = new Policy { policyId = policyId, policyName = policyName, coverageAmount = amount };
                                bool createResult = policyService.CreatePolicy(newPolicy);

                                if (!createResult)
                                    throw new Exception("Policy creation failed.");

                                Console.WriteLine("Policy created successfully.");
                                Console.WriteLine($"The created policy is :- {newPolicy.ToString()}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error: {ex.Message}");
                            }
                            break;

                        case 2:
                            try
                            {
                                // Get Policy by ID
                                Console.Write("Enter Policy ID: ");
                                int policyId = Convert.ToInt32(Console.ReadLine());

                                Policy policy = policyService.GetPolicy(policyId);
                                if (policy == null)
                                    throw new PolicyNotFoundException($"Policy with ID {policyId} not found.");

                                Console.WriteLine("Policy Details: ");
                                Console.WriteLine(policy.ToString()); 
                            }
                            catch (PolicyNotFoundException ex)
                            {
                                Console.WriteLine($"Error: {ex.Message}");
                            }
                            break;

                        case 3:
                            try
                            {
                                // Get All Policies
                                List<Policy> policies = policyService.GetAllPolicies();
                                if (!policies.Any())
                                    throw new PolicyNotFoundException("No policies available.");

                                Console.WriteLine("All Policies: ");
                                foreach (var p in policies)
                                {
                                    Console.WriteLine(p.ToString()); 
                                }
                            }
                            catch (PolicyNotFoundException ex)
                            {
                                Console.WriteLine($"An error occurred: {ex.Message}");
                            }
                            break;

                        case 4:
                            try
                            {
                                // Update Policy
                                Console.Write("Enter Policy ID to update: ");
                                int policyId = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter new Policy Name: ");
                                string policyName = Console.ReadLine();
                                Console.Write("Enter Coverage Amount: ");
                                int amount = Convert.ToInt32(Console.ReadLine());

                                Policy updatedPolicy = new Policy { policyId = policyId, policyName = policyName, coverageAmount = amount };
                                bool updateResult = policyService.UpdatePolicy(updatedPolicy);

                                if (!updateResult)
                                    throw new PolicyNotFoundException("Policy update failed.");

                                Console.WriteLine("Policy updated successfully.");
                                Console.WriteLine("The updated policy is :");
                                Console.WriteLine(updatedPolicy.ToString());
                            }
                            catch (PolicyNotFoundException ex)
                            {
                                Console.WriteLine($"An error occurred: {ex.Message}");
                            }
                            break;

                        case 5:
                            try
                            {
                                // Delete Policy
                                Console.Write("Enter Policy ID to delete: ");
                                int policyId = Convert.ToInt32(Console.ReadLine());

                                bool deleteResult = policyService.DeletePolicy(policyId);

                                if (!deleteResult)
                                    throw new PolicyNotFoundException("Policy deletion failed.");

                                Console.WriteLine("Policy deleted successfully.");
                                
                            }
                            catch (PolicyNotFoundException ex)
                            {
                                Console.WriteLine($"An error occurred: {ex.Message}");
                            }
                            break;

                        case 6:
                            // Exit
                            exit = true;
                            Console.WriteLine("Exiting the program...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                catch (PolicyNotFoundException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}