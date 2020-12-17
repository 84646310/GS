using System;
using System.Collections;
using System.Collections.Generic;

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
            var s1 = 3;
            var s2 = 10;
            decimal s3 = Convert.ToDecimal(s1) / s2;

            var initDate = new DateTime(2020, 1, 1);
      
            IEnumerable<int> e1;
            ICollection c;
            ICollection<int> c1 = null;
            IList l;
            IList<int> l1 = null;
            
            foreach (var item in c1)
            {

            }
            
            foreach (var item in l1)
            {

            }
            IDictionary c3;
            Console.WriteLine(s3);
            Console.ReadLine();

        }

    }
    public class ProductId : StringGuid
    {
        public ProductId() : base()
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
