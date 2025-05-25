using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public int AmountOfBooks { get; set; }
        public decimal Price { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
