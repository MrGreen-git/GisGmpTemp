using GisGmp.Services.SubscriptionService;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public SubscriptionServiceRequest CreateSubscriptionServiceRequest(bool exportSubscriptions)
            => new SubscriptionServiceRequest(
                config: RequestConfig,
                exportSubscriptions: exportSubscriptions);

        /// <summary/>
        public SubscriptionServiceRequest CreateSubscriptionServiceRequest(CreateSubscription createSubscription)
            => new SubscriptionServiceRequest(
                config: RequestConfig,
                createSubscription: createSubscription);

        #region ReadyRequest
        /// <summary/>
        public string SubscriptionService(bool exportSubscriptions)
            => ReadyRequest(
                request: CreateSubscriptionServiceRequest(
                    exportSubscriptions: exportSubscriptions));

        /// <summary/>
        public string SubscriptionService(CreateSubscription createSubscription)
            => ReadyRequest(
                request: CreateSubscriptionServiceRequest(
                    createSubscription: createSubscription));
        #endregion

        /// <summary/>
        public SubscriptionServiceResponse CreateSubscriptionServiceResponse(CreateSubscriptionResult[] createSubscriptionResult)
            => new SubscriptionServiceResponse(
                config: ResponseConfig,
                createSubscriptionResult: createSubscriptionResult);

        /// <summary/>
        public SubscriptionServiceResponse CreateSubscriptionServiceResponse(Subscriptions[] subscriptions)
            => new SubscriptionServiceResponse(
                config: ResponseConfig,
                subscriptions: subscriptions);
    }
}
