using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALApplication.DTOs
{
    //post
    public class CreatePortfolioDto
    {
        public string Name { get; set; } = string.Empty;
    }
    //gets
    public class PortfolioDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
