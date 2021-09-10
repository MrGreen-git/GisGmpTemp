using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Описание реквизитов казначейского счета или банковского счета, открытого кредитной организации в ПБР
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class AccountType
    {
        /// <summary/>
        protected AccountType() { }

        /// <summary/>
        public AccountType(BankType bank) => Bank = bank;

        /// <summary/>
        public AccountType(BankType bank, AccountNumType accountNumber = null)
            : this(bank) => AccountNumber = accountNumber;


        /// <summary>
        /// Данные ТОФК, структурного подразделения кредитной организации или подразделения Банка России, в котором открыт счет
        /// </summary>
        public BankType Bank
        {
            get => BankField;
            set => BankField = Validator.IsNull(value: value, name: nameof(Bank));
        }

        BankType BankField;


        [XmlIgnore]
        public AccountNumType AccountNumber { get; set; }


        /// <summary>
        /// Поле номер 17: Номер казначейского счета или номер счета получателя средств в банке получателя
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("accountNumber")]
        public string WrapperAccountNumber { get => AccountNumber; set => AccountNumber = value; }
    }
}
