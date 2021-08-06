using GisGmp.Common;
using GisGmp.ImportPaymentCheck;
using GisGmp.Services.ExportPayments;
using System;
using System.Xml.Serialization;

namespace GisGmp.ImportPaymentCheck
{
    /// <summary>
    /// Ответ на запрос проверки значений реквизитов распоряжения о переводе денежных средств
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-paymentcheck/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-paymentcheck/2.4.0", IsNullable = false)]
    public class PaymentCheckResponse : ResponseType
    {
        /// <summary/>
        protected PaymentCheckResponse() { }

        public PaymentCheckResponse(ResponseType config, ImportProtocolType[] importProtocol)
            : base(config, importProtocol) { }

        public ImportProtocol ImportProtocol { get; set; }
    }
}

