using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <summary>
    /// Тип запроса на предоставление информации о результатах квитирования
    /// </summary>
    [Serializable]
    public enum ExportQuittancesKind
    {
        /// <summary>
        /// QUITTANCE - для запросов результатов квитирования, за исключением неактивных (возвращается результат квитирования с последним полученным платежом)
        /// </summary>
        [XmlEnum("QUITTANCE")]
        Quittance,

        /// <summary>
        /// ALLQUITTANCE - для запросов всех результатов квитирования
        /// </summary>
        [XmlEnum("ALLQUITTANCE")]
        AllQuittance,

        /// <summary>
        /// QUITTANCEMAINCHARGE - для запросов результатов квитирования по связанным начислениям (используется только ФССП)
        /// </summary>
        [XmlEnum("QUITTANCEMAINCHARGE")]
        QuittanceMainCharge,

        /// <summary>
        /// ALLPOSSIBLE – предоставление результата квитирования с указанием дополнительных сведений об извещениях о приеме к исполнению распоряжений, которые несквитированы с извещением о начислении, но совпали с ним по нескольким реквизитам квитирования (доступно только для участников взаимодействия с полномочием ГАН/АН)
        /// </summary>
        [XmlEnum("ALLPOSSIBLE")]
        AllPossible
    }
}
