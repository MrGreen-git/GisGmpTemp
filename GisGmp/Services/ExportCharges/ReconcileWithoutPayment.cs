using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportCharges
{
    /// <summary>
    /// Сведения о фактах погашения начисления без платежа
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0")]
    public class ReconcileWithoutPayment
    {
        /// <summary>
        /// Номер операции принудительного квитирования начисления с отсутствующим в ГИС ГМП платежом
        /// </summary>
        [XmlAttribute("reconcileID")]
        public string ReconcileID { get; set; }

        /// <summary>
        /// Сумма операции принудительного квитирования начисления с отсутствующим в ГИС ГМП платежом
        /// </summary>
        [XmlAttribute("amountReconcile")]
        public ulong AmountReconcile { get; set; }
    }
}
