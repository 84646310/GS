namespace GMall.EFCore 
{
    public class BrandDO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int Sort { get; set; }
        public bool Active { get; set; }
    }
}
