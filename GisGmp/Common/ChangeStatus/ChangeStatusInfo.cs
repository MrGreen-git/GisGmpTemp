using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Сведения о статусе извещения о приеме к исполнению распоряжения и основаниях изменения.
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0", IsNullable = false)]
    public class ChangeStatusInfo : ChangeStatusType
    {
        /// <remarks/>
        protected ChangeStatusInfo() { }

        /// <remarks/>
        public ChangeStatusInfo(string meaning) => Meaning = meaning;
    }
}
