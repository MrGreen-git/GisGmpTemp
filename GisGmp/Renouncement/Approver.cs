using System;
using System.Xml.Serialization;

namespace GisGmp.Renouncement
{
    /// <summary>
    /// Информация об утверждении постановления об отказе в возбуждении ИП
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Renouncement/2.4.0")]
    public class Approver
    {
        /// <summary>
        /// Код должности СПИ/должностного лица ФССП России, утвердившего документ
        /// </summary>
        [XmlAttribute("positionCode")]
        public string PositionCode { get; set; }

        /// <summary>
        /// Наименование должности лица, утвердившего документ
        /// </summary>
        [XmlAttribute("positionName")]
        public string PositionName { get; set; }

        /// <summary>
        /// ФИО лица, утвердившего документ
        /// </summary>
        [XmlAttribute("personApproving")]
        public string PersonApproving { get; set; }

        /// <summary>
        /// Дата утверждения
        /// </summary>
        [XmlAttribute("approvalDate", DataType = "date")]
        public DateTime ApprovalDate { get; set; }
    }
}
