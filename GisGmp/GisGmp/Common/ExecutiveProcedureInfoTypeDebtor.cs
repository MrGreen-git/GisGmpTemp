using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class ExecutiveProcedureInfoTypeDebtor
    {
        public ExecutiveProcedureInfoTypeDebtorPerson Person { get; set; }

        [XmlAttribute]
        public ExecutiveProcedureInfoTypeDebtorDebtorType debtorType { get; set; }

        [XmlAttribute]
        public string debtorAdr { get; set; }

        [XmlAttribute]
        public string debtorAdrFakt { get; set; }

        [XmlAttribute]
        public string debtorCountryCode { get; set; }
    }
}
