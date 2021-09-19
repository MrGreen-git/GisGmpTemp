using GisGmp.Common;
using GisGmp.Services.ImportCharges;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportClarification
{
    /// <summary>
    /// Ответ на запрос об уточнении вида и принадлежности платежа
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-clarification/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-clarification/2.4.0", IsNullable = false)]
    public class ImportClarificationResponse : ImportPackageResponseType
    {
        /// <summary/>
        protected ImportClarificationResponse() { }

        public ImportClarificationResponse(ResponseType config, ImportProtocolType[] importProtocol)
            : base(config, importProtocol)
        { 
        }
    }
}
