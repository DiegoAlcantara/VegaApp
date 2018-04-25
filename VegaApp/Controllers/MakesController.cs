using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VegaApp.Context;
using VegaApp.Entities;
using Microsoft.EntityFrameworkCore;
namespace VegaApp.Controllers
{
    [Produces("application/json")]
    [Route("api/Makes")]
    public class MakesController : Controller
    {
        private readonly VegaDbContext _context;
        public MakesController(VegaDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetMakes")]
        public async Task<IEnumerable<Make>> GetMakes()
        {

            return await _context.Makes.Include(m => m.Models).ToListAsync();
        }

    }
}