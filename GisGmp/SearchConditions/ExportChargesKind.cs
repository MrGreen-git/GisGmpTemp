using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    [Serializable]
    public enum ExportChargesKind
    {
        /// <summary>
        /// CHARGE — используется для запроса неоплаченных начислений
        /// </summary>
        [XmlEnum("CHARGE")]
        Charge,

        /// <summary>
        /// CHARGENOTFULLMATCHED — используется для запроса начислений, не полностью сквитированных с платежами (в т.ч. таких, по которым оставшаяся сумма к оплате равна «0», но при этом в начислении и соответствующем ему платеже попарно могут не совпадать какой-либо или несколько атрибутов из следующего набора: КБК, код по ОКТМО, ИНН, КПП, номер счета, БИК, идентификатор плательщика)
        /// </summary>
        [XmlEnum("CHARGENOTFULLMATCHED")]
        ChargeNotFullMatched,

        /// <summary>
        /// CHARGESTATUS — используется для запроса начислений и статусов их квитирования
        /// </summary>
        [XmlEnum("CHARGESTATUS")]
        ChargeStatus,

        /// <summary>
        /// CHARGE-PRIOR — используется для запроса неоплаченных предварительных начислений
        /// </summary>
        [XmlEnum("CHARGE-PRIOR")]
        ChargePrior,

        /// <summary>
        /// CHARGE-PRIOR-NOTFULLMATCHED — используется для запроса предварительных начислений, не полностью сквитированных с платежами
        /// </summary>
        [XmlEnum("CHARGE-PRIOR-NOTFULLMATCHED")]
        ChargePriorNotFullMatched,

        /// <summary>
        /// CHARGE-PRIOR-STATUS — используется для запроса предварительных начислений и статусов их квитирования
        /// </summary>
        [XmlEnum("CHARGE-PRIOR-STATUS")]
        ChargePriorStatus,

        /// <summary>
        /// TEMP-CHARGING — используется для запроса неоплаченных предварительных начислений, сформированных ГИС ГМП
        /// </summary>
        [XmlEnum("TEMP-CHARGING")]
        TempCharging,

        /// <summary>
        /// TEMP-CHARGING-NOTFULLMATCHED — используется для запроса предварительных начислений, сформированных ГИС ГМП, не полностью сквитированных с платежами
        /// </summary>
        [XmlEnum("TEMP-CHARGING-NOTFULLMATCHED")]
        TempChargingNotFullMatched,

        /// <summary>
        /// TEMP-CHARGING-STATUS — используется для запроса предварительных начислений, сформированных ГИС ГМП, и статусов их квитирования
        /// </summary>
        [XmlEnum("TEMP-CHARGING-STATUS")]
        TempChargingStatus,

        /// <summary>
        /// MAINCHARGE — используется для запроса начислений, связанных с начислением, данные которого указаны в параметрах запроса (используется только ФССП)
        /// </summary>
        [XmlEnum("MAINCHARGE")]
        MainCharge,

        /// <summary>
        /// CHARGE-LIST-FULL — используется для запроса активных начислений, статусов их квитирования и дополнительной информации по начислениям (блоки данных «ExecutiveProcedureInfo», «ReconcileWithoutPayment»)
        /// </summary>
        [XmlEnum("CHARGE-LIST-FULL")]
        ChargelistFull,

        /// <summary>
        /// CHARGE-OFFENSE — используется для запроса дополнительной информации административного правонарушения, зафиксированного специальными техническими средствами, работающими в автоматическом режиме
        /// </summary>
        [XmlEnum("CHARGE-OFFENSE")]
        ChargeOffense
    }
}
