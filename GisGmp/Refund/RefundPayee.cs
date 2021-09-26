using GisGmp.Common;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Refund
{
    /// <summary>
    /// Сведения о получателе денежных средств
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Refund/2.4.0")]
    public class RefundPayee : PayerType
    {
        protected RefundPayee() { }

        /// <summary>
        /// Сведения о получателе денежных средств
        /// </summary>
        /// <param name="payerIdentifier"></param>
        /// <param name="name"></param>
        /// <param name="bankAccountNumber"></param>
        public RefundPayee(
            string payerIdentifier,
            string name,
            AccountType bankAccountNumber
            ) : base(payerIdentifier)
        {
            Name = name;
            BankAccountNumber = bankAccountNumber;
        }

        /// <summary>
        /// Особенности заполнения: для ЮЛ указывается наименование организации; для ФЛ указывается фамилия, имя, отчество (при наличии); для ИП указывается фамилия, имя, отчество (при наличии) ИП.
        /// <para>use: required</para>
        /// <para>length: 1..160</para>
        /// </summary>
        [XmlAttribute("name")]
        public string Name
        {
            get => NameField;
            set => NameField = value.IsRequired().IsLength(min: 1, max: 160);
        }

        string NameField;

        /// <summary>
        /// Поле номер 3104: КБК
        /// use: not required
        /// </summary>
        [XmlIgnore]
        public KBKType Kbk { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("kbk")]
        public string WrapperKbk { get => Kbk; set => Kbk = value; }

        /// <summary>
        /// Поле номер 3105: Код по ОКТМО
        /// <para>use: not required</para>
        /// </summary>
        [XmlIgnore]
        public OKTMOType Oktmo { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("oktmo")]
        public string WrapperOktmo { get => Oktmo; set => Oktmo = value; }

        /// <summary>
        /// Номер счета получателя платежа
        /// <para>use: required</para>
        /// </summary>
        public AccountType BankAccountNumber
        {
            get => BankAccountNumberField;
            set => BankAccountNumberField = value.IsRequired();
        }

        AccountType BankAccountNumberField;

        /// <summary>
        /// Поле номер 3008: Номер лицевого счета получателя платежа
        /// <para>use: not required</para>
        /// </summary>
        public string PayeeAccount { get; set; }   //TODO тип
    }
}
