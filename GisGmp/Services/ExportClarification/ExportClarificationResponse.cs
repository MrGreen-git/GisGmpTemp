using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportClarification
{
    /// <summary>
    /// Ответ на запрос предоставления информации об уточнении вида и принадлежности платежа(уточнение зачисления)
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-clarification/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-clarification/2.4.0", IsNullable = false)]
    public class ExportClarificationResponse : ResponseType
    {
        /// <summary>
        /// Извещение для предоставления информации об уточнении вида и принадлежности платежа(уточнение зачисления)
        /// </summary>
        [XmlElement("ClarificationInfo")]
        public ClarificationInfo[] ClarificationInfo { get; set; }

        /// <summary>
        /// Признак конца выборки: false - достигнут конец выборки; true - после последнего предоставленного элемента в выборке имеются другие.
        /// </summary>
        [XmlAttribute("hasMore")]
        public bool HasMore { get; set; }
    }
}
