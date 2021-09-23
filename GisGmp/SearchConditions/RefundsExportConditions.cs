using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <summary>
    /// Условия для предоставления информации об уплате
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0", IsNullable = false)]
    public class RefundsExportConditions : Conditions
    {
        protected RefundsExportConditions() { }

        private RefundsExportConditions(ExportRefundsKind kind) => Kind = kind.GetXmlValue();

        public RefundsExportConditions(ExportRefundsKind kind, PayersConditionsType conditions) : this(kind) => PayersConditions = conditions;
        public RefundsExportConditions(ExportRefundsKind kind, PaymentsConditionsType conditions) : this(kind) => PaymentsConditions = conditions;
        public RefundsExportConditions(ExportRefundsKind kind, RefundsConditionsType conditions) : this(kind) => RefundsConditions = conditions;
        public RefundsExportConditions(ExportRefundsKind kind, TimeConditionsType conditions) : this(kind) => TimeConditions = conditions;


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
        public RefundsConditionsType RefundsConditions {
            get => Item as RefundsConditionsType;
            set => Item = value;
        }

        [XmlIgnore]
        public TimeConditionsType TimeConditions {
            get => Item as TimeConditionsType;
            set => Item = value;
        }
    }
}
