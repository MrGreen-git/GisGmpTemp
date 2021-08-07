using GisGmp.Common;
using GisGmp.Package;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportClarification
{
    /// <summary>
    /// Запрос на прием информации о сертификате ключа проверки электронной подписи
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-clarification/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-clarification/2.4.0", IsNullable = false)]
    public class ImportClarificationRequest : RequestType
    {
        /// <summary/>
        protected ImportClarificationRequest() { }

        /// <summary>
        /// Информация о сертификате ключа проверки ЭП
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
        public ClarificationsPackage ClarificationsPackage 
        {
            get => ClarificationsPackageField;
            set => ClarificationsPackageField = value;
        }

        ClarificationsPackage ClarificationsPackageField;
    }
}
