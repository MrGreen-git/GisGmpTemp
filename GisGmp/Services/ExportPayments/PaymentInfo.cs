using GisGmp.Common;
using GisGmp.Payment;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    /// <summary>
    /// Извещение о приеме к исполнению распоряжения (платеж)
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
    public class PaymentInfo : PaymentType
    {
        /// <summary>
        /// Обозначение факта квитирования платежа с начисление либо признака у платежа "Услуга предоставлена"
        /// </summary>
        public AcknowledgmentInfo AcknowledgmentInfo { get; set; }

        /// <summary>
        /// Сведения о возвратах денежных средств. Присутствует в ответе на запрос предоставления информации об уплате в случае осуществления возврата денежных средств
        /// </summary>
        [XmlElement("RefundInfo")]
        public RefundInfo[] RefundInfo { get; set; }

        /// <summary>
        /// Сведения о статусе платежа и основаниях его изменения
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public ChangeStatusInfo ChangeStatusInfo { get; set; }
    }
}
