using ArcadeScore.Domain.Entities;
using ArcadeScore.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArcadeScore.Infrastruture
{
    public class ScoreRepository : IScoreRepository
    {
        private readonly MyDbContext _context;
        public ScoreRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Score>> GetAllAsync()
        {
            var result = await _context.Score
                .OrderByDescending(o => o.Points)
                .ToListAsync();

            return result.Take(10);
        }

        public async Task AddAsync(Score score) 
        {
            score = new Score
            {
                Points = score.Points,
                Date = score.Date,
                Player = score.Player
            };

            _context.Score.Add(score);
            await _context.SaveChangesAsync();
        }
    }

}
