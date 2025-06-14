using API.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Portfolio
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string UserId { get; set; } = default!; 
        public User User { get; set; } = default!;

        public ICollection<Asset> Assets { get; set; } = new List<Asset>();
    }
}
