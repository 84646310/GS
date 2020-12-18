namespace GMall.EFCore
{
    public class CategoryPropertyValueDO
    {
        public int Id { get; set; }
        public long CategoryId { get; set; }
        public long PropertyId { get; set; }
        public long PropertyValueId { get; set; }
    }
}
