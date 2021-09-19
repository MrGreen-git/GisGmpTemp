using GisGmp.Common;
using GisGmp.SearchConditions;
using GisGmp.Services.ExportClarification;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        private ExportClarificationRequest CreateExportClarificationRequest(ClarificationsExportConditions exportConditions)
            => new ExportClarificationRequest(
                config: ExportRequestConfig,
                exportConditions: exportConditions);

        public ExportClarificationRequest CreateExportClarificationRequest(ExportClarificationsKind kind, string[] clarificationID)
            => CreateExportClarificationRequest(
                exportConditions: new ClarificationsExportConditions(
                    kind: kind, 
                    conditions: new ClarificationsConditionsType(
                        clarificationID: clarificationID)));

        public ExportClarificationRequest CreateExportClarificationRequest(ExportClarificationsKind kind, string[] incomeId, bool t) //TODO исправть
            => CreateExportClarificationRequest(
                exportConditions: new ClarificationsExportConditions(
                    kind: kind, 
                    conditions: new IncomesConditionsType(
                        incomeId: incomeId)));

        public ExportClarificationRequest CreateExportClarificationRequest(ExportClarificationsKind kind, PayerId[] payerId, Beneficiary[] beneficiary, string[] kbk, TimeIntervalType timeInterval)
            => CreateExportClarificationRequest(
                exportConditions: new ClarificationsExportConditions(
                    kind: kind, 
                    conditions: new PayersConditionsType(
                        payerId: payerId,
                        beneficiary: beneficiary,
                        kBKlist: kbk,
                        timeInterval: timeInterval)));

        public ExportClarificationRequest CreateExportClarificationRequest(ExportClarificationsKind kind, INNType[] payerInn, Beneficiary[] beneficiary, string[] kbk, TimeIntervalType timeInterval)
            => CreateExportClarificationRequest(
                exportConditions: new ClarificationsExportConditions(
                    kind: kind,
                    conditions: new PayersConditionsType(
                        payerInn: payerInn,
                        beneficiary: beneficiary,
                        kBKlist: kbk,
                        timeInterval: timeInterval)));

        public ExportClarificationRequest CreateExportClarificationRequest(ExportClarificationsKind kind, UIP[] uip)
            => CreateExportClarificationRequest(
                exportConditions: new ClarificationsExportConditions(
                    kind: kind, 
                    conditions: new PaymentsConditionsType(
                        uip: uip)));

        public ExportClarificationRequest CreateExportClarificationRequest(ExportClarificationsKind kind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = default, KBKType[] kbk = default)
            => CreateExportClarificationRequest(
                exportConditions: new ClarificationsExportConditions(
                    kind: kind, 
                    conditions: new TimeConditionsType(
                        timeInterval: timeInterval,
                        beneficiary: beneficiary,
                        kbkList: kbk)));

        #region ReadyRequest
        //public string ExportClarification(ExportClarificationsKind kind, ClarificationsConditionsType conditions)
        //    => ReadyRequest(CreateExportClarificationRequest(kind, conditions));

        //public string ExportClarification(ExportClarificationsKind kind, IncomesConditionsType conditions)
        //    => ReadyRequest(CreateExportClarificationRequest(kind, conditions));

        //public string ExportClarification(ExportClarificationsKind kind, PayersConditionsType conditions)
        //    => ReadyRequest(CreateExportClarificationRequest(kind, conditions));

        //public string ExportClarification(ExportClarificationsKind kind, PaymentsConditionsType conditions)
        //    => ReadyRequest(CreateExportClarificationRequest(kind, conditions));

        //public string ExportClarification(ExportClarificationsKind kind, TimeConditionsType conditions)
        //    => ReadyRequest(CreateExportClarificationRequest(kind, conditions));
        #endregion

        public ExportClarificationResponse CreateExportClarificationResponse(bool hasMore, ClarificationInfo[] clarificationInfo = default)
        {
            return new ExportClarificationResponse(
                config: ResponseConfig,
                hasMore: hasMore,
                clarificationInfo: clarificationInfo);
        }
    }
}
