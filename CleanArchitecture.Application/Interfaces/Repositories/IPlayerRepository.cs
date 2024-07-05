using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Interfaces.Repositories
{
    public interface IPlayerRepository
    {
        Task<List<Player>> GetPlayersByClubAsync(int clubId);
    }
}
