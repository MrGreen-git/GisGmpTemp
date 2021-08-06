using GisGmp.SubscriptionService;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public SubscriptionServiceRequest CreateSubscriptionServiceRequest()
        {
            return new SubscriptionServiceRequest();
        }

        public string SubscriptionService()
            => ReadyRequest(CreateSubscriptionServiceRequest());


        public SubscriptionServiceResponse CreateSubscriptionServiceResponse()
        {
            return new SubscriptionServiceResponse();
        }
    }
}
