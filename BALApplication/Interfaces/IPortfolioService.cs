using BALApplication.DTOs;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALApplication.Interfaces
{
    public interface IPortfolioService
    {
        Task<Portfolio> CreatePortfolioAsync(CreatePortfolioDto dto, string userId);
        Task<List<PortfolioDto>> GetUserPortfolioAsync(string userId);
    }
}
