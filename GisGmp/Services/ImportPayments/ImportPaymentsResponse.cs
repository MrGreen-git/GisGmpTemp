using GisGmp.Common;
using GisGmp.Services.ImportCharges;
using System;
using System.Collections.Generic;
using System.Text;

namespace GisGmp.Services.ImportPayments
{
    /// <summary>
    /// Ответ на запрос приема информации об уплате (информации из распоряжения плательщика)
    /// </summary>
    public class ImportPaymentsResponse : ImportPackageResponseType
    {
        public ImportPaymentsResponse(ResponseType config, ImportProtocolType[] importProtocol)
            : base(config, importProtocol)
        { 
        }
    }
}
