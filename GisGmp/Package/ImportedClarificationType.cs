using GisGmp.Clarification;
using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <summary>
    /// Направляемые новое уточнение вида и принадлежности платежа
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public class ImportedClarificationType : ClarificationType
    {
        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего запрос
        /// </summary>
        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }

        /// <summary>
        /// Идентификатор начисления в пакете
        /// </summary>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
