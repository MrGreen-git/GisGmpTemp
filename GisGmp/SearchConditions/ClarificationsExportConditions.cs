using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <summary>
    /// Условия для предоставления информации об уточнении вида и принадлежности платежа
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0", IsNullable = false)]
    public class ClarificationsExportConditions : Conditions
    {
        /// <summary/>
        protected ClarificationsExportConditions() { }

        /// <summary/>
        private ClarificationsExportConditions(ExportClarificationsKind kind)
            => Kind = kind.GetXmlValue();

        /// <summary/>
        public ClarificationsExportConditions(ExportClarificationsKind kind, ClarificationsConditionsType conditions)
            : this(kind) => Item = conditions;

        /// <summary/>
        public ClarificationsExportConditions(ExportClarificationsKind kind, IncomesConditionsType conditions)
            : this(kind) => Item = conditions;

        /// <summary/>
        public ClarificationsExportConditions(ExportClarificationsKind kind, PaymentsConditionsType conditions)
            : this(kind) => Item = conditions;

        /// <summary/>
        public ClarificationsExportConditions(ExportClarificationsKind kind, PayersConditionsType conditions)
            : this(kind) => Item = conditions;

        /// <summary/>
        public ClarificationsExportConditions(ExportClarificationsKind kind, TimeConditionsType conditions)
            : this(kind) => Item = conditions;
    }
}
