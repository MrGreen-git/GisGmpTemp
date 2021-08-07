using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <summary>
    /// Способ оплаты начисления.
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public enum PaymentMethod
    {
        /// <summary>
        /// 1 - Признак оплаты начисления через СБП.
        /// </summary>
        [XmlEnum("1")]
        Item1,
    }
}
