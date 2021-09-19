using GisGmp.Common;
using GisGmp.Services.ImportPaymentCheck;
using System;
using System.Collections.Generic;
using System.Text;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public PaymentCheckRequest CreatePaymentCheckRequest(PaymentTemplate template)
            => new PaymentCheckRequest(
                config: RequestConfig,
                template: template);

        #region ReadyRequest
        /// <summary/>
        public string PaymentCheck(PaymentTemplate template)
            => ReadyRequest(
                request: CreatePaymentCheckRequest(
                    template: template));
        #endregion

        /// <summary/>
        public PaymentCheckResponse CreatePaymentCheckResponse(ImportProtocolType importProtocol)
            => new PaymentCheckResponse(
                config: ResponseConfig,
                importProtocol: importProtocol);
    }
}
