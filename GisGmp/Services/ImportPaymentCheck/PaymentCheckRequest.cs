using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportPaymentCheck
{
    /// <summary>
    /// Прием запроса проверки значений реквизитов распоряжения о переводе денежных средств
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-paymentcheck/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-paymentcheck/2.4.0", IsNullable = false)]
    public class PaymentCheckRequest : RequestType
    {
        /// <summary/>
        protected PaymentCheckRequest() { }

        public PaymentCheckRequest(RequestType config, PaymentTemplate template)
            : base(config) => PaymentTemplate = template;


        PaymentTemplate PaymentTemplateField;

        /// <summary>
        /// Данные необходимые для приема информации об уплате
        /// </summary>
        public PaymentTemplate PaymentTemplate 
        { 
            get => PaymentTemplateField;
            set => PaymentTemplateField = value;
        }
    }
}
