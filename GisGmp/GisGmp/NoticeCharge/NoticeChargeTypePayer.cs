using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.NoticeCharge
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/NoticeCharge/2.4.0")]
    public class NoticeChargeTypePayer : PayerType
    {
        [XmlAttribute]
        public string payerName { get; set; }

        [XmlAttribute]
        public string additionalPayerIdentifier { get; set; }
    }
}
