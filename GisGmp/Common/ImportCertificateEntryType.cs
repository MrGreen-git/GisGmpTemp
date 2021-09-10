using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class ImportCertificateEntryType
    {
        /// <summary />
        protected ImportCertificateEntryType() { }

        /// <summary />
        public ImportCertificateEntryType(string id, URNType ownership)
        {
            Id = id;
            Ownership = ownership;
        }

        /// <summary>
        /// Уникальный в пределах запроса идентификатор описания сертификата используемый для поиска самого сертификата в элементе basic:AttachmentContentList запроса СМЭВ
        /// </summary>
        [XmlAttribute(DataType = "IDREF")]
        public string Id
        {
            get => IdField;
            set => IdField = Validator.String(value: ref value, name: nameof(Id), required: true, min: 0, max: 50);
        }

        string IdField;

        /// <summary>
        /// УРН владельца сертификата ключа проверки ЭП.
        /// </summary>
        [XmlIgnore]
        public URNType Ownership
        {
            get => OwnershipField;
            set => OwnershipField = value ?? throw new Exception($"{nameof(Ownership)} не может иметь значание null");
        }

        URNType OwnershipField;

        [XmlAttribute("ownership")]
        public string WrapperOwnership { get => Ownership; set => Ownership = value; }
    }
}
