using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DatingApp.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context){
            _context = context;
        }
        [AllowAnonymous]
        [HttpGet]
        public async  Task<IActionResult> GetValues(){
            var values= await _context.Values.ToListAsync();
            return Ok(values) ;
        }
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task< IActionResult> GetValues(int id){
            var values= await _context.Values.FirstOrDefaultAsync(x=> x.Id == id );
            return Ok(values) ;
        }

       
        /*public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }*/
    }
}
