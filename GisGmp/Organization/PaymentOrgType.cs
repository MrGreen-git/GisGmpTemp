using GisGmp.Common;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Organization
{
    /// <summary>
    /// Организация принявшая платеж
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
    public class PaymentOrgType
    {
        /// <summary />
        protected PaymentOrgType() { }

        /// <summary />
        public PaymentOrgType(BankType bank) => Bank = bank;

        /// <summary />
        public PaymentOrgType(PaymentOrgTypeOther paymentOrg) => PaymentOrg = paymentOrg;

        /// <summary />
        public PaymentOrgType(string ufk) => UFK = ufk;


        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("Bank", typeof(BankType))]
        [XmlElement("Other", typeof(PaymentOrgTypeOther))]
        [XmlElement("UFK", typeof(string))]
        public object Item { get; set; }

        /// <summary />
        [XmlIgnore]
        public BankType Bank
        {
            get => Item as BankType;
            set => Item = value;
        }

        /// <summary />
        [XmlIgnore]
        public PaymentOrgTypeOther PaymentOrg
        {
            get => Item.GetType() == typeof(PaymentOrgTypeOther) ? (PaymentOrgTypeOther)Item : PaymentOrgTypeOther.CASH;
            set => Item = value;
        }

        /// <summary />
        [XmlIgnore]
        public string UFK
        {
            get => Item as string;
            set => Item = value;
        }
    }
}
