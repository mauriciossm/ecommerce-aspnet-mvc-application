using eTickets.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services.Interfaces
{
    public interface IActorsService
    {
        Task<IEnumerable<ActorModel>> GetAllAsync();
        Task<ActorModel> GetByIdAsync(int id);
        Task AddAsync(ActorModel model);
        ActorModel Update(int idm, ActorModel actorDB);
        void Delete(int id);
    }
}
