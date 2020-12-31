namespace GMall.EFCore
{
    public class BrandDO : BaseDO<int>
    {
        public string UId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int Sort { get; set; }
        public bool Enabled { get; set; }
    }
    
}
