using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public class RefundsConditionsType
    {
        [XmlElement("RefundId")]
        public string[] RefundId { get; set; }
    }
}
