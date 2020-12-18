namespace GMall.EFCore
{
    public class CategoryPictureDO
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int UseType { get; set; }
        public long PictureId { get; set; }
    }
}
