using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    /// <summary>
    /// Обозначение факта квитирования платежа с начислением либо установление у платежа признака «Услуга предоставлена»
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
    public class AcknowledgmentInfo
    {
        /// <summary />
        protected AcknowledgmentInfo() { }

        /// <summary />
        public AcknowledgmentInfo(ServiceProvidedInfo serviceProvidedInfo) => ServiceProvidedInfo = serviceProvidedInfo;

        /// <summary />
        public AcknowledgmentInfo(SupplierBillIDType supplierBillID) => SupplierBillID = supplierBillID;


        [XmlElement("ServiceProvidedInfo", typeof(ServiceProvidedInfo))]
        [XmlElement("SupplierBillID", typeof(string))]
        public object Item { get; set; }

        //TODO ???
        [XmlIgnore]
        public SupplierBillIDType SupplierBillID
        {
            get => Item as string;
            set => Item = value.ToString();
        }

        [XmlIgnore]
        public ServiceProvidedInfo ServiceProvidedInfo
        {
            get => Item as ServiceProvidedInfo;
            set => Item = value;
        }
    }
}
