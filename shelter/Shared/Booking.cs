using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace shelter.Shared
{

    [BsonIgnoreExtraElements]
    public class Booking
    {
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; } = MongoDB.Bson.ObjectId.GenerateNewId().ToString();
        public string Navn { get; set; } = "";
        public string Email { get; set; } = "";
        public int Tlf { get; set; } = 0;
        public int Antal_pl { get; set; } = 0;
        public DateTime? StartDato { get; set; } = null;
        public DateTime? SlutDato { get; set; } = null;

        public Booking(string navn, string email, int tlf, int antal_pl,
            DateTime startdato, DateTime slutdato)
        {
            Navn = navn;
            Email = email;
            Tlf = tlf;
            Antal_pl = antal_pl;
            StartDato = startdato;
            SlutDato = slutdato;
        }

        public Booking()
        {

        }
    }

}
