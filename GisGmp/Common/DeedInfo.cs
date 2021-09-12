using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Данные исполнительного документа, по которому вынесено постановление об отказе в возбуждении ИП
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0", IsNullable = false)]
    public class DeedInfo
    {
        /// <summary/>
        protected DeedInfo() { }

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
        /// Поле номер 1109: Код вида исполнительного документа | required
        /// </summary>
        [XmlAttribute]
        public IDType IDType { get; set; }

        /// <summary>
        /// Поле номер 1110: Номер исполнительного документа, присвоенный органом, выдавшим исполнительный документ | required
        /// </summary>
        [XmlAttribute("idDocNo")]
        public string IdDocNo { get; set; }

        /// <summary>
        /// Поле номер 1111: Дата выдачи исполнительного документа | required
        /// </summary>
        [XmlAttribute("idDocDate", DataType = "date")]
        public DateTime IdDocDate { get; set; }

        /// <summary>
        /// Поле номер 1112: Код предмета исполнения | required
        /// </summary>
        [XmlAttribute("subjCode")]
        public string SubjCode { get; set; }

        /// <summary>
        /// Поле номер 1113: Предмет исполнения | required
        /// </summary>
        [XmlAttribute("subjName")]
        public string SubjName { get; set; }
    }
}
