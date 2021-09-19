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
        /// <summary/>
        protected ImportedClarificationType() { }

        public ImportedClarificationType(string id, ClarificationType clarification, string originatorId = default)
            : base(clarification)
        {
            Id = id;
            OriginatorId = originatorId;
        }

        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего сущность |> not required
        /// </summary>
        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }

        /// <summary>
        /// Идентификатор уточнения вида и принадлежности платежа в пакете |> required
        /// </summary>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
