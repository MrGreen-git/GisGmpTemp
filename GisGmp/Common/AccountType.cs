using System;
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
        /// <summary>
        /// Данные ТОФК, структурного подразделения кредитной организации или подразделения Банка России, в котором открыт счет
        /// </summary>
        public BankType Bank { get; set; }

        /// <summary>
        /// Поле номер 17: Номер казначейского счета или номер счета получателя средств в банке получателя
        /// </summary>
        [XmlAttribute("accountNumber")]
        public string AccountNumber { get; set; }
    }
}
