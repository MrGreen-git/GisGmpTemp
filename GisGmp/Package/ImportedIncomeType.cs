using GisGmp.Income;
using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <summary>
    /// Направляемое новое зачисление
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public class ImportedIncomeType : IncomeType
    {
        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего запрос
        /// </summary>
        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }

        /// <summary>
        /// Идентификатор зачисления в пакете
        /// </summary>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
