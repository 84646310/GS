using System;

namespace GS.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product p = new Product(new GMall.Types.ProductId(1));
            //p.CreateSpecification();

            //var id = new ProductId();

            //Console.WriteLine("***********");
            //var id2 = new ProductId("2");
            //var ss = id.ToString();
             

            Console.ReadLine();

        }
        
    }
    public class ProductId : StringGuid
    {
        public ProductId():base()
        {
            Console.WriteLine("ProductId-无参-构造函数");
        }
        public ProductId(string aValue)
        {
            Console.WriteLine("ProductId-有参-构造函数");
            Value = aValue;
        }
    }
    public abstract class StringGuid 
    {
        protected string Value { get; set; }
        public StringGuid()
        {
            Console.WriteLine("StringGuid-无参-构造函数");
            Value = CreateGuid();
        }
        public StringGuid(string aValue)
        {
            Console.WriteLine("StringGuid-有参-构造函数");
            Value = aValue;
        }
        private string CreateGuid()
        {
            Console.WriteLine("CreateGuid");
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            return string.Format("{0:x}", i - DateTime.Now.Ticks);
        }
    }
}
