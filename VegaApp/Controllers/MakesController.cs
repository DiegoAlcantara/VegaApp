using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VegaApp.Context;
using VegaApp.Entities;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using VegaApp.Resources;

namespace VegaApp.Controllers
{
    [Produces("application/json")]
    [Route("api/Makes")]
    public class MakesController : Controller
    {
        private readonly VegaDbContext _context;
        private readonly IMapper mapper;

        public MakesController(VegaDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        [HttpGet("GetMakes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {

            var makes= await _context.Makes.Include(m => m.Models).ToListAsync();

            var makesResource = mapper.Map<List<Make>,List<MakeResource>> (makes);

            return makesResource;


        }

    }
}