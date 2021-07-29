using GisGmp.Services.ImportCharges;
using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [XmlInclude(typeof(ImportPackageResponseType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class ResponseType
    {
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }

        [XmlAttribute]
        public string RqId { get; set; }

        [XmlAttribute]
        public string recipientIdentifier { get; set; }

        [XmlAttribute]
        public DateTime timestamp { get; set; }
    }
}
