using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0", IsNullable = false)]
    public class RenouncementPackage : PackageType
    {
        /// <summary/>
        protected RenouncementPackage() { }

        /// <summary/>
        public RenouncementPackage(ImportedRenouncementType[] importedRenouncements) => ImportedRenouncemens = importedRenouncements;


        [XmlIgnore]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new ImportedChangeType[] ImportedChanges { get => throw new NotSupportedException(); }

        [XmlIgnore]
        public ImportedRenouncementType[] ImportedRenouncemens
        {
            get => Items as ImportedRenouncementType[];
            set => Items = value;
        }
    }
}
