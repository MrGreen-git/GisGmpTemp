using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public class ClarificationsConditionsType
    {
        /// <summary/>
        protected ClarificationsConditionsType() { }

        /// <summary/>
        public ClarificationsConditionsType(string[] clarificationID) 
            => ClarificationID = clarificationID;

        [XmlElement("ClarificationID")]
        public string[] ClarificationID { get; set; }
    }
}
