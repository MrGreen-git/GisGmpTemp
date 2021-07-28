using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        PayerIdentifier,

        PayerInn,
    }
}
