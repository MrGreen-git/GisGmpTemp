using GisGmp.Services.ImportCharges;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ImportChargesRequest CreateImportChargesRequest()
        {
            return new ImportChargesRequest();
        }

        public string ImportCharges()
            => ReadyRequest(CreateImportChargesRequest());


        public ImportChargesResponse CreateImportChargesResponse()
        {
            return new ImportChargesResponse();
        }
    }
}
