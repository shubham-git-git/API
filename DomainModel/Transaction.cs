using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Transaction
    {
        public Guid Id { get; set; }

        public Guid AssetId { get; set; }
        public Asset Asset { get; set; } = default!;

        public DateTime Date { get; set; }          // Date of transaction
        public decimal Units { get; set; }          // Number of units bought/sold
        public decimal PricePerUnit { get; set; }   // NAV or stock price
        public decimal Charges { get; set; }        // Optional brokerage/tax

        public string Type { get; set; } = "Buy";   // Buy, Sell, SIP

        public string Note { get; set; } = string.Empty;
    }
}
