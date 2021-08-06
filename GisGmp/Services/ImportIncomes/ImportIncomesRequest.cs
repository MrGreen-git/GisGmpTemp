using GisGmp.Common;
using GisGmp.Package;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportIncomes
{
    /// <summary>
    /// Прием информации о зачислении
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-incomes/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-incomes/2.4.0", IsNullable = false)]
    public class ImportIncomesRequest : RequestType
    {
        /// <summary/>
        protected ImportIncomesRequest() { }

        /// <remarks/>
        public ImportIncomesRequest(RequestType config, IncomesPackage package)
            : base(config) => IncomesPackage = package;


        IncomesPackage IncomesPackageField;

        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
        public IncomesPackage IncomesPackage 
        {
            get => IncomesPackageField; //TODO: validation
            set => IncomesPackageField = value;
        }
    }
}
