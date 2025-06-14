using API.DALInfrastructure.Data;
using BALApplication.DTOs;
using BALApplication.Interfaces;
using DomainModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALInfrastructure.Services
{
    public class PortfolioService : IPortfolioService
    {
        private readonly AppDbContext _db;

        public PortfolioService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<Portfolio> CreatePortfolioAsync(CreatePortfolioDto dto, string userId)
        {
            var entity = new Portfolio()
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                UserId = userId
            };
            _db.portfolios.Add(entity);
            await _db.SaveChangesAsync();
            return new Portfolio { Id = entity.Id, Name = entity.Name };
        }

        public async Task<List<PortfolioDto>> GetUserPortfolioAsync(string userId)
        {
            return await _db.portfolios.Where(p => p.UserId == userId)
            .Select(p => new PortfolioDto
            {
                Id = p.Id,
                Name = p.Name
            })
            .ToListAsync();
        }
    }
}
