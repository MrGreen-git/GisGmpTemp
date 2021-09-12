﻿using GisGmp.Common;
using GisGmp.Quittance;
using GisGmp.SearchConditions;
using GisGmp.Services.ExportQuittances;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ExportQuittancesRequest CreateExportQuittancesRequest(ExportQuittancesKind quittancesKind, SupplierBillIDType[] uin, TimeIntervalType timeInterval = default)
        {
            return new ExportQuittancesRequest(
                config: ExportRequestConfig,
                exportConditions: new QuittancesExportConditions(
                    kind: quittancesKind,
                    conditions: new ChargesConditionsType(
                        supplierBillID: uin,
                        timeInterval: timeInterval)));
        }

        public ExportQuittancesRequest CreateExportQuittancesRequest(ExportQuittancesKind quittancesKind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = default, KBKType[] kbk = default)
        {
            return new ExportQuittancesRequest(
                config: ExportRequestConfig,
                exportConditions: new QuittancesExportConditions(
                    kind: quittancesKind,
                    conditions: new TimeConditionsType(
                        timeInterval: timeInterval,
                        beneficiary: beneficiary,
                        kbkList: kbk)));
        }


        /// <inheritdoc cref="CreateExportQuittancesRequest(ExportQuittancesKind, SupplierBillIDType[], TimeIntervalType)"/>
        public string ExportQuittances(ExportQuittancesKind quittancesKind, SupplierBillIDType[] uin, TimeIntervalType timeInterval = default)
            => ReadyRequest(CreateExportQuittancesRequest(quittancesKind, uin, timeInterval));


        /// <inheritdoc cref="CreateExportQuittancesRequest(ExportQuittancesKind, TimeIntervalType, Beneficiary[], KBKType[])"/>
        public string ExportQuittances(ExportQuittancesKind quittancesKind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = default, KBKType[] kbk = default)
            => ReadyRequest(CreateExportQuittancesRequest(quittancesKind, timeInterval, beneficiary, kbk));

        public ExportQuittancesResponse CreateExportQuittancesResponse(bool hasMore, QuittanceType[] quittance)
        {
            return new ExportQuittancesResponse(
                config: ResponseConfig,
                hasMore: hasMore,
                quittance: quittance);
        }
    }
}
