using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using API_mockup.Models;
using System.Threading.Tasks;

namespace API_mockup.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnvioController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<EnvioController> _logger;

        public EnvioController(ILogger<EnvioController> logger)
        {
            _logger = logger;
        }

        [HttpPost, Route("v1/linkNotaFiscal")]
        public linkNotaFiscal linkNotaFiscal()
        {
            linkNotaFiscal linkAq = new linkNotaFiscal();
            return linkAq;
        }

        [HttpPost, Route("v1/CodigosProdutosSupermercados")]
        public IEnumerable<WeatherForecast> CodigosProdutosSupermercados()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost, Route("v1/ProdutosEscolhidos")]

        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
