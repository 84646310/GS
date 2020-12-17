namespace GMall.EFCore
{
    public class ProductPictureDO
    {
        public int Id { get; set; }
        public long ProductId { get; set; }
        public long PictureId { get; set; }
        public int UseType { get; set; }
    }
}
