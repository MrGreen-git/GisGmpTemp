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
        /// <summary/>
        protected RenouncementType() { }

        /// <summary/>
        public RenouncementType(RenouncementType renouncement) => Clone.Field(this, renouncement);

        /// <summary/>
        public RenouncementType(
            string supplierBillID,
            string renouncementID,
            string rulingNum,
            string refusalGround,
            ReasonCode reasonCode,
            Approver approver,
            Executor executor,
            DeedInfo deedInfo
            )
        { 
            SupplierBillID = supplierBillID;
            RenouncementID = renouncementID;
            RulingNum = rulingNum;
            RefusalGround = refusalGround;
            ReasonCode = reasonCode;
            Approver = approver;
            Executor = executor;
            DeedInfo = deedInfo;
        }

        /// <summary>
        /// Информация об утверждении постановления об отказе в возбуждении ИП | required
        /// </summary>
        public Approver Approver { get; set; }

        /// <summary>
        /// ?? Данные должностного лица (исполнителя), вынесшего постановление об отказе |required
        /// </summary>
        public Executor Executor { get; set; }

        /// <summary>
        /// Данные исполнительного документа, по которому вынесено постановление об отказе в возбуждении ИП | required
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public DeedInfo DeedInfo { get; set; }

        /// <summary>
        /// Уникальный идентификатор начисления (УИН) | required
        /// </summary>
        [XmlAttribute("supplierBillID")]
        public string SupplierBillID { get; set; }

        /// <summary>
        /// Уникальный идентификатор извещения об отказе в возбуждении исполнительного производства | required
        /// </summary>
        [XmlAttribute("renouncementID")]
        public string RenouncementID { get; set; }

        /// <summary>
        /// Дата постановления об отказе в возбуждении ИП  | required
        /// </summary>
        [XmlAttribute("rulingDate", DataType = "date")]
        public DateTime RulingDate { get; set; }

        /// <summary>
        /// Номер постановления об отказе в возбуждении ИП | required
        /// </summary>
        [XmlAttribute("rulingNum")]
        public string RulingNum { get; set; }

        /// <summary>
        /// Обстоятельства, послужившие основанием для отказа в возбуждении ИП | required
        /// </summary>
        [XmlAttribute("refusalGround")]
        public string RefusalGround { get; set; }

        /// <summary>
        /// Код причины отказа (пункт ч. 1 ст. 31 Федерального закона от 02.10.2007 N 229-ФЗ) | required
        /// </summary>
        [XmlAttribute("reasonCode")]
        public ReasonCode ReasonCode { get; set; }
    }
}
