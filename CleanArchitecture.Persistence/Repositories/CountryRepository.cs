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
    public class CountryRepository : ICountryRepository
    {
        private readonly IGenericRepository<Country> _repository;

        public CountryRepository(IGenericRepository<Country> repository)
        {
            _repository = repository;
        }
    }
}
