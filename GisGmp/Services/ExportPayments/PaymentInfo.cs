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
        /// <summary/>
        protected PaymentInfo() { }

        public PaymentInfo(ChangeStatusInfo changeStatusInfo, PaymentType payment) 
            : base(payment) => ChangeStatusInfo = changeStatusInfo;
        

        /// <summary>
        /// Обозначение факта квитирования платежа с начислением либо установление у платежа признака «Услуга предоставлена» | not required
        /// </summary>
        public AcknowledgmentInfo AcknowledgmentInfo { get; set; }

        /// <summary>
        /// Сведения о возвратах денежных средств | not required
        /// </summary>
        [XmlElement("RefundInfo")]
        public RefundInfo[] RefundInfo { get; set; }

        /// <summary>
        /// Сведения о статусе извещения о приеме к исполнению распоряжения и основаниях изменения | required
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public ChangeStatusInfo ChangeStatusInfo { get; set; }
    }
}
