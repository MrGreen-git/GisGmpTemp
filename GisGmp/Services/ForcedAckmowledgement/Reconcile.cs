using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAckmowledgement
{
    /// <summary>
    /// Принудительное квитирование начисления с платежами
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
    public class Reconcile
    {
        [XmlElement("PaymentId", typeof(string))]
        [XmlElement("PaymentNotLoaded", typeof(PaymentNotLoaded))]
        public object[] Items { get; set; }

        /// <summary>
        /// УИН
        /// </summary>
        [XmlAttribute("supplierBillId")]
        public string SupplierBillId { get; set; }
    }
}
