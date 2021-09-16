using GisGmp.Charge;
using GisGmp.Services.ImportChargestemplate;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public ChargeCreationRequest CreateImportChargesTemplateRequest(ChargeTemplateType chargeTemplateType)
            => new ChargeCreationRequest(
                config: RequestConfig,
                chargeTemplate: chargeTemplateType);

        #region ReadyRequest
        /// <summary/>
        public string ImportChargesTemplate(ChargeTemplateType chargeTemplateType)
            => ReadyRequest(
                request: CreateImportChargesTemplateRequest(
                    chargeTemplateType: chargeTemplateType));
        #endregion

        /// <summary/>
        public ChargeCreationResponse CreateImportChargesTemplateResponse(ChargeType charge)
            => new ChargeCreationResponse(
                config: ResponseConfig,
                charge: charge);
    }
}
