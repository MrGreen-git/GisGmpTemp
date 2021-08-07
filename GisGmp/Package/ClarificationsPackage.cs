using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0", IsNullable = false)]
    public class ClarificationsPackage : PackageType
    {
        /// <summary/>
        protected ClarificationsPackage() { }

        /// <summary/>
        public ClarificationsPackage(ImportedClarificationType[] importedClarification) => ImportedClarification = importedClarification;

        /// <summary/>
        public ClarificationsPackage(ImportedChangeType[] importedChanges) => ImportedChanges = importedChanges;


        [XmlIgnore]
        public ImportedClarificationType[] ImportedClarification
        {
            get => Items as ImportedClarificationType[];
            set => Items = value;
        }
    }
}
