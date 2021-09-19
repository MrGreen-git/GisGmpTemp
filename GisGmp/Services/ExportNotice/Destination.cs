using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNotice
{
    /// <summary>
    /// Идентификаторы получателя уведомлений по подписке
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.4.0")]
    public class Destination
    {
        /// <summary/>
        protected Destination() { }

        /// <summary/>
        public Destination(
            string routingCode,
            string recipientIdentifier
            ) 
        { 
            RoutingCode = routingCode;
            RecipientIdentifier = recipientIdentifier;
        }

        /// <summary>
        /// Код маршрутизации участника для предоставления информации по ВС с табличной маршрутизацией | required
        /// </summary>
        public string RoutingCode { get; set; }

        /// <summary>
        /// УРН участника получателя | required
        /// </summary>
        [XmlAttribute("recipientIdentifier")]
        public string RecipientIdentifier { get; set; }
    }
}
