using GisGmp.Common;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Refund
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Refund/2.4.0")]
    public class RefundPayee : PayerType
    {
        /// <summary />
        protected RefundPayee() { }

        /// <summary />
        public RefundPayee(
            string payerIdentifier,
            string name,
            AccountType bankAccountNumber
            ) : base(payerIdentifier)
        {
            Name = name;
            BankAccountNumber = bankAccountNumber;
        }


        public AccountType BankAccountNumber
        {
            get => BankAccountNumberField;
            set => BankAccountNumberField = Validator.IsNull(value: value, name: nameof(BankAccountNumber));
        }

        AccountType BankAccountNumberField;

        public string PayeeAccount { get; set; }


        [XmlAttribute("name")]
        public string Name
        {
            get => NameField;
            set => NameField = Validator.String(value: ref value, name: nameof(Name), required: true, min: 1, max: 160);
        }

        string NameField;


        [XmlIgnore]
        public string Kbk { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("kbk")]
        public string WrapperKbk { get => Kbk; set => Kbk = value; }


        [XmlIgnore]
        public OKTMOType Oktmo { get; set; }


        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("oktmo")]
        public string WrapperOktmo { get => Oktmo; set => Oktmo = value; }
    }
}
