using GisGmp.Common;
using GisGmp.SearchConditions;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportClarification
{
    /// <summary>
    /// Запрос на предоставление информации об уточнении вида и принадлежности платежа(уточнение зачисления)
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-clarification/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-clarification/2.4.0", IsNullable = false)]
    public class ExportClarificationsRequest : ExportRequestType
    {
        /// <summary/>

        /// <summary>
        /// Условия для предоставления информации об уточнении вида и принадлежности платежа(уточнение зачисления)
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
        public ClarificationsExportConditions ClarificationsExportConditions { get; set; }
    }
}
