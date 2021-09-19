using GisGmp.Common;
using GisGmp.SearchConditions;
using GisGmp.Services.ExportCharges;
using System;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        private ExportChargesRequest CreateExportChargesRequest(ChargesExportConditions exportConditions, EsiaUserInfoType esiaUserInfo = default, External? external = default)
            => new ExportChargesRequest(
                config: ExportRequestConfig,
                exportConditions: exportConditions,
                esiaUserInfo: esiaUserInfo,
                external: external);

        /// <summary/>
        public ExportChargesRequest CreateExportChargesRequest(ExportChargesKind kind, SupplierBillIDType[] supplierBillID, TimeIntervalType timeInterval = default, EsiaUserInfoType esiaUserInfo = default, External? external = default)
            => CreateExportChargesRequest(
                exportConditions: new ChargesExportConditions(
                    kind: kind,
                    conditions: new ChargesConditionsType(
                        supplierBillID: supplierBillID,
                        timeInterval: timeInterval)),
                esiaUserInfo: esiaUserInfo,
                external: external);

        /// <summary/>
        public ExportChargesRequest CreateExportChargesRequest(ExportChargesKind kind, PayerId[] payerId, Beneficiary[] beneficiary, string[] kbk = default, TimeIntervalType timeInterval = default, EsiaUserInfoType esiaUserInfo = default, External? external = default)
            => CreateExportChargesRequest(
                exportConditions: new ChargesExportConditions(
                    kind: kind,
                    conditions: new PayersConditionsType(
                        payerId: payerId,
                        beneficiary: beneficiary,
                        kBKlist: kbk,
                        timeInterval: timeInterval)), 
                esiaUserInfo, 
                external);

        /// <summary/>
        public ExportChargesRequest CreateExportChargesRequest(ExportChargesKind kind, INNType[] payerInn, Beneficiary[] beneficiary, string[] kbk = default, TimeIntervalType timeInterval = default, EsiaUserInfoType esiaUserInfo = default, External? external = default)
            => CreateExportChargesRequest(
                exportConditions: new ChargesExportConditions(
                    kind: kind,
                    conditions: new PayersConditionsType(
                        payerInn: payerInn,
                        beneficiary: beneficiary,
                        kBKlist: kbk,
                        timeInterval: timeInterval)),
                esiaUserInfo,
                external);

        /// <summary/>
        public ExportChargesRequest CreateExportChargesRequest(ExportChargesKind kind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = default, KBKType[] kbk = default, EsiaUserInfoType esiaUserInfo = default, External? external = default)
            => CreateExportChargesRequest(
                exportConditions: new ChargesExportConditions(
                    kind: kind,
                    conditions: new TimeConditionsType(
                        timeInterval: timeInterval,
                        beneficiary: beneficiary, 
                        kbkList: kbk)),
                esiaUserInfo: esiaUserInfo,
                external: external);

        #region ReadyRequest
        /// <inheritdoc cref="CreateExportChargesRequest(ExportChargesKind, SupplierBillIDType[], TimeIntervalType, EsiaUserInfoType, External?)"/>
        public string ExportCharges(ExportChargesKind kind, SupplierBillIDType[] supplierBillID, TimeIntervalType timeInterval = default, EsiaUserInfoType esiaUserInfo = default, External? external = default)
            => ReadyRequest(
                request: CreateExportChargesRequest(
                    kind: kind,
                    supplierBillID: supplierBillID,
                    timeInterval: timeInterval,
                    esiaUserInfo: esiaUserInfo,
                    external: external));

        /// <inheritdoc cref="CreateExportChargesRequest(ExportChargesKind, PayerId[], Beneficiary[], string[], TimeIntervalType, EsiaUserInfoType, External?)"/>
        public string ExportCharges(ExportChargesKind kind, PayerId[] payerId, Beneficiary[] beneficiary, string[] kbk = default, TimeIntervalType timeInterval = default, EsiaUserInfoType esiaUserInfo = default, External? external = default)
            => ReadyRequest(
                request: CreateExportChargesRequest(
                    kind: kind,
                    payerId: payerId,
                    beneficiary: beneficiary,
                    kbk: kbk,
                    timeInterval: timeInterval));

        /// <inheritdoc cref="CreateExportChargesRequest(ExportChargesKind, INNType[], Beneficiary[], string[], TimeIntervalType, EsiaUserInfoType, External?)"/>
        public string ExportCharges(ExportChargesKind kind, INNType[] payerInn, Beneficiary[] beneficiary, string[] kbk = default, TimeIntervalType timeInterval = default, EsiaUserInfoType esiaUserInfo = default, External? external = default)
            => ReadyRequest(
                request: CreateExportChargesRequest(
                    kind: kind,
                    payerInn: payerInn,
                    beneficiary: beneficiary,
                    kbk: kbk,
                    timeInterval: timeInterval,
                    esiaUserInfo: esiaUserInfo,
                    external: external));

        /// <inheritdoc cref="CreateExportChargesRequest(ExportChargesKind, TimeIntervalType, Beneficiary[], KBKType[], EsiaUserInfoType, External?)" />
        public string ExportCharges(ExportChargesKind kind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = null, KBKType[] kbk = null)
            => ReadyRequest(
                request: CreateExportChargesRequest(
                    kind: kind,
                    timeInterval: timeInterval,
                    beneficiary: beneficiary,
                    kbk: kbk));
        #endregion

        public ExportChargesResponse CreateExportChargesResponse(bool hasMore, ChargeInfo[] chargeInfo = default, bool? needReRequest = default)
            => new ExportChargesResponse(
                config: ResponseConfig,
                hasMore: hasMore,
                chargeInfo: chargeInfo,
                needReRequest: needReRequest);
    }
}
