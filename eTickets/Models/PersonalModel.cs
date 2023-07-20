using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class PersonalModel : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is requerid")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is requerid")]
        public string Bio { get; set; }

        public PersonalModel()
        {
        }

        public PersonalModel(int id, string profilePictureURL, string fullName, string bio)
        {
            Id = id;
            ProfilePictureURL = profilePictureURL;
            FullName = fullName;
            Bio = bio;
        }
    }
}
