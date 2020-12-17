namespace GMall.EFCore
{
    public class BrandPictureDO
    {
        public int Id { get; set; }
        public long BrandId { get; set; }
        public long PictureId { get; set; }
        public int UseType { get; set; }
    }
}
