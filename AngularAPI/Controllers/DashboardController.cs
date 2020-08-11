using AngularAPI.Models;
using AngularAPI.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : Controller
    {

        private readonly DataContext _context;

        public DashboardController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DashboardViewModel>> GetDashboard(long id)
        {
            DashboardViewModel d = new DashboardViewModel();
            List<Lijst> beheerderLijsten = new List<Lijst>();
            List<Stem> uStemmen = new List<Stem>();

            List<Lijst> lijsten = await _context.Lijsten
                .Include(l => l.Items)
                .ToListAsync();

            foreach (var item in lijsten)
            {
                    if (item.GebruikerID == id)
                    {
                        beheerderLijsten.Add(item);
                    }
                

            }

            List<Stem> stemmen = await _context.Stemmen
                .Include(s=> s.Item)
                .Include(s => s.Gebruiker)
                .ToListAsync();

            foreach (var item in stemmen)
            {
                if (item.GebruikerID == id)
                {
                    uStemmen.Add(item);
                }
            }

            d.BeheerderLijsten = beheerderLijsten;
            d.UitStemmen = uStemmen;

            return d;
        }
    }
}
