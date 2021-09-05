using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [XmlInclude(typeof(ExportRequestType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class RequestType
    {
        /// <summary/>
        protected RequestType() { }

        public RequestType(RequestType request) => Clone.Field(this, request);
         
        /// <summary/>
        public RequestType(string id, URNType senderIdentifier, string senderRole, DateTime timestamp)
        { 
            Id = id;
            SenderIdentifier = senderIdentifier;
            SenderRole = senderRole;
            Timestamp = timestamp;
        }

        /// <summary>
        /// Идентификатор запроса
        /// </summary>
        [XmlAttribute(DataType = "ID")]
        public string Id 
        {
            get => IdField;
            set => IdField = Validator.String(value: ref value, name: nameof(Id), required: true, min: 0, max: 50);
        }

        string IdField;

        /// <summary>
        /// Дата и время формирования запроса
        /// </summary>
        [XmlAttribute("timestamp")]
        public DateTime Timestamp { get; set; }


        /// <summary>
        /// УРН участника-отправителя запроса
        /// </summary>
        [XmlIgnore]
        public URNType SenderIdentifier
        { 
            get => SenderIdentifierField;
            set => SenderIdentifierField = Validator.IsNull(value: value, name: nameof(SenderIdentifier));
        }

        URNType SenderIdentifierField;

        /// <summary/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("senderIdentifier")]
        public string WrapperSenderIdentifier { get => SenderIdentifier; set => SenderIdentifier = value; }


        /// <summary>
        /// Полномочие участника-отправителя сообщения, с которым происходит обращение к ГИС ГМП
        /// </summary>
        [XmlAttribute("senderRole")]
        public string SenderRole 
        {
            get => SenderRoleField;
            set => SenderRoleField = Validator.String(value: ref value, name: nameof(SenderRole), required: true, min: 1, max: 10);
        }

        string SenderRoleField;
    }
}
