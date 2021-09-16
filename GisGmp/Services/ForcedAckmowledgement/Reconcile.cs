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

        /// <summary />
        public Reconcile(SupplierBillIDType supplierBillId, PaymentIdType[] paymentId)
        {
            SupplierBillId = supplierBillId;
            PaymentId = paymentId;
        }

        /// <summary />
        public Reconcile(SupplierBillIDType supplierBillId, bool[] paymentNotLoaded)
        {
            SupplierBillId = supplierBillId;
            PaymentNotLoaded = paymentNotLoaded;
        }

        [XmlIgnore]
        public PaymentIdType[] PaymentId
        {
            get => null;
            set => Items = value.ToArrayString();
        }

        [XmlIgnore]
        public bool[] PaymentNotLoaded
        {
            get => null;
            set => Items = null;
        }


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
