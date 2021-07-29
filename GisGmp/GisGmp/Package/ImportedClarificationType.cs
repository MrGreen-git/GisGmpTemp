﻿using GisGmp.Clarification;
using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public class ImportedClarificationType : ClarificationType
    {
        [XmlAttribute]
        public string originatorId { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
