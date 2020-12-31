namespace GMall.EFCore
{
    public class ProductDO : BaseDO<int>
    {
        public string UId { get; set; }
        public string Name { get; set; }
        public string ModelCode { get; set; }
        public string Description { get; set; }
        public string Introduction { get; set; }
        public string BrandId { get; set; }
        public string CategoryId { get; set; }
    }
}
