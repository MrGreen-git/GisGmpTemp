using GisGmp.Common;
using GisGmp.Quittance;
using GisGmp.SearchConditions;
using GisGmp.Services.ExportQuittances;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ExportQuittancesRequest CreateExportQuittancesRequest(ExportQuittancesKind quittancesKind, SupplierBillIDType[] uin, TimeIntervalType timeInterval = default)
            => new ExportQuittancesRequest(
                config: ExportRequestConfig,
                exportConditions: new QuittancesExportConditions(
                    kind: quittancesKind,
                    conditions: new ChargesConditionsType(
                        supplierBillID: uin,
                        timeInterval: timeInterval)));

        public ExportQuittancesRequest CreateExportQuittancesRequest(ExportQuittancesKind quittancesKind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = default, KBKType[] kbk = default)
            => new ExportQuittancesRequest(
                config: ExportRequestConfig,
                exportConditions: new QuittancesExportConditions(
                    kind: quittancesKind,
                    conditions: new TimeConditionsType(
                        timeInterval: timeInterval,
                        beneficiary: beneficiary,
                        kbkList: kbk)));

        #region ReadyRequest
        /// <inheritdoc cref="CreateExportQuittancesRequest(ExportQuittancesKind, SupplierBillIDType[], TimeIntervalType)"/>
        public string ExportQuittances(ExportQuittancesKind quittancesKind, SupplierBillIDType[] uin, TimeIntervalType timeInterval = default)
            => ReadyRequest(
                request: CreateExportQuittancesRequest(
                    quittancesKind: quittancesKind,
                    uin: uin,
                    timeInterval: timeInterval));

        /// <inheritdoc cref="CreateExportQuittancesRequest(ExportQuittancesKind, TimeIntervalType, Beneficiary[], KBKType[])"/>
        public string ExportQuittances(ExportQuittancesKind quittancesKind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = default, KBKType[] kbk = default)
            => ReadyRequest(
                request: CreateExportQuittancesRequest(
                    quittancesKind: quittancesKind,
                    timeInterval: timeInterval,
                    beneficiary: beneficiary,
                    kbk: kbk));
        #endregion

        public ExportQuittancesResponse CreateExportQuittancesResponse(bool hasMore, QuittanceType[] quittance)
            => new ExportQuittancesResponse(
                config: ResponseConfig,
                hasMore: hasMore,
                quittance: quittance);
    }
}
