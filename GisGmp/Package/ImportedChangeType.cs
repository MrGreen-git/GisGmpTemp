using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public class ImportedChangeType
    {
        [XmlElement("ClarificationId", typeof(string))]
        [XmlElement("IncomeId", typeof(string))]
        [XmlElement("PaymentId", typeof(string))]
        [XmlElement("RefundId", typeof(string))]
        [XmlElement("RenouncementID", typeof(string))]
        [XmlElement("SupplierBillId", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item { get; set; }

        [XmlIgnore]
        public ItemChoiceType1 ItemElementName { get; set; }

        /// <summary>
        /// Изменяемые поля
        /// </summary>
        [XmlElement("Change")]
        public ChangeType[] Change { get; set; }

        /// <summary>
        /// Сведения о статусе и основаниях изменения
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public ChangeStatus ChangeStatus { get; set; }

        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }

        /// <summary>
        /// Идентификатор изменяемого извещения в пакете
        /// </summary>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
