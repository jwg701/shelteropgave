using shelter.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using MongoDB.Bson;

namespace shelter.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]

    // Nedarvning tager fra en anden klasse der hedder ControllorBase
    public class SheltersController : ControllerBase
    {
        // Indkapsling
        private IMongoCollection<Shelters> _shelterCollection;

        [Obsolete]
        public SheltersController(IMongoClient client)
        {
            var database = client.GetDatabase("shelterdb");
             _shelterCollection = database.GetCollection<Shelters>("shelters");
        }

        [HttpGet]
        public IEnumerable<Shelters> Get()
        {
            return _shelterCollection.Find(s => s.type == "Feature").ToList();
        }
    }
}
