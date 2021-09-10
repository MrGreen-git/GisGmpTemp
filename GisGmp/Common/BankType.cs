using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Данные ТОФК, структурных подразделений кредитных организаций или подразделений Банка России
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class BankType
    {
        /// <summary/>
        protected BankType() { }

        /// <summary/>
        public BankType(string bik) => Bik = bik;

        /// <summary/>
        public BankType(string bik, string name = null, AccountNumType correspondentBankAccount = null)
            : this(bik)
        {
            Name = name;
            CorrespondentBankAccount = correspondentBankAccount;
        }

        /// <summary>
        /// Поле номер 13 для получателя средств. Поле номер 10 для организации, принявшей платеж. Наименование ТОФК, структурного подразделения кредитной организации или подразделения Банка России, в котором открыт счет.
        /// </summary>
        [XmlAttribute("name")]
        public string Name
        {
            get => NameField;
            set => NameField = Validator.String(value: ref value, name: nameof(Name), required: false, min: 1, max: 200);
        }

        string NameField;


        [XmlIgnore]
        public BIKType Bik
        {
            get => BikField;
            set => BikField = Validator.IsNull(value: value, name: nameof(Bik));
        }

        BIKType BikField;

        /// <summary>
        /// Поле номер 14 для получателя средств. Поле номер 11 для организации, принявшей платеж. БИК ТОФК, структурного подразделения кредитной организации или подразделения Банка России, в котором открыт счет
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("bik")]
        public string WrapperBik { get => Bik; set => Bik = value; }


        [XmlIgnore]
        public AccountNumType CorrespondentBankAccount { get; set; }

        /// <summary>
        /// Поле номер 15 для получателя средств. Поле номер 12 для организации, принявшей платеж. Номер единого казначейского счета или корреспондентского счета кредитной организации, открытый в подразделении Банка России.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("correspondentBankAccount")]
        public string WrapperCorrespondentBankAccount { get => CorrespondentBankAccount; set => CorrespondentBankAccount = value; }
    }
}
