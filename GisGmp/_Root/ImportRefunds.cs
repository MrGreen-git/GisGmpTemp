using GisGmp.Services.ImportRefunds;

namespace GisGmp._Root
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public ImportRefundsRequest CreateImportRefundsRequest()
        {
            return new ImportRefundsRequest();
        }
     
        public string ImportRefunds()
            => ReadyRequest(CreateImportRefundsRequest());


        public ImportRefundsResponse CreateImportRefundsResponse()
        {
            return new ImportRefundsResponse();
        }
    }
}
