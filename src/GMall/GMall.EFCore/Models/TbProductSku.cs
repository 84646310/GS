namespace GMall.EFCore
{
    public class TbProductSku
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long SpecificationId { get; set; }
    }
}
