// Do
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAckmowledgement
{
    /// <summary>
    /// Признак принудтельного квитирования начисления с отсутствующим в ГИС ГМП платежом
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
    public class PaymentNotLoaded
    {
        /// <summary/>
        protected PaymentNotLoaded() {  }

        /// <summary>
        /// Сумма погашения, в копейках |> not required
        /// </summary>
        [XmlAttribute("amountReconcile")]
        public ulong AmountReconcile { get; set; }

        [XmlIgnore]
        public bool AmountReconcileSpecified { get; set; }

        /// <summary/>
        [XmlText]
        public bool Value { get; set; }
    }
}
