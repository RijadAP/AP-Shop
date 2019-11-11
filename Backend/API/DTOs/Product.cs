namespace DTOs
{
    public class Product
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string ShortDescription { get; set; }
        public double Price { get; set; }
        public double ShippingPrice { get; set; }
    }
}