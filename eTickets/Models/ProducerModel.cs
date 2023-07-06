using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class ProducerModel : PersonalModel
    {
        //Relationships
        public List<MovieModel> Movies { get; set; }
        
        public ProducerModel(int id, string profilePictureURL, string fullName, string bio) : base(id, profilePictureURL, fullName, bio)
        {
        }

       

        

    }
}
