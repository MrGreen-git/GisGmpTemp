using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class ExecutiveProcedureInfoTypeDebtorPerson
    {
        [XmlAttribute]
        public string debtorRegPlace { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime debtorBirthDate { get; set; }

        [XmlIgnore]
        public bool debtorBirthDateSpecified { get; set; }

        [XmlAttribute]
        public ExecutiveProcedureInfoTypeDebtorPersonDebtorGender debtorGender { get; set; }

        [XmlAttribute]
        public string debtorBirthPlace { get; set; }
    }
}
