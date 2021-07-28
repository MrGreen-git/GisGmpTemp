﻿using System;
using System.Xml.Serialization;
using GisGmp.Charge;
using GisGmp.Common;
using GisGmp.Refund;
using GisGmp.Payment;
using GisGmp.Organization;



//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-chargestemplate/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-chargestemplate/2.4.0", IsNullable=false)]
public class ChargeCreationRequest : RequestType {
    public ChargeTemplateType ChargeTemplate { get; set; }

    [XmlAttribute]
    public string originatorId { get; set; }
}









[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
[XmlRoot(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0", IsNullable=false)]
public class DeedInfo {
    [XmlAttribute]
    public DeedInfoIDType IDType { get; set; }

    [XmlAttribute]
    public string idDocNo { get; set; }

    [XmlAttribute(DataType = "date")]
    public DateTime idDocDate { get; set; }

    [XmlAttribute]
    public string subjCode { get; set; }

    [XmlAttribute]
    public string subjName { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public enum DeedInfoIDType {

    [XmlEnum("1")]
    Item1,

    [XmlEnum("3")]
    Item3,

    [XmlEnum("4")]
    Item4,

    [XmlEnum("5")]
    Item5,

    [XmlEnum("7")]
    Item7,

    [XmlEnum("10")]
    Item10,

    [XmlEnum("11")]
    Item11,

    [XmlEnum("13")]
    Item13,

    [XmlEnum("16")]
    Item16,
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public class ExecutiveProcedureInfoTypeExecutOrgan {
    [XmlAttribute]
    public string organOkogu { get; set; }

    [XmlAttribute]
    public string organCode { get; set; }

    [XmlAttribute]
    public string organ { get; set; }

    [XmlAttribute]
    public string organAdr { get; set; }

    [XmlAttribute]
    public string organSignCodePost { get; set; }

    [XmlAttribute]
    public string organSign { get; set; }

    [XmlAttribute]
    public string organSignFIO { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public class ExecutiveProcedureInfoTypeDebtor {
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

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public class ExecutiveProcedureInfoTypeDebtorPerson {
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

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public enum ExecutiveProcedureInfoTypeDebtorPersonDebtorGender {

    мужской,

    женский,
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public enum ExecutiveProcedureInfoTypeDebtorDebtorType {

    [XmlEnum("1")]
    Item1,

    [XmlEnum("2")]
    Item2,

    [XmlEnum("3")]
    Item3,

    [XmlEnum("1700")]
    Item1700,
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public enum ExecutiveProcedureInfoTypeSrokPrIspType {

    [XmlEnum("1")]
    Item1,

    [XmlEnum("2")]
    Item2,

    [XmlEnum("3")]
    Item3,
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
public class ImportedChargeType : ChargeType {
    [XmlAttribute]
    public string originatorId { get; set; }

    [XmlAttribute(DataType = "ID")]
    public string Id { get; set; }
}

[XmlInclude(typeof(ExportRequestType))]

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public class RequestType {
    [XmlAttribute(DataType = "ID")]
    public string Id { get; set; }

    [XmlAttribute]
    public DateTime timestamp { get; set; }

    [XmlAttribute]
    public string senderIdentifier { get; set; }

    [XmlAttribute]
    public string senderRole { get; set; }
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public class ExportRequestType : RequestType {
    public PagingType Paging { get; set; }

    [XmlAttribute]
    public string originatorId { get; set; }
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public class PagingType {
    [XmlAttribute(DataType = "nonNegativeInteger")]
    public string pageNumber { get; set; }

    [XmlAttribute(DataType = "nonNegativeInteger")]
    public string pageLength { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-chargestemplate/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-chargestemplate/2.4.0", IsNullable=false)]
public class ChargeCreationResponse : ResponseType {
    public ChargeType Charge { get; set; }
}

[XmlInclude(typeof(ImportPackageResponseType))]
[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public class ResponseType {
    [XmlAttribute(DataType = "ID")]
    public string Id { get; set; }

    [XmlAttribute]
    public string RqId { get; set; }

    [XmlAttribute]
    public string recipientIdentifier { get; set; }

    [XmlAttribute]
    public DateTime timestamp { get; set; }
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
[XmlRoot("ImportChargesResponse", Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-charges/2.4.0", IsNullable=false)]
public class ImportPackageResponseType : ResponseType {
    [XmlElement("ImportProtocol")]
    public ImportProtocolType[] ImportProtocol { get; set; }
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public class ImportProtocolType {
    [XmlAttribute(DataType = "ID")]
    public string entityID { get; set; }

    [XmlAttribute]
    public string code { get; set; }

    [XmlAttribute]
    public string description { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
[XmlRoot(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0", IsNullable=false)]
public class ChangeStatus : ChangeStatusType {
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public abstract class ChangeStatusType {
    public string Meaning { get; set; }

    public string Reason { get; set; }

    public DateTime ChangeDate { get; set; }

    [XmlIgnore]
    public bool ChangeDateSpecified { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
[XmlRoot(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0", IsNullable=false)]
public class ChangeStatusInfo : ChangeStatusType {
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
[XmlRoot("TimeInterval", Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0", IsNullable=false)]
public class TimeIntervalType {
    [XmlAttribute]
    public DateTime startDate { get; set; }

    [XmlAttribute]
    public DateTime endDate { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
[XmlRoot(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0", IsNullable=false)]
public class KBKlist {
    [XmlElement("KBK")]
    public string[] KBK { get; set; }
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
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public class EsiaUserInfoType {
    [XmlElement("IndividualBusiness", typeof(EsiaUserInfoTypeIndividualBusiness))]
    [XmlElement("Person", typeof(EsiaUserInfoTypePerson))]
    public object Item { get; set; }

    [XmlAttribute(DataType = "integer")]
    public string userId { get; set; }

    [XmlAttribute]
    public string sessionIndex { get; set; }

    [XmlAttribute]
    public DateTime sessionDate { get; set; }

    [XmlIgnore]
    public bool sessionDateSpecified { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public class EsiaUserInfoTypeIndividualBusiness {
    [XmlAttribute]
    public string personINN { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public class EsiaUserInfoTypePerson {
    public EsiaUserInfoTypePersonDocumentIdentity DocumentIdentity { get; set; }

    [XmlAttribute]
    public string snils { get; set; }

    [XmlAttribute]
    public string personINN { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public class EsiaUserInfoTypePersonDocumentIdentity {
    [XmlAttribute]
    public EsiaUserInfoTypePersonDocumentIdentityCode code { get; set; }

    [XmlAttribute]
    public string series { get; set; }

    [XmlAttribute]
    public string number { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public enum EsiaUserInfoTypePersonDocumentIdentityCode {

    [XmlEnum("1")]
    Item1,

    [XmlEnum("2")]
    Item2,
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
[XmlRoot(Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0", IsNullable=false)]
public class ChargesExportConditions : Conditions {
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
public abstract class Conditions {
    [XmlElement("ChargesConditions", typeof(ChargesConditionsType))]
    [XmlElement("ClarificationsConditions", typeof(ClarificationsConditionsType))]
    [XmlElement("IncomesConditions", typeof(IncomesConditionsType))]
    [XmlElement("PayersConditions", typeof(PayersConditionsType))]
    [XmlElement("PaymentsConditions", typeof(PaymentsConditionsType))]
    [XmlElement("RefundsConditions", typeof(RefundsConditionsType))]
    [XmlElement("TimeConditions", typeof(TimeConditionsType))]
    [XmlChoiceIdentifier("ItemElementName")]
    public object Item { get; set; }

    [XmlIgnore]
    public ItemChoiceType ItemElementName { get; set; }

    [XmlAttribute]
    public string kind { get; set; }
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
public class ChargesConditionsType {
    [XmlElement("SupplierBillID")]
    public string[] SupplierBillID { get; set; }

    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public TimeIntervalType TimeInterval { get; set; }

    public PaymentMethodType paymentMethod { get; set; }

    [XmlIgnore]
    public bool paymentMethodSpecified { get; set; }
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public enum PaymentMethodType {

    [XmlEnum("1")]
    Item1,
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
public class ClarificationsConditionsType {
    [XmlElement("ClarificationID")]
    public string[] ClarificationID { get; set; }
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
public class IncomesConditionsType {
    [XmlElement("IncomeId")]
    public string[] IncomeId { get; set; }
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
public class PayersConditionsType {
    [XmlElement("PayerIdentifier", typeof(string))]
    [XmlElement("PayerInn", typeof(string))]
    [XmlChoiceIdentifier("ItemsElementName")]
    public string[] Items { get; set; }

    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType[] ItemsElementName { get; set; }

    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public TimeIntervalType TimeInterval { get; set; }

    [XmlArray(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    [XmlArrayItem("KBK", IsNullable = false)]
    public string[] KBKlist { get; set; }

    [XmlElement("Beneficiary")]
    public PayersConditionsTypeBeneficiary[] Beneficiary { get; set; }
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0", IncludeInSchema=false)]
public enum ItemsChoiceType {

    PayerIdentifier,

    PayerInn,
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
public class PayersConditionsTypeBeneficiary {
    [XmlAttribute]
    public string inn { get; set; }

    [XmlAttribute]
    public string kpp { get; set; }
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
public class PaymentsConditionsType {
    [XmlElement("PaymentId")]
    public string[] PaymentId { get; set; }
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
public class RefundsConditionsType {
    [XmlElement("RefundId")]
    public string[] RefundId { get; set; }
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
public class TimeConditionsType {
    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public TimeIntervalType TimeInterval { get; set; }

    [XmlElement("Beneficiary")]
    public TimeConditionsTypeBeneficiary[] Beneficiary { get; set; }

    [XmlArray(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    [XmlArrayItem("KBK", IsNullable = false)]
    public string[] KBKlist { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
public class TimeConditionsTypeBeneficiary {
    [XmlAttribute]
    public string inn { get; set; }

    [XmlAttribute]
    public string kpp { get; set; }
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0", IncludeInSchema=false)]
public enum ItemChoiceType {

    ChargesConditions,

    ClarificationsConditions,

    IncomesConditions,

    PayersConditions,

    PaymentsConditions,

    RefundsConditions,

    TimeConditions,
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
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
[XmlRoot(Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0", IsNullable=false)]
public class IncomesExportConditions : Conditions {
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

[XmlInclude(typeof(ImportedIncomeType))]
[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Income/2.4.0")]
public class IncomeType : PaymentBaseType {
    public IncomeTypeIncomeIndex IncomeIndex { get; set; }

    [XmlAttribute]
    public string transactionID { get; set; }

    [XmlAttribute(DataType = "date")]
    public DateTime edDate { get; set; }

    [XmlAttribute]
    public string incomeId { get; set; }

    [XmlAttribute]
    public DateTime incomeDate { get; set; }

    [XmlAttribute]
    public IncomeTypeEdCode edCode { get; set; }

    [XmlAttribute]
    public string edNo { get; set; }

    [XmlAttribute(DataType = "date")]
    public DateTime chargeOffDate { get; set; }

    [XmlIgnore]
    public bool chargeOffDateSpecified { get; set; }

    [XmlAttribute]
    public bool isUncertain { get; set; }

    [XmlAttribute]
    public string paymentId { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Income/2.4.0")]
public class IncomeTypeIncomeIndex {
    [XmlAttribute]
    public string kbk { get; set; }

    [XmlAttribute]
    public string oktmo { get; set; }

    [XmlAttribute]
    public string inn { get; set; }

    [XmlAttribute]
    public string kpp { get; set; }

    [XmlAttribute]
    public string accountNumber { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Income/2.4.0")]
public enum IncomeTypeEdCode {

    ED101,

    ED104,

    ED105,

    ED108,

    ED701,
}

[XmlInclude(typeof(PaymentType))]
[XmlInclude(typeof(ImportedPaymentType))]
[XmlInclude(typeof(IncomeType))]
[XmlInclude(typeof(ImportedIncomeType))]
[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Payment/2.4.0")]
public class PaymentBaseType {
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

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
public class PaymentOrgType {
    [XmlElement("Bank", typeof(BankType))]
    [XmlElement("Other", typeof(PaymentOrgTypeOther))]
    [XmlElement("UFK", typeof(string))]
    public object Item { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
public enum PaymentOrgTypeOther {

    CASH,
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Payment/2.4.0")]
[XmlRoot("Payer", Namespace="http://roskazna.ru/gisgmp/xsd/Payment/2.4.0", IsNullable=false)]
public class Payer1 : PayerType {
    [XmlAttribute]
    public string payerName { get; set; }

    [XmlAttribute]
    public string payerAccount { get; set; }
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

[XmlInclude(typeof(ImportedPaymentType))]
[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Payment/2.4.0")]
public class PaymentType : PaymentBaseType {
    public PaymentTypePartialPayt PartialPayt { get; set; }

    [XmlAttribute]
    public string paymentId { get; set; }

    [XmlAttribute]
    public DateTime paymentDate { get; set; }

    [XmlAttribute(DataType = "date")]
    public DateTime deliveryDate { get; set; }

    [XmlIgnore]
    public bool deliveryDateSpecified { get; set; }

    [XmlAttribute]
    public string ESIA_ID { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Payment/2.4.0")]
public class PaymentTypePartialPayt {
    public AccDocType AccDoc { get; set; }

    [XmlAttribute]
    public TransKindType transKind { get; set; }

    [XmlAttribute]
    public string paytNo { get; set; }

    [XmlAttribute]
    public string transContent { get; set; }

    [XmlAttribute(DataType = "integer")]
    public string sumResidualPayt { get; set; }
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
public class ImportedPaymentType : PaymentType {
    [XmlAttribute]
    public string originatorId { get; set; }

    [XmlAttribute(DataType = "ID")]
    public string Id { get; set; }

    [XmlAttribute]
    public ImportedPaymentTypePaymentMethod paymentMethod { get; set; }

    [XmlIgnore]
    public bool paymentMethodSpecified { get; set; }

    [XmlAttribute]
    public string requisiteCheckCode { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
public enum ImportedPaymentTypePaymentMethod {

    [XmlEnum("1")]
    Item1,
}

[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
public class ImportedIncomeType : IncomeType {
    [XmlAttribute]
    public string originatorId { get; set; }

    [XmlAttribute(DataType = "ID")]
    public string Id { get; set; }
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
    private NoticeChargeTypeEventNotification eventNotificationField;
    
    private string supplierBillIDField;
    
    private DateTime billDateField;
    
    private DateTime validUntilField;
    
    private bool validUntilFieldSpecified;
    
    private DateTime paymentTermField;
    
    private bool paymentTermFieldSpecified;
    
    private ulong totalAmountField;
    
    private string purposeField;
    
    private string kbkField;
    
    private string oktmoField;
    
    private string chargeOffenseField;
    
    private long amountToPayField;
    
    private AcknowledgmentStatusType acknowledgmentStatusField;
    
    private bool acknowledgmentStatusFieldSpecified;

    public OrganizationType Payee { get; set; }

    public NoticeChargeTypePayer Payer { get; set; }

    [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public ChangeStatusInfo ChangeStatusInfo { get; set; }

    [XmlElement("DiscountFixed", typeof(ChargeTypeDiscountDiscountFixed), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    [XmlElement("DiscountSize", typeof(ChargeTypeDiscountDiscountSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    [XmlElement("MultiplierSize", typeof(ChargeTypeDiscountMultiplierSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public DiscountType Item { get; set; }

    public NoticeChargeTypeEventNotification EventNotification {
        get {
            return this.eventNotificationField;
        }
        set {
            this.eventNotificationField = value;
        }
    }

    [XmlAttribute]
    public string supplierBillID {
        get {
            return this.supplierBillIDField;
        }
        set {
            this.supplierBillIDField = value;
        }
    }

    [XmlAttribute]
    public DateTime billDate {
        get {
            return this.billDateField;
        }
        set {
            this.billDateField = value;
        }
    }

    [XmlAttribute(DataType="date")]
    public DateTime validUntil {
        get {
            return this.validUntilField;
        }
        set {
            this.validUntilField = value;
        }
    }

    [XmlIgnore]
    public bool validUntilSpecified {
        get {
            return this.validUntilFieldSpecified;
        }
        set {
            this.validUntilFieldSpecified = value;
        }
    }

    [XmlAttribute(DataType="date")]
    public DateTime paymentTerm {
        get {
            return this.paymentTermField;
        }
        set {
            this.paymentTermField = value;
        }
    }

    [XmlIgnore]
    public bool paymentTermSpecified {
        get {
            return this.paymentTermFieldSpecified;
        }
        set {
            this.paymentTermFieldSpecified = value;
        }
    }

    [XmlAttribute]
    public ulong totalAmount {
        get {
            return this.totalAmountField;
        }
        set {
            this.totalAmountField = value;
        }
    }

    [XmlAttribute]
    public string purpose {
        get {
            return this.purposeField;
        }
        set {
            this.purposeField = value;
        }
    }

    [XmlAttribute]
    public string kbk {
        get {
            return this.kbkField;
        }
        set {
            this.kbkField = value;
        }
    }

    [XmlAttribute]
    public string oktmo {
        get {
            return this.oktmoField;
        }
        set {
            this.oktmoField = value;
        }
    }

    [XmlAttribute(DataType="integer")]
    public string chargeOffense {
        get {
            return this.chargeOffenseField;
        }
        set {
            this.chargeOffenseField = value;
        }
    }

    [XmlAttribute]
    public long amountToPay {
        get {
            return this.amountToPayField;
        }
        set {
            this.amountToPayField = value;
        }
    }

    [XmlAttribute]
    public AcknowledgmentStatusType acknowledgmentStatus {
        get {
            return this.acknowledgmentStatusField;
        }
        set {
            this.acknowledgmentStatusField = value;
        }
    }

    [XmlIgnore]
    public bool acknowledgmentStatusSpecified {
        get {
            return this.acknowledgmentStatusFieldSpecified;
        }
        set {
            this.acknowledgmentStatusFieldSpecified = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/NoticeCharge/2.4.0")]
public class NoticeChargeTypePayer : PayerType {
    
    private string payerNameField;
    
    private string additionalPayerIdentifierField;

    [XmlAttribute]
    public string payerName {
        get {
            return this.payerNameField;
        }
        set {
            this.payerNameField = value;
        }
    }

    [XmlAttribute]
    public string additionalPayerIdentifier {
        get {
            return this.additionalPayerIdentifierField;
        }
        set {
            this.additionalPayerIdentifierField = value;
        }
    }
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
    
    private Payee payeeField;
    
    private NoticeChargeExecutiveTypePayer payerField;
    
    private BudgetIndexType budgetIndexField;
    
    private ExecutiveProcedureInfoType executiveProcedureInfoField;
    
    private ChangeStatusInfo changeStatusInfoField;
    
    private DiscountType itemField;
    
    private string supplierBillIDField;
    
    private DateTime billDateField;
    
    private DateTime validUntilField;
    
    private bool validUntilFieldSpecified;
    
    private DateTime paymentTermField;
    
    private bool paymentTermFieldSpecified;
    
    private ulong totalAmountField;
    
    private string purposeField;
    
    private string kbkField;
    
    private string oktmoField;
    
    private string chargeOffenseField;
    
    private long amountToPayField;
    
    private AcknowledgmentStatusType acknowledgmentStatusField;
    
    private bool acknowledgmentStatusFieldSpecified;

    [XmlElement(Namespace="http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
    public Payee Payee {
        get {
            return this.payeeField;
        }
        set {
            this.payeeField = value;
        }
    }

    public NoticeChargeExecutiveTypePayer Payer {
        get {
            return this.payerField;
        }
        set {
            this.payerField = value;
        }
    }

    public BudgetIndexType BudgetIndex {
        get {
            return this.budgetIndexField;
        }
        set {
            this.budgetIndexField = value;
        }
    }

    public ExecutiveProcedureInfoType ExecutiveProcedureInfo {
        get {
            return this.executiveProcedureInfoField;
        }
        set {
            this.executiveProcedureInfoField = value;
        }
    }

    [XmlElement(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public ChangeStatusInfo ChangeStatusInfo {
        get {
            return this.changeStatusInfoField;
        }
        set {
            this.changeStatusInfoField = value;
        }
    }

    [XmlElement("DiscountFixed", typeof(ChargeTypeDiscountDiscountFixed), Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    [XmlElement("DiscountSize", typeof(ChargeTypeDiscountDiscountSize), Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    [XmlElement("MultiplierSize", typeof(ChargeTypeDiscountMultiplierSize), Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public DiscountType Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }

    [XmlAttribute]
    public string supplierBillID {
        get {
            return this.supplierBillIDField;
        }
        set {
            this.supplierBillIDField = value;
        }
    }

    [XmlAttribute]
    public DateTime billDate {
        get {
            return this.billDateField;
        }
        set {
            this.billDateField = value;
        }
    }

    [XmlAttribute(DataType="date")]
    public DateTime validUntil {
        get {
            return this.validUntilField;
        }
        set {
            this.validUntilField = value;
        }
    }

    [XmlIgnore]
    public bool validUntilSpecified {
        get {
            return this.validUntilFieldSpecified;
        }
        set {
            this.validUntilFieldSpecified = value;
        }
    }

    [XmlAttribute(DataType="date")]
    public DateTime paymentTerm {
        get {
            return this.paymentTermField;
        }
        set {
            this.paymentTermField = value;
        }
    }

    [XmlIgnore]
    public bool paymentTermSpecified {
        get {
            return this.paymentTermFieldSpecified;
        }
        set {
            this.paymentTermFieldSpecified = value;
        }
    }

    [XmlAttribute]
    public ulong totalAmount {
        get {
            return this.totalAmountField;
        }
        set {
            this.totalAmountField = value;
        }
    }

    [XmlAttribute]
    public string purpose {
        get {
            return this.purposeField;
        }
        set {
            this.purposeField = value;
        }
    }

    [XmlAttribute]
    public string kbk {
        get {
            return this.kbkField;
        }
        set {
            this.kbkField = value;
        }
    }

    [XmlAttribute]
    public string oktmo {
        get {
            return this.oktmoField;
        }
        set {
            this.oktmoField = value;
        }
    }

    [XmlAttribute(DataType="integer")]
    public string chargeOffense {
        get {
            return this.chargeOffenseField;
        }
        set {
            this.chargeOffenseField = value;
        }
    }

    [XmlAttribute]
    public long amountToPay {
        get {
            return this.amountToPayField;
        }
        set {
            this.amountToPayField = value;
        }
    }

    [XmlAttribute]
    public AcknowledgmentStatusType acknowledgmentStatus {
        get {
            return this.acknowledgmentStatusField;
        }
        set {
            this.acknowledgmentStatusField = value;
        }
    }

    [XmlIgnore]
    public bool acknowledgmentStatusSpecified {
        get {
            return this.acknowledgmentStatusFieldSpecified;
        }
        set {
            this.acknowledgmentStatusFieldSpecified = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/NoticeCharge/2.4.0")]
public class NoticeChargeExecutiveTypePayer : PayerType {
    
    private string payerNameField;
    
    private string additionalPayerIdentifierField;

    [XmlAttribute]
    public string payerName {
        get {
            return this.payerNameField;
        }
        set {
            this.payerNameField = value;
        }
    }

    [XmlAttribute]
    public string additionalPayerIdentifier {
        get {
            return this.additionalPayerIdentifierField;
        }
        set {
            this.additionalPayerIdentifierField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.4.0")]
public class ExportNoticeRequestNoticePayment : PaymentType {
    
    private ChangeStatusInfo changeStatusInfoField;

    [XmlElement(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public ChangeStatusInfo ChangeStatusInfo {
        get {
            return this.changeStatusInfoField;
        }
        set {
            this.changeStatusInfoField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.4.0")]
public class ExportNoticeRequestNoticeQuittance : QuittanceType {
}

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Quittance/2.4.0")]
public class QuittanceType {
    
    private DiscountType itemField;
    
    private QuittanceTypeRefund[] refundField;
    
    private string supplierBillIDField;
    
    private ulong totalAmountField;
    
    private bool totalAmountFieldSpecified;
    
    private DateTime creationDateField;
    
    private AcknowledgmentStatusType billStatusField;
    
    private long balanceField;
    
    private bool balanceFieldSpecified;
    
    private string paymentIdField;
    
    private ulong amountPaymentField;
    
    private bool amountPaymentFieldSpecified;
    
    private string payeeINNField;
    
    private string payeeKPPField;
    
    private string kbkField;
    
    private string oktmoField;
    
    private string payerIdentifierField;
    
    private string accountNumberField;
    
    private string bikField;
    
    private bool isRevokedField;
    
    private bool isRevokedFieldSpecified;
    
    private bool paymentPortalField;
    
    private bool paymentPortalFieldSpecified;

    [XmlElement("DiscountFixed", typeof(ChargeTypeDiscountDiscountFixed), Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    [XmlElement("DiscountSize", typeof(ChargeTypeDiscountDiscountSize), Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    [XmlElement("MultiplierSize", typeof(ChargeTypeDiscountMultiplierSize), Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public DiscountType Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }

    [XmlElement("Refund")]
    public QuittanceTypeRefund[] Refund {
        get {
            return this.refundField;
        }
        set {
            this.refundField = value;
        }
    }

    [XmlAttribute]
    public string supplierBillID {
        get {
            return this.supplierBillIDField;
        }
        set {
            this.supplierBillIDField = value;
        }
    }

    [XmlAttribute]
    public ulong totalAmount {
        get {
            return this.totalAmountField;
        }
        set {
            this.totalAmountField = value;
        }
    }

    [XmlIgnore]
    public bool totalAmountSpecified {
        get {
            return this.totalAmountFieldSpecified;
        }
        set {
            this.totalAmountFieldSpecified = value;
        }
    }

    [XmlAttribute]
    public DateTime creationDate {
        get {
            return this.creationDateField;
        }
        set {
            this.creationDateField = value;
        }
    }

    [XmlAttribute]
    public AcknowledgmentStatusType billStatus {
        get {
            return this.billStatusField;
        }
        set {
            this.billStatusField = value;
        }
    }

    [XmlAttribute]
    public long balance {
        get {
            return this.balanceField;
        }
        set {
            this.balanceField = value;
        }
    }

    [XmlIgnore]
    public bool balanceSpecified {
        get {
            return this.balanceFieldSpecified;
        }
        set {
            this.balanceFieldSpecified = value;
        }
    }

    [XmlAttribute]
    public string paymentId {
        get {
            return this.paymentIdField;
        }
        set {
            this.paymentIdField = value;
        }
    }

    [XmlAttribute]
    public ulong amountPayment {
        get {
            return this.amountPaymentField;
        }
        set {
            this.amountPaymentField = value;
        }
    }

    [XmlIgnore]
    public bool amountPaymentSpecified {
        get {
            return this.amountPaymentFieldSpecified;
        }
        set {
            this.amountPaymentFieldSpecified = value;
        }
    }

    [XmlAttribute]
    public string payeeINN {
        get {
            return this.payeeINNField;
        }
        set {
            this.payeeINNField = value;
        }
    }

    [XmlAttribute]
    public string payeeKPP {
        get {
            return this.payeeKPPField;
        }
        set {
            this.payeeKPPField = value;
        }
    }

    [XmlAttribute]
    public string kbk {
        get {
            return this.kbkField;
        }
        set {
            this.kbkField = value;
        }
    }

    [XmlAttribute]
    public string oktmo {
        get {
            return this.oktmoField;
        }
        set {
            this.oktmoField = value;
        }
    }

    [XmlAttribute]
    public string payerIdentifier {
        get {
            return this.payerIdentifierField;
        }
        set {
            this.payerIdentifierField = value;
        }
    }

    [XmlAttribute]
    public string accountNumber {
        get {
            return this.accountNumberField;
        }
        set {
            this.accountNumberField = value;
        }
    }

    [XmlAttribute]
    public string bik {
        get {
            return this.bikField;
        }
        set {
            this.bikField = value;
        }
    }

    [XmlAttribute]
    public bool isRevoked {
        get {
            return this.isRevokedField;
        }
        set {
            this.isRevokedField = value;
        }
    }

    [XmlIgnore]
    public bool isRevokedSpecified {
        get {
            return this.isRevokedFieldSpecified;
        }
        set {
            this.isRevokedFieldSpecified = value;
        }
    }

    [XmlAttribute]
    public bool paymentPortal {
        get {
            return this.paymentPortalField;
        }
        set {
            this.paymentPortalField = value;
        }
    }

    [XmlIgnore]
    public bool paymentPortalSpecified {
        get {
            return this.paymentPortalFieldSpecified;
        }
        set {
            this.paymentPortalFieldSpecified = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Quittance/2.4.0")]
public class QuittanceTypeRefund {
    
    private string refundIdField;
    
    private ulong amountField;

    [XmlAttribute]
    public string refundId {
        get {
            return this.refundIdField;
        }
        set {
            this.refundIdField = value;
        }
    }

    [XmlAttribute]
    public ulong amount {
        get {
            return this.amountField;
        }
        set {
            this.amountField = value;
        }
    }
}

[XmlInclude(typeof(ImportedRenouncementType))]

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Renouncement/2.4.0")]
public class RenouncementType {
    
    private RenouncementTypeApprover approverField;
    
    private RenouncementTypeExecutor executorField;
    
    private DeedInfo deedInfoField;
    
    private string supplierBillIDField;
    
    private string renouncementIDField;
    
    private DateTime rulingDateField;
    
    private string rulingNumField;
    
    private string refusalGroundField;
    
    private RenouncementTypeReasonCode reasonCodeField;

    public RenouncementTypeApprover Approver {
        get {
            return this.approverField;
        }
        set {
            this.approverField = value;
        }
    }

    public RenouncementTypeExecutor Executor {
        get {
            return this.executorField;
        }
        set {
            this.executorField = value;
        }
    }

    [XmlElement(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public DeedInfo DeedInfo {
        get {
            return this.deedInfoField;
        }
        set {
            this.deedInfoField = value;
        }
    }

    [XmlAttribute]
    public string supplierBillID {
        get {
            return this.supplierBillIDField;
        }
        set {
            this.supplierBillIDField = value;
        }
    }

    [XmlAttribute]
    public string renouncementID {
        get {
            return this.renouncementIDField;
        }
        set {
            this.renouncementIDField = value;
        }
    }

    [XmlAttribute(DataType="date")]
    public DateTime rulingDate {
        get {
            return this.rulingDateField;
        }
        set {
            this.rulingDateField = value;
        }
    }

    [XmlAttribute]
    public string rulingNum {
        get {
            return this.rulingNumField;
        }
        set {
            this.rulingNumField = value;
        }
    }

    [XmlAttribute]
    public string refusalGround {
        get {
            return this.refusalGroundField;
        }
        set {
            this.refusalGroundField = value;
        }
    }

    [XmlAttribute]
    public RenouncementTypeReasonCode reasonCode {
        get {
            return this.reasonCodeField;
        }
        set {
            this.reasonCodeField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Renouncement/2.4.0")]
public class RenouncementTypeApprover {
    
    private string positionCodeField;
    
    private string positionNameField;
    
    private string personApprovingField;
    
    private DateTime approvalDateField;

    [XmlAttribute]
    public string positionCode {
        get {
            return this.positionCodeField;
        }
        set {
            this.positionCodeField = value;
        }
    }

    [XmlAttribute]
    public string positionName {
        get {
            return this.positionNameField;
        }
        set {
            this.positionNameField = value;
        }
    }

    [XmlAttribute]
    public string personApproving {
        get {
            return this.personApprovingField;
        }
        set {
            this.personApprovingField = value;
        }
    }

    [XmlAttribute(DataType="date")]
    public DateTime approvalDate {
        get {
            return this.approvalDateField;
        }
        set {
            this.approvalDateField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Renouncement/2.4.0")]
public class RenouncementTypeExecutor {
    
    private string vKSPCodeField;
    
    private string structuralUnitNameField;
    
    private string structuralUnitAddressField;
    
    private string structuralLocalityField;
    
    private string executorFullNameField;

    [XmlAttribute]
    public string VKSPCode {
        get {
            return this.vKSPCodeField;
        }
        set {
            this.vKSPCodeField = value;
        }
    }

    [XmlAttribute]
    public string structuralUnitName {
        get {
            return this.structuralUnitNameField;
        }
        set {
            this.structuralUnitNameField = value;
        }
    }

    [XmlAttribute]
    public string structuralUnitAddress {
        get {
            return this.structuralUnitAddressField;
        }
        set {
            this.structuralUnitAddressField = value;
        }
    }

    [XmlAttribute]
    public string structuralLocality {
        get {
            return this.structuralLocalityField;
        }
        set {
            this.structuralLocalityField = value;
        }
    }

    [XmlAttribute]
    public string executorFullName {
        get {
            return this.executorFullNameField;
        }
        set {
            this.executorFullNameField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Renouncement/2.4.0")]
public enum RenouncementTypeReasonCode {

    [XmlEnum("3")]
    Item3,

    [XmlEnum("4")]
    Item4,

    [XmlEnum("7")]
    Item7,

    [XmlEnum("8")]
    Item8,
}

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
public class ImportedRenouncementType : RenouncementType {
    
    private string originatorIdField;
    
    private string idField;

    [XmlAttribute]
    public string originatorId {
        get {
            return this.originatorIdField;
        }
        set {
            this.originatorIdField = value;
        }
    }

    [XmlAttribute(DataType="ID")]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.4.0", IsNullable=false)]
public class ExportNoticeResponse : ResponseType {
    
    private string routingCodeField;
    
    private bool exportNoticeConfirmationField;

    public string RoutingCode {
        get {
            return this.routingCodeField;
        }
        set {
            this.routingCodeField = value;
        }
    }

    public bool ExportNoticeConfirmation {
        get {
            return this.exportNoticeConfirmationField;
        }
        set {
            this.exportNoticeConfirmationField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.4.0", IsNullable=false)]
public class ExportNoticeNSIRequest {
    
    private ExportNoticeNSIRequestDestination destinationField;
    
    private ExportNoticeNSIRequestNoticeNSI noticeNSIField;
    
    private string idField;
    
    private DateTime timestampField;

    public ExportNoticeNSIRequestDestination Destination {
        get {
            return this.destinationField;
        }
        set {
            this.destinationField = value;
        }
    }

    public ExportNoticeNSIRequestNoticeNSI NoticeNSI {
        get {
            return this.noticeNSIField;
        }
        set {
            this.noticeNSIField = value;
        }
    }

    [XmlAttribute(DataType="ID")]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }

    [XmlAttribute]
    public DateTime timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.4.0")]
public class ExportNoticeNSIRequestDestination {
    
    private string routingCodeField;
    
    private string recipientIdentifierField;

    public string RoutingCode {
        get {
            return this.routingCodeField;
        }
        set {
            this.routingCodeField = value;
        }
    }

    [XmlAttribute]
    public string recipientIdentifier {
        get {
            return this.recipientIdentifierField;
        }
        set {
            this.recipientIdentifierField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.4.0")]
public class ExportNoticeNSIRequestNoticeNSI {
    
    private object[] itemsField;
    
    private string directoryCodeField;

    [XmlElement("PayeeNSIInfo", typeof(PayeeNSIInfoType))]
    [XmlElement("oktmoNSIInfo", typeof(oktmoNSIInfoType))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }

    [XmlAttribute]
    public string directoryCode {
        get {
            return this.directoryCodeField;
        }
        set {
            this.directoryCodeField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.4.0", IsNullable=false)]
public class ExportNoticeNSIResponse : ResponseType {
    
    private string routingCodeField;
    
    private bool exportNoticeNSIConfirmationField;

    public string RoutingCode {
        get {
            return this.routingCodeField;
        }
        set {
            this.routingCodeField = value;
        }
    }

    public bool ExportNoticeNSIConfirmation {
        get {
            return this.exportNoticeNSIConfirmationField;
        }
        set {
            this.exportNoticeNSIConfirmationField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0", IsNullable=false)]
public class ExportNSIRequest : RequestType {
    
    private ExportNSIRequestNSIExportConditions nSIExportConditionsField;
    
    private string originatorIdField;

    public ExportNSIRequestNSIExportConditions NSIExportConditions {
        get {
            return this.nSIExportConditionsField;
        }
        set {
            this.nSIExportConditionsField = value;
        }
    }

    [XmlAttribute]
    public string originatorId {
        get {
            return this.originatorIdField;
        }
        set {
            this.originatorIdField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0")]
public class ExportNSIRequestNSIExportConditions {
    
    private object itemField;

    [XmlElement("PayeeData", typeof(ExportNSIRequestNSIExportConditionsPayeeData))]
    [XmlElement("oktmo", typeof(string))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0")]
public class ExportNSIRequestNSIExportConditionsPayeeData {
    
    private string innField;
    
    private string kppField;

    [XmlAttribute]
    public string inn {
        get {
            return this.innField;
        }
        set {
            this.innField = value;
        }
    }

    [XmlAttribute]
    public string kpp {
        get {
            return this.kppField;
        }
        set {
            this.kppField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0", IsNullable=false)]
public class ExportNSIResponse : ResponseType {
    
    private object itemField;

    [XmlElement("PayeeNSIInfo", typeof(PayeeNSIInfoType))]
    [XmlElement("oktmoNSIInfo", typeof(oktmoNSIInfoType))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0", IsNullable=false)]
public class ExportPaymentsRequest : ExportRequestType {
    
    private PaymentsExportConditions paymentsExportConditionsField;

    [XmlElement(Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public PaymentsExportConditions PaymentsExportConditions {
        get {
            return this.paymentsExportConditionsField;
        }
        set {
            this.paymentsExportConditionsField = value;
        }
    }
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
    
    private ExportPaymentsResponsePaymentInfo[] paymentInfoField;
    
    private bool hasMoreField;

    [XmlElement("PaymentInfo")]
    public ExportPaymentsResponsePaymentInfo[] PaymentInfo {
        get {
            return this.paymentInfoField;
        }
        set {
            this.paymentInfoField = value;
        }
    }

    [XmlAttribute]
    public bool hasMore {
        get {
            return this.hasMoreField;
        }
        set {
            this.hasMoreField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
public class ExportPaymentsResponsePaymentInfo : PaymentType {
    
    private ExportPaymentsResponsePaymentInfoAcknowledgmentInfo acknowledgmentInfoField;
    
    private ExportPaymentsResponsePaymentInfoRefundInfo[] refundInfoField;
    
    private ChangeStatusInfo changeStatusInfoField;

    public ExportPaymentsResponsePaymentInfoAcknowledgmentInfo AcknowledgmentInfo {
        get {
            return this.acknowledgmentInfoField;
        }
        set {
            this.acknowledgmentInfoField = value;
        }
    }

    [XmlElement("RefundInfo")]
    public ExportPaymentsResponsePaymentInfoRefundInfo[] RefundInfo {
        get {
            return this.refundInfoField;
        }
        set {
            this.refundInfoField = value;
        }
    }

    [XmlElement(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public ChangeStatusInfo ChangeStatusInfo {
        get {
            return this.changeStatusInfoField;
        }
        set {
            this.changeStatusInfoField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
public class ExportPaymentsResponsePaymentInfoAcknowledgmentInfo {
    
    private object itemField;

    [XmlElement("ServiceProvidedInfo", typeof(ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfo))]
    [XmlElement("SupplierBillID", typeof(string))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
public class ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfo {
    
    private ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoAdditionalRepaymenInfo additionalRepaymenInfoField;
    
    private ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoServiceProvided serviceProvidedField;

    public ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoAdditionalRepaymenInfo AdditionalRepaymenInfo {
        get {
            return this.additionalRepaymenInfoField;
        }
        set {
            this.additionalRepaymenInfoField = value;
        }
    }

    [XmlAttribute]
    public ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoServiceProvided serviceProvided {
        get {
            return this.serviceProvidedField;
        }
        set {
            this.serviceProvidedField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
public class ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoAdditionalRepaymenInfo {
    
    private ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoAdditionalRepaymenInfoServiceData[] serviceDataField;
    
    private long residualAmountField;

    [XmlElement("ServiceData")]
    public ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoAdditionalRepaymenInfoServiceData[] ServiceData {
        get {
            return this.serviceDataField;
        }
        set {
            this.serviceDataField = value;
        }
    }

    [XmlAttribute]
    public long residualAmount {
        get {
            return this.residualAmountField;
        }
        set {
            this.residualAmountField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
public class ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoAdditionalRepaymenInfoServiceData : ServiceDataType {
    
    private string serviceDataIDField;

    [XmlAttribute]
    public string serviceDataID {
        get {
            return this.serviceDataIDField;
        }
        set {
            this.serviceDataIDField = value;
        }
    }
}

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public class ServiceDataType {
    
    private ServiceDataTypePersoneOfficial personeOfficialField;
    
    private ulong amountField;
    
    private string courtNameField;
    
    private string lawsuitInfoField;

    public ServiceDataTypePersoneOfficial personeOfficial {
        get {
            return this.personeOfficialField;
        }
        set {
            this.personeOfficialField = value;
        }
    }

    [XmlAttribute]
    public ulong amount {
        get {
            return this.amountField;
        }
        set {
            this.amountField = value;
        }
    }

    [XmlAttribute]
    public string courtName {
        get {
            return this.courtNameField;
        }
        set {
            this.courtNameField = value;
        }
    }

    [XmlAttribute]
    public string lawsuitInfo {
        get {
            return this.lawsuitInfoField;
        }
        set {
            this.lawsuitInfoField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public class ServiceDataTypePersoneOfficial {
    
    private string nameField;
    
    private string officialPositionField;

    [XmlAttribute]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }

    [XmlAttribute]
    public string officialPosition {
        get {
            return this.officialPositionField;
        }
        set {
            this.officialPositionField = value;
        }
    }
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
    
    private string refundIdField;
    
    private ulong amountField;

    [XmlAttribute]
    public string refundId {
        get {
            return this.refundIdField;
        }
        set {
            this.refundIdField = value;
        }
    }

    [XmlAttribute]
    public ulong amount {
        get {
            return this.amountField;
        }
        set {
            this.amountField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.4.0", IsNullable=false)]
public class ExportQuittancesRequest : ExportRequestType {
    
    private QuittancesExportConditions quittancesExportConditionsField;

    [XmlElement(Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public QuittancesExportConditions QuittancesExportConditions {
        get {
            return this.quittancesExportConditionsField;
        }
        set {
            this.quittancesExportConditionsField = value;
        }
    }
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
    
    private QuittanceType[] quittanceField;
    
    private ExportQuittancesResponsePossibleData[] possibleDataField;
    
    private bool hasMoreField;

    [XmlElement("Quittance")]
    public QuittanceType[] Quittance {
        get {
            return this.quittanceField;
        }
        set {
            this.quittanceField = value;
        }
    }

    [XmlElement("PossibleData")]
    public ExportQuittancesResponsePossibleData[] PossibleData {
        get {
            return this.possibleDataField;
        }
        set {
            this.possibleDataField = value;
        }
    }

    [XmlAttribute]
    public bool hasMore {
        get {
            return this.hasMoreField;
        }
        set {
            this.hasMoreField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.4.0")]
public class ExportQuittancesResponsePossibleData {
    
    private ExportQuittancesResponsePossibleDataComparisonResult[] comparisonResultField;
    
    private string supplierBillIDField;
    
    private ulong totalAmountField;
    
    private bool totalAmountFieldSpecified;

    [XmlElement("ComparisonResult")]
    public ExportQuittancesResponsePossibleDataComparisonResult[] ComparisonResult {
        get {
            return this.comparisonResultField;
        }
        set {
            this.comparisonResultField = value;
        }
    }

    [XmlAttribute]
    public string supplierBillID {
        get {
            return this.supplierBillIDField;
        }
        set {
            this.supplierBillIDField = value;
        }
    }

    [XmlAttribute]
    public ulong totalAmount {
        get {
            return this.totalAmountField;
        }
        set {
            this.totalAmountField = value;
        }
    }

    [XmlIgnore]
    public bool totalAmountSpecified {
        get {
            return this.totalAmountFieldSpecified;
        }
        set {
            this.totalAmountFieldSpecified = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.4.0")]
public class ExportQuittancesResponsePossibleDataComparisonResult {
    
    private string paymentIdField;
    
    private ulong comparisonWeightField;
    
    private DateTime comparisonDateField;
    
    private bool comparisonDateFieldSpecified;
    
    private ulong amountPaymentField;
    
    private bool amountPaymentFieldSpecified;
    
    private string kbkField;
    
    private string oktmoField;
    
    private string accountNumberField;
    
    private string bikField;

    [XmlAttribute]
    public string paymentId {
        get {
            return this.paymentIdField;
        }
        set {
            this.paymentIdField = value;
        }
    }

    [XmlAttribute]
    public ulong comparisonWeight {
        get {
            return this.comparisonWeightField;
        }
        set {
            this.comparisonWeightField = value;
        }
    }

    [XmlAttribute]
    public DateTime comparisonDate {
        get {
            return this.comparisonDateField;
        }
        set {
            this.comparisonDateField = value;
        }
    }

    [XmlIgnore]
    public bool comparisonDateSpecified {
        get {
            return this.comparisonDateFieldSpecified;
        }
        set {
            this.comparisonDateFieldSpecified = value;
        }
    }

    [XmlAttribute]
    public ulong amountPayment {
        get {
            return this.amountPaymentField;
        }
        set {
            this.amountPaymentField = value;
        }
    }

    [XmlIgnore]
    public bool amountPaymentSpecified {
        get {
            return this.amountPaymentFieldSpecified;
        }
        set {
            this.amountPaymentFieldSpecified = value;
        }
    }

    [XmlAttribute]
    public string kbk {
        get {
            return this.kbkField;
        }
        set {
            this.kbkField = value;
        }
    }

    [XmlAttribute]
    public string oktmo {
        get {
            return this.oktmoField;
        }
        set {
            this.oktmoField = value;
        }
    }

    [XmlAttribute]
    public string accountNumber {
        get {
            return this.accountNumberField;
        }
        set {
            this.accountNumberField = value;
        }
    }

    [XmlAttribute]
    public string bik {
        get {
            return this.bikField;
        }
        set {
            this.bikField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-refunds/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-refunds/2.4.0", IsNullable=false)]
public class ExportRefundsRequest : ExportRequestType {
    
    private RefundsExportConditions refundsExportConditionsField;

    [XmlElement(Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public RefundsExportConditions RefundsExportConditions {
        get {
            return this.refundsExportConditionsField;
        }
        set {
            this.refundsExportConditionsField = value;
        }
    }
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
    
    private ExportRefundsResponseRefund[] refundField;
    
    private bool hasMoreField;

    [XmlElement("Refund")]
    public ExportRefundsResponseRefund[] Refund {
        get {
            return this.refundField;
        }
        set {
            this.refundField = value;
        }
    }

    [XmlAttribute]
    public bool hasMore {
        get {
            return this.hasMoreField;
        }
        set {
            this.hasMoreField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-refunds/2.4.0")]
public class ExportRefundsResponseRefund : RefundType {
    
    private ChangeStatusInfo changeStatusInfoField;

    [XmlElement(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public ChangeStatusInfo ChangeStatusInfo {
        get {
            return this.changeStatusInfoField;
        }
        set {
            this.changeStatusInfoField = value;
        }
    }
}

[XmlInclude(typeof(ImportedRefundType))]

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Refund/2.4.0")]
public class RefundType {
    
    private RefundPayer refundPayerField;
    
    private RefundTypeRefundApplication refundApplicationField;
    
    private RefundTypeRefundBasis refundBasisField;
    
    private RefundTypeRefundPayee refundPayeeField;
    
    private AdditionalDataType[] additionalDataField;
    
    private string refundIdField;
    
    private DateTime refundDocDateField;
    
    private RefundTypeBudgetLevel budgetLevelField;
    
    private string kbkField;
    
    private string oktmoField;

    [XmlElement(Namespace="http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
    public RefundPayer RefundPayer {
        get {
            return this.refundPayerField;
        }
        set {
            this.refundPayerField = value;
        }
    }

    public RefundTypeRefundApplication RefundApplication {
        get {
            return this.refundApplicationField;
        }
        set {
            this.refundApplicationField = value;
        }
    }

    public RefundTypeRefundBasis RefundBasis {
        get {
            return this.refundBasisField;
        }
        set {
            this.refundBasisField = value;
        }
    }

    public RefundTypeRefundPayee RefundPayee {
        get {
            return this.refundPayeeField;
        }
        set {
            this.refundPayeeField = value;
        }
    }

    [XmlElement("AdditionalData", Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public AdditionalDataType[] AdditionalData {
        get {
            return this.additionalDataField;
        }
        set {
            this.additionalDataField = value;
        }
    }

    [XmlAttribute]
    public string refundId {
        get {
            return this.refundIdField;
        }
        set {
            this.refundIdField = value;
        }
    }

    [XmlAttribute]
    public DateTime refundDocDate {
        get {
            return this.refundDocDateField;
        }
        set {
            this.refundDocDateField = value;
        }
    }

    [XmlAttribute]
    public RefundTypeBudgetLevel budgetLevel {
        get {
            return this.budgetLevelField;
        }
        set {
            this.budgetLevelField = value;
        }
    }

    [XmlAttribute]
    public string kbk {
        get {
            return this.kbkField;
        }
        set {
            this.kbkField = value;
        }
    }

    [XmlAttribute]
    public string oktmo {
        get {
            return this.oktmoField;
        }
        set {
            this.oktmoField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
[XmlRoot(Namespace="http://roskazna.ru/gisgmp/xsd/Organization/2.4.0", IsNullable=false)]
public class RefundPayer : OrganizationType {
    
    private string codeUBPField;

    [XmlAttribute]
    public string codeUBP {
        get {
            return this.codeUBPField;
        }
        set {
            this.codeUBPField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Refund/2.4.0")]
public class RefundTypeRefundApplication {
    
    private string appNumField;
    
    private DateTime appDateField;
    
    private string paymentIdField;
    
    private int cashTypeField;
    
    private ulong amountField;
    
    private string purposeField;

    [XmlAttribute]
    public string appNum {
        get {
            return this.appNumField;
        }
        set {
            this.appNumField = value;
        }
    }

    [XmlAttribute(DataType="date")]
    public DateTime appDate {
        get {
            return this.appDateField;
        }
        set {
            this.appDateField = value;
        }
    }

    [XmlAttribute]
    public string paymentId {
        get {
            return this.paymentIdField;
        }
        set {
            this.paymentIdField = value;
        }
    }

    [XmlAttribute]
    public int cashType {
        get {
            return this.cashTypeField;
        }
        set {
            this.cashTypeField = value;
        }
    }

    [XmlAttribute]
    public ulong amount {
        get {
            return this.amountField;
        }
        set {
            this.amountField = value;
        }
    }

    [XmlAttribute]
    public string purpose {
        get {
            return this.purposeField;
        }
        set {
            this.purposeField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Refund/2.4.0")]
public class RefundTypeRefundBasis {
    
    private string docKindField;
    
    private string docNumberField;
    
    private DateTime docDateField;

    [XmlAttribute]
    public string docKind {
        get {
            return this.docKindField;
        }
        set {
            this.docKindField = value;
        }
    }

    [XmlAttribute]
    public string docNumber {
        get {
            return this.docNumberField;
        }
        set {
            this.docNumberField = value;
        }
    }

    [XmlAttribute(DataType="date")]
    public DateTime docDate {
        get {
            return this.docDateField;
        }
        set {
            this.docDateField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Refund/2.4.0")]
public class RefundTypeRefundPayee : PayeeType {
    
    private AccountType bankAccountNumberField;
    
    private string payeeAccountField;
    
    private string nameField;
    
    private string kbkField;
    
    private string oktmoField;

    public AccountType BankAccountNumber {
        get {
            return this.bankAccountNumberField;
        }
        set {
            this.bankAccountNumberField = value;
        }
    }

    public string PayeeAccount {
        get {
            return this.payeeAccountField;
        }
        set {
            this.payeeAccountField = value;
        }
    }

    [XmlAttribute]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }

    [XmlAttribute]
    public string kbk {
        get {
            return this.kbkField;
        }
        set {
            this.kbkField = value;
        }
    }

    [XmlAttribute]
    public string oktmo {
        get {
            return this.oktmoField;
        }
        set {
            this.oktmoField = value;
        }
    }
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
    
    private string originatorIdField;
    
    private string idField;

    [XmlAttribute]
    public string originatorId {
        get {
            return this.originatorIdField;
        }
        set {
            this.originatorIdField = value;
        }
    }

    [XmlAttribute(DataType="ID")]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-clarification/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-clarification/2.4.0", IsNullable=false)]
public class ExportClarificationsRequest : ExportRequestType {
    
    private ClarificationsExportConditions clarificationsExportConditionsField;

    [XmlElement(Namespace="http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public ClarificationsExportConditions ClarificationsExportConditions {
        get {
            return this.clarificationsExportConditionsField;
        }
        set {
            this.clarificationsExportConditionsField = value;
        }
    }
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
    
    private ExportClarificationResponseClarificationInfo[] clarificationInfoField;
    
    private bool hasMoreField;

    [XmlElement("ClarificationInfo")]
    public ExportClarificationResponseClarificationInfo[] ClarificationInfo {
        get {
            return this.clarificationInfoField;
        }
        set {
            this.clarificationInfoField = value;
        }
    }

    [XmlAttribute]
    public bool hasMore {
        get {
            return this.hasMoreField;
        }
        set {
            this.hasMoreField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/export-clarification/2.4.0")]
public class ExportClarificationResponseClarificationInfo : ClarificationType {
    
    private ChangeStatusInfo changeStatusInfoField;

    [XmlElement(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public ChangeStatusInfo ChangeStatusInfo {
        get {
            return this.changeStatusInfoField;
        }
        set {
            this.changeStatusInfoField = value;
        }
    }
}

[XmlInclude(typeof(ImportedClarificationType))]

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
public class ClarificationType : AbstractClarificationType {
    
    private ClarificationApplicationType clarificationApplicationField;
    
    private SignsClarificationType signsField;
    
    private string clarificationNumberField;
    
    private DateTime clarificationDateField;
    
    private string clarificationIdField;
    
    private string paymentIdField;
    
    private string supplierBillIDField;
    
    private string authorAccountField;
    
    private string authorNameField;
    
    private string codeUBPField;
    
    private string mainAuthorNameField;
    
    private string kbkGlavaCodeField;
    
    private ClarificationTypeBudgetLevel budgetLevelField;
    
    private string okpoField;
    
    private string finBodyAccountField;
    
    private string financialBodyField;
    
    private string tofkNameField;
    
    private string tofkCodeField;
    
    private string payerNameField;
    
    private string payerIdentifierField;
    
    private string innField;
    
    private string kppField;
    
    private string payerDocumentField;
    
    private string payerAccountField;
    
    private string findingoutRequestNumField;
    
    private DateTime findingoutRequestDateField;
    
    private bool findingoutRequestDateFieldSpecified;

    public ClarificationApplicationType ClarificationApplication {
        get {
            return this.clarificationApplicationField;
        }
        set {
            this.clarificationApplicationField = value;
        }
    }

    public SignsClarificationType Signs {
        get {
            return this.signsField;
        }
        set {
            this.signsField = value;
        }
    }

    [XmlAttribute]
    public string clarificationNumber {
        get {
            return this.clarificationNumberField;
        }
        set {
            this.clarificationNumberField = value;
        }
    }

    [XmlAttribute(DataType="date")]
    public DateTime clarificationDate {
        get {
            return this.clarificationDateField;
        }
        set {
            this.clarificationDateField = value;
        }
    }

    [XmlAttribute]
    public string clarificationId {
        get {
            return this.clarificationIdField;
        }
        set {
            this.clarificationIdField = value;
        }
    }

    [XmlAttribute]
    public string paymentId {
        get {
            return this.paymentIdField;
        }
        set {
            this.paymentIdField = value;
        }
    }

    [XmlAttribute]
    public string supplierBillID {
        get {
            return this.supplierBillIDField;
        }
        set {
            this.supplierBillIDField = value;
        }
    }

    [XmlAttribute]
    public string authorAccount {
        get {
            return this.authorAccountField;
        }
        set {
            this.authorAccountField = value;
        }
    }

    [XmlAttribute]
    public string authorName {
        get {
            return this.authorNameField;
        }
        set {
            this.authorNameField = value;
        }
    }

    [XmlAttribute]
    public string codeUBP {
        get {
            return this.codeUBPField;
        }
        set {
            this.codeUBPField = value;
        }
    }

    [XmlAttribute]
    public string mainAuthorName {
        get {
            return this.mainAuthorNameField;
        }
        set {
            this.mainAuthorNameField = value;
        }
    }

    [XmlAttribute]
    public string kbkGlavaCode {
        get {
            return this.kbkGlavaCodeField;
        }
        set {
            this.kbkGlavaCodeField = value;
        }
    }

    [XmlAttribute]
    public ClarificationTypeBudgetLevel budgetLevel {
        get {
            return this.budgetLevelField;
        }
        set {
            this.budgetLevelField = value;
        }
    }

    [XmlAttribute]
    public string okpo {
        get {
            return this.okpoField;
        }
        set {
            this.okpoField = value;
        }
    }

    [XmlAttribute]
    public string finBodyAccount {
        get {
            return this.finBodyAccountField;
        }
        set {
            this.finBodyAccountField = value;
        }
    }

    [XmlAttribute]
    public string financialBody {
        get {
            return this.financialBodyField;
        }
        set {
            this.financialBodyField = value;
        }
    }

    [XmlAttribute]
    public string tofkName {
        get {
            return this.tofkNameField;
        }
        set {
            this.tofkNameField = value;
        }
    }

    [XmlAttribute]
    public string tofkCode {
        get {
            return this.tofkCodeField;
        }
        set {
            this.tofkCodeField = value;
        }
    }

    [XmlAttribute]
    public string payerName {
        get {
            return this.payerNameField;
        }
        set {
            this.payerNameField = value;
        }
    }

    [XmlAttribute]
    public string payerIdentifier {
        get {
            return this.payerIdentifierField;
        }
        set {
            this.payerIdentifierField = value;
        }
    }

    [XmlAttribute]
    public string inn {
        get {
            return this.innField;
        }
        set {
            this.innField = value;
        }
    }

    [XmlAttribute]
    public string kpp {
        get {
            return this.kppField;
        }
        set {
            this.kppField = value;
        }
    }

    [XmlAttribute]
    public string payerDocument {
        get {
            return this.payerDocumentField;
        }
        set {
            this.payerDocumentField = value;
        }
    }

    [XmlAttribute]
    public string payerAccount {
        get {
            return this.payerAccountField;
        }
        set {
            this.payerAccountField = value;
        }
    }

    [XmlAttribute]
    public string findingoutRequestNum {
        get {
            return this.findingoutRequestNumField;
        }
        set {
            this.findingoutRequestNumField = value;
        }
    }

    [XmlAttribute(DataType="date")]
    public DateTime findingoutRequestDate {
        get {
            return this.findingoutRequestDateField;
        }
        set {
            this.findingoutRequestDateField = value;
        }
    }

    [XmlIgnore]
    public bool findingoutRequestDateSpecified {
        get {
            return this.findingoutRequestDateFieldSpecified;
        }
        set {
            this.findingoutRequestDateFieldSpecified = value;
        }
    }
}

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
public class ClarificationApplicationType {
    
    private originalDetailType originalDetailsField;
    
    private setDetailType setDetailsField;
    
    private string ordinalNumberField;
    
    private string applicationNameField;
    
    private ClarificationApplicationTypeAppCode appCodeField;
    
    private bool appCodeFieldSpecified;
    
    private string appNumField;
    
    private DateTime appDateField;
    
    private bool appDateFieldSpecified;
    
    private string incomeIdField;
    
    private string applicationNumberField;
    
    private DateTime applicationDateField;
    
    private bool applicationDateFieldSpecified;

    public originalDetailType OriginalDetails {
        get {
            return this.originalDetailsField;
        }
        set {
            this.originalDetailsField = value;
        }
    }

    public setDetailType SetDetails {
        get {
            return this.setDetailsField;
        }
        set {
            this.setDetailsField = value;
        }
    }

    [XmlAttribute]
    public string ordinalNumber {
        get {
            return this.ordinalNumberField;
        }
        set {
            this.ordinalNumberField = value;
        }
    }

    [XmlAttribute]
    public string applicationName {
        get {
            return this.applicationNameField;
        }
        set {
            this.applicationNameField = value;
        }
    }

    [XmlAttribute]
    public ClarificationApplicationTypeAppCode appCode {
        get {
            return this.appCodeField;
        }
        set {
            this.appCodeField = value;
        }
    }

    [XmlIgnore]
    public bool appCodeSpecified {
        get {
            return this.appCodeFieldSpecified;
        }
        set {
            this.appCodeFieldSpecified = value;
        }
    }

    [XmlAttribute]
    public string appNum {
        get {
            return this.appNumField;
        }
        set {
            this.appNumField = value;
        }
    }

    [XmlAttribute(DataType="date")]
    public DateTime appDate {
        get {
            return this.appDateField;
        }
        set {
            this.appDateField = value;
        }
    }

    [XmlIgnore]
    public bool appDateSpecified {
        get {
            return this.appDateFieldSpecified;
        }
        set {
            this.appDateFieldSpecified = value;
        }
    }

    [XmlAttribute]
    public string incomeId {
        get {
            return this.incomeIdField;
        }
        set {
            this.incomeIdField = value;
        }
    }

    [XmlAttribute]
    public string applicationNumber {
        get {
            return this.applicationNumberField;
        }
        set {
            this.applicationNumberField = value;
        }
    }

    [XmlAttribute(DataType="date")]
    public DateTime applicationDate {
        get {
            return this.applicationDateField;
        }
        set {
            this.applicationDateField = value;
        }
    }

    [XmlIgnore]
    public bool applicationDateSpecified {
        get {
            return this.applicationDateFieldSpecified;
        }
        set {
            this.applicationDateFieldSpecified = value;
        }
    }
}

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
public class originalDetailType : paymentDetailType {
    
    private ulong amountField;

    [XmlAttribute]
    public ulong amount {
        get {
            return this.amountField;
        }
        set {
            this.amountField = value;
        }
    }
}

[XmlInclude(typeof(setDetailType))]
[XmlInclude(typeof(originalDetailType))]

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
public class paymentDetailType {
    
    private string payeeNameField;
    
    private string innField;
    
    private string kppField;
    
    private string payeeAccountField;
    
    private string oktmoField;
    
    private string kbkField;
    
    private string subsidyField;
    
    private string purposeField;
    
    private string descriptionField;

    [XmlAttribute]
    public string payeeName {
        get {
            return this.payeeNameField;
        }
        set {
            this.payeeNameField = value;
        }
    }

    [XmlAttribute]
    public string inn {
        get {
            return this.innField;
        }
        set {
            this.innField = value;
        }
    }

    [XmlAttribute]
    public string kpp {
        get {
            return this.kppField;
        }
        set {
            this.kppField = value;
        }
    }

    [XmlAttribute]
    public string payeeAccount {
        get {
            return this.payeeAccountField;
        }
        set {
            this.payeeAccountField = value;
        }
    }

    [XmlAttribute]
    public string oktmo {
        get {
            return this.oktmoField;
        }
        set {
            this.oktmoField = value;
        }
    }

    [XmlAttribute]
    public string kbk {
        get {
            return this.kbkField;
        }
        set {
            this.kbkField = value;
        }
    }

    [XmlAttribute]
    public string subsidy {
        get {
            return this.subsidyField;
        }
        set {
            this.subsidyField = value;
        }
    }

    [XmlAttribute]
    public string purpose {
        get {
            return this.purposeField;
        }
        set {
            this.purposeField = value;
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
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
public class setDetailType : paymentDetailType {
    
    private ulong amountField;
    
    private bool amountFieldSpecified;

    [XmlAttribute]
    public ulong amount {
        get {
            return this.amountField;
        }
        set {
            this.amountField = value;
        }
    }

    [XmlIgnore]
    public bool amountSpecified {
        get {
            return this.amountFieldSpecified;
        }
        set {
            this.amountFieldSpecified = value;
        }
    }
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
    
    private string headPostField;
    
    private string headNameField;
    
    private string executorPostField;
    
    private string executorNameField;
    
    private string executorNumField;
    
    private DateTime signDateField;
    
    private bool signDateFieldSpecified;
    
    private string tOFKheadPostField;
    
    private string tOFKheadNameField;
    
    private string tOFKexecutorPostField;
    
    private string tOFKexecutorNameField;
    
    private string tOFKexecutorNumField;
    
    private DateTime tOFKsignDateField;
    
    private bool tOFKsignDateFieldSpecified;

    public string HeadPost {
        get {
            return this.headPostField;
        }
        set {
            this.headPostField = value;
        }
    }

    public string HeadName {
        get {
            return this.headNameField;
        }
        set {
            this.headNameField = value;
        }
    }

    public string ExecutorPost {
        get {
            return this.executorPostField;
        }
        set {
            this.executorPostField = value;
        }
    }

    public string ExecutorName {
        get {
            return this.executorNameField;
        }
        set {
            this.executorNameField = value;
        }
    }

    public string ExecutorNum {
        get {
            return this.executorNumField;
        }
        set {
            this.executorNumField = value;
        }
    }

    [XmlElement(DataType="date")]
    public DateTime SignDate {
        get {
            return this.signDateField;
        }
        set {
            this.signDateField = value;
        }
    }

    [XmlIgnore]
    public bool SignDateSpecified {
        get {
            return this.signDateFieldSpecified;
        }
        set {
            this.signDateFieldSpecified = value;
        }
    }

    public string TOFKheadPost {
        get {
            return this.tOFKheadPostField;
        }
        set {
            this.tOFKheadPostField = value;
        }
    }

    public string TOFKheadName {
        get {
            return this.tOFKheadNameField;
        }
        set {
            this.tOFKheadNameField = value;
        }
    }

    public string TOFKexecutorPost {
        get {
            return this.tOFKexecutorPostField;
        }
        set {
            this.tOFKexecutorPostField = value;
        }
    }

    public string TOFKexecutorName {
        get {
            return this.tOFKexecutorNameField;
        }
        set {
            this.tOFKexecutorNameField = value;
        }
    }

    public string TOFKexecutorNum {
        get {
            return this.tOFKexecutorNumField;
        }
        set {
            this.tOFKexecutorNumField = value;
        }
    }

    [XmlElement(DataType="date")]
    public DateTime TOFKsignDate {
        get {
            return this.tOFKsignDateField;
        }
        set {
            this.tOFKsignDateField = value;
        }
    }

    [XmlIgnore]
    public bool TOFKsignDateSpecified {
        get {
            return this.tOFKsignDateFieldSpecified;
        }
        set {
            this.tOFKsignDateFieldSpecified = value;
        }
    }
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
    
    private string originatorIdField;
    
    private string idField;

    [XmlAttribute]
    public string originatorId {
        get {
            return this.originatorIdField;
        }
        set {
            this.originatorIdField = value;
        }
    }

    [XmlAttribute(DataType="ID")]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0", IsNullable=false)]
public class ForcedAcknowledgementRequest : RequestType {
    
    private object itemField;
    
    private string originatorIdField;

    [XmlElement("AnnulmentReconcile", typeof(ForcedAcknowledgementRequestAnnulmentReconcile))]
    [XmlElement("AnnulmentServiceProvided", typeof(ForcedAcknowledgementRequestAnnulmentServiceProvided))]
    [XmlElement("Reconcile", typeof(ForcedAcknowledgementRequestReconcile))]
    [XmlElement("ServiceProvided", typeof(ForcedAcknowledgementRequestServiceProvided))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }

    [XmlAttribute]
    public string originatorId {
        get {
            return this.originatorIdField;
        }
        set {
            this.originatorIdField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
public class ForcedAcknowledgementRequestAnnulmentReconcile {
    
    private object[] itemsField;
    
    private string supplierBillIdField;

    [XmlElement("PaymentId", typeof(string))]
    [XmlElement("PaymentNotLoaded", typeof(ForcedAcknowledgementRequestAnnulmentReconcilePaymentNotLoaded))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }

    [XmlAttribute]
    public string supplierBillId {
        get {
            return this.supplierBillIdField;
        }
        set {
            this.supplierBillIdField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
public class ForcedAcknowledgementRequestAnnulmentReconcilePaymentNotLoaded {
    
    private string reconcileIDField;
    
    private bool valueField;

    [XmlAttribute]
    public string reconcileID {
        get {
            return this.reconcileIDField;
        }
        set {
            this.reconcileIDField = value;
        }
    }

    [XmlText()]
    public bool Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
public class ForcedAcknowledgementRequestAnnulmentServiceProvided {
    
    private ForcedAcknowledgementRequestAnnulmentServiceProvidedPaymentDataID[] paymentDataIDField;

    [XmlElement("PaymentDataID")]
    public ForcedAcknowledgementRequestAnnulmentServiceProvidedPaymentDataID[] PaymentDataID {
        get {
            return this.paymentDataIDField;
        }
        set {
            this.paymentDataIDField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
public class ForcedAcknowledgementRequestAnnulmentServiceProvidedPaymentDataID {
    
    private string paymentIdField;
    
    private string serviceDataIDField;

    [XmlAttribute]
    public string paymentId {
        get {
            return this.paymentIdField;
        }
        set {
            this.paymentIdField = value;
        }
    }

    [XmlAttribute]
    public string serviceDataID {
        get {
            return this.serviceDataIDField;
        }
        set {
            this.serviceDataIDField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
public class ForcedAcknowledgementRequestReconcile {
    
    private object[] itemsField;
    
    private string supplierBillIdField;

    [XmlElement("PaymentId", typeof(string))]
    [XmlElement("PaymentNotLoaded", typeof(ForcedAcknowledgementRequestReconcilePaymentNotLoaded))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }

    [XmlAttribute]
    public string supplierBillId {
        get {
            return this.supplierBillIdField;
        }
        set {
            this.supplierBillIdField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
public class ForcedAcknowledgementRequestReconcilePaymentNotLoaded {
    
    private ulong amountReconcileField;
    
    private bool amountReconcileFieldSpecified;
    
    private bool valueField;

    [XmlAttribute]
    public ulong amountReconcile {
        get {
            return this.amountReconcileField;
        }
        set {
            this.amountReconcileField = value;
        }
    }

    [XmlIgnore]
    public bool amountReconcileSpecified {
        get {
            return this.amountReconcileFieldSpecified;
        }
        set {
            this.amountReconcileFieldSpecified = value;
        }
    }

    [XmlText()]
    public bool Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
public class ForcedAcknowledgementRequestServiceProvided {
    
    private ForcedAcknowledgementRequestServiceProvidedPaymentDataInfo[] paymentDataInfoField;

    [XmlElement("PaymentDataInfo")]
    public ForcedAcknowledgementRequestServiceProvidedPaymentDataInfo[] PaymentDataInfo {
        get {
            return this.paymentDataInfoField;
        }
        set {
            this.paymentDataInfoField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
public class ForcedAcknowledgementRequestServiceProvidedPaymentDataInfo {
    
    private ServiceDataType serviceDataField;
    
    private string paymentIdField;

    public ServiceDataType ServiceData {
        get {
            return this.serviceDataField;
        }
        set {
            this.serviceDataField = value;
        }
    }

    [XmlAttribute]
    public string paymentId {
        get {
            return this.paymentIdField;
        }
        set {
            this.paymentIdField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0", IsNullable=false)]
public class ForcedAcknowledgementResponse : ResponseType {
    
    private object[] itemsField;

    [XmlElement("Done", typeof(ForcedAcknowledgementResponseDone))]
    [XmlElement("Quittance", typeof(ForcedAcknowledgementResponseQuittance))]
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
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
public class ForcedAcknowledgementResponseDone {
    
    private string serviceDataIDField;
    
    private bool valueField;

    [XmlAttribute]
    public string serviceDataID {
        get {
            return this.serviceDataIDField;
        }
        set {
            this.serviceDataIDField = value;
        }
    }

    [XmlText()]
    public bool Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
public class ForcedAcknowledgementResponseQuittance : QuittanceType {
    
    private string reconcileIDField;

    [XmlAttribute]
    public string reconcileID {
        get {
            return this.reconcileIDField;
        }
        set {
            this.reconcileIDField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.4.0", IsNullable=false)]
public class ImportCertificateRequest : RequestType {
    
    private ImportCertificateEntryType[] requestEntryField;

    [XmlElement("RequestEntry")]
    public ImportCertificateEntryType[] RequestEntry {
        get {
            return this.requestEntryField;
        }
        set {
            this.requestEntryField = value;
        }
    }
}

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
public class ImportCertificateEntryType {
    
    private string idField;
    
    private string ownershipField;

    [XmlAttribute(DataType="IDREF")]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }

    [XmlAttribute]
    public string ownership {
        get {
            return this.ownershipField;
        }
        set {
            this.ownershipField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.4.0", IsNullable=false)]
public class ImportCertificateResponse : ResponseType {
    
    private ImportProtocolType[] importProtocolField;

    [XmlElement("ImportProtocol")]
    public ImportProtocolType[] ImportProtocol {
        get {
            return this.importProtocolField;
        }
        set {
            this.importProtocolField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-charges/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-charges/2.4.0", IsNullable=false)]
public class ImportChargesRequest : RequestType {
    
    private ChargesPackage chargesPackageField;

    [XmlElement(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public ChargesPackage ChargesPackage {
        get {
            return this.chargesPackageField;
        }
        set {
            this.chargesPackageField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
[XmlRoot(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0", IsNullable=false)]
public class ChargesPackage : PackageType {
}

//[Serializable]
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
public class PackageType {
    
    private object[] itemsField;

    [XmlElement("ImportedChange", typeof(ImportedChangeType))]
    [XmlElement("ImportedCharge", typeof(ImportedChargeType))]
    [XmlElement("ImportedClarification", typeof(ImportedClarificationType))]
    [XmlElement("ImportedIncome", typeof(ImportedIncomeType))]
    [XmlElement("ImportedPayment", typeof(ImportedPaymentType))]
    [XmlElement("ImportedRefund", typeof(ImportedRefundType))]
    [XmlElement("ImportedRenouncement", typeof(ImportedRenouncementType))]
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
[XmlType(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
public class ImportedChangeType {
    
    private string itemField;
    
    private ItemChoiceType1 itemElementNameField;
    
    private ChangeType[] changeField;
    
    private ChangeStatus changeStatusField;
    
    private string originatorIdField;
    
    private string idField;

    [XmlElement("ClarificationId", typeof(string))]
    [XmlElement("IncomeId", typeof(string))]
    [XmlElement("PaymentId", typeof(string))]
    [XmlElement("RefundId", typeof(string))]
    [XmlElement("RenouncementID", typeof(string))]
    [XmlElement("SupplierBillId", typeof(string))]
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
    public ItemChoiceType1 ItemElementName {
        get {
            return this.itemElementNameField;
        }
        set {
            this.itemElementNameField = value;
        }
    }

    [XmlElement("Change")]
    public ChangeType[] Change {
        get {
            return this.changeField;
        }
        set {
            this.changeField = value;
        }
    }

    [XmlElement(Namespace="http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public ChangeStatus ChangeStatus {
        get {
            return this.changeStatusField;
        }
        set {
            this.changeStatusField = value;
        }
    }

    [XmlAttribute]
    public string originatorId {
        get {
            return this.originatorIdField;
        }
        set {
            this.originatorIdField = value;
        }
    }

    [XmlAttribute(DataType="ID")]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
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
    
    private ChangeTypeChangeValue[] changeValueField;
    
    private string fieldNumField;

    [XmlElement("ChangeValue")]
    public ChangeTypeChangeValue[] ChangeValue {
        get {
            return this.changeValueField;
        }
        set {
            this.changeValueField = value;
        }
    }

    [XmlAttribute]
    public string fieldNum {
        get {
            return this.fieldNumField;
        }
        set {
            this.fieldNumField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
public class ChangeTypeChangeValue {
    
    private string nameField;
    
    private string valueField;

    [XmlAttribute]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }

    [XmlAttribute]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-incomes/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-incomes/2.4.0", IsNullable=false)]
public class ImportIncomesRequest : RequestType {
    
    private IncomesPackage incomesPackageField;

    [XmlElement(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public IncomesPackage IncomesPackage {
        get {
            return this.incomesPackageField;
        }
        set {
            this.incomesPackageField = value;
        }
    }
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
    
    private PaymentsPackage paymentsPackageField;

    [XmlElement(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public PaymentsPackage PaymentsPackage {
        get {
            return this.paymentsPackageField;
        }
        set {
            this.paymentsPackageField = value;
        }
    }
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
    
    private RefundsPackage refundsPackageField;

    [XmlElement(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public RefundsPackage RefundsPackage {
        get {
            return this.refundsPackageField;
        }
        set {
            this.refundsPackageField = value;
        }
    }
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
    
    private RenouncementPackage renouncementPackageField;

    [XmlElement(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public RenouncementPackage RenouncementPackage {
        get {
            return this.renouncementPackageField;
        }
        set {
            this.renouncementPackageField = value;
        }
    }
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
    
    private ClarificationsPackage clarificationsPackageField;

    [XmlElement(Namespace="http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public ClarificationsPackage ClarificationsPackage {
        get {
            return this.clarificationsPackageField;
        }
        set {
            this.clarificationsPackageField = value;
        }
    }
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
    
    private PaymentCheckRequestPaymentTemplate paymentTemplateField;

    public PaymentCheckRequestPaymentTemplate PaymentTemplate {
        get {
            return this.paymentTemplateField;
        }
        set {
            this.paymentTemplateField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-paymentcheck/2.4.0")]
public class PaymentCheckRequestPaymentTemplate {
    
    private Payee payeeField;
    
    private string supplierBillIDField;
    
    private DateTime receiptDateField;
    
    private bool receiptDateFieldSpecified;
    
    private string kbkField;
    
    private string oktmoField;

    [XmlElement(Namespace="http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
    public Payee Payee {
        get {
            return this.payeeField;
        }
        set {
            this.payeeField = value;
        }
    }

    [XmlAttribute]
    public string supplierBillID {
        get {
            return this.supplierBillIDField;
        }
        set {
            this.supplierBillIDField = value;
        }
    }

    [XmlAttribute(DataType="date")]
    public DateTime receiptDate {
        get {
            return this.receiptDateField;
        }
        set {
            this.receiptDateField = value;
        }
    }

    [XmlIgnore]
    public bool receiptDateSpecified {
        get {
            return this.receiptDateFieldSpecified;
        }
        set {
            this.receiptDateFieldSpecified = value;
        }
    }

    [XmlAttribute]
    public string kbk {
        get {
            return this.kbkField;
        }
        set {
            this.kbkField = value;
        }
    }

    [XmlAttribute]
    public string oktmo {
        get {
            return this.oktmoField;
        }
        set {
            this.oktmoField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-paymentcheck/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-paymentcheck/2.4.0", IsNullable=false)]
public class PaymentCheckResponse : ResponseType {
    
    private PaymentCheckResponseImportProtocol importProtocolField;

    public PaymentCheckResponseImportProtocol ImportProtocol {
        get {
            return this.importProtocolField;
        }
        set {
            this.importProtocolField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/import-paymentcheck/2.4.0")]
public class PaymentCheckResponseImportProtocol : ImportProtocolType {
    
    private string requisiteCheckCodeField;

    [XmlAttribute]
    public string requisiteCheckCode {
        get {
            return this.requisiteCheckCodeField;
        }
        set {
            this.requisiteCheckCodeField = value;
        }
    }
}

//[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0")]
[XmlRoot(Namespace="urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0", IsNullable=false)]
public class SubscriptionServiceRequest : RequestType {
    
    private object itemField;

    [XmlElement("CreateSubscription", typeof(SubscriptionServiceRequestCreateSubscription))]
    [XmlElement("ExportSubscriptions", typeof(bool))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
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
