using GisGmp.Quittance;
using GisGmp.Services.ForcedAckmowledgement;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>     
        public ForcedAcknowledgementRequest CreateForcedAcknowledgementRequest(AnnulmentReconcile annulmentReconcile)
            => new ForcedAcknowledgementRequest(
                    config: RequestConfig,
                    originatorId: OriginatorId,
                    annulmentReconcile: annulmentReconcile);

        /// <summary/>
        public ForcedAcknowledgementRequest CreateForcedAcknowledgementRequest(AnnulmentServiceProvided annulmentServiceProvided)
            => new ForcedAcknowledgementRequest(
                    config: RequestConfig,
                    originatorId: OriginatorId,
                    annulmentServiceProvided: annulmentServiceProvided);

        /// <summary/>
        public ForcedAcknowledgementRequest CreateForcedAcknowledgementRequest(Reconcile reconcile)
            => new ForcedAcknowledgementRequest(
                    config: RequestConfig,
                    originatorId: OriginatorId,
                    reconcile: reconcile);

        /// <summary/>
        public ForcedAcknowledgementRequest CreateForcedAcknowledgementRequest(ServiceProvided serviceProvided)
            => new ForcedAcknowledgementRequest(
                    config: RequestConfig,
                    originatorId: OriginatorId,
                    serviceProvided: serviceProvided);

        #region ReadyRequest
        /// <summary/>
        public string ForcedAcknowledgement(AnnulmentReconcile annulmentReconcile)
            => ReadyRequest(
                request: CreateForcedAcknowledgementRequest(
                    annulmentReconcile: annulmentReconcile));

        /// <summary/>
        public string ForcedAcknowledgement(AnnulmentServiceProvided annulmentServiceProvided)
            => ReadyRequest(
                request: CreateForcedAcknowledgementRequest(
                    annulmentServiceProvided: annulmentServiceProvided));

        /// <summary/>
        public string ForcedAcknowledgement(Reconcile reconcile)
            => ReadyRequest(
                request: CreateForcedAcknowledgementRequest(
                    reconcile: reconcile));

        /// <summary/>
        public string ForcedAcknowledgement(ServiceProvided serviceProvided)
            => ReadyRequest(
                request: CreateForcedAcknowledgementRequest(
                    serviceProvided: serviceProvided));
        #endregion

        /// <summary/>
        public ForcedAcknowledgementResponse CreateForcedAcknowledgementResponse(bool[] done)
            => new ForcedAcknowledgementResponse(
                config: ResponseConfig,
                done: done);

        /// <summary/>
        public ForcedAcknowledgementResponse CreateForcedAcknowledgementResponse(QuittanceType[] quittances)
            => new ForcedAcknowledgementResponse(
                config: ResponseConfig,
                quittances: quittances);
    }
}
