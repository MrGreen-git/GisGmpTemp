using GisGmp.Charge;
using GisGmp.Services.ImportChargestemplate;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ChargeCreationRequest CreateImportChargesTemplateRequest()
        {
            return new ChargeCreationRequest();
        }

        public string ImportChargesTemplate()
            => ReadyRequest(CreateImportChargesTemplateRequest());


        public ChargeCreationResponse CreateImportChargesTemplateResponse(ChargeType charge)
        {
            return new ChargeCreationResponse();
        }
    }
}
