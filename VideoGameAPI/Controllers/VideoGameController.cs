using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using VideoGameAPI.Data;
using VideoGameAPI.Model;

namespace VideoGameAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController(VideoGameDbContext context) : ControllerBase
    {
        private readonly VideoGameDbContext _context = context;


        [HttpGet]
        public async Task<ActionResult<List<VideoGame>>> GetVideoGames()
        {
            return Ok(await 
                _context.videoGames.ToListAsync());
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<VideoGame>> GetVideoGameById(int id)
        {
            var game = await _context.videoGames.FindAsync(id);
            if (game == null)
                return NotFound();
            return Ok(game);
        }
        [HttpPost]
        public async Task<ActionResult<VideoGame>> AddVideoGame(VideoGame newGame)
        {
            if (newGame == null)
                return BadRequest();
            _context.videoGames.Add(newGame);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetVideoGameById), new { id = newGame.Id }, newGame);
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateVideoGame(int id, VideoGame updatedGame)
        {
            var game = await _context.videoGames.FindAsync(id);
            if (game == null)
                return NotFound();
            game.Title = updatedGame.Title;
            game.Platform = updatedGame.Platform;   
            game.Developer = updatedGame.Developer;
            game.Publisher = updatedGame.Publisher;
            game.GameImageURL = updatedGame.GameImageURL;
            game.GameLinkDownloadURL = updatedGame.GameLinkDownloadURL;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteVideoGame(int id)
        {
            var game = await _context.videoGames.FindAsync(id);
            if (game == null)
                return NotFound();
            _context.videoGames.Remove(game);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
