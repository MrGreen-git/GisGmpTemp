using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Данные органа, выдавшего исполнительный документ
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class ExecutOrgan
    {
        /// <summary>
        /// Поле номер 1114: Код по Общероссийскому классификатору органов государственной власти и управления (ОКОГУ) органа, выдавшего исполнительный документ
        /// </summary>
        [XmlAttribute("organOkogu")]
        public string OrganOkogu { get; set; }

        /// <summary>
        /// Поле номер 1115: Код подразделения органа, выдавшего исполнительный документ
        /// </summary>
        [XmlAttribute("organCode")]
        public string OrganCode { get; set; }

        /// <summary>
        /// Поле номер 1116: Наименование подразделения уполномоченного органа, выдавшего исполнительный документ
        /// </summary>
        [XmlAttribute("organ")]
        public string Organ { get; set; }

        /// <summary>
        /// Поле номер 1117: Адрес  органа, выдавшего исполнительный документ
        /// </summary>
        [XmlAttribute("organAdr")]
        public string OrganAdr { get; set; }

        /// <summary>
        /// Поле номер 1118: Код должности лица, выдавшего исполнительный документ
        /// </summary>
        [XmlAttribute("organSignCodePost")]
        public string OrganSignCodePost { get; set; }

        /// <summary>
        /// Поле номер 1119: Должность лица, выдавшего исполнительный документ
        /// </summary>
        [XmlAttribute("organSign")]
        public string OrganSign { get; set; }

        /// <summary>
        /// Поле номер 1120: Фамилия, имя, отчество должностного лица, выдавшего исполнительный документ
        /// </summary>
        [XmlAttribute("organSignFIO")]
        public string OrganSignFIO { get; set; }
    }
}
