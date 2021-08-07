using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportQuittances
{
    /// <summary>
    /// Информация о сопоставлении начислений с платежами. Предоставляется только для запроса kind=ALLPOSSIBLE
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.4.0")]
    public class PossibleData
    {
        /// <summary>
        /// Результат сопоставления начисления с платежом
        /// </summary>
        [XmlElement("ComparisonResult")]
        public ComparisonResult[] ComparisonResult { get; set; }

        /// <summary>
        /// УИН, с которым сопоставлены платежи
        /// </summary>
        [XmlAttribute("supplierBillID")]
        public string SupplierBillID { get; set; }

        /// <summary>
        /// Сумма, указанная в начислении
        /// </summary>
        [XmlAttribute("totalAmount")]
        public ulong TotalAmount { get; set; }

        [XmlIgnore]
        public bool TotalAmountSpecified { get; set; }
    }
}
