using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportPaymentCheck
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

        public PaymentCheckResponse(ResponseType config, ImportProtocolType importProtocol)
            : base(config)
        {
            ImportProtocol = importProtocol;
        }

        //public ImportProtocol ImportProtocol { get; set; }
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")] //TODO исправить эту бредятину разработчиков
        public ImportProtocolType ImportProtocol { get; set; }
    }
}

