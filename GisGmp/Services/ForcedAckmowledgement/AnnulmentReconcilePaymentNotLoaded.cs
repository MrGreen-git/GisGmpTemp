//Do
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAckmowledgement
{
    /// <summary>
    /// Признак принудительного квитирования начисления с отсутствующим в ГИС ГМП платежом
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
    public class AnnulmentReconcilePaymentNotLoaded
    {
        /// <summary/>
        protected AnnulmentReconcilePaymentNotLoaded() { }

        /// <summary>
        /// Номер операции принудительного квитирования начисления с отсутствующим в ГИС ГМП платежом (частичное погашение)
        /// |> not required
        /// </summary>
        [XmlAttribute("reconcileID")]
        public string ReconcileID { get; set; }

        [XmlText]
        public bool Value { get; set; }
    }
}
