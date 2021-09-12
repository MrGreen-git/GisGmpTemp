using GisGmp.Subscription;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.SubscriptionService
{
    /// <summary>
    /// Ответ с результатом обработки запроса о подписке (изменении/удалении подписки) участника
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0")]
    public class CreateSubscriptionResult
    {
        /// <summary />
        protected CreateSubscriptionResult() { }

        /// <summary />
        public CreateSubscriptionResult(SubscriptionProtocolType[] subscriptionProtocol) => SubscriptionProtocol = subscriptionProtocol;


        /// <summary>
        /// Результат обработки запроса о подписке или уточнения/удаления подписки | required
        /// </summary>
        [XmlElement("SubscriptionProtocol")]
        public SubscriptionProtocolType[] SubscriptionProtocol { get; set; }

        /// <summary>
        /// Дата и время добавления/удаления подписки или изменения значений параметров (группы параметров) подписки | not required
        /// </summary>
        [XmlAttribute("dispatchDate")]
        public DateTime DispatchDate { get; set; }

        [XmlIgnore]
        public bool DispatchDateSpecified { get; set; }

        /// <summary>
        /// Дата автоматического окончания срока действия значений параметров подписки в ГИС ГМП | not required
        /// </summary>
        [XmlAttribute("expiryDate", DataType = "date")]
        public DateTime ExpiryDate { get; set; }

        [XmlIgnore]
        public bool ExpiryDateSpecified { get; set; }

        /// <summary>
        /// Код варианта уведомлений | not required
        /// </summary>
        [XmlAttribute("subscriptionCode")]
        public string SubscriptionCode { get; set; }

        /// <summary>
        /// Идентификатор подписки | not required
        /// </summary>
        [XmlAttribute("subscriptionIdentifier")]
        public string SubscriptionIdentifier { get; set; }
    }
}
