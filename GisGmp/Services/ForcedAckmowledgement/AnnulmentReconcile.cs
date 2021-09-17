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

        /// <summary>
        /// Отмена принудительного квитирования начисления с платежами
        /// </summary>
        /// <param name="uin">УИН</param>
        public AnnulmentReconcile(SupplierBillIDType uin)
            => SupplierBillId = uin;

        /// <summary>
        /// ?
        /// </summary>
        [XmlElement("PaymentId", typeof(string))]
        [XmlElement("PaymentNotLoaded", typeof(AnnulmentReconcilePaymentNotLoaded))]
        public object[] Items { get; set; }

        /// <summary>
        /// Перечень идентификаторов платежей
        /// </summary>
        public string PaymentId { get; set; }

        /// <summary>
        /// Признак принудительного квитирования начисления с отсутствующим в ГИС ГМП платежом
        /// </summary>
        public AnnulmentReconcilePaymentNotLoaded PaymentNotLoaded {  get; set; }

        /// <summary>
        /// УИН |> required
        /// </summary>
        [XmlAttribute("supplierBillId")]
        public string SupplierBillId { get; set; }
    }
}
