namespace GMall.EFCore
{
    public class ProductSalePropertyDO : BaseDO<int>
    {
        public long ProductId { get; set; }
        public long PropertyId { get; set; } 
    }
}
