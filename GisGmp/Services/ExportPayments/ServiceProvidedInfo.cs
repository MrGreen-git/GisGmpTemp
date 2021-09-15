using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    /// <summary>
    /// Информации об установлении платежу признака "Услуга предоставлена"
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
    public class ServiceProvidedInfo
    {
        /// <summary>
        /// Дополнительные сведения о погашении платежа. Указывается в случае частичного учета платежа.
        /// </summary>
        public AdditionalRepaymenInfo AdditionalRepaymenInfo { get; set; }

        /// <summary>
        /// Обозначение у платежа статуса "Услуга предоставлена"
        /// </summary>
        [XmlAttribute("serviceProvided")]
        public ServiceProvided ServiceProvided { get; set; }
    }
}
