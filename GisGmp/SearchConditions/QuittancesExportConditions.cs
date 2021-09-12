using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0", IsNullable = false)]
    public class QuittancesExportConditions : Conditions
    {
        /// <summary />
        protected QuittancesExportConditions() { }

        private QuittancesExportConditions(ExportQuittancesKind kind) => Kind = kind.ToString();

        /// <summary />
        public QuittancesExportConditions(ExportQuittancesKind kind, ChargesConditionsType conditions) : this(kind) => Item = conditions;

        /// <summary />
        public QuittancesExportConditions(ExportQuittancesKind kind, TimeConditionsType conditions) : this(kind) => Item = conditions;
    }
}
