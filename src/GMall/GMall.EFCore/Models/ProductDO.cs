namespace GMall.EFCore
{
    public class ProductDO
    { 
        public long Id { get; set; }
        public string Name { get; set; }
        public string ModelCode { get; set; }
        public string Description { get; set; }
        public string Introduction { get; set; }
        public long BrandId { get; set; }
        public long CategoryId { get; set; }
    }
}
