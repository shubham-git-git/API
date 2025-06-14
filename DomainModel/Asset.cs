using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Asset
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty; // e.g., "HDFC Top 100"
        public string Type { get; set; } = string.Empty; // e.g., "Mutual Fund", "Stock"
        public string Symbol { get; set; } = string.Empty; // e.g., NSE Code or ISIN
        public string Category { get; set; } = string.Empty; // e.g., "Equity", "Debt"

        public Guid PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; } = default!;

        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
