using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Информация о лице, принявшем решение об учете факта оплаты
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class PersoneOfficial
    {
        /// <summary>
        /// Фамилия и инициалы должностного лица, принявшего решение об учете факта оплаты
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// Должность лица, принявшего решение об учете платежа
        /// </summary>
        [XmlAttribute("officialPosition")]
        public string OfficialPosition { get; set; }
    }
}
