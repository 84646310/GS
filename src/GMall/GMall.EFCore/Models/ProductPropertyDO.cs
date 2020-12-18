namespace GMall.EFCore
{
    public class ProductPropertyDO
    {
        public int Id { get; set; }
        public long ProductId { get; set; }
        public long PropertyId { get; set; }
        public long PropertyValueId { get; set; }
        public string PropertyValue { get; set; }
    }
}
