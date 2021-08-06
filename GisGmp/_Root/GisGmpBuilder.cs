using GisGmp.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace GisGmp
{
    public delegate string CallBackData(XmlDocument xmlData, string reference);

    public partial class GisGmpBuilder
    {
        public CallBackData CallBackReadyRequest { get; set; }

        #region Test
        string TestIdField;
        DateTime? TestTimestampField;

        public bool TestEnable { get; set; }

        public string TestId
        {
            get => TestIdField ?? throw new Exception($"Не присвоено значение свойству {nameof(TestId)}");
            set => TestIdField = value;
        }

        public DateTime TestTimestamp
        {
            get => TestTimestampField ?? throw new Exception($"Не присвоено значение свойству {nameof(TestTimestamp)}");
            set => TestTimestampField = value;
        }
        #endregion

        #region ExportRequestConfig
        #region RequestConfig

        string SenderIdentifierField;
        string SenderRoleField;

        private string Id
        {
            get => TestEnable ? TestId : $@"G_{Guid.NewGuid()}";
        }
        
        private DateTime Timestamp
        {
            get => TestEnable ? TestTimestamp : DateTime.Now;
        }

        public URNType SenderIdentifier
        {
            get => SenderIdentifierField ?? throw new Exception($"Не присвоено значение свойству {nameof(SenderIdentifier)}");
            set => SenderIdentifierField = value;
        }

        public string SenderRole
        {
            get => SenderRoleField ?? throw new Exception($"Не присвоено значение свойству {nameof(SenderRole)}");
            set => SenderRoleField = value;
        }
        #endregion

        int? PageNumberField;
        int? PageLengthField;

        public int PageNumber
        {
            get => PageNumberField ?? throw new Exception($"Не присвоено значение свойству {nameof(PageNumber)}");
            set => PageNumberField = value;
        }

        public int PageLength
        {
            get => PageLengthField ?? throw new Exception($"Не присвоено значение свойству {nameof(PageLength)}");
            set => PageLengthField = value;
        }

        /// <summary/>
        public URNType OriginatorId { get; set; }
        #endregion

        #region ResponseRequest
        string RqIdField;
        string RecipientIdentifierField;

        public string RqId
        {
            get => RqIdField ?? throw new Exception($"Не присвоено значение свойству {nameof(RqId)}");
            set => RqIdField = value;
        }

        public URNType RecipientIdentifier
        {
            get => RecipientIdentifierField ?? throw new Exception($"Не присвоено значение свойству {nameof(RecipientIdentifier)}");
            set => RecipientIdentifierField = value;
        }
        #endregion

        private RequestType RequestConfig
        {
            get => new RequestType(
                id: Id,
                senderIdentifier: SenderIdentifier,
                senderRole: SenderRole,
                timestamp: Timestamp
                );
        }

       
        private ExportRequestType ExportRequestConfig
        {
            get => new ExportRequestType(
                request: RequestConfig,
                originatorId: OriginatorId,
                paging: new PagingType(PageNumber.ToString(), PageLength.ToString())
                );
        }

        
        private ResponseType ResponseConfig
        {
            get => new ResponseType(
                id: Id,
                rqId: RqId,
                recipientIdentifier: RecipientIdentifier,
                timestamp: Timestamp
                );
        }

        private string ReadyRequest<T>(T request) where T : RequestType
        {
            Validator.IsNull(value: CallBackReadyRequest, name: nameof(CallBackReadyRequest));
            return CallBackReadyRequest(SerializerObject(request, true), request.Id);
        }
    }
}
