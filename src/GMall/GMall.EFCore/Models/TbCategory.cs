namespace GMall.EFCore
{
    public class TbCategory
    { 
        public long Id { get; set; }
        public long ParentId { get; set; }
        public string Name { get; set; }
    }
}
