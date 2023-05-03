using ArcadeScore.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArcadeScore.Domain.Repositories.Interfaces
{
    public interface IScoreRepository
    {
        Task<IEnumerable<Score>> GetAllAsync();
        Task AddAsync(Score score);
    }
}
