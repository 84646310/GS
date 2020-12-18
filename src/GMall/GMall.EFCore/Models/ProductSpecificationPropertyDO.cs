namespace GMall.EFCore
{
    public class ProductSpecificationPropertyDO
    {
        public int Id { get; set; }
        public long ProductId { get; set; }
        public long SpecificationId { get; set; }
        public long PropertyId { get; set; }
        public string Property { get; set; }
        public long PropertyValueId { get; set; }
        public string PropertyValue { get; set; }
    }
}
