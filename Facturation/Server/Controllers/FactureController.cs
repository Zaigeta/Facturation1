using Facturation.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturation.Server.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class FactureController : ControllerBase
    {
        private static readonly string[] Numeros = new[]
        {
            "002554388132", "0035568977512", "001578945625", "005487623213", "005487789623", "004875523475"
        };

        private static readonly string[] Clients = new[]
        {
            "Amine Brioueg", "Ayoub Blanchet", "Jordan Leston", "Theo Castet", "Paul Benetier", "Bastien Leviez"
        };

        private readonly ILogger<FactureController> logger;

        public FactureController(ILogger<FactureController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IEnumerable<Facture> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Facture
            {
                DateE = DateTime.Now.AddDays(index),
                DateR = DateTime.Now.AddDays(index),
                MontantD = rng.Next(-20, 55),
                MontantR = rng.Next(-20, 55),
                Numero = Numeros[rng.Next(Numeros.Length)],
                Client = Clients[rng.Next(Clients.Length)]

            })
            .ToArray();
        }
    }
}
