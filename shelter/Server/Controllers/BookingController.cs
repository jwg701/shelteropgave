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
    public class BookingController : ControllerBase
    {
        // Indkapsling
        private IMongoCollection<Booking> _shelterCollection;

        [Obsolete]
        public BookingController(IMongoClient client)
        {
            var database = client.GetDatabase("shelterdb");
            _shelterCollection = database.GetCollection<Booking>("booking");
        }

        [HttpGet]
        public IEnumerable<Booking> Get()
        {
            return _shelterCollection.Find(b => b.Navn == "Martin").ToList();
        }
    }
}
