// Do
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
        /// <summary />
        protected Reconcile() { }

        /// <summary>
        /// Принудительное квитирование начисления с платежами
        /// </summary>
        /// <param name="supplierBillId">УИН</param>
        /// <param name="paymentId">Перечень идентификаторов платежей</param>
        public Reconcile(SupplierBillIDType supplierBillId, PaymentIdType[] paymentId)
        {
            SupplierBillId = supplierBillId;
            PaymentId = paymentId;
        }

        /// <summary>
        /// Принудительное квитирование начисления с платежами
        /// </summary>
        /// <param name="supplierBillId">УИН</param>
        /// <param name="paymentNotLoaded">Признак принудтельного квитирования начисления с отсутствующим в ГИС ГМП платежом</param>
        public Reconcile(SupplierBillIDType supplierBillId, bool[] paymentNotLoaded)
        {
            SupplierBillId = supplierBillId;
            PaymentNotLoaded = paymentNotLoaded;
        }

        /// <summary>
        /// |> required
        /// </summary>
        [XmlElement("PaymentId", typeof(string))]
        [XmlElement("PaymentNotLoaded", typeof(PaymentNotLoaded))]
        public object[] Items { get; set; }

        /// <summary>
        /// Перечень идентификаторов платежей
        /// </summary>
        [XmlIgnore]
        public PaymentIdType[] PaymentId
        {
            get => Items as PaymentIdType[];
            set => Items = value.ToArrayString();
        }

        /// <summary>
        /// Признак принудтельного квитирования начисления с отсутствующим в ГИС ГМП платежом
        /// </summary>
        [XmlIgnore]
        public bool[] PaymentNotLoaded
        {
            get => null;
            set => Items = null;
        }

        /// <summary>
        /// УИН |> required
        /// </summary>
        [XmlAttribute("supplierBillId")]
        public string SupplierBillId { get; set; }
    }
}
