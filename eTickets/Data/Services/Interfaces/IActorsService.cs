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
        Task AddAsync(ActorModel actor);
        Task<ActorModel> UpdateAsync(int id, ActorModel actorDB);
        Task DeleteAsync(int id);
    }
}
