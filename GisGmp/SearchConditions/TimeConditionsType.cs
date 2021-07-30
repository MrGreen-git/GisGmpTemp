using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public class TimeConditionsType
    {
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public TimeIntervalType TimeInterval { get; set; }

        [XmlElement("Beneficiary")]
        public TimeConditionsTypeBeneficiary[] Beneficiary { get; set; }

        [XmlArray(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlArrayItem("KBK", IsNullable = false)]
        public string[] KBKlist { get; set; }
    }
}
