using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public abstract class Conditions
    {
        [XmlElement("ChargesConditions", typeof(ChargesConditionsType))]
        [XmlElement("ClarificationsConditions", typeof(ClarificationsConditionsType))]
        [XmlElement("IncomesConditions", typeof(IncomesConditionsType))]
        [XmlElement("PayersConditions", typeof(PayersConditionsType))]
        [XmlElement("PaymentsConditions", typeof(PaymentsConditionsType))]
        [XmlElement("RefundsConditions", typeof(RefundsConditionsType))]
        [XmlElement("TimeConditions", typeof(TimeConditionsType))]
        [XmlChoiceIdentifier("ItemElementName")]
        public object Item { get; set; }

        [XmlIgnore]
        public ItemChoiceType ItemElementName { get; set; }

        [XmlAttribute]
        public string kind { get; set; }
    }
}
