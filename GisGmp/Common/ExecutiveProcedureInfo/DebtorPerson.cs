using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Данные индивидуального предпринимателя или физического лица
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class DebtorPerson
    {
        /// <summary>
        /// Поле номер 1125: Место регистрации должника - индивидуального предпринимателя
        /// </summary>
        [XmlAttribute("debtorRegPlace")]
        public string DebtorRegPlace { get; set; }

        /// <summary>
        /// Поле номер 1126: Дата рождения должника
        /// </summary>
        [XmlAttribute("debtorBirthDate", DataType = "date")]
        public DateTime DebtorBirthDate { get; set; }

        [XmlIgnore]
        public bool DebtorBirthDateSpecified { get; set; }

        /// <summary>
        /// Поле номер 1127: Пол должника
        /// </summary>
        [XmlAttribute("debtorGender")]
        public Gender DebtorGender { get; set; }

        /// <summary>
        /// Поле номер 1128: Место рождения должника
        /// </summary>
        [XmlAttribute("debtorBirthPlace")]
        public string DebtorBirthPlace { get; set; }
    }
}
