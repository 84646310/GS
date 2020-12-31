namespace GMall.EFCore
{
    public class PictureDO : BaseDO<int>
    {
        public string UId { get; set; }
        public string RemoteUrl { get; set; }
        public string LocalPath { get; set; }
    }
}
