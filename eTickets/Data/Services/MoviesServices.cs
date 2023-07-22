using eTickets.Data.Base;
using eTickets.Data.Services.Interfaces;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class MoviesServices : EntityBaseRepository<MovieModel>, IMoviesService
    {
        private readonly AppDbContext _context;
        public MoviesServices(AppDbContext context) : base(context) 
        { 
            _context = context;
        }

        public async Task<MovieModel> GetMovieByIdAsync(int id)
        {
            var movieDetails = await _context.Movies
                .Include(c => c.Cinema)
                .Include(p => p.Producer)
                .Include(am => am.Actors_Movies).ThenInclude(a => a.Actor)
                .FirstOrDefaultAsync(n => n.Id == id);

            return movieDetails;
        }
    }
}
