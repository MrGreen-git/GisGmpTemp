using System;
using System.Xml.Serialization;
using GisGmp.Charge;
using GisGmp.Common;
using GisGmp.Refund;
using GisGmp.Payment;
using GisGmp.Organization;
using GisGmp.SearchConditions;
using GisGmp.Package;
using GisGmp.Income;
using GisGmp.Renouncement;
using GisGmp.Clarification;
using GisGmp.ExportCharges;

[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-chargestemplate/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-chargestemplate/2.4.0", IsNullable=false)]
public class ChargeCreationRequest : RequestType {
    public ChargeTemplateType ChargeTemplate { get; set; }

    [XmlAttribute]
    public string originatorId { get; set; }
}











[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-chargestemplate/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-chargestemplate/2.4.0", IsNullable=false)]
public class ChargeCreationResponse : ResponseType {
    public ChargeType Charge { get; set; }
}



[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
[XmlRoot("ImportChargesResponse", Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-charges/2.4.0", IsNullable=false)]
public class ImportPackageResponseType : ResponseType {
    [XmlElement("ImportProtocol")]
    public ImportProtocolType[] ImportProtocol { get; set; }
}



[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Common-nsi/2.4.0")]
[XmlRoot("directoryOKTMO", Namespace="urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/attachments/directoryOKTMO/2.4.0", IsNullable=false)]
public class directoryOKTMOType {
    [XmlElement("oktmoNSIInfo")]
    public oktmoNSIInfoType[] oktmoNSIInfo { get; set; }
}




[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Common-nsi/2.4.0")]
public class oktmoNSIInfoType {
    [XmlAttribute]
    public string regionCode { get; set; }

    [XmlAttribute]
    public string areaCode { get; set; }

    [XmlAttribute]
    public string cityCode { get; set; }

    [XmlAttribute]
    public string localCode { get; set; }

    [XmlAttribute]
    public string controlNum { get; set; }

    [XmlAttribute]
    public string section { get; set; }

    [XmlAttribute]
    public string code { get; set; }

    [XmlAttribute]
    public string name { get; set; }

    [XmlAttribute]
    public string centreName { get; set; }

    [XmlAttribute]
    public string clarification { get; set; }

    [XmlAttribute]
    public string lastChangeNum { get; set; }

    [XmlAttribute]
    public oktmoNSIInfoTypeLastChangeType lastChangeType { get; set; }

    [XmlAttribute(DataType = "date")]
    public DateTime changeDate { get; set; }

    [XmlAttribute(DataType = "date")]
    public DateTime introductionDate { get; set; }

    [XmlAttribute]
    public DateTime updateDate { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Common-nsi/2.4.0")]
public enum oktmoNSIInfoTypeLastChangeType {

    [XmlEnum("1")]
    Item1,

    [XmlEnum("2")]
    Item2,

    [XmlEnum("3")]
    Item3,

    [XmlEnum("0")]
    Item0,
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Common-nsi/2.4.0")]
[XmlRoot("directoryUBP", Namespace="urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/attachments/directoryUBP/2.4.0", IsNullable=false)]
public class directoryUBPType {
    [XmlElement("PayeeNSIInfo")]
    public PayeeNSIInfoType[] PayeeNSIInfo { get; set; }
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Common-nsi/2.4.0")]
public class PayeeNSIInfoType {
    [XmlArrayItem("kbk", IsNullable = false)]
    public string[] KBKlist { get; set; }

    [XmlArrayItem("OrgKS", IsNullable = false)]
    public PayeeNSIInfoTypeOrgKS[] OrgKSllist { get; set; }

    [XmlAttribute]
    public string name { get; set; }

    [XmlAttribute]
    public string inn { get; set; }

    [XmlAttribute]
    public string kpp { get; set; }

    [XmlAttribute]
    public string kbkGlavaCode { get; set; }

    [XmlAttribute]
    public PayeeNSIInfoTypeOrgStatus orgStatus { get; set; }

    [XmlAttribute]
    public DateTime updateDate { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Common-nsi/2.4.0")]
public class PayeeNSIInfoTypeOrgKS {
    [XmlAttribute]
    public string KSNumber { get; set; }

    [XmlAttribute]
    public string bik { get; set; }

    [XmlAttribute]
    public string bankAccountNumber { get; set; }

    [XmlAttribute]
    public PayeeNSIInfoTypeOrgKSStatKS statKS { get; set; }

    [XmlAttribute(DataType = "date")]
    public DateTime dateIn { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Common-nsi/2.4.0")]
public enum PayeeNSIInfoTypeOrgKSStatKS {

    KS1,

    KS2,

    KS3,
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Common-nsi/2.4.0")]
public enum PayeeNSIInfoTypeOrgStatus {

    [XmlEnum("1")]
    Item1,

    [XmlEnum("2")]
    Item2,

    [XmlEnum("3")]
    Item3,

    [XmlEnum("4")]
    Item4,
}




[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0")]
public class ExportNSIRequestNSIExportConditionsPayeeData {
    [XmlAttribute]
    public string inn { get; set; }

    [XmlAttribute]
    public string kpp { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0", IsNullable=false)]
public class ExportNSIResponse : ResponseType {
    [XmlElement("PayeeNSIInfo", typeof(PayeeNSIInfoType))]
    [XmlElement("oktmoNSIInfo", typeof(oktmoNSIInfoType))]
    public object Item { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0", IsNullable=false)]
public class ExportPaymentsRequest : ExportRequestType {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public PaymentsExportConditions PaymentsExportConditions { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
[XmlRoot(Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0", IsNullable=false)]
public class PaymentsExportConditions : Conditions {
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0", IsNullable=false)]
public class ExportPaymentsResponse : ResponseType {
    [XmlElement("PaymentInfo")]
    public ExportPaymentsResponsePaymentInfo[] PaymentInfo { get; set; }

    [XmlAttribute]
    public bool hasMore { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
public class ExportPaymentsResponsePaymentInfo : PaymentType {
    public ExportPaymentsResponsePaymentInfoAcknowledgmentInfo AcknowledgmentInfo { get; set; }

    [XmlElement("RefundInfo")]
    public ExportPaymentsResponsePaymentInfoRefundInfo[] RefundInfo { get; set; }

    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public ChangeStatusInfo ChangeStatusInfo { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
public class ExportPaymentsResponsePaymentInfoAcknowledgmentInfo {
    [XmlElement("ServiceProvidedInfo", typeof(ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfo))]
    [XmlElement("SupplierBillID", typeof(string))]
    public object Item { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
public class ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfo {
    public ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoAdditionalRepaymenInfo AdditionalRepaymenInfo { get; set; }

    [XmlAttribute]
    public ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoServiceProvided serviceProvided { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
public class ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoAdditionalRepaymenInfo {
    [XmlElement("ServiceData")]
    public ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoAdditionalRepaymenInfoServiceData[] ServiceData { get; set; }

    [XmlAttribute]
    public long residualAmount { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
public class ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoAdditionalRepaymenInfoServiceData : ServiceDataType {
    [XmlAttribute]
    public string serviceDataID { get; set; }
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public class ServiceDataType {
    public ServiceDataTypePersoneOfficial personeOfficial { get; set; }

    [XmlAttribute]
    public ulong amount { get; set; }

    [XmlAttribute]
    public string courtName { get; set; }

    [XmlAttribute]
    public string lawsuitInfo { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public class ServiceDataTypePersoneOfficial {
    [XmlAttribute]
    public string name { get; set; }

    [XmlAttribute]
    public string officialPosition { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
public enum ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoServiceProvided {

    [XmlEnum("1")]
    Item1,

    [XmlEnum("2")]
    Item2,
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
public class ExportPaymentsResponsePaymentInfoRefundInfo {
    [XmlAttribute]
    public string refundId { get; set; }

    [XmlAttribute]
    public ulong amount { get; set; }
}










[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.4.0", IsNullable=false)]
public class ImportCertificateRequest : RequestType {
    [XmlElement("RequestEntry")]
    public ImportCertificateEntryType[] RequestEntry { get; set; }
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public class ImportCertificateEntryType {
    [XmlAttribute(DataType = "IDREF")]
    public string Id { get; set; }

    [XmlAttribute]
    public string ownership { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.4.0", IsNullable=false)]
public class ImportCertificateResponse : ResponseType {
    [XmlElement("ImportProtocol")]
    public ImportProtocolType[] ImportProtocol { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-charges/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-charges/2.4.0", IsNullable=false)]
public class ImportChargesRequest : RequestType {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public ChargesPackage ChargesPackage { get; set; }
}






[Serializable]
[XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-incomes/2.4.0")]
[XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-incomes/2.4.0", IsNullable = false)]
public class ImportIncomesRequest : RequestType
{
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public IncomesPackage IncomesPackage { get; set; }
}





[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-payments/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-payments/2.4.0", IsNullable=false)]
public class ImportPaymentsRequest : RequestType {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public PaymentsPackage PaymentsPackage { get; set; }
}



[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-refunds/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-refunds/2.4.0", IsNullable=false)]
public class ImportRefundsRequest : RequestType {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public RefundsPackage RefundsPackage { get; set; }
}

