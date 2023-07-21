using eTickets.Data.Base;
using eTickets.Data.Services.Interfaces;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public class MoviesServices : EntityBaseRepository<MovieModel>, IMoviesService
    {
        public MoviesServices(AppDbContext context) : base(context) { }
    }
}
