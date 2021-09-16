using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public class PaymentsConditionsType
    {
        /// <summary/>
        protected PaymentsConditionsType() { }

        /// <summary/>
        public PaymentsConditionsType(UIP[] uip)
            => PaymentId = uip.ToArrayString();

        [XmlElement("PaymentId")]
        public string[] PaymentId { get; set; }
    }
}
