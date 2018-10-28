using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uplantApi.Models.Persons;

namespace uplantApi.Models
{
    public class Products
    {
        public Guid Id { get; set; }
        public String productName { get; set; }
        public Farmer farmer { get; set; }
        public Investor investors { get; set; }
        public String productDetails { get; set; }
        public long minimumProfitability { get; set; }
        public long maximumProfitability { get; set; }
        public long returnTime { get; set; }
        public long totlaInvestment { get; set; }
        public long minimumInvestiment { get; set; }
    }
}
