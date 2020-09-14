using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exchange_rate.Models
{
    public class Rate
    {
        public int Id { get; set; } 
        public string Name { get; set; } //название валюты
        public decimal Value { get; set; } //значение валюты
    }
}
