using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    /// <summary>
    /// Дополнительные сведения о погашении платежа. Указывается в случае частичного учета платежа.
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
    public class AdditionalRepaymenInfo
    {
        /// <summary>
        /// Дополнительные сведения о предоставлении услуги/ об учете платежа
        /// </summary>
        [XmlElement("ServiceData")]
        public ServiceData[] ServiceData { get; set; }

        /// <summary>
        /// Разность между суммой, указанной в платеже и сумм учета платежа. Целое число, показывающее остаток от суммы платежа с учетом частичного учета платежа.
        /// </summary>
        [XmlAttribute("residualAmount")]
        public long ResidualAmount { get; set; }
    }
}
