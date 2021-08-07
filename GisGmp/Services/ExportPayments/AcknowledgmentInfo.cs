using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    /// <summary>
    /// Обозначение факта квитирования платежа с начисление либо признака у платежа "Услуга предоставлена"
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
    public class AcknowledgmentInfo
    {
        [XmlElement("ServiceProvidedInfo", typeof(Info))]
        [XmlElement("SupplierBillID", typeof(string))]
        public object Item { get; set; }
    }
}
