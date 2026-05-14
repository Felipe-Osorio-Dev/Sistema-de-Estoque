namespace EstoqueAPI.Models.Product
{
    public class ProductModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string BarCode { get; set; }
        public int Amount { get; set; }
        public DateOnly Validate { get; set; }
    }
}
