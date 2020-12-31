namespace GMall.EFCore
{
    public class CategoryPropertyValueDO : BaseDO<int>
    {
        public int CategoryId { get; set; }
        public int CategoryPropertyId { get; set; } 
        public string PropertyValueId { get; set; }
    }
}
