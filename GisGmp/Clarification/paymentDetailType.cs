using System;
using System.Xml.Serialization;

namespace GisGmp.Clarification
{
    [XmlInclude(typeof(setDetailType))]
    [XmlInclude(typeof(originalDetailType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
    public class paymentDetailType
    {
        [XmlAttribute]
        public string payeeName { get; set; }

        [XmlAttribute]
        public string inn { get; set; }

        [XmlAttribute]
        public string kpp { get; set; }

        [XmlAttribute]
        public string payeeAccount { get; set; }

        [XmlAttribute]
        public string oktmo { get; set; }

        [XmlAttribute]
        public string kbk { get; set; }

        [XmlAttribute]
        public string subsidy { get; set; }

        [XmlAttribute]
        public string purpose { get; set; }

        [XmlAttribute]
        public string description { get; set; }
    }
}
