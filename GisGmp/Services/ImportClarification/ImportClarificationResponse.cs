using GisGmp.Common;
using GisGmp.Services.ImportCharges;

namespace GisGmp.Services.ImportClarification
{
    /// <summary>
    /// Ответ на запрос об уточнении вида и принадлежности платежа
    /// </summary>
    public class ImportClarificationResponse : ImportPackageResponseType
    {
        public ImportClarificationResponse(ResponseType config, ImportProtocolType[] importProtocol)
            : base(config, importProtocol)
        { 
        }
    }
}
