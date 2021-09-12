using System;
using System.Xml.Serialization;

namespace GisGmp.Quittance
{
    /// <summary>
    /// Сведения о возврате денежных средств
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Quittance/2.4.0")]
    public class Refund
    {
        /// <summary/>
        protected Refund() { }

        /// <summary/>
        public Refund(
            string refundId,
            ulong amount
            )
        {
            RefundId = refundId;
            Amount = amount;
        }

        /// <summary>
        /// Уникальный идентификатор возврата (УИВ) | required
        /// </summary>
        [XmlAttribute("refundId")]
        public string RefundId { get; set; }

        /// <summary>
        /// Сумма возврата | required
        /// </summary>
        [XmlAttribute("amount")]
        public ulong Amount { get; set; }
    }
}
