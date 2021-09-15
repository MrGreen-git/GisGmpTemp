using GisGmp.Common;
using GisGmp.SearchConditions;
using GisGmp.Services.ExportCharges;
using System;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ExportChargesRequest CreateExportChargesRequest(ExportChargesKind chargesKind, SupplierBillIDType[] supplierBillID, TimeIntervalType timeInterval = default, EsiaUserInfoType esiaUserInfo = default, External? external = default)
        {
            return new ExportChargesRequest(
                config: ExportRequestConfig,
                exportConditions: new ChargesExportConditions(
                    kind: chargesKind,
                    conditions: new ChargesConditionsType(
                        supplierBillID: supplierBillID,
                        timeInterval: timeInterval)),
                esiaUserInfo: esiaUserInfo,
                external: external);
        }

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

        public ExportChargesRequest CreateExportChargesRequest(ExportChargesKind chargesKind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = default, KBKType[] kbk = default, EsiaUserInfoType esiaUserInfo = default, External? external = default)
        {
            return new ExportChargesRequest(
                config: ExportRequestConfig,
                exportConditions: new ChargesExportConditions(
                    kind: chargesKind,
                    conditions: new TimeConditionsType(
                        timeInterval: timeInterval,
                        beneficiary: beneficiary, 
                        kbkList: kbk)),
                esiaUserInfo: esiaUserInfo,
                external: external);
        }


        /// <inheritdoc cref="CreateExportChargesRequest(ExportChargesKind, SupplierBillIDType[], TimeIntervalType, EsiaUserInfoType, External?)"/>
        public string ExportCharges(ExportChargesKind chargesKind, SupplierBillIDType[] supplierBillID, TimeIntervalType timeInterval = default, EsiaUserInfoType esiaUserInfo = default, External? external = default)
            => ReadyRequest(CreateExportChargesRequest(chargesKind, supplierBillID, timeInterval, esiaUserInfo, external));

        /// <summary/>
        public string ExportCharges(ExportChargesKind chargesKind, IPayerInnOrId[] payerInnOrId, TimeIntervalType timeInterval = null, KBKType[] kbk = null)
            => ReadyRequest(CreateExportChargesRequest(chargesKind, payerInnOrId, timeInterval, kbk));

        /// <inheritdoc craf="CreateExportChargesRequest(ExportChargesKind, TimeIntervalType, Beneficiary[], KBKType[], EsiaUserInfoType, External?)" />
        public string ExportCharges(ExportChargesKind chargesKind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = null, KBKType[] kbk = null)
            => ReadyRequest(CreateExportChargesRequest(chargesKind, timeInterval, beneficiary, kbk));


        public ExportChargesResponse CreateExportChargesResponse(bool hasMore, ChargeInfo[] chargeInfo = default, bool? needReRequest = default)
        {
            return new ExportChargesResponse(
                config: ResponseConfig,
                hasMore: hasMore,
                chargeInfo: chargeInfo,
                needReRequest: needReRequest);
        }
    }
}
