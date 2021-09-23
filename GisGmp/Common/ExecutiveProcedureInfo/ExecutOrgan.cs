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
        protected ExecutOrgan() { }

        /// <summary>
        /// Данные органа, выдавшего исполнительный документ
        /// </summary>
        /// <param name="organOkogu">Поле номер 1114: Код по Общероссийскому классификатору органов государственной власти и управления (ОКОГУ) органа, выдавшего исполнительный документ</param>
        /// <param name="organCode">Поле номер 1115: Код подразделения органа, выдавшего исполнительный документ</param>
        /// <param name="organ">Поле номер 1116: Наименование подразделения уполномоченного органа, выдавшего исполнительный документ</param>
        /// <param name="organAdr">Поле номер 1117: Адрес органа, выдавшего исполнительный документ</param>
        /// <param name="organSignCodePost">Поле номер 1118: Код должности лица, выдавшего исполнительный документ</param>
        /// <param name="organSign">Поле номер 1119: Должность лица, выдавшего исполнительный документ</param>
        /// <param name="organSignFIO">Поле номер 1120: Фамилия, имя, отчество должностного лица, выдавшего исполнительный документ</param>
        public ExecutOrgan(
            string organOkogu,
            string organCode,
            string organ,
            string organAdr,
            string organSignCodePost,
            string organSign,
            string organSignFIO
            ) 
        {
            OrganOkogu = organOkogu;
            OrganCode = organCode;
            Organ = organ;
            OrganAdr = organAdr;
            OrganSignCodePost = organSignCodePost;
            OrganSign = organSign;
            OrganSignFIO = organSignFIO;
        }

        /// <summary>
        /// Поле номер 1114: Код по Общероссийскому классификатору органов государственной власти и управления (ОКОГУ) органа, выдавшего исполнительный документ
        /// <para>use: required</para>
        /// <para>length: 7</para>
        /// <para>pattern: "\d{7}"</para>
        /// </summary>
        [XmlAttribute("organOkogu")]
        public string OrganOkogu { get; set; }

        /// <summary>
        /// Поле номер 1115: Код подразделения органа, выдавшего исполнительный документ
        /// <para>use: required</para>
        /// <para>length: 1..10</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("organCode")]
        public string OrganCode { get; set; }

        /// <summary>
        /// Поле номер 1116: Наименование подразделения уполномоченного органа, выдавшего исполнительный документ
        /// <para>use: required</para>
        /// <para>length: 1..1000</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("organ")]
        public string Organ { get; set; }

        /// <summary>
        /// Поле номер 1117: Адрес органа, выдавшего исполнительный документ
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("organAdr")]
        public string OrganAdr { get; set; }

        /// <summary>
        /// Поле номер 1118: Код должности лица, выдавшего исполнительный документ
        /// <para>use: required</para>
        /// <para>length: 1..25</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("organSignCodePost")]
        public string OrganSignCodePost { get; set; }

        /// <summary>
        /// Поле номер 1119: Должность лица, выдавшего исполнительный документ
        /// <para>use: required</para>
        /// <para>length: 1..255</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("organSign")]
        public string OrganSign { get; set; }

        /// <summary>
        /// Поле номер 1120: Фамилия, имя, отчество должностного лица, выдавшего исполнительный документ
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("organSignFIO")]
        public string OrganSignFIO { get; set; }
    }
}
