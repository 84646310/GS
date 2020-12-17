namespace GMall.EFCore
{
    public class CategoryDO
    { 
        public long Id { get; set; }
        public long ParentId { get; set; } 
        public string Name { get; set; }
        public int Sort { get; set; }
        public bool Active { get; set; }
    }
}
