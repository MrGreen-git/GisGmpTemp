using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public class ChargesConditionsType
    {
        [XmlElement("SupplierBillID")]
        public string[] SupplierBillID { get; set; }

        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public TimeIntervalType TimeInterval { get; set; }

        public PaymentMethodType paymentMethod { get; set; }

        [XmlIgnore]
        public bool paymentMethodSpecified { get; set; }
    }
}
