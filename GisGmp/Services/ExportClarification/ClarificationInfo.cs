using GisGmp.Clarification;
using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportClarification
{
    /// <summary>
    /// Извещение о зачислении
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-clarification/2.4.0")]
    public class ClarificationInfo : ClarificationType
    {
        /// <summary/>
        protected ClarificationInfo() { }

        /// <summary/>
        public ClarificationInfo(ChangeStatusInfo changeStatusInfo, ClarificationType clarification)
            : base(clarification) => ChangeStatusInfo = changeStatusInfo;

        /// <summary>
        /// Сведения о статусе извещения о зачислении и основаниях изменения |> required
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public ChangeStatusInfo ChangeStatusInfo { get; set; }
    }
}
