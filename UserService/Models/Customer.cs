using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<CreditCard> CreditCards { get; set; }

        public Customer() { }

        public Customer(int customerId, string name, string lastName, string email, string password)
        {
            CustomerId = customerId;
            Name = name;
            LastName = lastName;
            Email = email;
            Password = password;
        }
    }
}
