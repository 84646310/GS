namespace GMall.EFCore
{
    public class ProductCustomPropertyDO
    {
        public int Id { get; set; }
        public long ProductId { get; set; }
        public long PropertyId { get; set; }
        public string PropertyValue { get; set; }
    }
}
