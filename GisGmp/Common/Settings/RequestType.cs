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

        /// <summary>
        /// Идентификатор запроса
        /// </summary>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// Дата и время формирования запроса
        /// </summary>
        [XmlAttribute("timestamp")]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// УРН участника-отправителя запроса
        /// </summary>
        [XmlAttribute("senderIdentifier")]
        public string SenderIdentifier { get; set; }

        /// <summary>
        /// Полномочие участника-отправителя сообщения, с которым происходит обращение к ГИС ГМП
        /// </summary>
        [XmlAttribute("senderRole")]
        public string SenderRole { get; set; }
    }
}
