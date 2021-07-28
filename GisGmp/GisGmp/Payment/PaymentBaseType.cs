using GisGmp.Common;
using GisGmp.Income;
using GisGmp.Organization;
using System;
using System.Xml.Serialization;

namespace GisGmp.Payment
{
    [XmlInclude(typeof(PaymentType))]
    [XmlInclude(typeof(ImportedPaymentType))]
    [XmlInclude(typeof(IncomeType))]
    [XmlInclude(typeof(ImportedIncomeType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Payment/2.4.0")]
    public class PaymentBaseType
    {
        public PaymentOrgType PaymentOrg { get; set; }

        public Payer1 Payer { get; set; }

        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
        public Payee Payee { get; set; }

        public BudgetIndexType BudgetIndex { get; set; }

        public AccDocType AccDoc { get; set; }

        [XmlElement("AdditionalData", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public AdditionalDataType[] AdditionalData { get; set; }

        [XmlAttribute]
        public string supplierBillID { get; set; }

        [XmlAttribute]
        public string purpose { get; set; }

        [XmlAttribute]
        public ulong amount { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime receiptDate { get; set; }

        [XmlIgnore]
        public bool receiptDateSpecified { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime paymentExecDate { get; set; }

        [XmlIgnore]
        public bool paymentExecDateSpecified { get; set; }

        [XmlAttribute]
        public string kbk { get; set; }

        [XmlAttribute]
        public string oktmo { get; set; }

        [XmlAttribute]
        public TransKindType transKind { get; set; }
    }
}
