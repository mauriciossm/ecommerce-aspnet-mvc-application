using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class OrderItemModel
    {
        [Key] 
        public int Id { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public virtual MovieModel Movie { get; set; }
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual OrderModel Order { get; set; }
    }
}
