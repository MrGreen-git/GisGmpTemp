using GisGmp.Common;
using GisGmp.Services.ImportCharges;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportRefunds
{
    /// <summary>
    /// Ответ на запрос приема информации о возврате
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-refunds/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-refunds/2.4.0", IsNullable = false)]
    public class ImportRefundsResponse : ImportPackageResponseType
    {
        /// <summary/>
        protected ImportRefundsResponse() { }

        public ImportRefundsResponse(ResponseType config, ImportProtocolType[] importProtocol)
            : base(config, importProtocol) { }
    }
}
