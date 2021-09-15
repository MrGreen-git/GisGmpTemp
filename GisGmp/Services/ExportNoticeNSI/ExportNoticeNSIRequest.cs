using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNoticeNSI
{
    /// <summary>
    /// Предоставление из ГИС ГМП уведомлений о нормативно-справочной информации по подписке
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.4.0", IsNullable = false)]
    public class ExportNoticeNSIRequest
    {
        /// <summary/>
        protected ExportNoticeNSIRequest() { }

        /// <summary/>
        public ExportNoticeNSIRequest(string id, DateTime timestamp, Destination destination, NoticeNSI noticeNSI)
        {
            Id = id;
            Timestamp = timestamp;
            Destination = destination;
            NoticeNSI = noticeNSI;
        }

        /// <summary>
        /// Идентификаторы получателя уведомлений по подписке | required
        /// </summary>
        public Destination Destination 
        {
            get => DestinationField; 
            set => DestinationField = value;
        }

        Destination DestinationField;

        /// <summary>
        /// Уведомления о нормативно-справочной информации | required
        /// </summary>
        public NoticeNSI NoticeNSI 
        {
            get => NoticeNSIField;
            set => NoticeNSIField = value;
        }

        NoticeNSI NoticeNSIField;

        /// <summary>
        /// Идентификатор запроса | required
        /// </summary>
        [XmlAttribute(DataType = "ID")]
        public string Id 
        {
            get => IdField;
            set => IdField = value;
        }

        string IdField;

        /// <summary>
        /// Дата и время формирования ответа | required
        /// </summary>
        [XmlAttribute("timestamp")]
        public DateTime Timestamp { get; set; }
    }
}
