using eTickets.Data.Base;
using eTickets.Models;
using System.Threading.Tasks;

namespace eTickets.Data.Services.Interfaces
{
    public interface IMoviesService : IEntityBaseRepository<MovieModel>
    {
        Task<MovieModel> GetMovieByIdAsync(int id);
    }
}
