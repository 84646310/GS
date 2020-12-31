namespace GMall.EFCore
{
    public class ProductPropertyDO : BaseDO<int>
    { 
        public long ProductId { get; set; }
        public long PropertyId { get; set; }
        public long PropertyValueId { get; set; }
        public string PropertyValue { get; set; }
    }
}
