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
        protected ClarificationsExportConditions() { }

        private ClarificationsExportConditions(ExportClarificationsKind kind) => Kind = kind.GetXmlValue();

        public ClarificationsExportConditions(ExportClarificationsKind kind, ClarificationsConditionsType conditions) : this(kind) => ClarificationsConditions = conditions;
        public ClarificationsExportConditions(ExportClarificationsKind kind, IncomesConditionsType conditions) : this(kind) => IncomesConditions = conditions;
        public ClarificationsExportConditions(ExportClarificationsKind kind, PaymentsConditionsType conditions) : this(kind) => PaymentsConditions = conditions;
        public ClarificationsExportConditions(ExportClarificationsKind kind, PayersConditionsType conditions) : this(kind) => PayersConditions = conditions;
        public ClarificationsExportConditions(ExportClarificationsKind kind, TimeConditionsType conditions) : this(kind) => TimeConditions = conditions;


        [XmlIgnore]
        public ClarificationsConditionsType ClarificationsConditions { 
            get => Item as ClarificationsConditionsType;
            set => Item = value;
        }

        [XmlIgnore]
        public IncomesConditionsType IncomesConditions { 
            get => Item as IncomesConditionsType;
            set => Item = value;
        }

        [XmlIgnore]
        public PaymentsConditionsType PaymentsConditions { 
            get => Item as PaymentsConditionsType;
            set => Item = value;
        }

        [XmlIgnore]
        public PayersConditionsType PayersConditions {
            get => Item as PayersConditionsType;
            set => Item = value;
        }

        [XmlIgnore]
        public TimeConditionsType TimeConditions { 
            get => Item as TimeConditionsType;
            set => Item = value;
        }
    }
}
