using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0", IsNullable = false)]
    public class IncomesExportConditions : Conditions
    {
        protected IncomesExportConditions() { }

        private IncomesExportConditions(ExportIncomesKind kind) => Kind = kind.GetXmlValue();

        public IncomesExportConditions(ExportIncomesKind kind, ChargesConditionsType conditions) : this(kind) => ChargesConditions = conditions;
        public IncomesExportConditions(ExportIncomesKind kind, PayersConditionsType conditions) : this(kind) => PayersConditions = conditions;
        public IncomesExportConditions(ExportIncomesKind kind, PaymentsConditionsType conditions) : this(kind) => PaymentsConditions = conditions;
        public IncomesExportConditions(ExportIncomesKind kind, TimeConditionsType conditions) : this(kind) => TimeConditions = conditions;
        public IncomesExportConditions(ExportIncomesKind kind, IncomesConditionsType conditions) : this(kind) => IncomesConditions = conditions;


        [XmlIgnore]
        public ChargesConditionsType ChargesConditions { 
            get => Item as ChargesConditionsType;
            set => Item = value;
        }

        [XmlIgnore]
        public PayersConditionsType PayersConditions { 
            get => Item as PayersConditionsType;
            set => Item = value;
        }

        [XmlIgnore]
        public PaymentsConditionsType PaymentsConditions { 
            get => Item as PaymentsConditionsType;
            set => Item = value;
        }

        [XmlIgnore]
        public TimeConditionsType TimeConditions { 
            get => Item as TimeConditionsType;
            set => Item = value;
        }

        [XmlIgnore]
        public IncomesConditionsType IncomesConditions { 
            get => Item as IncomesConditionsType;
            set => Item = value;
        }
    }
}
