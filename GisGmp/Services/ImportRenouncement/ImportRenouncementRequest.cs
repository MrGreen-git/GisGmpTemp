using GisGmp.Common;
using GisGmp.Package;
using System;
using System.Xml.Serialization;

namespace GisGmp.Service.ImportRenouncement
{
    /// <summary>
    /// Прием извещения об отказе в возбуждении исполнительного производства
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-Renouncement/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-Renouncement/2.4.0", IsNullable = false)]
    public class ImportRenouncementRequest : RequestType
    {
        /// <summary/>
        protected ImportRenouncementRequest() { }

        /// <summary/>
        public ImportRenouncementRequest(RequestType config, RenouncementPackage package) 
            : base(config) => RenouncementPackage = package;


        RenouncementPackage RenouncementPackageField;

        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
        public RenouncementPackage RenouncementPackage 
        {
            get => RenouncementPackageField; 
            set => RenouncementPackageField = value;
        }
    }
}
