using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNotice
{
    /// <summary>
    /// Ответ на запрос предоставления из ГИС ГМП уведомлений по подписке
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.4.0", IsNullable = false)]
    public class ExportNoticeResponse : ResponseType
    {
        /// <summary/>
        protected ExportNoticeResponse() { }

        /// <summary/>
        public ExportNoticeResponse(ResponseType config, string routingCode, bool exportNoticeConfirmation)
            : base(config)
        {
            RoutingCode = routingCode;
            ExportNoticeConfirmation = exportNoticeConfirmation;
        }


        /// <summary>
        /// Код маршрутизации участника
        /// </summary>
        public string RoutingCode
        {
            get => RoutingCodeField;
            set => RoutingCodeField = value;
        }

        string RoutingCodeField;

        /// <summary>
        /// Подтверждение приема сообщения с рассылкой уведомлений по подписке: true - сообщение принято; false - отказ в приеме сообщения
        /// </summary>
        public bool ExportNoticeConfirmation { get; set; }
    }
}
