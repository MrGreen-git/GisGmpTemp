using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNoticeNSI
{
    /// <summary>
    /// Идентификаторы получателя уведомлений по подписке
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.4.0")]
    public class Destination
    {
        /// <summary>
        /// Код маршрутизации участника для предоставления информации по ВС с табличной маршрутизацией
        /// </summary>
        public string RoutingCode { get; set; }

        /// <summary>
        /// УРН участника получателя
        /// </summary>
        [XmlAttribute("recipientIdentifier")]
        public string RecipientIdentifier { get; set; }
    }
}
