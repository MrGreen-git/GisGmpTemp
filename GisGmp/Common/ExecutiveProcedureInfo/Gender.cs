using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Поле номер 1127: Пол должника
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public enum Gender
    {

        мужской,

        женский,
    }
}
