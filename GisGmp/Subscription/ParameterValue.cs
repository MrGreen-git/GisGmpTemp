using System;
using System.Xml.Serialization;

namespace GisGmp.Subscription
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Subscription/2.4.0")]
    public class ParameterValue
    {
        /// <summary />
        protected ParameterValue() { }

        /// <summary />
        public ParameterValue(string parameterCode, string value)
        {
            ParameterCode = parameterCode;
            Value = value;
        }

        [XmlAttribute("parameterCode")]
        public string ParameterCode { get; set; }

        [XmlText()]
        public string Value { get; set; }
    }
}
