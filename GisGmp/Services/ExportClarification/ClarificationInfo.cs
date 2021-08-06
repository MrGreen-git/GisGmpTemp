using GisGmp.Clarification;
using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportClarification
{
    /// <summary>
    /// Извещение для предоставления информации об уточнении вида и принадлежности платежа(уточнение зачисления)
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-clarification/2.4.0")]
    public class ClarificationInfo : ClarificationType
    {
        /// <summary>
        /// Сведения о статусе уточнении вида и принадлежности платежа и основаниях его изменения
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public ChangeStatusInfo ChangeStatusInfo { get; set; }
    }
}
