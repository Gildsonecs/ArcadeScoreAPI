using ArcadeScore.Domain.Entities;
using ArcadeScore.Domain.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArcadeScore.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScoreController : ControllerBase
    {
        private readonly IScoreRepository _repository;

        public ScoreController(IScoreRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("ranking")]
        public async Task<IEnumerable<Score>> Get()
        {
            return await _repository.GetAllAsync();
        }

        [HttpPost("registrar-pontuacao")]
        public async Task<ActionResult> Post(Score score)
        {
            await _repository.AddAsync(score);
            return CreatedAtAction(nameof(Get), new { id = score.Id }, score);
        }
    }

}
