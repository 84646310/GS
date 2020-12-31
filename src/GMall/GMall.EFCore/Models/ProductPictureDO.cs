namespace GMall.EFCore
{
    public class ProductPictureDO : BaseDO<int>
    {
        public int UId { get; set; }
        public int ProductId { get; set; }
        public string PictureId { get; set; }
        public int UseType { get; set; }
    }
}
