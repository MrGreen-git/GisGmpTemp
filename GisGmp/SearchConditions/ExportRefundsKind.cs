using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <summary>
    /// Тип запроса на предоставление информации о возврате
    /// </summary>
    [Serializable]
    public enum ExportRefundsKind
    {
        /// <summary>
        /// REFUND
        /// </summary>
        [XmlEnum("REFUND")]
        Refund
    }
}
