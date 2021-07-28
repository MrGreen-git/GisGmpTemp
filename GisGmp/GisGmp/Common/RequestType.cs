using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [XmlInclude(typeof(ExportRequestType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class RequestType
    {
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }

        [XmlAttribute]
        public DateTime timestamp { get; set; }

        [XmlAttribute]
        public string senderIdentifier { get; set; }

        [XmlAttribute]
        public string senderRole { get; set; }
    }
}
