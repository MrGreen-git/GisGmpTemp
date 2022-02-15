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
        protected Refund() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="refundId">Уникальный идентификатор возврата (УИВ)</param>
        /// <param name="amount">Сумма возврата</param>
        public Refund(
            string refundId,
            ulong amount
            )
        {
            RefundId = refundId;
            Amount = amount;
        }

        /// <summary>
        /// Уникальный идентификатор возврата (УИВ)
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("refundId")]
        public string RefundId { get; set; }

        /// <summary>
        /// Сумма возврата
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("amount")]
        public ulong Amount { get; set; }
    }
}
