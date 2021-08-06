using System;
using System.Xml.Serialization;

namespace GisGmp.Clarification
{
    /// <summary>
    /// Тип для хранения реквизитов уточняемого платежного документа, которые могут быть уточнены.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
    public class setDetailType : paymentDetailType
    {
        /// <summary>
        /// Целое число, показывающее сумму в копейках.
        /// </summary>
        [XmlAttribute("amount")]
        public ulong Amount { get; set; }

        [XmlIgnore]
        public bool AmountSpecified { get; set; }
    }
}
