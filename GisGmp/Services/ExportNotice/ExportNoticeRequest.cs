using GisGmp.NoticeCharge;
using GisGmp.Renouncement;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNotice
{
    /// <summary>
    /// Предоставление из ГИС ГМП уведомлений по подписке
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.4.0", IsNullable = false)]
    public class ExportNoticeRequest
    {
        /// <summary/>
        protected ExportNoticeRequest() { }

        /// <summary/>
        private ExportNoticeRequest(string id, DateTime timestamp, Destination destination)
        {
            Id = id;
            Timestamp = timestamp;
            Destination = destination;
        }

        /// <summary/>
        public ExportNoticeRequest(
            string id,
            DateTime timestamp,
            Destination destination,
            NoticeCharge[] noticeCharge
            ) : this(id, timestamp, destination) => NoticeCharge = noticeCharge;

        /// <summary/>
        public ExportNoticeRequest(
            string id,
            DateTime timestamp,
            Destination destination,
            NoticeChargeExecutiveType[] noticeChargeExecutive
            ) : this(id, timestamp, destination) => NoticeChargeExecutive = noticeChargeExecutive;

        /// <summary/>
        public ExportNoticeRequest(
            string id,
            DateTime timestamp,
            Destination destination,
            NoticePayment[] noticePayment
            ) : this(id, timestamp, destination) => NoticePayment = noticePayment;

        /// <summary/>
        public ExportNoticeRequest(
            string id,
            DateTime timestamp,
            Destination destination,
            NoticeQuittance[] noticeQuittance
            ) : this(id, timestamp, destination) => NoticeQuittance = noticeQuittance;

        /// <summary/>
        public ExportNoticeRequest(
            string id,
            DateTime timestamp,
            Destination destination,
            RenouncementType[] renouncementType
            ) : this(id, timestamp, destination) => RenouncementType = renouncementType;

        /// <summary>
        /// Идентификаторы получателя уведомлений по подписке
        /// </summary>
        public Destination Destination 
        {
            get => DestinationField;
            set => DestinationField = value;
        }

        Destination DestinationField;

        /// <summary/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("NoticeCharge", typeof(NoticeCharge))]
        [XmlElement("NoticeChargeExecutive", typeof(NoticeChargeExecutiveType))]
        [XmlElement("NoticePayment", typeof(NoticePayment))]
        [XmlElement("NoticeQuittance", typeof(NoticeQuittance))]
        [XmlElement("NoticeRenouncement", typeof(RenouncementType))]
        public object[] Items 
        {
            get => ItemsField;
            set => ItemsField = value;
        }

        object[] ItemsField; 

        /// <summary/>
        [XmlIgnore]
        public NoticeCharge[] NoticeCharge
        {
            get => (NoticeCharge[])ItemsField;
            set => ItemsField = value;
        }

        /// <summary/>
        [XmlIgnore]
        public NoticeChargeExecutiveType[] NoticeChargeExecutive
        {
            get => (NoticeChargeExecutiveType[])ItemsField;
            set => ItemsField = value;
        }

        /// <summary/>
        [XmlIgnore]
        public NoticePayment[] NoticePayment
        { 
            get => (NoticePayment[])ItemsField;
            set => ItemsField = value;
        }

        /// <summary/>
        [XmlIgnore]
        public NoticeQuittance[] NoticeQuittance
        {
            get => (NoticeQuittance[])ItemsField;
            set => ItemsField = value;
        }

        /// <summary/>
        [XmlIgnore]
        public RenouncementType[] RenouncementType
        {
            get => (RenouncementType[])ItemsField;
            set => ItemsField = value;
        }


        /// <summary>
        /// Идентификатор запроса
        /// </summary>
        [XmlAttribute(DataType = "ID")]
        public string Id 
        {
            get => IdField; 
            set => IdField = value;
        }

        string IdField;

        /// <summary>
        /// Дата и время формирования сообщения
        /// </summary>
        [XmlAttribute("timestamp")]
        public DateTime Timestamp { get; set; }
    }
}
