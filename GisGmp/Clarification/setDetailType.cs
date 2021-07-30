using System;
using System.Xml.Serialization;

namespace GisGmp.Clarification
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
    public class setDetailType : paymentDetailType
    {
        [XmlAttribute]
        public ulong amount { get; set; }

        [XmlIgnore]
        public bool amountSpecified { get; set; }
    }
}
