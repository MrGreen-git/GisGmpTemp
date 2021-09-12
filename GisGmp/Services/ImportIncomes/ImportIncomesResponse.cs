using GisGmp.Common;
using GisGmp.Services.ImportCharges;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportIncomes
{
    /// <summary>
    /// Ответ на запрос приема информации о зачислении
    /// </summary>
    [Serializable]
    [XmlRoot("ImportIncomesResponse", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-incomes/2.4.0")]
    public class ImportIncomesResponse : ImportPackageResponseType
    {
        /// <summary/>
        protected ImportIncomesResponse() { }

        public ImportIncomesResponse(ResponseType config, ImportProtocolType[] importProtocol)
            : base(config, importProtocol) { }
    }
}
