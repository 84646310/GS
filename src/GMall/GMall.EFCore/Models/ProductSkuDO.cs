namespace GMall.EFCore
{
    public class ProductSkuDO
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long SpecificationId { get; set; }
        public decimal UnitPrice { get; set; }
        public long PictureId { get; set; }
        public int Sellable { get; set; }
        public int Available { get; set; }
    }
}
