using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Сведения о должнике
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class Debtor
    {
        /// <summary>
        /// Данные индивидуального предпринимателя или физического лица
        /// </summary>
        public DebtorPerson Person { get; set; }

        /// <summary>
        /// Поле номер 1121: Тип должника
        /// </summary>
        [XmlAttribute("debtorType")]
        public DebtorType DebtorType { get; set; }

        /// <summary>
        /// Поле номер 1122: Адрес должника
        /// </summary>
        [XmlAttribute("debtorAdr")]
        public string DebtorAdr { get; set; }

        /// <summary>
        /// Поле номер 1123: Адрес должника фактический
        /// </summary>
        [XmlAttribute("debtorAdrFakt")]
        public string DebtorAdrFakt { get; set; }

        /// <summary>
        /// Поле номер 1124: Код страны принадлежности должника по Общероссийскому классификатору стран мира
        /// </summary>
        [XmlAttribute("debtorCountryCode")]
        public string DebtorCountryCode { get; set; }
    }
}
