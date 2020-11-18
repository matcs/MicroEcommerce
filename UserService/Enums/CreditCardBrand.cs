using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Enums
{
    public enum CreditCardBrand
    {
        [Description("Visa")]
        Visa,
        [Description("Master")]
        Master,
        [Description("Elo")]
        Elo
    }
}
