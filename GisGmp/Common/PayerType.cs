using GisGmp.Payment;
using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{   
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class PayerType
    {
        protected PayerType() { }

        /// <summary/>
        public PayerType(string payerIdentifier) => PayerIdentifier = payerIdentifier;

        /// <summary>
        /// Поле номер 201: Идентификатор плательщика
        /// </summary>
        [XmlAttribute("payerIdentifier")]
        public string PayerIdentifier { get; set; }
    }
}
