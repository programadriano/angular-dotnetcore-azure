using Api.Domain;
using Api.Infra;
using Api.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repository
{
    public class DestaqueService : IDestaqueService
    {
        private readonly MongoRepository _repository = null;
        public DestaqueService(IOptions<Settings> settings)
        {
            _repository = new MongoRepository(settings);
        }

        public async Task Create(Destaques destaque)
        {
            destaque.dateCreated = DateTime.Now;
            destaque.dateUpdated = DateTime.Now;
            await _repository.destaque.InsertOneAsync(destaque);
        }

        public async Task<Destaques> GetAll()
        {
            return await _repository.destaque.Find(x => x.title != "").FirstOrDefaultAsync();
        }
    }
}
