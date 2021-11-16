using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace shelter.Shared
{

    [BsonIgnoreExtraElements]
    public class Shelters
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("type")]
        public string type { get; set; }

        [BsonElement("geometry")]
        public object geometry { get; set; }

        [BsonElement("properties")]
        public Properties properties { get; set; } 

    }

    public class Properties
    {
        [BsonElement("objekt_id")]
        public string objekt_id { get; set; }

        [BsonElement("versions_id")]
        public string versions_id { get; set; }

        [BsonElement("kommunekode")]
        public int kommunekode { get; set; }

        [BsonElement("cvr_navn")]
        public string cvr_navn { get; set; }

        [BsonElement("cvr_kode")]
        public int cvr_kode { get; set; }

        [BsonElement("bruger_id")]
        public string bruger_id { get; set; }

        [BsonElement("navn")]
        public string navn { get; set; }

        [BsonElement("antal_pl")]
        public int? antal_pl { get; set; }

        [BsonElement("status")]
        public string status { get; set; }

        public Properties(string cvr_navn, int cvr_kode, string bruger_id, string navn, int? antal_pl,
            string objekt_id, string versions_id, int kommunekode, string status)
        {
            this.cvr_navn = cvr_navn;
            this.cvr_kode = cvr_kode;
            this.bruger_id = bruger_id;
            this.navn = navn;
            this.antal_pl = antal_pl;
            this.objekt_id = objekt_id;
            this.versions_id = versions_id;
            this.kommunekode = kommunekode;
            this.status = status;

        }

        public Properties()
        {

        }
    }

}
