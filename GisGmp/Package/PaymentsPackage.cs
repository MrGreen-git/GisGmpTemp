using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0", IsNullable = false)]
    public class PaymentsPackage : PackageType
    {
        /// <summary/>
        protected PaymentsPackage() { }

        /// <summary/>
        public PaymentsPackage(ImportedPaymentType[] importedPayments) => ImportedPayments = importedPayments;
        /// <summary/>
        public PaymentsPackage(ImportedChangeType[] importedChanges) => ImportedChanges = importedChanges;

        [XmlIgnore]
        public ImportedPaymentType[] ImportedPayments
        {
            get => Items as ImportedPaymentType[];
            set => Items = value;
        }
    }
}
