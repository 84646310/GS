namespace GMall.EFCore
{
    public class ProductCustomPropertyDO : BaseDO<int>
    {
        public string UId { get; set; }
        public string ProductId { get; set; }
        public string PropertyId { get; set; }
        public string PropertyValue { get; set; }
    }
}
