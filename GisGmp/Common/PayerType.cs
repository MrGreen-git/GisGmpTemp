using GisGmp.Charge;
using GisGmp.Payment;
using GisGmp.Refund;
using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [XmlInclude(typeof(PayeeType))]
    [XmlInclude(typeof(PayerType2))]
    [XmlInclude(typeof(PayerType1))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class PayerType
    {
        /// <summary>
        /// Поле номер 201: Идентификатор плательщика
        /// </summary>
        [XmlAttribute("payerIdentifier")]
        public string PayerIdentifier { get; set; }
    }
}
