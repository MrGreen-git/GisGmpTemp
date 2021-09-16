using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAckmowledgement
{
    /// <summary>
    /// Отмена принудительного квитирования начисления с платежами
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
    public class AnnulmentReconcile
    {
        /// <summary/>
        protected AnnulmentReconcile() { }

        /// <summary/>
        public AnnulmentReconcile(SupplierBillIDType uin)
            => SupplierBillId = uin;

        [XmlElement("PaymentId", typeof(string))]
        [XmlElement("PaymentNotLoaded", typeof(AnnulmentReconcilePaymentNotLoaded))]
        public object[] Items { get; set; }

        /// <summary>
        /// УИН
        /// </summary>
        [XmlAttribute("supplierBillId")]
        public string SupplierBillId { get; set; }
    }
}
