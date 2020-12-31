namespace GMall.EFCore
{
    public class ProductSpecificationDO : BaseDO<int>
    {
        public long ProductId { get; set; }
        public string PropertyString { get; set; }
    }
}
