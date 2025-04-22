using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Entity
{
    class Users
    {
        public int userId { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public String role { get; set; }
        public Users() { }
        public Users(int userId, String username, String password, String role)
        {
            this.userId = userId;
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public override string ToString()
        {
            return $"User ID: {userId}, Username: {username}, Role: {role}";
        }
    }
}
