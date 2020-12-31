namespace GMall.EFCore
{
    public class PropertyDO : BaseDO<int>
    {
        public string Name { get; set; }
        public int Sort { get; set; }
    }
}
