using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNSI
{
    /// <summary>
    /// Данные для идентификации получателя средств
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0")]
    public class PayeeData
    {
        /// <summary>
        /// ИНН организации, являющейся получателем средств
        /// </summary>
        [XmlAttribute("inn")]
        public string Inn { get; set; }

        /// <summary>
        /// КПП организации, являющейся получателем средств
        /// </summary>
        [XmlAttribute("kpp")]
        public string Kpp { get; set; }
    }
}
