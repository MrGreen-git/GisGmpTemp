using GisGmp.Common;
using GisGmp.Package;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportCharges
{
    /// <summary>
    /// Прием необходимой для уплаты информации (начисления)
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-charges/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-charges/2.4.0", IsNullable = false)]
    public class ImportChargesRequest : RequestType
    {
        /// <summary>
        /// Служебный конструктор (для десериализации)
        /// </summary>
        protected ImportChargesRequest() { }

        /// <summary />
        public ImportChargesRequest(RequestType config, ChargesPackage package)
            : base(config) => ChargesPackage = package;


        /// <summary>
        /// Пакет, содержащий импортируемые начисления
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
        public ChargesPackage ChargesPackage 
        {
            get => ChargesPackageField;
            set => ChargesPackageField = value;
        }

        ChargesPackage ChargesPackageField;
    }
}
