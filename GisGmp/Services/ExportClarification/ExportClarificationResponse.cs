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
        /// <summary/>
        protected ExportClarificationResponse() { }

        public ExportClarificationResponse(ResponseType config, bool hasMore)
            : base(config) => HasMore = hasMore;

        public ExportClarificationResponse(ResponseType config, bool hasMore, ClarificationInfo[] clarificationInfo = default)
            : this(config, hasMore) => ClarificationInfo = clarificationInfo;

        /// <summary>
        /// Извещение о зачислении
        /// </summary>
        [XmlElement("ClarificationInfo")]
        public ClarificationInfo[] ClarificationInfo { get; set; }

        /// <summary>
        /// Признак конца выборки: false - достигнут конец выборки; true - после последнего предоставленного элемента в выборке имеются другие.
        /// required
        /// </summary>
        [XmlAttribute("hasMore")]
        public bool HasMore { get; set; }
    }
}
