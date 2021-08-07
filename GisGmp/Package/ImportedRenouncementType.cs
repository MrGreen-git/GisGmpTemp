using GisGmp.Renouncement;
using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <summary>
    /// Направляемое новое извещение об отказе в возбуждении ИП
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public class ImportedRenouncementType : RenouncementType
    {
        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего запрос
        /// </summary>
        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }

        /// <summary>
        /// Идентификатор извещения об отказе в пакете
        /// </summary>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
