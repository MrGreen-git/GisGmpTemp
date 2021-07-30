using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public class TimeConditionsTypeBeneficiary
    {
        [XmlAttribute]
        public string inn { get; set; }

        [XmlAttribute]
        public string kpp { get; set; }
    }
}
