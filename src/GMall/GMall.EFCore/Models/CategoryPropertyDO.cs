namespace GMall.EFCore
{
    public class CategoryPropertyDO : BaseDO<int>
    {
        public int CategoryId { get; set; }
        public int UId { get; set; }
        public string PropertyId { get; set; }
    }
}
