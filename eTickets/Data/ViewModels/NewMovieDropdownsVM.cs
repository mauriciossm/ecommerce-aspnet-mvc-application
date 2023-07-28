using eTickets.Models;
using System.Collections.Generic;

namespace eTickets.Data.ViewModels
{
    public class NewMovieDropdownsVM
    {
        public List<ProducerModel> Producers { get; set; }
        public List<CinemaModel> Cinemas { get; set; }
        public List<ActorModel> Actors { get; set; }

        public NewMovieDropdownsVM()
        {
            Producers = new List<ProducerModel>();
            Cinemas = new List<CinemaModel>();
            Actors = new List<ActorModel>();
        }
    }
}
