namespace GMall.EFCore
{
    public class CategoryDO : BaseDO<int>
    {
        public string UId { get; set; }
        public string ParentId { get; set; } 
        public string Name { get; set; }
        public int Sort { get; set; }
        public bool Enabled { get; set; }
    }
    
}
