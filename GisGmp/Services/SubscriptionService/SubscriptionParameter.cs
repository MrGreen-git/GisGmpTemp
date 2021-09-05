using System;
using System.Xml.Serialization;

namespace GisGmp.Services.SubscriptionService
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0")]
    public class SubscriptionParameter
    {
        /// <summary />
        protected SubscriptionParameter() { }

        /// <summary />
        public SubscriptionParameter(string parameterCode, string parameterName, bool required)
        {
            ParameterCode = parameterCode;
            ParameterName = parameterName;
            Required = required;
        }

        /// <summary />
        public SubscriptionParameter(string parameterCode, string parameterName, bool required, string parameterPattern)
            : this(parameterCode, parameterName, required) => ParameterPattern = parameterPattern;


        [XmlAttribute("parameterCode")]
        public string ParameterCode { get; set; }

        [XmlAttribute("parameterName")]
        public string ParameterName
        {
            get => ParameterNameField;
            set => ParameterNameField = Validator.String(value: ref value, name: nameof(ParameterName), required: true, min: 0, max: 50);
        }

        string ParameterNameField;


        [XmlAttribute("parameterPattern")]
        public string ParameterPattern
        {
            get => ParameterPatternField;
            set => ParameterPatternField = Validator.String(value: ref value, name: nameof(ParameterPattern), required: false, min: 0, max: 2000);
        }

        string ParameterPatternField;


        [XmlAttribute("required")]
        public bool Required { get; set; }

        [XmlAttribute("parameterDescription")]
        public string ParameterDescription
        {
            get => ParameterDescriptionField;
            set => ParameterDescriptionField = Validator.String(value: ref value, name: nameof(ParameterDescription), required: false, min: 0, max: 2000);
        }

        string ParameterDescriptionField;
    }
}
