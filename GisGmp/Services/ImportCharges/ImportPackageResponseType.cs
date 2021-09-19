using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportCharges
{
    
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    [XmlRoot("ImportPackageResponse", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-charges/2.4.0", IsNullable = false)]
    public class ImportPackageResponseType : ResponseType
    {
        /// <summary/>
        protected ImportPackageResponseType() { }

        public ImportPackageResponseType(ResponseType config, ImportProtocolType[] importProtocol)
            : base(config) => ImportProtocol = importProtocol;

        [XmlElement("ImportProtocol")]
        public ImportProtocolType[] ImportProtocol { get; set; }
    }
}
