using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Models
{
    public class CreditCard
    {
        [Key]
        public int CreditCardId { get; set; }
        public string CreditCardType { get; set; }
        public string CreditCardNumber { get; set; }
        public string Code { get; set; }
        public DateTime CreditCardExpiration { get; set; }
        
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public CreditCard() { }

        public CreditCard(string creditCardType, string creditCardNumber, string code, DateTime creditCardExpiration, int customerId)
        {
            CreditCardType = creditCardType;
            CreditCardNumber = creditCardNumber;
            Code = code;
            CreditCardExpiration = creditCardExpiration;
            CustomerId = customerId;
        }
    }
}
