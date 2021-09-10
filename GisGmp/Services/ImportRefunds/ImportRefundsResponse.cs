using GisGmp.Common;
using GisGmp.Services.ImportCharges;

namespace GisGmp.Services.ImportRefunds
{
    /// <summary>
    /// Ответ на запрос приема информации о возврате
    /// </summary>
    public class ImportRefundsResponse : ImportPackageResponseType
    {
        /// <summary/>
        //protected ImportRefundsResponse() { }

        public ImportRefundsResponse(ResponseType config, ImportProtocolType[] importProtocol)
            : base(config, importProtocol) { }
    }
}
