using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Документ, удостоверяющий личность
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class DocumentIdentity
    {
        /// <summary>
        /// Код документа, удостоверяющего личность
        /// </summary>
        [XmlAttribute("code")]
        public Code Code { get; set; }

        /// <summary>
        /// Серия
        /// </summary>
        [XmlAttribute("series")]
        public string Series { get; set; }

        /// <summary>
        /// Номер
        /// </summary>
        [XmlAttribute("number")]
        public string Number { get; set; }
    }
}
