using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class ShoppingCartItemModel
    {
        [Key]
        public int Id { get; set; }
        public MovieModel Movie { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
