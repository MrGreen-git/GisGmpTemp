using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class ImportCertificateEntryType
    {
        /// <summary>
        /// Уникальный в пределах запроса идентификатор описания сертификата используемый для поиска самого сертификата в элементе basic:AttachmentContentList запроса СМЭВ
        /// </summary>
        [XmlAttribute(DataType = "IDREF")]
        public string Id { get; set; }

        /// <summary>
        /// УРН владельца сертификата ключа проверки ЭП.
        /// </summary>
        [XmlAttribute("ownership")]
        public string Ownership { get; set; }
    }
}
