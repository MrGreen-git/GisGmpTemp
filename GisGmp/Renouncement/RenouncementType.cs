using GisGmp.Common;
using GisGmp.Package;
using System;
using System.Xml.Serialization;

namespace GisGmp.Renouncement
{
    [XmlInclude(typeof(ImportedRenouncementType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Renouncement/2.4.0")]
    public class RenouncementType
    {
        /// <summary>
        /// Информация об утверждении постановления об отказе в возбуждении ИП
        /// </summary>
        public Approver Approver { get; set; }

        /// <summary>
        /// Данные должностного лица (исполнителя), вынесшего постановление об отказе
        /// </summary>
        public Executor Executor { get; set; }

        /// <summary>
        /// Данные исполнительного документа, по которому вынесено постановление об отказе в возбуждении ИП
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public DeedInfo DeedInfo { get; set; }

        /// <summary>
        /// Уникальный идентификатор начисления (УИН)
        /// </summary>
        [XmlAttribute("supplierBillID")]
        public string SupplierBillID { get; set; }

        /// <summary>
        /// Идентификатор извещения об отказе в возбуждении исполнительного производства
        /// </summary>
        [XmlAttribute("renouncementID")]
        public string RenouncementID { get; set; }

        /// <summary>
        /// Дата постановления об отказе в возбуждении ИП
        /// </summary>
        [XmlAttribute("rulingDate", DataType = "date")]
        public DateTime RulingDate { get; set; }

        /// <summary>
        /// Номер постановления об отказе в возбуждении ИП
        /// </summary>
        [XmlAttribute("rulingNum")]
        public string RulingNum { get; set; }

        /// <summary>
        /// Обстоятельства, послужившие основанием для отказа в возбуждении ИП
        /// </summary>
        [XmlAttribute("refusalGround")]
        public string RefusalGround { get; set; }

        /// <summary>
        /// Код причины отказа (пункт ч. 1 ст. 31 Федерального закона от 02.10.2007 N 229-ФЗ)
        /// </summary>
        [XmlAttribute("reasonCode")]
        public ReasonCode ReasonCode { get; set; }
    }
}
