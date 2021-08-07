using System;
using System.Xml.Serialization;
using System.Linq;

namespace GisGmp.Package
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public class PackageType
    {
        [XmlElement("ImportedChange", typeof(ImportedChangeType))]
        [XmlElement("ImportedCharge", typeof(ImportedChargeType))]
        [XmlElement("ImportedClarification", typeof(ImportedClarificationType))]
        [XmlElement("ImportedIncome", typeof(ImportedIncomeType))]
        [XmlElement("ImportedPayment", typeof(ImportedPaymentType))]
        [XmlElement("ImportedRefund", typeof(ImportedRefundType))]
        [XmlElement("ImportedRenouncement", typeof(ImportedRenouncementType))]
        public object[] Items 
        {
            get => ItemsField;
            set
            {
                if(
                    new []{
                        typeof(ImportedChangeType[]),
                        typeof(ImportedChargeType[]),
                        typeof(ImportedClarificationType[]),
                        typeof(ImportedIncomeType[]),
                        typeof(ImportedPaymentType[]),
                        typeof(ImportedRefundType[]),
                        typeof(ImportedRenouncementType[])
                    }.Any(type => type == value.GetType())
                ) throw new Exception($"{nameof(PackageType)}.{nameof(Items)} Недопустимый тип");

                ItemsField = Validator.ArrayObj(value: value, name: nameof(Items), required: true, min: 1, max: 100);
            }
        }

        object[] ItemsField;

        [XmlIgnore]
        public ImportedChangeType[] ImportedChanges  
        {
            get => Items as ImportedChangeType[];
            set => Items = value;
        }
    }
}
