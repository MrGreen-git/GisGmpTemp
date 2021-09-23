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
        protected Debtor() { }

        /// <summary>
        /// Сведения о должнике
        /// </summary>
        /// <param name="debtorType"></param>
        /// <param name="debtorAdr"></param>
        public Debtor(
            DebtorType debtorType,
            string debtorAdr
            ) 
        {  
            DebtorType = debtorType;
            DebtorAdr = debtorAdr;
        }

        /// <summary>
        /// Данные индивидуального предпринимателя или физического лица
        /// <para>use: not required</para>
        /// </summary>
        public DebtorPerson Person { get; set; }

        /// <summary>
        /// Поле номер 1121: Тип должника
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("debtorType")]
        public DebtorType DebtorType { get; set; }

        /// <summary>
        /// Поле номер 1122: Адрес должника
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("debtorAdr")]
        public string DebtorAdr { get; set; }

        /// <summary>
        /// Поле номер 1123: Адрес должника фактический
        /// <para>use: not required</para>
        /// </summary>
        [XmlAttribute("debtorAdrFakt")]
        public string DebtorAdrFakt { get; set; }

        /// <summary>
        /// Поле номер 1124: Код страны принадлежности должника по Общероссийскому классификатору стран мира
        /// <para>use: not required</para>
        /// <para>length: 3</para>
        /// <para>pattern: "\d{3}"</para>
        /// </summary>
        [XmlAttribute("debtorCountryCode")]
        public string DebtorCountryCode { get; set; }
    }
}
