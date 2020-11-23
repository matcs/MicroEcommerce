using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Models
{
    public class CustomerViewModel
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public CustomerViewModel() { }

        public CustomerViewModel(int customerId, string name, string lastName, string email, string password)
        {
            CustomerId = customerId;
            Name = name;
            LastName = lastName;
            Email = email;
            Password = password;
        }
    }
}
