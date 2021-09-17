using GisGmp.Common;
using GisGmp.SearchConditions;
using GisGmp.Services.ExportIncomes;
using System;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="incomesKind"></param>
        /// <param name="supplierBillID"></param>
        /// <param name="timeInterval"></param>
        /// <returns></returns>
        public ExportIncomesRequest CreateExportIncomesRequest(ExportIncomesKind incomesKind, SupplierBillIDType[] supplierBillID, TimeIntervalType timeInterval)
         => new ExportIncomesRequest(
             config: ExportRequestConfig,
             exportConditions: new IncomesExportConditions(
                 kind: incomesKind,
                 conditions: new ChargesConditionsType(
                     supplierBillID: supplierBillID,
                     timeInterval: timeInterval)));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="incomesKind"></param>
        /// <param name="incomeId"></param>
        /// <returns></returns>
        public ExportIncomesRequest CreateExportIncomesRequest(ExportIncomesKind incomesKind, string[] incomeId)
         => new ExportIncomesRequest(
             config: ExportRequestConfig,
             exportConditions: new IncomesExportConditions(
                 kind: incomesKind,
                 conditions: new IncomesConditionsType(
                     incomeId: incomeId)));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="incomesKind"></param>
        /// <param name="timeInterval"></param>
        /// <param name="beneficiary"></param>
        /// <param name="kbk"></param>
        /// <returns></returns>
        public ExportIncomesRequest CreateExportIncomesRequest(ExportIncomesKind incomesKind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = default, KBKType[] kbk = default)
         => new ExportIncomesRequest(
             config: ExportRequestConfig,
             exportConditions: new IncomesExportConditions(
                 kind: incomesKind,
                 conditions: new TimeConditionsType(
                     timeInterval: timeInterval,
                     beneficiary: beneficiary,
                     kbkList: kbk)));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="incomesKind"></param>
        /// <param name="uip"></param>
        /// <returns></returns>
        public ExportIncomesRequest CreateExportIncomesRequest(ExportIncomesKind incomesKind, UIP[] uip)
         => new ExportIncomesRequest(
             config: ExportRequestConfig,
             exportConditions: new IncomesExportConditions(
                 kind: incomesKind,
                 conditions: new PaymentsConditionsType(
                     uip: uip)));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="incomesKind"></param>
        /// <param name="payerId"></param>
        /// <param name="beneficiary"></param>
        /// <returns></returns>
        public ExportIncomesRequest CreateExportIncomesRequest(ExportIncomesKind incomesKind, PayerId[] payerId, Beneficiary[] beneficiary)
         => new ExportIncomesRequest(
             config: ExportRequestConfig,
             exportConditions: new IncomesExportConditions(
                 kind: incomesKind,
                 conditions: new PayersConditionsType(
                     payerId: payerId,
                     beneficiary: beneficiary)));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="incomesKind"></param>
        /// <param name="payerInn"></param>
        /// <param name="beneficiary"></param>
        /// <returns></returns>
        public ExportIncomesRequest CreateExportIncomesRequest(ExportIncomesKind incomesKind, INNType[] payerInn, Beneficiary[] beneficiary)
         => new ExportIncomesRequest(
             config: ExportRequestConfig,
             exportConditions: new IncomesExportConditions(
                 kind: incomesKind,
                 conditions: new PayersConditionsType(
                     payerInn: payerInn,
                     beneficiary: beneficiary)));

        #region ReadyRequest
        /// <inheritdoc cref="CreateExportIncomesRequest(ExportIncomesKind incomesKind, SupplierBillIDType[] supplierBillID, TimeIntervalType timeInterval)"/>
        public string ExportIncomes(ExportIncomesKind incomesKind, SupplierBillIDType[] supplierBillID, TimeIntervalType timeInterval)
            => ReadyRequest(
                request: CreateExportIncomesRequest(
                    incomesKind: incomesKind,
                    supplierBillID: supplierBillID,
                    timeInterval: timeInterval));


        /// <inheritdoc cref="CreateExportIncomesRequest(ExportIncomesKind incomesKind, string[] incomeId)"/>
        public string ExportIncomes(ExportIncomesKind incomesKind, string[] incomeId)
            => ReadyRequest(
                request: CreateExportIncomesRequest(
                    incomesKind: incomesKind,
                    incomeId: incomeId));


        /// <inheritdoc cref="CreateExportIncomesRequest(ExportIncomesKind incomesKind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = default, KBKType[] kbk = default)"/>
        public string ExportIncomes(ExportIncomesKind incomesKind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = default, KBKType[] kbk = default)
            => ReadyRequest(
                request: CreateExportIncomesRequest(
                    incomesKind: incomesKind,
                    timeInterval: timeInterval,
                    beneficiary: beneficiary,
                    kbk: kbk));


        /// <inheritdoc cref="CreateExportIncomesRequest(ExportIncomesKind incomesKind, UIP[] uip)"/>
        public string ExportIncomes(ExportIncomesKind incomesKind, UIP[] uip)
            => ReadyRequest(
                request: CreateExportIncomesRequest(
                    incomesKind: incomesKind,
                    uip: uip));


        /// <inheritdoc cref="CreateExportIncomesRequest(ExportIncomesKind incomesKind, PayerId[] payerId, Beneficiary[] beneficiary)"/>
        public string ExportIncomes(ExportIncomesKind incomesKind, PayerId[] payerId, Beneficiary[] beneficiary)
            => ReadyRequest(
                request: CreateExportIncomesRequest(
                    incomesKind: incomesKind,
                    payerId: payerId,
                    beneficiary: beneficiary));


        /// <inheritdoc cref="CreateExportIncomesRequest(ExportIncomesKind incomesKind, INNType[] payerInn, Beneficiary[] beneficiary)"/>
        public string ExportIncomes(ExportIncomesKind incomesKind, INNType[] payerInn, Beneficiary[] beneficiary)
            => ReadyRequest(
                request: CreateExportIncomesRequest(
                    incomesKind: incomesKind,
                    payerInn: payerInn,
                    beneficiary: beneficiary));
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hasMore"></param>
        /// <param name="incomeInfo"></param>
        /// <returns></returns>
        public ExportIncomesResponse CreateExportIncomesResponse(bool hasMore, IncomeInfo[] incomeInfo = default)
            =>  new ExportIncomesResponse(
                config: ResponseConfig, 
                hasMore: hasMore, 
                incomeInfo: incomeInfo);
    }
}
