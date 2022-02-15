using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Payment
{
    /// <summary>
    /// Поле номер 2006: Сведения о плательщике
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Payment/2.4.0")]
    [XmlRoot("Payer", Namespace = "http://roskazna.ru/gisgmp/xsd/Payment/2.4.0", IsNullable = false)]
    public class PaymentPayer : PayerType
    {
        protected PaymentPayer() { }

        /// <summary>
        /// Поле номер 2006: Сведения о плательщике
        /// </summary>
        /// <param name="payerIdentifier">Поле номер 201: Идентификатор плательщика</param>
        /// <param name="payerName">Поле номер 8: Плательщик</param>
        public PaymentPayer(string payerIdentifier, string payerName)
            : base(payerIdentifier) => PayerName = payerName;

        /// <summary>
        /// Поле номер 2006: Сведения о плательщике
        /// </summary>
        /// <param name="payerIdentifier">Поле номер 201: Идентификатор плательщика</param>
        /// <param name="payerName">Поле номер 8: Плательщик</param>
        /// <param name="payerAccount">Поле номер 9: Номер счета плательщика(при наличии) в организации, принявшей платеж</param>
        public PaymentPayer(string payerIdentifier, string payerName, string payerAccount)
            : this(payerIdentifier, payerName) => PayerAccount = payerAccount;

        /// <summary>
        /// Поле номер 8: Плательщик
        /// <para>use: required</para>
        /// <para>length: 0..160</para>
        /// <para>pattern: "[^\s]+(\s+[^\s]+)*"</para>
        /// </summary>
        [XmlAttribute("payerName")]
        public string PayerName { get; set; }

        /// <summary>
        /// Поле номер 9: Номер счета плательщика(при наличии) в организации, принявшей платеж
        /// <para>use: not required</para>
        /// <para>length: 0..20</para>
        /// </summary>
        [XmlAttribute("payerAccount")]
        public string PayerAccount { get; set; }
    }
}
