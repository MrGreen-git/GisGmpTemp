using System;
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
        /// <summary>
        /// Поле номер 13 для получателя средств. Поле номер 10 для организации, принявшей платеж. Наименование ТОФК, структурного подразделения кредитной организации или подразделения Банка России, в котором открыт счет.
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// Поле номер 14 для получателя средств. Поле номер 11 для организации, принявшей платеж. БИК ТОФК, структурного подразделения кредитной организации или подразделения Банка России, в котором открыт счет
        /// </summary>
        [XmlAttribute("bik")]
        public string Bik { get; set; }

        /// <summary>
        /// Поле номер 15 для получателя средств. Поле номер 12 для организации, принявшей платеж. Номер единого казначейского счета или корреспондентского счета кредитной организации, открытый в подразделении Банка России.
        /// </summary>
        [XmlAttribute("correspondentBankAccount")]
        public string CorrespondentBankAccount { get; set; }
    }
}
