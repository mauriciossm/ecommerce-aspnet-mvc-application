using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class ActorModel : PersonalModel
    {
        //Relationships
        public List<Actor_MovieModel> Actors_Movies { get; set; }

        public ActorModel()
        {
        }

        public ActorModel(int id, string profilePictureURL, string fullName, string bio) : base(id, profilePictureURL, fullName, bio)
        {
        }
    }
}
