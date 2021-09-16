using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0", IsNullable = false)]
    public class PaymentsExportConditions : Conditions
    {
        /// <summary/>
        protected PaymentsExportConditions() { }

        /// <summary/>
        private PaymentsExportConditions(ExportPaymentsKind kind) 
            => Kind = kind.GetXmlValue();

        /// <summary/>
        public PaymentsExportConditions(ExportPaymentsKind kind, ChargesConditionsType conditions) 
            : this(kind) => Item = conditions;

        /// <summary/>
        public PaymentsExportConditions(ExportPaymentsKind kind, PayersConditionsType conditions) 
            : this(kind) => Item = conditions;

        /// <summary/>
        public PaymentsExportConditions(ExportPaymentsKind kind, PaymentsConditionsType conditions) 
            : this(kind) => Item = conditions;

        /// <summary/>
        public PaymentsExportConditions(ExportPaymentsKind kind, TimeConditionsType conditions) 
            : this(kind) => Item = conditions;
    }
}
