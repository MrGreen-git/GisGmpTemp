using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <summary>
    /// Пакет, содержащий направляемые зачисления
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0", IsNullable = false)]
    public class IncomesPackage : PackageType
    {
        /// <summary/>
        protected IncomesPackage() { }

        /// <summary/>
        public IncomesPackage(ImportedIncomeType[] importedIncomes) => ImportedIncomes = importedIncomes;

        /// <summary/>
        public IncomesPackage(ImportedChangeType[] importedChanges) => ImportedChanges = importedChanges;


        [XmlIgnore]
        public ImportedIncomeType[] ImportedIncomes
        {
            get => Items as ImportedIncomeType[];
            set => Items = value;
        }
    }
}
