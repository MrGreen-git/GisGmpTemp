using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNSI
{
    /// <summary>
    /// Запрос на предоставление из ГИС ГМП нормативно-справочной информации
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0", IsNullable = false)]
    public class ExportNSIRequest : RequestType
    {
        /// <summary/>
        protected ExportNSIRequest() { }

        /// <summary/>
        public ExportNSIRequest(RequestType config, NSIExportConditions nSIExportConditions)
            : base(config) => NSIExportConditions = nSIExportConditions;

        /// <summary/>
        public ExportNSIRequest(RequestType config, NSIExportConditions nSIExportConditions, URNType originatorId)
            : this(config, nSIExportConditions) => OriginatorId = originatorId;

        /// <summary>
        /// Условия для предоставления нормативно-справочной информации
        /// </summary>
        public NSIExportConditions NSIExportConditions 
        {
            get => NSIExportConditionsField;
            set => NSIExportConditionsField = value;
        }

        NSIExportConditions NSIExportConditionsField;

        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }
    }
}
