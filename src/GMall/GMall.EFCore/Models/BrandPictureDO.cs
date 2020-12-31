namespace GMall.EFCore
{
    public class BrandPictureDO : BaseDO<int>
    {
        public int BrandId { get; set; }
        public int UId { get; set; }
        public string PictureId { get; set; }
        public int UseType { get; set; }
    }
}
