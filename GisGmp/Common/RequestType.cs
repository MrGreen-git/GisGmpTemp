using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [XmlInclude(typeof(ExportRequestType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class RequestType
    {
        /// <summary/>
        protected RequestType() { }

        public RequestType(RequestType request)
        { 
            Id = request.Id;
            Timestamp = request.Timestamp;
            SenderIdentifier = request.SenderIdentifier;
            SenderRole = request.SenderRole;
        }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }

        [XmlAttribute("timestamp")]
        public DateTime Timestamp { get; set; }

        [XmlAttribute("senderIdentifier")]
        public string SenderIdentifier { get; set; }

        [XmlAttribute("senderRole")]
        public string SenderRole { get; set; }
    }
}
