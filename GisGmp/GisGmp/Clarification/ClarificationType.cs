using GisGmp.Package;
using System;
using System.Xml.Serialization;

namespace GisGmp.Clarification
{
    [XmlInclude(typeof(ImportedClarificationType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
    public class ClarificationType : AbstractClarificationType
    {
        public ClarificationApplicationType ClarificationApplication { get; set; }

        public SignsClarificationType Signs { get; set; }

        [XmlAttribute]
        public string clarificationNumber { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime clarificationDate { get; set; }

        [XmlAttribute]
        public string clarificationId { get; set; }

        [XmlAttribute]
        public string paymentId { get; set; }

        [XmlAttribute]
        public string supplierBillID { get; set; }

        [XmlAttribute]
        public string authorAccount { get; set; }

        [XmlAttribute]
        public string authorName { get; set; }

        [XmlAttribute]
        public string codeUBP { get; set; }

        [XmlAttribute]
        public string mainAuthorName { get; set; }

        [XmlAttribute]
        public string kbkGlavaCode { get; set; }

        [XmlAttribute]
        public ClarificationTypeBudgetLevel budgetLevel { get; set; }

        [XmlAttribute]
        public string okpo { get; set; }

        [XmlAttribute]
        public string finBodyAccount { get; set; }

        [XmlAttribute]
        public string financialBody { get; set; }

        [XmlAttribute]
        public string tofkName { get; set; }

        [XmlAttribute]
        public string tofkCode { get; set; }

        [XmlAttribute]
        public string payerName { get; set; }

        [XmlAttribute]
        public string payerIdentifier { get; set; }

        [XmlAttribute]
        public string inn { get; set; }

        [XmlAttribute]
        public string kpp { get; set; }

        [XmlAttribute]
        public string payerDocument { get; set; }

        [XmlAttribute]
        public string payerAccount { get; set; }

        [XmlAttribute]
        public string findingoutRequestNum { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime findingoutRequestDate { get; set; }

        [XmlIgnore]
        public bool findingoutRequestDateSpecified { get; set; }
    }
}
