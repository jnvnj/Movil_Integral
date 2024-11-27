using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BallonParty.Models
{
    public class Cita
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string NombreCompleto { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string DetallesEvento { get; set; }
    }
}
