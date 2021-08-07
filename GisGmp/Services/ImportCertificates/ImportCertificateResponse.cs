using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportСertificates
{
    /// <summary>
    /// Ответ на запрос приема информации о сертификате ключа проверки электронной подписи
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.4.0", IsNullable = false)]
    public class ImportCertificateResponse : ResponseType
    {
        /// <summary/>
        protected ImportCertificateResponse() { }

        /// <summary>
        /// Ответ на запрос приема информации о сертификате ключа проверки электронной подписи
        /// </summary>
        /// <param name="config"></param>
        /// <param name="importProtocol">Результат обработки сущности в пакете | required: true, min: 1, max 100</param>
        public ImportCertificateResponse(ResponseType config, ImportProtocolType[] importProtocol)
            : base(config) => ImportProtocol = importProtocol;


        #region XmlElement
        /// <summary>
        /// Результат обработки сущности в пакете | required: true, min: 1, max 100
        /// </summary>
        [XmlElement("ImportProtocol")]
        public ImportProtocolType[] ImportProtocol
        {
            get => ImportProtocolField;
            set => ImportProtocolField = value;
        }

        ImportProtocolType[] ImportProtocolField;
        #endregion
    }
}
