using System;
using System.Xml.Serialization;

namespace GisGmp.Organization
{
    /// <summary>
    /// Данные организации
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
    public class OrganizationType
    {
        /// <summary>
        /// Поле номер 16: Наименование организации
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// Поле номер 61: ИНН организации
        /// </summary>
        [XmlAttribute("inn")]
        public string Inn { get; set; }

        /// <summary>
        /// Поле номер 103: КПП организации
        /// </summary>
        [XmlAttribute("kpp")]
        public string Kpp { get; set; }

        /// <summary>
        /// Поле номер 200: ОГРН организации
        /// </summary>
        [XmlAttribute("ogrn")]
        public string Ogrn { get; set; }
    }
}
