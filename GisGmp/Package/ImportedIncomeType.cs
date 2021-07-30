using GisGmp.Income;
using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public class ImportedIncomeType : IncomeType
    {
        [XmlAttribute]
        public string originatorId { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
