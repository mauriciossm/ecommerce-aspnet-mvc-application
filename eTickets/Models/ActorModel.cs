using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class ActorModel : PersonalModel
    {
        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
        public ActorModel(int id, string profilePictureURL, string fullName, string bio) : base(id, profilePictureURL, fullName, bio)
        {
        }
    }
}
