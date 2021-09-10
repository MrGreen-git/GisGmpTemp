using GisGmp.Common;
using GisGmp.Services.ImportCharges;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportRenouncement
{
    /// <summary>
    /// Ответ на запрос приема извещения об отказе в возбуждении исполнительного производства
    /// </summary>
    [Serializable]
    [XmlRoot("ImportRenouncementResponse", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-Renouncement/2.4.0")]
    public class ImportRenouncementResponse : ImportPackageResponseType
    {
        /// <summary/>
        //protected ImportRenouncementResponse() { }

        public ImportRenouncementResponse(ResponseType config, ImportProtocolType[] importProtocol)
            : base(config, importProtocol) { }
    }
}
