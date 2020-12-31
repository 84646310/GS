namespace GMall.EFCore
{
    public class ProductSalePropertyValueDO : BaseDO<int>
    {
        public long ProductId { get; set; }
        public long PropertyId { get; set; }
        public long PropertyValueId { get; set; }
    }
}
