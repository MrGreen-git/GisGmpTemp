using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0", IsNullable = false)]
    public class RefundsPackage : PackageType
    {
        /// <summary/>
        protected RefundsPackage() { }

        /// <summary/>
        public RefundsPackage(ImportedRefundType[] importedRefunds) => ImportedRefunds = importedRefunds;

        /// <summary/>
        public RefundsPackage(ImportedChangeType[] importedChanges) => ImportedChanges = importedChanges;

        [XmlIgnore]
        public ImportedRefundType[] ImportedRefunds
        {
            get => Items as ImportedRefundType[];
            set => Items = value;
        }
    }
}
