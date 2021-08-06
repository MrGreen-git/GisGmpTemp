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
        /// <summary>
        /// Поле номер 1109: Код вида исполнительного документа
        /// </summary>
        [XmlAttribute]
        public DeedInfoIDType IDType { get; set; }

        /// <summary>
        /// Поле номер 1110: Номер исполнительного документа, присвоенный органом, выдавшим исполнительный документ
        /// </summary>
        [XmlAttribute("idDocNo")]
        public string IdDocNo { get; set; }

        /// <summary>
        /// Поле номер 1111: Дата выдачи исполнительного документа
        /// </summary>
        [XmlAttribute("idDocDate", DataType = "date")]
        public DateTime IdDocDate { get; set; }

        /// <summary>
        /// Поле номер 1112: Код предмета исполнения
        /// </summary>
        [XmlAttribute("subjCode")]
        public string SubjCode { get; set; }

        /// <summary>
        /// Поле номер 1113: Предмет исполнения
        /// </summary>
        [XmlAttribute("subjName")]
        public string SubjName { get; set; }
    }
}
