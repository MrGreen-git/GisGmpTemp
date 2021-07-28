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



//[Serializable]
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
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0", IsNullable=false)]
public class ExportChargesRequest : ExportRequestType {
    public EsiaUserInfoType EsiaUserInfo { get; set; }

    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public ChargesExportConditions ChargesExportConditions { get; set; }

    [XmlAttribute]
    public ExportChargesRequestExternal external { get; set; }

    [XmlIgnore]
    public bool externalSpecified { get; set; }
}























[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0")]
public enum ExportChargesRequestExternal {

    [XmlEnum("0")]
    Item0,

    [XmlEnum("1")]
    Item1,
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0", IsNullable=false)]
public class ExportChargesResponse : ResponseType {
    public ExportChargesResponse() {
        needReRequest = false;
    }

    [XmlElement("ChargeInfo", typeof(ExportChargesResponseChargeInfo))]
    [XmlElement("ChargeOffense", typeof(ExportChargesResponseChargeOffense))]
    public object[] Items { get; set; }

    [XmlAttribute]
    public bool hasMore { get; set; }

    [XmlAttribute]
    [System.ComponentModel.DefaultValue(false)]
    public bool needReRequest { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0")]
public class ExportChargesResponseChargeInfo : ChargeType {
    [XmlElement("ReconcileWithoutPayment")]
    public ExportChargesResponseChargeInfoReconcileWithoutPayment[] ReconcileWithoutPayment { get; set; }

    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public ChangeStatusInfo ChangeStatusInfo { get; set; }

    [XmlAttribute]
    public long amountToPay { get; set; }

    [XmlAttribute]
    public AcknowledgmentStatusType acknowledgmentStatus { get; set; }

    [XmlIgnore]
    public bool acknowledgmentStatusSpecified { get; set; }

    [XmlAttribute]
    public string requisiteCheckCode { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0")]
public class ExportChargesResponseChargeInfoReconcileWithoutPayment {
    [XmlAttribute]
    public string reconcileID { get; set; }

    [XmlAttribute]
    public ulong amountReconcile { get; set; }
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public enum AcknowledgmentStatusType {

    [XmlEnum("1")]
    Item1,

    [XmlEnum("2")]
    Item2,

    [XmlEnum("3")]
    Item3,

    [XmlEnum("4")]
    Item4,

    [XmlEnum("5")]
    Item5,

    [XmlEnum("6")]
    Item6,
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0")]
public class ExportChargesResponseChargeOffense {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.4.0")]
    public OffenseType AdditionalOffense { get; set; }

    [XmlAttribute]
    public string supplierBillID { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-incomes/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-incomes/2.4.0", IsNullable=false)]
public class ExportIncomesRequest : ExportRequestType {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public IncomesExportConditions IncomesExportConditions { get; set; }
}



[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-incomes/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-incomes/2.4.0", IsNullable=false)]
public class ExportIncomesResponse : ResponseType {
    [XmlElement("IncomeInfo")]
    public ExportIncomesResponseIncomeInfo[] IncomeInfo { get; set; }

    [XmlAttribute]
    public bool hasMore { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-incomes/2.4.0")]
public class ExportIncomesResponseIncomeInfo : IncomeType {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public ChangeStatusInfo ChangeStatusInfo { get; set; }
}








[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public class AccDocType {
    [XmlAttribute]
    public string accDocNo { get; set; }

    [XmlAttribute(DataType = "date")]
    public DateTime accDocDate { get; set; }
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public enum TransKindType {

    [XmlEnum("01")]
    Item01,

    [XmlEnum("06")]
    Item06,

    [XmlEnum("16")]
    Item16,
}











[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.4.0", IsNullable=false)]
public class ExportNoticeRequest {
    public ExportNoticeRequestDestination Destination { get; set; }

    [XmlElement("NoticeCharge", typeof(ExportNoticeRequestNoticeCharge))]
    [XmlElement("NoticeChargeExecutive", typeof(NoticeChargeExecutiveType))]
    [XmlElement("NoticePayment", typeof(ExportNoticeRequestNoticePayment))]
    [XmlElement("NoticeQuittance", typeof(ExportNoticeRequestNoticeQuittance))]
    [XmlElement("NoticeRenouncement", typeof(RenouncementType))]
    public object[] Items { get; set; }

    [XmlAttribute(DataType = "ID")]
    public string Id { get; set; }

    [XmlAttribute]
    public DateTime timestamp { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.4.0")]
public class ExportNoticeRequestDestination {
    public string RoutingCode { get; set; }

    [XmlAttribute]
    public string recipientIdentifier { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.4.0")]
public class ExportNoticeRequestNoticeCharge : NoticeChargeType {
}

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/NoticeCharge/2.4.0")]
public class NoticeChargeType {
    public OrganizationType Payee { get; set; }

    public NoticeChargeTypePayer Payer { get; set; }

    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public ChangeStatusInfo ChangeStatusInfo { get; set; }

    [XmlElement("DiscountFixed", typeof(ChargeTypeDiscountDiscountFixed), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    [XmlElement("DiscountSize", typeof(ChargeTypeDiscountDiscountSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    [XmlElement("MultiplierSize", typeof(ChargeTypeDiscountMultiplierSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public DiscountType Item { get; set; }

    public NoticeChargeTypeEventNotification EventNotification { get; set; }

    [XmlAttribute]
    public string supplierBillID { get; set; }

    [XmlAttribute]
    public DateTime billDate { get; set; }

    [XmlAttribute(DataType = "date")]
    public DateTime validUntil { get; set; }

    [XmlIgnore]
    public bool validUntilSpecified { get; set; }

    [XmlAttribute(DataType = "date")]
    public DateTime paymentTerm { get; set; }

    [XmlIgnore]
    public bool paymentTermSpecified { get; set; }

    [XmlAttribute]
    public ulong totalAmount { get; set; }

    [XmlAttribute]
    public string purpose { get; set; }

    [XmlAttribute]
    public string kbk { get; set; }

    [XmlAttribute]
    public string oktmo { get; set; }

    [XmlAttribute(DataType = "integer")]
    public string chargeOffense { get; set; }

    [XmlAttribute]
    public long amountToPay { get; set; }

    [XmlAttribute]
    public AcknowledgmentStatusType acknowledgmentStatus { get; set; }

    [XmlIgnore]
    public bool acknowledgmentStatusSpecified { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/NoticeCharge/2.4.0")]
public class NoticeChargeTypePayer : PayerType {
    [XmlAttribute]
    public string payerName { get; set; }

    [XmlAttribute]
    public string additionalPayerIdentifier { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/NoticeCharge/2.4.0")]
public enum NoticeChargeTypeEventNotification {

    [XmlEnum("1")]
    Item1,

    [XmlEnum("2")]
    Item2,

    [XmlEnum("3")]
    Item3,

    [XmlEnum("4")]
    Item4,

    [XmlEnum("5")]
    Item5,

    [XmlEnum("6")]
    Item6,
}

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/NoticeCharge/2.4.0")]
public class NoticeChargeExecutiveType {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
    public Payee Payee { get; set; }

    public NoticeChargeExecutiveTypePayer Payer { get; set; }

    public BudgetIndexType BudgetIndex { get; set; }

    public ExecutiveProcedureInfoType ExecutiveProcedureInfo { get; set; }

    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public ChangeStatusInfo ChangeStatusInfo { get; set; }

    [XmlElement("DiscountFixed", typeof(ChargeTypeDiscountDiscountFixed), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    [XmlElement("DiscountSize", typeof(ChargeTypeDiscountDiscountSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    [XmlElement("MultiplierSize", typeof(ChargeTypeDiscountMultiplierSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public DiscountType Item { get; set; }

    [XmlAttribute]
    public string supplierBillID { get; set; }

    [XmlAttribute]
    public DateTime billDate { get; set; }

    [XmlAttribute(DataType = "date")]
    public DateTime validUntil { get; set; }

    [XmlIgnore]
    public bool validUntilSpecified { get; set; }

    [XmlAttribute(DataType = "date")]
    public DateTime paymentTerm { get; set; }

    [XmlIgnore]
    public bool paymentTermSpecified { get; set; }

    [XmlAttribute]
    public ulong totalAmount { get; set; }

    [XmlAttribute]
    public string purpose { get; set; }

    [XmlAttribute]
    public string kbk { get; set; }

    [XmlAttribute]
    public string oktmo { get; set; }

    [XmlAttribute(DataType = "integer")]
    public string chargeOffense { get; set; }

    [XmlAttribute]
    public long amountToPay { get; set; }

    [XmlAttribute]
    public AcknowledgmentStatusType acknowledgmentStatus { get; set; }

    [XmlIgnore]
    public bool acknowledgmentStatusSpecified { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/NoticeCharge/2.4.0")]
public class NoticeChargeExecutiveTypePayer : PayerType {
    [XmlAttribute]
    public string payerName { get; set; }

    [XmlAttribute]
    public string additionalPayerIdentifier { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.4.0")]
public class ExportNoticeRequestNoticePayment : PaymentType {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public ChangeStatusInfo ChangeStatusInfo { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.4.0")]
public class ExportNoticeRequestNoticeQuittance : QuittanceType {
}

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Quittance/2.4.0")]
public class QuittanceType {
    [XmlElement("DiscountFixed", typeof(ChargeTypeDiscountDiscountFixed), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    [XmlElement("DiscountSize", typeof(ChargeTypeDiscountDiscountSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    [XmlElement("MultiplierSize", typeof(ChargeTypeDiscountMultiplierSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public DiscountType Item { get; set; }

    [XmlElement("Refund")]
    public QuittanceTypeRefund[] Refund { get; set; }

    [XmlAttribute]
    public string supplierBillID { get; set; }

    [XmlAttribute]
    public ulong totalAmount { get; set; }

    [XmlIgnore]
    public bool totalAmountSpecified { get; set; }

    [XmlAttribute]
    public DateTime creationDate { get; set; }

    [XmlAttribute]
    public AcknowledgmentStatusType billStatus { get; set; }

    [XmlAttribute]
    public long balance { get; set; }

    [XmlIgnore]
    public bool balanceSpecified { get; set; }

    [XmlAttribute]
    public string paymentId { get; set; }

    [XmlAttribute]
    public ulong amountPayment { get; set; }

    [XmlIgnore]
    public bool amountPaymentSpecified { get; set; }

    [XmlAttribute]
    public string payeeINN { get; set; }

    [XmlAttribute]
    public string payeeKPP { get; set; }

    [XmlAttribute]
    public string kbk { get; set; }

    [XmlAttribute]
    public string oktmo { get; set; }

    [XmlAttribute]
    public string payerIdentifier { get; set; }

    [XmlAttribute]
    public string accountNumber { get; set; }

    [XmlAttribute]
    public string bik { get; set; }

    [XmlAttribute]
    public bool isRevoked { get; set; }

    [XmlIgnore]
    public bool isRevokedSpecified { get; set; }

    [XmlAttribute]
    public bool paymentPortal { get; set; }

    [XmlIgnore]
    public bool paymentPortalSpecified { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Quittance/2.4.0")]
public class QuittanceTypeRefund {
    [XmlAttribute]
    public string refundId { get; set; }

    [XmlAttribute]
    public ulong amount { get; set; }
}











//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.4.0", IsNullable=false)]
public class ExportNoticeResponse : ResponseType {
    public string RoutingCode { get; set; }

    public bool ExportNoticeConfirmation { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.4.0", IsNullable=false)]
public class ExportNoticeNSIRequest {
    public ExportNoticeNSIRequestDestination Destination { get; set; }

    public ExportNoticeNSIRequestNoticeNSI NoticeNSI { get; set; }

    [XmlAttribute(DataType = "ID")]
    public string Id { get; set; }

    [XmlAttribute]
    public DateTime timestamp { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.4.0")]
public class ExportNoticeNSIRequestDestination {
    public string RoutingCode { get; set; }

    [XmlAttribute]
    public string recipientIdentifier { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.4.0")]
public class ExportNoticeNSIRequestNoticeNSI {
    [XmlElement("PayeeNSIInfo", typeof(PayeeNSIInfoType))]
    [XmlElement("oktmoNSIInfo", typeof(oktmoNSIInfoType))]
    public object[] Items { get; set; }

    [XmlAttribute]
    public string directoryCode { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.4.0", IsNullable=false)]
public class ExportNoticeNSIResponse : ResponseType {
    public string RoutingCode { get; set; }

    public bool ExportNoticeNSIConfirmation { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0", IsNullable=false)]
public class ExportNSIRequest : RequestType {
    public ExportNSIRequestNSIExportConditions NSIExportConditions { get; set; }

    [XmlAttribute]
    public string originatorId { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0")]
public class ExportNSIRequestNSIExportConditions {
    [XmlElement("PayeeData", typeof(ExportNSIRequestNSIExportConditionsPayeeData))]
    [XmlElement("oktmo", typeof(string))]
    public object Item { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0")]
public class ExportNSIRequestNSIExportConditionsPayeeData {
    [XmlAttribute]
    public string inn { get; set; }

    [XmlAttribute]
    public string kpp { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0", IsNullable=false)]
public class ExportNSIResponse : ResponseType {
    [XmlElement("PayeeNSIInfo", typeof(PayeeNSIInfoType))]
    [XmlElement("oktmoNSIInfo", typeof(oktmoNSIInfoType))]
    public object Item { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0", IsNullable=false)]
public class ExportPaymentsRequest : ExportRequestType {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public PaymentsExportConditions PaymentsExportConditions { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
[XmlRoot(Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0", IsNullable=false)]
public class PaymentsExportConditions : Conditions {
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0", IsNullable=false)]
public class ExportPaymentsResponse : ResponseType {
    [XmlElement("PaymentInfo")]
    public ExportPaymentsResponsePaymentInfo[] PaymentInfo { get; set; }

    [XmlAttribute]
    public bool hasMore { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
public class ExportPaymentsResponsePaymentInfo : PaymentType {
    public ExportPaymentsResponsePaymentInfoAcknowledgmentInfo AcknowledgmentInfo { get; set; }

    [XmlElement("RefundInfo")]
    public ExportPaymentsResponsePaymentInfoRefundInfo[] RefundInfo { get; set; }

    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public ChangeStatusInfo ChangeStatusInfo { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
public class ExportPaymentsResponsePaymentInfoAcknowledgmentInfo {
    [XmlElement("ServiceProvidedInfo", typeof(ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfo))]
    [XmlElement("SupplierBillID", typeof(string))]
    public object Item { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
public class ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfo {
    public ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoAdditionalRepaymenInfo AdditionalRepaymenInfo { get; set; }

    [XmlAttribute]
    public ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoServiceProvided serviceProvided { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
public class ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoAdditionalRepaymenInfo {
    [XmlElement("ServiceData")]
    public ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoAdditionalRepaymenInfoServiceData[] ServiceData { get; set; }

    [XmlAttribute]
    public long residualAmount { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
public class ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoAdditionalRepaymenInfoServiceData : ServiceDataType {
    [XmlAttribute]
    public string serviceDataID { get; set; }
}

//[Serializable]
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

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public class ServiceDataTypePersoneOfficial {
    [XmlAttribute]
    public string name { get; set; }

    [XmlAttribute]
    public string officialPosition { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
public enum ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoServiceProvided {

    [XmlEnum("1")]
    Item1,

    [XmlEnum("2")]
    Item2,
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
public class ExportPaymentsResponsePaymentInfoRefundInfo {
    [XmlAttribute]
    public string refundId { get; set; }

    [XmlAttribute]
    public ulong amount { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.4.0", IsNullable=false)]
public class ExportQuittancesRequest : ExportRequestType {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public QuittancesExportConditions QuittancesExportConditions { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
[XmlRoot(Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0", IsNullable=false)]
public class QuittancesExportConditions : Conditions {
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.4.0", IsNullable=false)]
public class ExportQuittancesResponse : ResponseType {
    [XmlElement("Quittance")]
    public QuittanceType[] Quittance { get; set; }

    [XmlElement("PossibleData")]
    public ExportQuittancesResponsePossibleData[] PossibleData { get; set; }

    [XmlAttribute]
    public bool hasMore { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.4.0")]
public class ExportQuittancesResponsePossibleData {
    [XmlElement("ComparisonResult")]
    public ExportQuittancesResponsePossibleDataComparisonResult[] ComparisonResult { get; set; }

    [XmlAttribute]
    public string supplierBillID { get; set; }

    [XmlAttribute]
    public ulong totalAmount { get; set; }

    [XmlIgnore]
    public bool totalAmountSpecified { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.4.0")]
public class ExportQuittancesResponsePossibleDataComparisonResult {
    [XmlAttribute]
    public string paymentId { get; set; }

    [XmlAttribute]
    public ulong comparisonWeight { get; set; }

    [XmlAttribute]
    public DateTime comparisonDate { get; set; }

    [XmlIgnore]
    public bool comparisonDateSpecified { get; set; }

    [XmlAttribute]
    public ulong amountPayment { get; set; }

    [XmlIgnore]
    public bool amountPaymentSpecified { get; set; }

    [XmlAttribute]
    public string kbk { get; set; }

    [XmlAttribute]
    public string oktmo { get; set; }

    [XmlAttribute]
    public string accountNumber { get; set; }

    [XmlAttribute]
    public string bik { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-refunds/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-refunds/2.4.0", IsNullable=false)]
public class ExportRefundsRequest : ExportRequestType {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public RefundsExportConditions RefundsExportConditions { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
[XmlRoot(Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0", IsNullable=false)]
public class RefundsExportConditions : Conditions {
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-refunds/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-refunds/2.4.0", IsNullable=false)]
public class ExportRefundsResponse : ResponseType {
    [XmlElement("Refund")]
    public ExportRefundsResponseRefund[] Refund { get; set; }

    [XmlAttribute]
    public bool hasMore { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-refunds/2.4.0")]
public class ExportRefundsResponseRefund : RefundType {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public ChangeStatusInfo ChangeStatusInfo { get; set; }
}

[XmlInclude(typeof(ImportedRefundType))]
//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Refund/2.4.0")]
public class RefundType {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
    public RefundPayer RefundPayer { get; set; }

    public RefundTypeRefundApplication RefundApplication { get; set; }

    public RefundTypeRefundBasis RefundBasis { get; set; }

    public RefundTypeRefundPayee RefundPayee { get; set; }

    [XmlElement("AdditionalData", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public AdditionalDataType[] AdditionalData { get; set; }

    [XmlAttribute]
    public string refundId { get; set; }

    [XmlAttribute]
    public DateTime refundDocDate { get; set; }

    [XmlAttribute]
    public RefundTypeBudgetLevel budgetLevel { get; set; }

    [XmlAttribute]
    public string kbk { get; set; }

    [XmlAttribute]
    public string oktmo { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
[XmlRoot(Namespace="http://roskazna.ru/gisgmp/xsd/Organization/2.4.0", IsNullable=false)]
public class RefundPayer : OrganizationType {
    [XmlAttribute]
    public string codeUBP { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Refund/2.4.0")]
public class RefundTypeRefundApplication {
    [XmlAttribute]
    public string appNum { get; set; }

    [XmlAttribute(DataType = "date")]
    public DateTime appDate { get; set; }

    [XmlAttribute]
    public string paymentId { get; set; }

    [XmlAttribute]
    public int cashType { get; set; }

    [XmlAttribute]
    public ulong amount { get; set; }

    [XmlAttribute]
    public string purpose { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Refund/2.4.0")]
public class RefundTypeRefundBasis {
    [XmlAttribute]
    public string docKind { get; set; }

    [XmlAttribute]
    public string docNumber { get; set; }

    [XmlAttribute(DataType = "date")]
    public DateTime docDate { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Refund/2.4.0")]
public class RefundTypeRefundPayee : PayeeType {
    public AccountType BankAccountNumber { get; set; }

    public string PayeeAccount { get; set; }

    [XmlAttribute]
    public string name { get; set; }

    [XmlAttribute]
    public string kbk { get; set; }

    [XmlAttribute]
    public string oktmo { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Refund/2.4.0")]
public enum RefundTypeBudgetLevel {

    [XmlEnum("1")]
    Item1,

    [XmlEnum("2")]
    Item2,

    [XmlEnum("3")]
    Item3,

    [XmlEnum("4")]
    Item4,

    [XmlEnum("5")]
    Item5,

    [XmlEnum("6")]
    Item6,
}

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
public class ImportedRefundType : RefundType {
    [XmlAttribute]
    public string originatorId { get; set; }

    [XmlAttribute(DataType = "ID")]
    public string Id { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-clarification/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-clarification/2.4.0", IsNullable=false)]
public class ExportClarificationsRequest : ExportRequestType {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public ClarificationsExportConditions ClarificationsExportConditions { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
[XmlRoot(Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0", IsNullable=false)]
public class ClarificationsExportConditions : Conditions {
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-clarification/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-clarification/2.4.0", IsNullable=false)]
public class ExportClarificationResponse : ResponseType {
    [XmlElement("ClarificationInfo")]
    public ExportClarificationResponseClarificationInfo[] ClarificationInfo { get; set; }

    [XmlAttribute]
    public bool hasMore { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-clarification/2.4.0")]
public class ExportClarificationResponseClarificationInfo : ClarificationType {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public ChangeStatusInfo ChangeStatusInfo { get; set; }
}

[XmlInclude(typeof(ImportedClarificationType))]

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
public class ClarificationType : AbstractClarificationType {
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

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
public class ClarificationApplicationType {
    public originalDetailType OriginalDetails { get; set; }

    public setDetailType SetDetails { get; set; }

    [XmlAttribute]
    public string ordinalNumber { get; set; }

    [XmlAttribute]
    public string applicationName { get; set; }

    [XmlAttribute]
    public ClarificationApplicationTypeAppCode appCode { get; set; }

    [XmlIgnore]
    public bool appCodeSpecified { get; set; }

    [XmlAttribute]
    public string appNum { get; set; }

    [XmlAttribute(DataType = "date")]
    public DateTime appDate { get; set; }

    [XmlIgnore]
    public bool appDateSpecified { get; set; }

    [XmlAttribute]
    public string incomeId { get; set; }

    [XmlAttribute]
    public string applicationNumber { get; set; }

    [XmlAttribute(DataType = "date")]
    public DateTime applicationDate { get; set; }

    [XmlIgnore]
    public bool applicationDateSpecified { get; set; }
}

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
public class originalDetailType : paymentDetailType {
    [XmlAttribute]
    public ulong amount { get; set; }
}

[XmlInclude(typeof(setDetailType))]
[XmlInclude(typeof(originalDetailType))]
//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
public class paymentDetailType {
    [XmlAttribute]
    public string payeeName { get; set; }

    [XmlAttribute]
    public string inn { get; set; }

    [XmlAttribute]
    public string kpp { get; set; }

    [XmlAttribute]
    public string payeeAccount { get; set; }

    [XmlAttribute]
    public string oktmo { get; set; }

    [XmlAttribute]
    public string kbk { get; set; }

    [XmlAttribute]
    public string subsidy { get; set; }

    [XmlAttribute]
    public string purpose { get; set; }

    [XmlAttribute]
    public string description { get; set; }
}

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
public class setDetailType : paymentDetailType {
    [XmlAttribute]
    public ulong amount { get; set; }

    [XmlIgnore]
    public bool amountSpecified { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
public enum ClarificationApplicationTypeAppCode {

    PP,

    PL,

    ZR,

    ZK,

    ZS,

    ZN,

    UF,

    ZV,
}

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
public class SignsClarificationType {
    public string HeadPost { get; set; }

    public string HeadName { get; set; }

    public string ExecutorPost { get; set; }

    public string ExecutorName { get; set; }

    public string ExecutorNum { get; set; }

    [XmlElement(DataType = "date")]
    public DateTime SignDate { get; set; }

    [XmlIgnore]
    public bool SignDateSpecified { get; set; }

    public string TOFKheadPost { get; set; }

    public string TOFKheadName { get; set; }

    public string TOFKexecutorPost { get; set; }

    public string TOFKexecutorName { get; set; }

    public string TOFKexecutorNum { get; set; }

    [XmlElement(DataType = "date")]
    public DateTime TOFKsignDate { get; set; }

    [XmlIgnore]
    public bool TOFKsignDateSpecified { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
public enum ClarificationTypeBudgetLevel {

    [XmlEnum("1")]
    Item1,

    [XmlEnum("2")]
    Item2,

    [XmlEnum("3")]
    Item3,

    [XmlEnum("4")]
    Item4,

    [XmlEnum("5")]
    Item5,

    [XmlEnum("6")]
    Item6,
}

[XmlInclude(typeof(ClarificationType))]
[XmlInclude(typeof(ImportedClarificationType))]
//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
public abstract class AbstractClarificationType {
}

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
public class ImportedClarificationType : ClarificationType {
    [XmlAttribute]
    public string originatorId { get; set; }

    [XmlAttribute(DataType = "ID")]
    public string Id { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0", IsNullable=false)]
public class ForcedAcknowledgementRequest : RequestType {
    [XmlElement("AnnulmentReconcile", typeof(ForcedAcknowledgementRequestAnnulmentReconcile))]
    [XmlElement("AnnulmentServiceProvided", typeof(ForcedAcknowledgementRequestAnnulmentServiceProvided))]
    [XmlElement("Reconcile", typeof(ForcedAcknowledgementRequestReconcile))]
    [XmlElement("ServiceProvided", typeof(ForcedAcknowledgementRequestServiceProvided))]
    public object Item { get; set; }

    [XmlAttribute]
    public string originatorId { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
public class ForcedAcknowledgementRequestAnnulmentReconcile {
    [XmlElement("PaymentId", typeof(string))]
    [XmlElement("PaymentNotLoaded", typeof(ForcedAcknowledgementRequestAnnulmentReconcilePaymentNotLoaded))]
    public object[] Items { get; set; }

    [XmlAttribute]
    public string supplierBillId { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
public class ForcedAcknowledgementRequestAnnulmentReconcilePaymentNotLoaded {
    [XmlAttribute]
    public string reconcileID { get; set; }

    [XmlText()]
    public bool Value { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
public class ForcedAcknowledgementRequestAnnulmentServiceProvided {
    [XmlElement("PaymentDataID")]
    public ForcedAcknowledgementRequestAnnulmentServiceProvidedPaymentDataID[] PaymentDataID { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
public class ForcedAcknowledgementRequestAnnulmentServiceProvidedPaymentDataID {
    [XmlAttribute]
    public string paymentId { get; set; }

    [XmlAttribute]
    public string serviceDataID { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
public class ForcedAcknowledgementRequestReconcile {
    [XmlElement("PaymentId", typeof(string))]
    [XmlElement("PaymentNotLoaded", typeof(ForcedAcknowledgementRequestReconcilePaymentNotLoaded))]
    public object[] Items { get; set; }

    [XmlAttribute]
    public string supplierBillId { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
public class ForcedAcknowledgementRequestReconcilePaymentNotLoaded {
    [XmlAttribute]
    public ulong amountReconcile { get; set; }

    [XmlIgnore]
    public bool amountReconcileSpecified { get; set; }

    [XmlText()]
    public bool Value { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
public class ForcedAcknowledgementRequestServiceProvided {
    [XmlElement("PaymentDataInfo")]
    public ForcedAcknowledgementRequestServiceProvidedPaymentDataInfo[] PaymentDataInfo { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
public class ForcedAcknowledgementRequestServiceProvidedPaymentDataInfo {
    public ServiceDataType ServiceData { get; set; }

    [XmlAttribute]
    public string paymentId { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0", IsNullable=false)]
public class ForcedAcknowledgementResponse : ResponseType {
    [XmlElement("Done", typeof(ForcedAcknowledgementResponseDone))]
    [XmlElement("Quittance", typeof(ForcedAcknowledgementResponseQuittance))]
    public object[] Items { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
public class ForcedAcknowledgementResponseDone {
    [XmlAttribute]
    public string serviceDataID { get; set; }

    [XmlText()]
    public bool Value { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
public class ForcedAcknowledgementResponseQuittance : QuittanceType {
    [XmlAttribute]
    public string reconcileID { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.4.0", IsNullable=false)]
public class ImportCertificateRequest : RequestType {
    [XmlElement("RequestEntry")]
    public ImportCertificateEntryType[] RequestEntry { get; set; }
}

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public class ImportCertificateEntryType {
    [XmlAttribute(DataType = "IDREF")]
    public string Id { get; set; }

    [XmlAttribute]
    public string ownership { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.4.0", IsNullable=false)]
public class ImportCertificateResponse : ResponseType {
    [XmlElement("ImportProtocol")]
    public ImportProtocolType[] ImportProtocol { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-charges/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-charges/2.4.0", IsNullable=false)]
public class ImportChargesRequest : RequestType {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public ChargesPackage ChargesPackage { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
[XmlRoot(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0", IsNullable=false)]
public class ChargesPackage : PackageType {
}

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
public class PackageType {
    [XmlElement("ImportedChange", typeof(ImportedChangeType))]
    [XmlElement("ImportedCharge", typeof(ImportedChargeType))]
    [XmlElement("ImportedClarification", typeof(ImportedClarificationType))]
    [XmlElement("ImportedIncome", typeof(ImportedIncomeType))]
    [XmlElement("ImportedPayment", typeof(ImportedPaymentType))]
    [XmlElement("ImportedRefund", typeof(ImportedRefundType))]
    [XmlElement("ImportedRenouncement", typeof(ImportedRenouncementType))]
    public object[] Items { get; set; }
}

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
public class ImportedChangeType {
    [XmlElement("ClarificationId", typeof(string))]
    [XmlElement("IncomeId", typeof(string))]
    [XmlElement("PaymentId", typeof(string))]
    [XmlElement("RefundId", typeof(string))]
    [XmlElement("RenouncementID", typeof(string))]
    [XmlElement("SupplierBillId", typeof(string))]
    [XmlChoiceIdentifier("ItemElementName")]
    public string Item { get; set; }

    [XmlIgnore]
    public ItemChoiceType1 ItemElementName { get; set; }

    [XmlElement("Change")]
    public ChangeType[] Change { get; set; }

    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public ChangeStatus ChangeStatus { get; set; }

    [XmlAttribute]
    public string originatorId { get; set; }

    [XmlAttribute(DataType = "ID")]
    public string Id { get; set; }
}

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0", IncludeInSchema=false)]
public enum ItemChoiceType1 {

    ClarificationId,

    IncomeId,

    PaymentId,

    RefundId,

    RenouncementID,

    SupplierBillId,
}

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
public class ChangeType {
    [XmlElement("ChangeValue")]
    public ChangeTypeChangeValue[] ChangeValue { get; set; }

    [XmlAttribute]
    public string fieldNum { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
public class ChangeTypeChangeValue {
    [XmlAttribute]
    public string name { get; set; }

    [XmlAttribute]
    public string value { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-incomes/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-incomes/2.4.0", IsNullable=false)]
public class ImportIncomesRequest : RequestType {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public IncomesPackage IncomesPackage { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
[XmlRoot(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0", IsNullable=false)]
public class IncomesPackage : PackageType {
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-payments/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-payments/2.4.0", IsNullable=false)]
public class ImportPaymentsRequest : RequestType {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public PaymentsPackage PaymentsPackage { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
[XmlRoot(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0", IsNullable=false)]
public class PaymentsPackage : PackageType {
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-refunds/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-refunds/2.4.0", IsNullable=false)]
public class ImportRefundsRequest : RequestType {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public RefundsPackage RefundsPackage { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
[XmlRoot(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0", IsNullable=false)]
public class RefundsPackage : PackageType {
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-Renouncement/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-Renouncement/2.4.0", IsNullable=false)]
public class ImportRenouncementRequest : RequestType {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public RenouncementPackage RenouncementPackage { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
[XmlRoot(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0", IsNullable=false)]
public class RenouncementPackage : PackageType {
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-clarification/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-clarification/2.4.0", IsNullable=false)]
public class ImportClarificationRequest : RequestType {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public ClarificationsPackage ClarificationsPackage { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
[XmlRoot(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0", IsNullable=false)]
public class ClarificationsPackage : PackageType {
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-paymentcheck/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-paymentcheck/2.4.0", IsNullable=false)]
public class PaymentCheckRequest : RequestType {
    public PaymentCheckRequestPaymentTemplate PaymentTemplate { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-paymentcheck/2.4.0")]
public class PaymentCheckRequestPaymentTemplate {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
    public Payee Payee { get; set; }

    [XmlAttribute]
    public string supplierBillID { get; set; }

    [XmlAttribute(DataType = "date")]
    public DateTime receiptDate { get; set; }

    [XmlIgnore]
    public bool receiptDateSpecified { get; set; }

    [XmlAttribute]
    public string kbk { get; set; }

    [XmlAttribute]
    public string oktmo { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-paymentcheck/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-paymentcheck/2.4.0", IsNullable=false)]
public class PaymentCheckResponse : ResponseType {
    public PaymentCheckResponseImportProtocol ImportProtocol { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-paymentcheck/2.4.0")]
public class PaymentCheckResponseImportProtocol : ImportProtocolType {
    [XmlAttribute]
    public string requisiteCheckCode { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0", IsNullable=false)]
public class SubscriptionServiceRequest : RequestType {
    [XmlElement("CreateSubscription", typeof(SubscriptionServiceRequestCreateSubscription))]
    [XmlElement("ExportSubscriptions", typeof(bool))]
    public object Item { get; set; }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0")]
public class SubscriptionServiceRequestCreateSubscription {
    
    private string itemField;
    
    private ItemChoiceType2 itemElementNameField;
    
    private SubscriptionParametersType[] subscriptionParametersField;
    
    private SubscriptionServiceRequestCreateSubscriptionSubscriptionStatus subscriptionStatusField;
    
    private string routingCodeField;

    [XmlElement("SubscriptionIdentifier", typeof(string), Namespace="http://roskazna.ru/gisgmp/xsd/Subscription/2.4.0")]
    [XmlElement("SubscriptionCode", typeof(string))]
    [XmlChoiceIdentifier("ItemElementName")]
    public string Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }

    [XmlIgnore]
    public ItemChoiceType2 ItemElementName {
        get {
            return this.itemElementNameField;
        }
        set {
            this.itemElementNameField = value;
        }
    }

    [XmlElement("SubscriptionParameters")]
    public SubscriptionParametersType[] SubscriptionParameters {
        get {
            return this.subscriptionParametersField;
        }
        set {
            this.subscriptionParametersField = value;
        }
    }

    [XmlAttribute]
    public SubscriptionServiceRequestCreateSubscriptionSubscriptionStatus subscriptionStatus {
        get {
            return this.subscriptionStatusField;
        }
        set {
            this.subscriptionStatusField = value;
        }
    }

    [XmlAttribute]
    public string routingCode {
        get {
            return this.routingCodeField;
        }
        set {
            this.routingCodeField = value;
        }
    }
}

//[Serializable]
[XmlType(Namespace="urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0", IncludeInSchema=false)]
public enum ItemChoiceType2 {

    [XmlEnum("http://roskazna.ru/gisgmp/xsd/Subscription/2.4.0:SubscriptionIdentifier")]
    SubscriptionIdentifier,

    SubscriptionCode,
}

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Subscription/2.4.0")]
public class SubscriptionParametersType {
    
    private SubscriptionParametersTypeParameterValue[] parameterValueField;
    
    private SubscriptionParametersTypeStatus statusField;
    
    private string parameterIdField;

    [XmlElement("ParameterValue")]
    public SubscriptionParametersTypeParameterValue[] ParameterValue {
        get {
            return this.parameterValueField;
        }
        set {
            this.parameterValueField = value;
        }
    }

    [XmlAttribute]
    public SubscriptionParametersTypeStatus status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }

    [XmlAttribute(DataType="ID")]
    public string parameterId {
        get {
            return this.parameterIdField;
        }
        set {
            this.parameterIdField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Subscription/2.4.0")]
public class SubscriptionParametersTypeParameterValue {
    
    private string parameterCodeField;
    
    private string valueField;

    [XmlAttribute]
    public string parameterCode {
        get {
            return this.parameterCodeField;
        }
        set {
            this.parameterCodeField = value;
        }
    }

    [XmlText()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Subscription/2.4.0")]
public enum SubscriptionParametersTypeStatus {

    [XmlEnum("1")]
    Item1,

    [XmlEnum("2")]
    Item2,
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0")]
public enum SubscriptionServiceRequestCreateSubscriptionSubscriptionStatus {

    [XmlEnum("1")]
    Item1,

    [XmlEnum("2")]
    Item2,

    [XmlEnum("3")]
    Item3,
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0", IsNullable=false)]
public class SubscriptionServiceResponse : ResponseType {
    
    private object[] itemsField;

    [XmlElement("CreateSubscriptionResult", typeof(SubscriptionServiceResponseCreateSubscriptionResult))]
    [XmlElement("Subscriptions", typeof(SubscriptionServiceResponseSubscriptions))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0")]
public class SubscriptionServiceResponseCreateSubscriptionResult {
    
    private SubscriptionProtocolType[] subscriptionProtocolField;
    
    private DateTime dispatchDateField;
    
    private bool dispatchDateFieldSpecified;
    
    private DateTime expiryDateField;
    
    private bool expiryDateFieldSpecified;
    
    private string subscriptionCodeField;
    
    private string subscriptionIdentifierField;

    [XmlElement("SubscriptionProtocol")]
    public SubscriptionProtocolType[] SubscriptionProtocol {
        get {
            return this.subscriptionProtocolField;
        }
        set {
            this.subscriptionProtocolField = value;
        }
    }

    [XmlAttribute]
    public DateTime dispatchDate {
        get {
            return this.dispatchDateField;
        }
        set {
            this.dispatchDateField = value;
        }
    }

    [XmlIgnore]
    public bool dispatchDateSpecified {
        get {
            return this.dispatchDateFieldSpecified;
        }
        set {
            this.dispatchDateFieldSpecified = value;
        }
    }

    [XmlAttribute(DataType="date")]
    public DateTime expiryDate {
        get {
            return this.expiryDateField;
        }
        set {
            this.expiryDateField = value;
        }
    }

    [XmlIgnore]
    public bool expiryDateSpecified {
        get {
            return this.expiryDateFieldSpecified;
        }
        set {
            this.expiryDateFieldSpecified = value;
        }
    }

    [XmlAttribute]
    public string subscriptionCode {
        get {
            return this.subscriptionCodeField;
        }
        set {
            this.subscriptionCodeField = value;
        }
    }

    [XmlAttribute]
    public string subscriptionIdentifier {
        get {
            return this.subscriptionIdentifierField;
        }
        set {
            this.subscriptionIdentifierField = value;
        }
    }
}

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Subscription/2.4.0")]
public class SubscriptionProtocolType {
    
    private string parameterIdField;
    
    private string codeField;
    
    private string descriptionField;

    [XmlAttribute(DataType="ID")]
    public string parameterId {
        get {
            return this.parameterIdField;
        }
        set {
            this.parameterIdField = value;
        }
    }

    [XmlAttribute]
    public string code {
        get {
            return this.codeField;
        }
        set {
            this.codeField = value;
        }
    }

    [XmlAttribute]
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0")]
public class SubscriptionServiceResponseSubscriptions {
    
    private SubscriptionServiceResponseSubscriptionsSubscriptionParameter[] subscriptionParameterField;
    
    private string subscriptionCodeField;
    
    private string subscriptionNameField;
    
    private string subscriptionOperationField;

    [XmlElement("SubscriptionParameter")]
    public SubscriptionServiceResponseSubscriptionsSubscriptionParameter[] SubscriptionParameter {
        get {
            return this.subscriptionParameterField;
        }
        set {
            this.subscriptionParameterField = value;
        }
    }

    [XmlAttribute]
    public string subscriptionCode {
        get {
            return this.subscriptionCodeField;
        }
        set {
            this.subscriptionCodeField = value;
        }
    }

    [XmlAttribute]
    public string subscriptionName {
        get {
            return this.subscriptionNameField;
        }
        set {
            this.subscriptionNameField = value;
        }
    }

    [XmlAttribute]
    public string subscriptionOperation {
        get {
            return this.subscriptionOperationField;
        }
        set {
            this.subscriptionOperationField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0")]
public class SubscriptionServiceResponseSubscriptionsSubscriptionParameter {
    
    private string parameterCodeField;
    
    private string parameterNameField;
    
    private string parameterPatternField;
    
    private bool requiredField;
    
    private string parameterDescriptionField;

    [XmlAttribute]
    public string parameterCode {
        get {
            return this.parameterCodeField;
        }
        set {
            this.parameterCodeField = value;
        }
    }

    [XmlAttribute]
    public string parameterName {
        get {
            return this.parameterNameField;
        }
        set {
            this.parameterNameField = value;
        }
    }

    [XmlAttribute]
    public string parameterPattern {
        get {
            return this.parameterPatternField;
        }
        set {
            this.parameterPatternField = value;
        }
    }

    [XmlAttribute]
    public bool required {
        get {
            return this.requiredField;
        }
        set {
            this.requiredField = value;
        }
    }

    [XmlAttribute]
    public string parameterDescription {
        get {
            return this.parameterDescriptionField;
        }
        set {
            this.parameterDescriptionField = value;
        }
    }
}
