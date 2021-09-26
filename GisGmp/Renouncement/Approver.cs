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
        protected Approver() { }

        /// <summary>
        /// Информация об утверждении постановления об отказе в возбуждении ИП
        /// </summary>
        /// <param name="positionCode">Код должности СПИ/должностного лица ФССП России, утвердившего документ</param>
        /// <param name="positionName">Наименование должности лица, утвердившего документ</param>
        /// <param name="personApproving">ФИО лица, утвердившего документ</param>
        /// <param name="approvalDate">Дата утверждения</param>
        public Approver(
            string positionCode,
            string positionName,
            string personApproving,
            DateTime approvalDate
            )
        {
            PositionCode = positionCode;
            PositionName = positionName;
            PersonApproving = personApproving;
            ApprovalDate = approvalDate;
        }

        /// <summary>
        /// Код должности СПИ/должностного лица ФССП России, утвердившего документ
        /// <para>use: required</para>
        /// <para>length: 1..25</para>
        /// </summary>
        [XmlAttribute("positionCode")]
        public string PositionCode 
        {
            get => PositionCodeField;
            set => PositionCodeField = value.IsRequired().IsLength(min: 1, max: 25);
        }

        string PositionCodeField;

        /// <summary>
        /// Наименование должности лица, утвердившего документ
        /// <para>use: required</para>
        /// <para>length: 1..255</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("positionName")]
        public string PositionName 
        {
            get => PositionNameField;
            set => PositionNameField = value.IsRequired().IsLength(min: 1, max: 255);
        }

        string PositionNameField;

        /// <summary>
        /// ФИО лица, утвердившего документ
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("personApproving")]
        public string PersonApproving  //TODO type
        {
            get => PersonApprovingField;
            set => PersonApprovingField = value.IsRequired();
        }

        string PersonApprovingField;

        /// <summary>
        /// Дата утверждения
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("approvalDate", DataType = "date")]
        public DateTime ApprovalDate { get; set; }
    }
}
