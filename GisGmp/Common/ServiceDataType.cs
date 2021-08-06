using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Дополнительные сведения о предоставлении услуги
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class ServiceDataType
    {
        /// <summary>
        /// Информация о лице, принявшем решение об учете факта оплаты
        /// </summary>
        public PersoneOfficial personeOfficial { get; set; }

        /// <summary>
        /// Сумма, на которую была предоставлена услуга, в копейках
        /// </summary>
        [XmlAttribute("amount")]
        public ulong Amount { get; set; }

        /// <summary>
        /// Наименование организации, принявшей решение об учете платежа
        /// </summary>
        [XmlAttribute("courtName")]
        public string CourtName { get; set; }

        /// <summary>
        /// Реквизиты делопроизводства
        /// </summary>
        [XmlAttribute("lawsuitInfo")]
        public string LawsuitInfo { get; set; }
    }
}
