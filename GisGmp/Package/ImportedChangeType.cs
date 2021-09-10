using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public class ImportedChangeType
    {
        /// <summary>
        protected ImportedChangeType() { }

        public ImportedChangeType(
            string item,
            ChangeStatus changeStatus,
            string id
            )
        { 
            Item = item;
            ChangeStatus = changeStatus;
            Id = id;
        }

        /// <summary>
        /// required
        /// </summary>
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
        /// Изменяемые поля | not required
        /// </summary>
        [XmlElement("Change")]
        public ChangeType[] Change { get; set; }

        /// <summary>
        /// Сведения о статусе и основаниях изменения | required
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public ChangeStatus ChangeStatus { get; set; }

        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего сущность | not required
        /// </summary>
        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }

        /// <summary>
        /// Идентификатор изменяемого извещения в пакете | required
        /// </summary>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
