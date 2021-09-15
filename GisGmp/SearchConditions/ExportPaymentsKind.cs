using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <summary>
    /// Тип запроса на предоставление информации об уплате
    /// </summary>
    [Serializable]
    public enum ExportPaymentsKind
    {
        /// <summary>
        /// PAYMENT — все активные (неаннулированные) платежи
        /// </summary>
        [XmlEnum("PAYMENT")]
        Payment,

        /// <summary>
        /// PAYMENTMODIFIED — все платежи, имеющие статус уточнения (ChangeStatus@meaning имеет значение «2») или статус аннулирования (ChangeStatus@meaning имеет значение «3»)
        /// </summary>
        [XmlEnum("PAYMENTMODIFIED")]
        PaymentModified,

        /// <summary>
        /// ­PAYMENTUNMATCHED — все активные (неаннулированные) платежи, для которых в системе отсутствуют соответствующие начисления (не создана ни одна квитанция)
        /// </summary>
        [XmlEnum("PAYMENTUNMATCHED")]
        PaymentUnmatched,

        /// <summary>
        /// PAYMENTCANCELLED — аннулированные платежи (ChangeStatus@meaning имеет значение «3»);
        /// </summary>
        [XmlEnum("PAYMENTCANCELLED")]
        PaymentCancelled,

        /// <summary>
        /// PAYMENTMAINCHARGE — запрос платежей по связанным начислениям (используется только ФССП)
        /// </summary>
        [XmlEnum("PAYMENTMAINCHARGE")]
        PaymentMainCharge,

        /// <summary>
        /// ­PAYMENT-PART-SERVICE - запрос неаннулированных платежей, содержащих дополнительную информацию о частичном предоставлении услуги
        /// </summary>
        [XmlEnum("PAYMENT-PART-SERVICE")]
        PaymentPartService
    }
}
