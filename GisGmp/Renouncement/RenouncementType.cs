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
        protected RenouncementType() { }

        public RenouncementType(RenouncementType renouncement) => Clone.Field(this, renouncement);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="supplierBillID">Уникальный идентификатор начисления (УИН)</param>
        /// <param name="renouncementID">Уникальный идентификатор извещения об отказе в возбуждении исполнительного производства</param>
        /// <param name="rulingDate">Дата постановления об отказе в возбуждении ИП</param>
        /// <param name="rulingNum">Номер постановления об отказе в возбуждении ИП</param>
        /// <param name="refusalGround">Обстоятельства, послужившие основанием для отказа в возбуждении ИП</param>
        /// <param name="reasonCode">Код причины отказа (пункт ч. 1 ст. 31 Федерального закона от 02.10.2007 N 229-ФЗ)</param>
        /// <param name="approver">Информация об утверждении постановления об отказе в возбуждении ИП</param>
        /// <param name="executor">Данные должностного лица (исполнителя), вынесшего постановление об отказе</param>
        /// <param name="deedInfo">Данные исполнительного документа, по которому вынесено постановление об отказе в возбуждении ИП</param>
        public RenouncementType(
            string supplierBillID,
            string renouncementID,
            DateTime rulingDate,
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
            RulingDate = rulingDate;
            RulingNum = rulingNum;
            RefusalGround = refusalGround;
            ReasonCode = reasonCode;
            Approver = approver;
            Executor = executor;
            DeedInfo = deedInfo;
        }


        /// <summary>
        /// Уникальный идентификатор начисления (УИН)
        /// <para>use: required</para>
        /// <para>length: 20..25</para>
        /// <para>pattern: "\w{20}"</para>
        /// <para>pattern: "\d{25}"</para>
        /// <para>type: com:SupplierBillIDType</para>
        /// </summary>
        [XmlAttribute("supplierBillID")]
        public string SupplierBillID { get; set; } //TODO Type

        /// <summary>
        /// Уникальный идентификатор извещения об отказе в возбуждении исполнительного производства
        /// <para>use: required</para>
        /// <para>length: 1..25</para>
        /// <para>pattern: "F[0-9a-fA-F]{6}((0[1-9]|[12][0-9]|3[01])(0[1-9]|1[012])\d{4})\d{10}"</para>
        /// <para>type: dv:RenouncementIDType</para>
        /// </summary>
        [XmlAttribute("renouncementID")]
        public string RenouncementID { get; set; } //TODO Type

        /// <summary>
        /// Дата постановления об отказе в возбуждении ИП
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("rulingDate", DataType = "date")]
        public DateTime RulingDate { get; set; }

        /// <summary>
        /// Номер постановления об отказе в возбуждении ИП
        /// <para>use: required</para>
        /// <para>length: 1..25</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("rulingNum")]
        public string RulingNum { get; set; }

        /// <summary>
        /// Обстоятельства, послужившие основанием для отказа в возбуждении ИП
        /// <para>use: required</para>
        /// <para>length: 1..1000</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("refusalGround")]
        public string RefusalGround { get; set; }

        /// <summary>
        /// Код причины отказа (пункт ч. 1 ст. 31 Федерального закона от 02.10.2007 N 229-ФЗ)
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("reasonCode")]
        public ReasonCode ReasonCode { get; set; }

        /// <summary>
        /// Информация об утверждении постановления об отказе в возбуждении ИП
        /// <para>use: required</para>
        /// </summary>
        public Approver Approver { get; set; }

        /// <summary>
        /// Данные должностного лица (исполнителя), вынесшего постановление об отказе
        /// <para>use: required</para>
        /// </summary>
        public Executor Executor { get; set; }

        /// <summary>
        /// Данные исполнительного документа, по которому вынесено постановление об отказе в возбуждении ИП
        /// <para>use: required</para>
        /// <para>type: com:DeedInfo</para>
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public DeedInfo DeedInfo { get; set; }
    }
}
