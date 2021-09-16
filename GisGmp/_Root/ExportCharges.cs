using GisGmp.Common;
using GisGmp.SearchConditions;
using GisGmp.Services.ExportCharges;
using System;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public ExportChargesRequest CreateExportChargesRequest(ExportChargesKind chargesKind, SupplierBillIDType[] supplierBillID, TimeIntervalType timeInterval = default, EsiaUserInfoType esiaUserInfo = default, External? external = default)
            => new ExportChargesRequest(
                config: ExportRequestConfig,
                exportConditions: new ChargesExportConditions(
                    kind: chargesKind,
                    conditions: new ChargesConditionsType(
                        supplierBillID: supplierBillID,
                        timeInterval: timeInterval)),
                esiaUserInfo: esiaUserInfo,
                external: external);

        public ExportChargesRequest CreateExportChargesRequest(ExportChargesKind chargesKind, IPayerInnOrId[] payerInnOrId, TimeIntervalType timeInterval = null, KBKType[] kbk = null)
        {
            //return new ExportChargesRequest(
            //    config: ExportRequestConfig(),
            //    exportConditions: new ChargesExportConditions(
            //        kind: chargesKind,
            //        conditions: new PayersConditionsType(payerInnOrId, timeInterval, kbk)
            //        )
            //    );

            throw new NotImplementedException();
        }

        /// <summary/>
        public ExportChargesRequest CreateExportChargesRequest(ExportChargesKind chargesKind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = default, KBKType[] kbk = default, EsiaUserInfoType esiaUserInfo = default, External? external = default)
            => new ExportChargesRequest(
                config: ExportRequestConfig,
                exportConditions: new ChargesExportConditions(
                    kind: chargesKind,
                    conditions: new TimeConditionsType(
                        timeInterval: timeInterval,
                        beneficiary: beneficiary, 
                        kbkList: kbk)),
                esiaUserInfo: esiaUserInfo,
                external: external);

        #region ReadyRequest
        /// <inheritdoc cref="CreateExportChargesRequest(ExportChargesKind, SupplierBillIDType[], TimeIntervalType, EsiaUserInfoType, External?)"/>
        public string ExportCharges(ExportChargesKind chargesKind, SupplierBillIDType[] supplierBillID, TimeIntervalType timeInterval = default, EsiaUserInfoType esiaUserInfo = default, External? external = default)
            => ReadyRequest(
                request: CreateExportChargesRequest(
                    chargesKind: chargesKind,
                    supplierBillID: supplierBillID,
                    timeInterval: timeInterval,
                    esiaUserInfo: esiaUserInfo,
                    external: external));

        /// <summary/>
        public string ExportCharges(ExportChargesKind chargesKind, IPayerInnOrId[] payerInnOrId, TimeIntervalType timeInterval = null, KBKType[] kbk = null)
            => ReadyRequest(
                request: CreateExportChargesRequest(
                    chargesKind: chargesKind,
                    payerInnOrId: payerInnOrId,
                    timeInterval: timeInterval,
                    kbk: kbk));

        /// <inheritdoc craf="CreateExportChargesRequest(ExportChargesKind, TimeIntervalType, Beneficiary[], KBKType[], EsiaUserInfoType, External?)" />
        public string ExportCharges(ExportChargesKind chargesKind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = null, KBKType[] kbk = null)
            => ReadyRequest(
                request: CreateExportChargesRequest(
                    chargesKind: chargesKind,
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
