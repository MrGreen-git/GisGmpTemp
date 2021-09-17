using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAckmowledgement
{
    /// <summary>
    /// Установление платежу признака «Услуга предоставлена»
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
    public class ServiceProvided
    {
        /// <summary/>
        protected ServiceProvided() { }

        /// <summary>
        /// Установление платежу признака «Услуга предоставлена»
        /// </summary>
        /// <param name="paymentDataInfo">Информация о платеже</param>
        public ServiceProvided(PaymentDataInfo[] paymentDataInfo)
            => PaymentDataInfo = paymentDataInfo;

        /// <summary>
        /// Информация о платеже |> required
        /// </summary>
        [XmlElement("PaymentDataInfo")]
        public PaymentDataInfo[] PaymentDataInfo { get; set; }
    }
}
