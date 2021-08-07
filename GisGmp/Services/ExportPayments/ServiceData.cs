using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    /// <summary>
    /// Дополнительные сведения о предоставлении услуги/ об учете платежа
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
    public class ServiceData : ServiceDataType
    {
        /// <summary>
        /// Идентификатор информации об учете платежа
        /// </summary>
        [XmlAttribute("serviceDataID")]
        public string ServiceDataID { get; set; }
    }
}
