using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAckmowledgement
{
    /// <summary>
    /// Информация о платеже
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
    public class PaymentDataInfo
    {
        /// <summary/>
        protected PaymentDataInfo() { }

        /// <summary>
        /// Информация о платеже
        /// </summary>
        /// <param name="paymentId">Идентификатор платежа</param>
        public PaymentDataInfo(string paymentId)
            => PaymentId = paymentId;


        /// <summary>
        /// Идентификатор платежа |> required
        /// </summary>
        [XmlAttribute("paymentId")]
        public string PaymentId { get; set; }


        /// <summary>
        /// Дополнительные сведения о предоставлении услуги/ учете платежа |> not required
        /// </summary>
        [XmlElement("ServiceData")]
        public ServiceDataType ServiceData { get; set; }
    }
}
