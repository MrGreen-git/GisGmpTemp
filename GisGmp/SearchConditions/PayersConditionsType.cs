using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public class PayersConditionsType
    {
        [XmlElement("PayerIdentifier", typeof(string))]
        [XmlElement("PayerInn", typeof(string))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public string[] Items { get; set; }

        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public ItemsChoiceType[] ItemsElementName { get; set; }

        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public TimeIntervalType TimeInterval { get; set; }

        [XmlArray(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlArrayItem("KBK", IsNullable = false)]
        public string[] KBKlist { get; set; }

        [XmlElement("Beneficiary")]
        public Beneficiary[] Beneficiary { get; set; }
    }
}
