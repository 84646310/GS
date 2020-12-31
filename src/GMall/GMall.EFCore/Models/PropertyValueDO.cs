namespace GMall.EFCore
{
    public class PropertyValueDO : BaseDO<int>
    {
        public long PropertyId { get; set; }
        public string Name { get; set; }
        public int Sort { get; set; }
    }
}
