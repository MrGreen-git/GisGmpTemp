using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0", IsNullable = false)]
    public class QuittancesExportConditions : Conditions
    {
        protected QuittancesExportConditions() { }

        private QuittancesExportConditions(ExportQuittancesKind kind) => Kind = kind.GetXmlValue();

        public QuittancesExportConditions(ExportQuittancesKind kind, ChargesConditionsType conditions) : this(kind) => ChargesConditions = conditions;
        public QuittancesExportConditions(ExportQuittancesKind kind, TimeConditionsType conditions) : this(kind) => TimeConditions = conditions;


        [XmlIgnore]
        public ChargesConditionsType ChargesConditions {
            get => Item as ChargesConditionsType;
            set => Item = value;
        }

        [XmlIgnore]
        public TimeConditionsType TimeConditions {
            get => Item as TimeConditionsType;
            set => Item = value;
        }
    }
}
