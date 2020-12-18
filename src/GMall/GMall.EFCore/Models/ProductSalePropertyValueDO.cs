namespace GMall.EFCore
{
    public class ProductSalePropertyValueDO
    {
        public int Id { get; set; }
        public long ProductId { get; set; }
        public long PropertyId { get; set; }
        public long PropertyValueId { get; set; }
    }
}
