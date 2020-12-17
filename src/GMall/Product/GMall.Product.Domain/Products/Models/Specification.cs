﻿using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Products
{
    public class Specification : Entity<SpecificationId>
    {
        public ICollection<KeyValuePair<PropertyId, PropertyValueId>> Properties { get; private set; }
        public Money UnitPrice { get; private set; }
        private string JsonString { get; set; }
        public Specification(SpecificationId aId, ICollection<KeyValuePair<PropertyId, PropertyValueId>> aProperties, Money aUnitPrice) : base(aId)
        {
            Properties = aProperties;
            UnitPrice = aUnitPrice;
        }
        public string ToJson()
        {
            if (string.IsNullOrWhiteSpace(JsonString))
                ConvertToJson();
            return JsonString;
        }

        private string ConvertToJson()
        {
            if (Properties.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("[");
                foreach (var item in Properties)
                {
                    sb.Append("{");
                    sb.Append($"\"pid\":{item.Key.Value},");
                    sb.Append($"\"pvid\":{item.Value.Value}");
                    sb.Append("}");
                    sb.Append(",");
                }
                sb.Remove(sb.Length - 1, 1);
                sb.Append("]");
                JsonString = sb.ToString();
                return JsonString;
            }
            return "";
        }
    }
}
