using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exchange_rate.Models
{
    public class CurrencyConverter
    {
        public decimal Rate USD = new Rate {Name = "USD" };
        Rate EUR = new Rate {Name = "EUR" };
        Rate CNY = new Rate {Name = "CNY" };

        //public decimal USD { get; set; }
        //public decimal ConvertToUSD(decimal priceRUB) => priceRUB / USD;
        

        //public decimal EUR { get; set; }
        //public decimal ConvertToEUR(decimal priceRUB) => priceRUB / EUR;

        //public decimal CNY { get; set; }
        //public decimal ConvertToCNY(decimal PriceRUB) => PriceRUB / CNY;
    }
}
