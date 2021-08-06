using System;
using System.Xml.Serialization;

namespace GisGmp.Income
{
    /// <summary>
    /// Поле номер 4002: Обозначение электронного сообщения в унифицированных форматах электронных банковских сообщений Банка России, на основании которого сформировано зачисление
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Income/2.4.0")]
    public enum EdCode
    {
        ED101,

        ED104,

        ED105,

        ED108,

        ED701,
    }
}
