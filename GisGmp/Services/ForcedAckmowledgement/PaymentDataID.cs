//Do
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAckmowledgement
{
    /// <summary>
    /// Сведения об идентификаторах платежа
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
    public class PaymentDataID
    {
        /// <summary/>
        protected PaymentDataID() { }

        /// <summary>
        /// Сведения об идентификаторах платежа
        /// </summary>
        /// <param name="PaymentId">Идентификатор платежа</param>
        public PaymentDataID(string paymentId)
            => PaymentId = paymentId;


        /// <summary>
        /// Идентификатор платежа |> required
        /// </summary>
        [XmlAttribute("paymentId")]
        public string PaymentId { get; set; }

        /// <summary>
        /// Идентификатор информации об учете факта оплаты. Заполняется в случае отмены частичного учета факта оплаты. |> not required
        /// </summary>
        [XmlAttribute("serviceDataID")]
        public string ServiceDataID { get; set; }
    }
}
