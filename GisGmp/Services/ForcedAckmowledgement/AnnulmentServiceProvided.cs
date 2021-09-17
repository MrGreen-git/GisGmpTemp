using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAckmowledgement
{
    /// <summary>
    /// Отмена факта установления платежу признака «Услуга предоставлена»
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
    public class AnnulmentServiceProvided
    {
        /// <summary/>
        protected AnnulmentServiceProvided() { }

        /// <summary>
        /// Отмена факта установления платежу признака «Услуга предоставлена»
        /// </summary>
        /// <param name="paymentDataID">Сведения об идентификаторах платежа</param>
        public AnnulmentServiceProvided(PaymentDataID[] paymentDataID)
            => PaymentDataID = paymentDataID;


        /// <summary>
        /// Сведения об идентификаторах платежа |> required
        /// </summary>
        [XmlElement("PaymentDataID")]
        public PaymentDataID[] PaymentDataID { get; set; }
    }
}
