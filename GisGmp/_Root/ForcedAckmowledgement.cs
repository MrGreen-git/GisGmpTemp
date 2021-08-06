using GisGmp.Services.ForcedAckmowledgement;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ForcedAcknowledgementRequest CreateForcedAcknowledgementRequest()
        {
            return new ForcedAcknowledgementRequest();
        }

        public string ForcedAcknowledgement()
            => ReadyRequest(CreateForcedAcknowledgementRequest());


        public ForcedAcknowledgementResponse CreateForcedAcknowledgementResponse()
        {
            return new ForcedAcknowledgementResponse();
        }
    }
}
