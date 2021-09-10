using GisGmp.Common;
using GisGmp.Package;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportPayments
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-payments/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-payments/2.4.0", IsNullable = false)]
    public class ImportPaymentsRequest : RequestType
    {
        /// <remarks/>
        protected ImportPaymentsRequest() { }

        /// <remarks/>
        public ImportPaymentsRequest(RequestType config, PaymentsPackage package)
            : base(config) => PaymentsPackage = package;


        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
        public PaymentsPackage PaymentsPackage
        {
            get => PaymentsPackageField;
            set => PaymentsPackageField = Validator.IsNull(value: value, name: nameof(PaymentsPackage));
        }

        PaymentsPackage PaymentsPackageField;
    }
}
