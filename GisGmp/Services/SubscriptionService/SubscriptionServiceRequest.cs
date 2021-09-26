using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.SubscriptionService
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0", IsNullable = false)]
    public class SubscriptionServiceRequest : RequestType
    {
        protected SubscriptionServiceRequest() { }

        /// <summary/>
        public SubscriptionServiceRequest(RequestType config, CreateSubscription createSubscription)
            : base(config) => CreateSubscription = createSubscription;

        /// <summary/>
        public SubscriptionServiceRequest(RequestType config, bool exportSubscriptions)
            : base(config) => ExportSubscriptions = exportSubscriptions;


        /// <summary>
        /// use: required
        /// </summary>
        [XmlElement("CreateSubscription", typeof(CreateSubscription))]
        [XmlElement("ExportSubscriptions", typeof(bool))]
        public object Item { get; set; }

        /// <summary>
        /// Запрос на оформление подписки (или изменение, удаление подписки) с указанием при необходимости значений параметров
        /// </summary>
        [XmlIgnore]
        public CreateSubscription CreateSubscription 
        {
            get => Item as CreateSubscription; 
            set => Item = value;
        }

        /// <summary>
        /// Запрос на предоставление перечня доступных участнику вариантов уведомлений для оформления подписки
        /// </summary>
        [XmlIgnore]
        public bool ExportSubscriptions 
        {
            get => false;  //TODO 
            set => Item = value;
        }
    }
}
