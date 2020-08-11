using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AngularAPI.Models;
using AngularAPI.Services;
using Microsoft.AspNetCore.Authorization;

namespace AngularAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GebruikerController : ControllerBase
    {
        private readonly DataContext _context;
        private IUserService _userService;

        public GebruikerController(DataContext context, IUserService userService)
        {
            _userService = userService;
            _context = context;
          
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] Gebruiker userParam)
        {
            var gebruiker = _userService.Authenticate(userParam.Email, userParam.Wachtwoord);
            if (gebruiker == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(gebruiker);
        }

        // GET: api/Gebruiker
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gebruiker>>> GetGebruikers()
        {
            var gebruikerID = User.Claims.FirstOrDefault(c => c.Type == "GebruikerID").Value;
            return await _context.Gebruikers.ToListAsync();
        }

        [HttpGet("checkUsername/{naam}")]
        public async Task<ActionResult<Boolean>> checkUsername(string naam)
        {
            var gebruiker = await _context.Gebruikers
                .FirstOrDefaultAsync(g => g.Gebruikersnaam == naam);

            if (gebruiker == null)
            {
                return false;
            }
            return true;
        }

        [HttpGet("checkEmail/{email}")]
        public async Task<ActionResult<Boolean>> checkEmail(string email)
        {
            var gebruiker = await _context.Gebruikers
                .FirstOrDefaultAsync(g => g.Email == email);

            if (gebruiker == null)
            {
                return false;
            }
            return true;
        }

        // GET: api/Gebruiker/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Gebruiker>> GetGebruiker(long id)
        {
            var gebruiker = await _context.Gebruikers.FindAsync(id);

            if (gebruiker == null)
            {
                return NotFound();
            }

            return gebruiker;
        }

        // PUT: api/Gebruiker/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGebruiker(long id, Gebruiker gebruiker)
        {
            if (id != gebruiker.GebruikerID)
            {
                return BadRequest();
            }

            _context.Entry(gebruiker).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GebruikerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Gebruiker
        [HttpPost]
        public async Task<ActionResult<Gebruiker>> PostGebruiker(Gebruiker gebruiker)
        {
            _context.Gebruikers.Add(gebruiker);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGebruiker", new { id = gebruiker.GebruikerID }, gebruiker);
        }

        // DELETE: api/Gebruiker/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Gebruiker>> DeleteGebruiker(long id)
        {
            var gebruiker = await _context.Gebruikers.FindAsync(id);
            if (gebruiker == null)
            {
                return NotFound();
            }

            _context.Gebruikers.Remove(gebruiker);
            await _context.SaveChangesAsync();

            return gebruiker;
        }

        private bool GebruikerExists(long id)
        {
            return _context.Gebruikers.Any(e => e.GebruikerID == id);
        }
    }
}
