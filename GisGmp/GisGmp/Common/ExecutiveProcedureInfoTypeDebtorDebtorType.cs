﻿using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public enum ExecutiveProcedureInfoTypeDebtorDebtorType
    {

        [XmlEnum("1")]
        Item1,

        [XmlEnum("2")]
        Item2,

        [XmlEnum("3")]
        Item3,

        [XmlEnum("1700")]
        Item1700,
    }
}
