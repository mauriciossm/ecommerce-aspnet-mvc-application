namespace eTickets.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; }
        public MovieModel Movie { get; set; }

        public int ActorId { get; set; }
        public ActorModel Actor { get; set; }
    }
}
