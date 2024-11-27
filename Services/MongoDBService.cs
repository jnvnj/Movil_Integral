using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using BallonParty.Models;

namespace BallonParty.Services
{
    public class MongoDBService
    {
        private readonly IMongoCollection<Cita> _citasCollection;

        public MongoDBService()
        {
            var client = new MongoClient("mongodb://localhost:27017/");
            var database = client.GetDatabase("Registro");
            _citasCollection = database.GetCollection<Cita>("Citas");
        }

        public async Task<List<Cita>> GetCitasAsync()
        {
            return await _citasCollection.Find(_ => true).ToListAsync();
        }

        public async Task AddCitaAsync(Cita cita)
        {
            await _citasCollection.InsertOneAsync(cita);
        }

        public async Task UpdateCitaAsync(string id, Cita cita)
        {
            await _citasCollection.ReplaceOneAsync(c => c.Id == id, cita);
        }

        public async Task DeleteCitaAsync(string id)
        {
            await _citasCollection.DeleteOneAsync(c => c.Id == id);
        }
    }
}
