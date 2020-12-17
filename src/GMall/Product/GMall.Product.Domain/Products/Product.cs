using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Products
{
    public class Product : AggregateRoot<ProductId>
    {
        public ProductInfo Info { get; private set; }
        public ICollection<PropertyInfo> PropertyInfos { get; private set; }
        public ICollection<CustomPropertyInfo> CustomPropertyInfos { get; private set; }
        public IList<SalePropertyInfo> SalePropertyInfos { get; private set; }
        public ICollection<Specification> Specifications { get; private set; }
        public Product(ProductId aId,
            ProductInfo aInfo,
            ICollection<PropertyInfo> aPropertyInfos,
            ICollection<CustomPropertyInfo> aCustomPropertyInfos,
            IList<SalePropertyInfo> aSalePropertyInfos
            ) : base(aId)
        {
            Info = aInfo;
            PropertyInfos = aPropertyInfos;
            SalePropertyInfos = aSalePropertyInfos;
            CustomPropertyInfos = aCustomPropertyInfos; 
        }
        public Product(ProductId aId) : base(aId)
        {
            var saleProperties = new List<SalePropertyInfo>()
            {
                new SalePropertyInfo(new PropertyId(1), new List<PropertyValueId>()
                {
                     new PropertyValueId(11),
                     new PropertyValueId(12),
                     new PropertyValueId(13)
                }),
                new SalePropertyInfo(new PropertyId(2), new List<PropertyValueId>()
                {
                     new PropertyValueId(21),
                     new PropertyValueId(22),
                     new PropertyValueId(23)
                }),
                new SalePropertyInfo(new PropertyId(3), new List<PropertyValueId>()
                {
                     new PropertyValueId(31),
                     new PropertyValueId(32),
                     new PropertyValueId(33)
                }),
                new SalePropertyInfo(new PropertyId(4), new List<PropertyValueId>()
                {
                     new PropertyValueId(41),
                     new PropertyValueId(42),
                     new PropertyValueId(43)
                }),
            };
        } 
        public void CreateSpecifications()
        {
            if (SalePropertyInfos.Count > 0)
            {
                int index = 0;
                var tempProperties = new List<KeyValuePair<PropertyId, PropertyValueId>>();
                var resultProperties = new List<ICollection<KeyValuePair<PropertyId, PropertyValueId>>>();
                this.Cartesian(SalePropertyInfos, index, resultProperties, tempProperties);
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
        private void Cartesian(IList<SalePropertyInfo> source, int aIndex, ICollection<ICollection<KeyValuePair<PropertyId, PropertyValueId>>> result, ICollection<KeyValuePair<PropertyId, PropertyValueId>> resultItem)
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
