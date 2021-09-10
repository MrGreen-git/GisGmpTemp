using GisGmp.Common;
using GisGmp.Package;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportRefunds
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-refunds/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-refunds/2.4.0", IsNullable = false)]
    public class ImportRefundsRequest : RequestType
    {
        /// <remarks/>
        protected ImportRefundsRequest() { }

        /// <remarks/>
        public ImportRefundsRequest(RequestType config, RefundsPackage package)
            : base(config) => RefundsPackage = package;

        /// <remarks/>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
        public RefundsPackage RefundsPackage
        {
            get => RefundsPackageField;
            set => RefundsPackageField = Validator.IsNull(value: value, name: nameof(RefundsPackage));
        }

        RefundsPackage RefundsPackageField;
    }
}
