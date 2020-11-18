using EnumsNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using UserService.Enums;

namespace UserService.Models
{
    public class CreditCard
    {
        [Key]
        public int CreditCardId { get; set; }
        public string HolderName { get; set; }
        public string Number { get; set; }
        public string Cvv { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string CreditCardBrand { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public CreditCard() { }

        public CreditCard(int creditCardId, string holderName, string number, string cvv, DateTime expirationDate, CreditCardBrand creditCardBrand, int customerId)
        {
            CreditCardId = creditCardId;
            HolderName = holderName;
            Number = number;
            Cvv = cvv;
            ExpirationDate = expirationDate;
            CreditCardBrand = creditCardBrand.ToString();
            CustomerId = customerId;
        }
    }
}
