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
        public string ModelCode { get; private set; }
        public string Description { get; private set; }
        public BrandId BrandId { get; private set; }
        public CategoryId CategoryId { get; private set; }
        public IList<SaleProperty> SaleProperties { get; private set; }
        public IList<CustomProperty> CustomProperties { get; private set; }
        public IList<Specification> Specifications { get; private set; }
        public Product(ProductId aId,
            string aModelCode,
            string aDescription,
            BrandId aBrandId,
            CategoryId aCategoryId,
            IList<SaleProperty> aSaleProperties,
            IList<CustomProperty> aCustomProperties
            ) : base(aId)
        {
            ModelCode = aModelCode;
            Description = aDescription;
            BrandId = aBrandId;
            CategoryId = aCategoryId;
            SaleProperties = aSaleProperties;
            CustomProperties = aCustomProperties;
        }
        public Product(ProductId aId) : base(aId)
        {
        }
        private void CreateSpecification()
        {
            var sourceSaleProperty = new List<SaleProperty>()
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
            var resultSpecification = new List<Specification>();
            var listProperties = new List<KeyValuePair<PropertyId, PropertyValueId>>();
            int index = 0;
            this.Cartesian(sourceSaleProperty, index, resultSpecification, listProperties);
            Specifications = new List<Specification>(resultSpecification);
        }

        private void Cartesian(IList<SaleProperty> sourceSaleProperty, int aIndex, IList<Specification> resultSpecification, IList<KeyValuePair<PropertyId, PropertyValueId>> resultProperties)
        {
            var propertyId = sourceSaleProperty[aIndex].PropertyId;
            IList<PropertyValueId> propertyValueIds = sourceSaleProperty[aIndex].PropertyValueIds;
            foreach (var item in propertyValueIds)
            {
                var tempProperties = new List<KeyValuePair<PropertyId, PropertyValueId>>(resultProperties);
                tempProperties.Add(new KeyValuePair<PropertyId, PropertyValueId>(propertyId, item));
                if (aIndex + 1 < sourceSaleProperty.Count)
                {
                    Cartesian(sourceSaleProperty, aIndex + 1, resultSpecification, tempProperties);
                }
                else
                {
                    Specification data = new Specification(1, tempProperties);
                    resultSpecification.Add(data);
                }
            }
        }
    }
}
