using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Web.Models.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public int MovieId { get; set; }

        [ForeignKey("MovieId")]
        public virtual Movie Movie { get; set; }

        public int OrderId { get; set; }

        [ForeignKey("MovieId")]
        public Order Order { get; set; }



    }
}
