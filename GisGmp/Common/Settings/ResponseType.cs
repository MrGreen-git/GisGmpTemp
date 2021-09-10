using GisGmp.Services.ImportCharges;
using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Основные параметры ответа на запрос
    /// </summary>
    [XmlInclude(typeof(ImportPackageResponseType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class ResponseType
    {
        /// <summary/>
        protected ResponseType() { }

        /// <summary/>
        public ResponseType(ResponseType response)
        {
            Id = response.Id;
            RqId = response.RqId;
            RecipientIdentifier = response.RecipientIdentifier;
            Timestamp = response.Timestamp;
        }

        /// <summary/>
        public ResponseType(string id, string rqId, string recipientIdentifier, DateTime timestamp)
        {
            Id = id;
            RqId = rqId;
            RecipientIdentifier = recipientIdentifier;
            Timestamp = timestamp;
        }

        /// <summary>
        /// Идентификатор ответа
        /// </summary>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// Идентификатор запроса
        /// </summary>
        [XmlAttribute]
        public string RqId { get; set; }

        /// <summary>
        /// УРН участника получателя
        /// </summary>
        [XmlAttribute("recipientIdentifier")]
        public string RecipientIdentifier { get; set; }

        /// <summary>
        /// Дата и время формирования ответа
        /// </summary>
        [XmlAttribute("timestamp")]
        public DateTime Timestamp { get; set; }
    }
}
