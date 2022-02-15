using System;
using System.Xml.Serialization;

namespace GisGmp.Clarification
{
    /// <summary>
    /// Тип для хранения реквизитов уточняемого платежного документа, которые могут быть уточнены.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
    public class originalDetailType : paymentDetailType
    {
        /// <summary>
        /// Целое число, показывающее сумму в копейках.
        /// <para>use: not required</para>
        /// </summary>
        [XmlAttribute("amount")]
        public ulong Amount { get; set; }
    }
}
