using GisGmp.Common;
using GisGmp.Services.ImportCharges;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportPayments
{
    /// <summary>
    /// Ответ на запрос приема информации об уплате (информации из распоряжения плательщика)
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-payments/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-payments/2.4.0", IsNullable = false)]
    public class ImportPaymentsResponse : ImportPackageResponseType
    {
        /// <summary/>
        protected ImportPaymentsResponse() { }

        /// <summary/>
        public ImportPaymentsResponse(ResponseType config, ImportProtocolType[] importProtocol)
            : base(config, importProtocol)
        { 
        }
    }
}
