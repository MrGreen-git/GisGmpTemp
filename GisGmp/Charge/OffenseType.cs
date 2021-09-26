using System;
using System.Xml.Serialization;

namespace GisGmp.Charge
{
    /// <summary>
    /// Блок дополнительной информации об административном правонарушении
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.4.0")]
    [XmlRoot("AdditionalOffense", Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.4.0", IsNullable = false)]
    public class OffenseType
    {
        protected OffenseType() { }

        /// <summary>
        /// Блок дополнительной информации об административном правонарушении
        /// </summary>
        /// <param name="offenseDate">Поле номер 1401: Дата и время нарушения</param>
        /// <param name="offensePlace">Поле номер 1402: Место нарушения</param>
        /// <param name="legalAct">Поле номер 1403: Статья нарушения</param>
        /// <param name="digitalLink">Поле номер 1404: Ссылка на фото (видео) материалы фиксации нарушения</param>
        /// <param name="departmentName">Поле номер 1406: Данные о подразделении, вынесшем постановлен</param>
        public OffenseType(
            DateTime offenseDate,
            string offensePlace,
            string legalAct,
            string digitalLink,
            string departmentName
            ) 
        { 
            OffenseDate = offenseDate;
            OffensePlace = offensePlace;
            LegalAct = legalAct;
            DigitalLink = digitalLink;
            DepartmentName = departmentName;
        }

        /// <summary>
        /// Поле номер 1401: Дата и время нарушения
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("offenseDate")]
        public DateTime OffenseDate { get; set; }

        /// <summary>
        /// Поле номер 1402: Место нарушения
        /// <para>use: required</para>
        /// <para>length: 1..255</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// <para>pattern: "0"</para>
        /// </summary>
        [XmlAttribute("offensePlace")]
        public string OffensePlace { get; set; }

        /// <summary>
        /// Поле номер 1403: Статья нарушения
        /// <para>use: required</para>
        /// <para>length: 1..255</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// <para>pattern: "0"</para>
        /// </summary>
        [XmlAttribute("legalAct")]
        public string LegalAct { get; set; }

        /// <summary>
        /// Поле номер 1404: Ссылка на фото (видео) материалы фиксации нарушения
        /// <para>use: required</para>
        /// <para>length: 1..2000</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// <para>pattern: "0"</para>
        /// </summary>
        [XmlAttribute("digitalLink")]
        public string DigitalLink { get; set; }

        /// <summary>
        /// Поле номер 1406: Данные о подразделении, вынесшем постановлен
        /// <para>use: required</para>
        /// <para>length: 1..255</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// <para>pattern: "0"</para>
        /// </summary>
        [XmlAttribute("departmentName")]
        public string DepartmentName { get; set; }
    }
}
