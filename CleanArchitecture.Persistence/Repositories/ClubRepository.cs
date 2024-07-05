using CleanArchitecture.Application.Interfaces.Repositories;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Persistence.Contexts;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Persistence.Repositories
{
    public class ClubRepository : IClubRepository
    {
        private readonly IGenericRepository<Club> _repository;

        public ClubRepository(IGenericRepository<Club> repository)
        {
            _repository = repository;
        }
    }
}
