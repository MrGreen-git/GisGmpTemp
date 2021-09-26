using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0", IsNullable = false)]
    public class PaymentsExportConditions : Conditions
    {
        protected PaymentsExportConditions() { }

        private PaymentsExportConditions(ExportPaymentsKind kind) => Kind = kind.GetXmlValue();

        public PaymentsExportConditions(ExportPaymentsKind kind, ChargesConditionsType conditions) : this(kind) => ChargesConditions = conditions;
        public PaymentsExportConditions(ExportPaymentsKind kind, PayersConditionsType conditions) : this(kind) => PayersConditions = conditions;
        public PaymentsExportConditions(ExportPaymentsKind kind, PaymentsConditionsType conditions) : this(kind) => PaymentsConditions = conditions;
        public PaymentsExportConditions(ExportPaymentsKind kind, TimeConditionsType conditions) : this(kind) => TimeConditions = conditions;


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
    }
}
