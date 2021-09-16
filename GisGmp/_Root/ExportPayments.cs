using GisGmp.Common;
using GisGmp.SearchConditions;
using GisGmp.Services.ExportPayments;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ExportPaymentsRequest CreateExportPaymentsRequest(ExportPaymentsKind paymentsKind, SupplierBillIDType[] uin, TimeIntervalType timeInterval = default)
            => new ExportPaymentsRequest(
                config: ExportRequestConfig,
                exportConditions: new PaymentsExportConditions(
                    kind: paymentsKind,
                    conditions: new ChargesConditionsType(
                        supplierBillID: uin,
                        timeInterval: timeInterval)));

        public ExportPaymentsRequest CreateExportPaymentsRequest(ExportPaymentsKind paymentsKind, UIP[] uip)
            => new ExportPaymentsRequest(
                config: ExportRequestConfig,
                exportConditions: new PaymentsExportConditions(
                    kind: paymentsKind,
                    conditions: new PaymentsConditionsType(uip)));

        public ExportPaymentsRequest CreateExportPaymentsRequest(ExportPaymentsKind paymentsKind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = default, KBKType[] kbk = default)
            => new ExportPaymentsRequest(
                config: ExportRequestConfig,
                exportConditions: new PaymentsExportConditions(
                    kind: paymentsKind,
                    conditions: new TimeConditionsType(
                        timeInterval: timeInterval,
                        beneficiary: beneficiary, 
                        kbkList: kbk)));


        #region ReadyRequest
        /// <inheritdoc cref="CreateExportPaymentsRequest(ExportPaymentsKind, SupplierBillIDType[], TimeIntervalType)"/>
        public string ExportPayments(ExportPaymentsKind paymentsKind, SupplierBillIDType[] uin, TimeIntervalType timeInterval = default)
            => ReadyRequest(
                request: CreateExportPaymentsRequest(
                    paymentsKind: paymentsKind, 
                    uin: uin, 
                    timeInterval: timeInterval));

        /// <summary/>
        //public string ExportPayments(ExportPaymentsKind paymentsKind, IPayerInnOrId[] payerInnOrId, TimeIntervalType timeInterval = default, KBKType[] kbk = default)
        //    => ReadyRequest(
        //        request: CreateExportPaymentsRequest(
        //            paymentKind: paymentsKind, 
        //            payerInnOrId: payerInnOrId, 
        //            timeInterval: timeInterval, 
        //            kbkList: kbk));

        /// <inheritdoc cref="CreateExportPaymentsRequest(ExportPaymentsKind, UIP[])"/>
        public string ExportPayments(ExportPaymentsKind paymentsKind, UIP[] uip)
            => ReadyRequest(
                request: CreateExportPaymentsRequest(
                    paymentsKind: paymentsKind, 
                    uip: uip));

        /// <inheritdoc cref="CreateExportPaymentsRequest(ExportPaymentsKind, TimeIntervalType, Beneficiary[], KBKType[])"/>
        public string ExportPayments(ExportPaymentsKind paymentsKind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = default, KBKType[] kbk = default)
            => ReadyRequest(
                request: CreateExportPaymentsRequest(
                    paymentsKind: paymentsKind, 
                    timeInterval: timeInterval, 
                    beneficiary: beneficiary, 
                    kbk: kbk));
        #endregion

        public ExportPaymentsResponse CreateExportPaymentsResponse(bool hasMore, PaymentInfo[] paymentInfo = default)
            => new ExportPaymentsResponse(
                config: ResponseConfig,
                hasMore: hasMore,
                paymentInfo: paymentInfo);
    }
}
