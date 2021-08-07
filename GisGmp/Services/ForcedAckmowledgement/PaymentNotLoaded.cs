using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAckmowledgement
{
    /// <summary>
    /// Появляется при квитировании с отсутствующим платежом
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
    public class PaymentNotLoaded
    {
        /// <summary>
        /// Сумма погашения, в копейках
        /// </summary>
        [XmlAttribute("amountReconcile")]
        public ulong AmountReconcile { get; set; }

        [XmlIgnore]
        public bool AmountReconcileSpecified { get; set; }

        [XmlText()]
        public bool Value { get; set; }
    }
}
