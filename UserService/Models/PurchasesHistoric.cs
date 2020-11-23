using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Models
{
    public class PurchasesHistoric
    {
        public int PurchasesHistoricId { get; set; }
        public int PurchasesItemId { get; set; }
        
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public PurchasesHistoric(int purchasesHistoricId, int purchasesItemId, int customerId)
        {
            PurchasesHistoricId = purchasesHistoricId;
            PurchasesItemId = purchasesItemId;
            CustomerId = customerId;
        }
    }
}
