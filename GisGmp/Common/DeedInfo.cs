using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Данные исполнительного документа
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0", IsNullable = false)]
    public class DeedInfo
    {
        protected DeedInfo() { }

        /// <summary>
        /// Данные исполнительного документа
        /// </summary>
        /// <param name="idType">Поле номер 1109: Код вида исполнительного документа</param>
        /// <param name="idDocNo">Поле номер 1110: Номер исполнительного документа, присвоенный органом, выдавшим исполнительный документ</param>
        /// <param name="idDocDate">Поле номер 1111: Дата выдачи исполнительного документа</param>
        /// <param name="subjCode">Поле номер 1112: Код предмета исполнения</param>
        /// <param name="subjName">Поле номер 1113: Предмет исполнения</param>
        public DeedInfo(
            IDType idType,
            string idDocNo,
            DateTime idDocDate,
            string subjCode,
            string subjName
            )
        {
            IDType = idType;
            IdDocNo = idDocNo;
            IdDocDate = idDocDate;
            SubjCode = subjCode;
            SubjName = subjName;
        }

        /// <summary>
        /// Поле номер 1109: Код вида исполнительного документа
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute]
        public IDType IDType { get; set; }

        /// <summary>
        /// Поле номер 1110: Номер исполнительного документа, присвоенный органом, выдавшим исполнительный документ
        /// <para>use: required</para>
        /// <para>length: 1..25</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("idDocNo")]
        public string IdDocNo { get; set; }

        /// <summary>
        /// Поле номер 1111: Дата выдачи исполнительного документа
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("idDocDate", DataType = "date")]
        public DateTime IdDocDate { get; set; }

        /// <summary>
        /// Поле номер 1112: Код предмета исполнения
        /// <para>use: required</para>
        /// <para>length: 7</para>
        /// <para>pattern: "\d{7}"</para>
        /// </summary>
        [XmlAttribute("subjCode")]
        public string SubjCode { get; set; }

        /// <summary>
        /// Поле номер 1113: Предмет исполнения
        /// <para>use: required</para>
        /// <para>length: 1..1000</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("subjName")]
        public string SubjName { get; set; }
    }
}
