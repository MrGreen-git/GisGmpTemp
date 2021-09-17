using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0", IsNullable = false)]
    public class IncomesExportConditions : Conditions
    {
        /// <summary/>
        protected IncomesExportConditions() { }

        private IncomesExportConditions(ExportIncomesKind kind)
            => Kind = kind.GetXmlValue();

        /// <summary/>
        public IncomesExportConditions(ExportIncomesKind kind, ChargesConditionsType conditions)
            : this(kind) => Item = conditions;

        /// <summary/>
        public IncomesExportConditions(ExportIncomesKind kind, PayersConditionsType conditions)
            : this(kind) => Item = conditions;

        /// <summary/>
        public IncomesExportConditions(ExportIncomesKind kind, PaymentsConditionsType conditions)
            : this(kind) => Item = conditions;

        /// <summary/>
        public IncomesExportConditions(ExportIncomesKind kind, TimeConditionsType conditions)
            : this(kind) => Item = conditions;

        /// <summary/>
        public IncomesExportConditions(ExportIncomesKind kind, IncomesConditionsType conditions)
            : this(kind) => Item = conditions;   
    }
}
