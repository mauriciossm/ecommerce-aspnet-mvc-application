using eTickets.Data.Services.Interfaces;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(ActorModel model)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<ActorModel>> GetAll()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public ActorModel GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public ActorModel Update(int idm, ActorModel actorDB)
        {
            throw new System.NotImplementedException();
        }
    }
}
