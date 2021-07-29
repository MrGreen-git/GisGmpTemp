using System;
using System.Xml.Serialization;

namespace GisGmp.Clarification
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
    public class originalDetailType : paymentDetailType
    {
        [XmlAttribute]
        public ulong amount { get; set; }
    }
}
