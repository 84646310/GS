using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Products
{
    public class Product : AggregateRoot<ProductId>
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public Money MinPrice { get; private set; }
        public Money MaxPrice { get; private set; }
        public BrandId BrandId { get; private set; }
        public CategoryId CategoryId { get; private set; }
        public IList<SaleProperty> SaleProperties { get; private set; }
        public IList<CustomProperty> CustomProperties { get; private set; }
        public IList<Specification> Specifications { get; private set; }
        public Product(ProductId aId,
            string aDescription,
            BrandId aBrandId,
            CategoryId aCategoryId,
            IList<SaleProperty> aSaleProperties,
            IList<CustomProperty> aCustomProperties
            ) : base(aId)
        {
            Description = aDescription;
            BrandId = aBrandId;
            CategoryId = aCategoryId;
            SaleProperties = aSaleProperties;
            CustomProperties = aCustomProperties;

            CreateSpecification();
        }
        public Product(ProductId aId) : base(aId)
        {
            var saleProperties = new List<SaleProperty>()
            {
                new SaleProperty(new PropertyId(1), new List<PropertyValueId>()
                {
                     new PropertyValueId(11),
                     new PropertyValueId(12),
                     new PropertyValueId(13)
                }),
                new SaleProperty(new PropertyId(2), new List<PropertyValueId>()
                {
                     new PropertyValueId(21),
                     new PropertyValueId(22),
                     new PropertyValueId(23)
                }),
                new SaleProperty(new PropertyId(3), new List<PropertyValueId>()
                {
                     new PropertyValueId(31),
                     new PropertyValueId(32),
                     new PropertyValueId(33)
                }),
                new SaleProperty(new PropertyId(4), new List<PropertyValueId>()
                {
                     new PropertyValueId(41),
                     new PropertyValueId(42),
                     new PropertyValueId(43)
                }),
            };
        }
        /// <summary>
        /// 根据销售属性生成产品规格
        /// </summary>
        private void CreateSpecification()
        {
            if (SaleProperties.Count > 0)
            {
                int index = 0;
                var tempProperties = new List<KeyValuePair<PropertyId, PropertyValueId>>();
                var resultProperties = new List<IList<KeyValuePair<PropertyId, PropertyValueId>>>();
                this.Cartesian(SaleProperties, index, resultProperties, tempProperties);
                if (resultProperties.Count > 0)
                {
                    var tempSpecifications = new List<Specification>();
                    foreach (var item in resultProperties)
                    {
                        tempSpecifications.Add(new Specification(new SpecificationId(), item, new Money(100)));
                    }
                    Specifications = tempSpecifications;
                }
            }
        }
        private void Cartesian(IList<SaleProperty> source, int aIndex, IList<IList<KeyValuePair<PropertyId, PropertyValueId>>> result, IList<KeyValuePair<PropertyId, PropertyValueId>> resultItem)
        {
            var sourceItem = source[aIndex];
            var propertyId = sourceItem.PropertyId;
            var propertyValueIds = sourceItem.PropertyValueIds;
            foreach (var item in propertyValueIds)
            {
                var tempProperties = new List<KeyValuePair<PropertyId, PropertyValueId>>(resultItem);
                tempProperties.Add(new KeyValuePair<PropertyId, PropertyValueId>(propertyId, item));
                if (aIndex + 1 < source.Count)
                    Cartesian(source, aIndex + 1, result, tempProperties);
                else
                    result.Add(tempProperties);
            }
        }
    }
}
