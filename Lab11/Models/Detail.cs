namespace Lab11.Models
{
    public class Detail
    {
        public int DetailId { get; set; }
        public float  Price { get; set; }
        public int Amount { get; set; }
        public float Subtotal { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

    }
}
