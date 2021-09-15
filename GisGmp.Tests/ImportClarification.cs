using Xunit;

namespace GisGmp.Tests
{
    public class ImportClarification
    {
        static readonly string pathRoot = $@"..\..\..\XmlDocument\{nameof(ImportClarification)}";

        [Fact]
        public void ImportClarificationRequest()
        {
            ///Arrange
            GisGmpBuilder gisgmp = new()
            {
                TestEnable = true,
                //
                TestId = "G_fce0c522-b08d-44bc-55d8-738f10e9d068",
                TestTimestamp = new(day: 01, month: 07, year: 2021, hour: 16, minute: 03, second: 05, millisecond: 041, kind: DateTimeKind.Local),
                SenderIdentifier = "aaa111",
                SenderRole = "70"
            };

            ////Act
            //var request = gisgmp.CreateImportIncomesRequest(
            //    importedIncomeTypes: new[]
            //    {
            //        new ImportedIncomeType(


            //            }
            //    });

            ////Assert              
            //Assert.True(Tools.CheckObjToXml(request, $@"{nameof(ImportClarificationRequest)}", pathRoot));
        }

        [Fact]
        public void ImportClarificationResponse()
        {           
            //Arrange
            //Act
            //Assert              
            Assert.True(false);
        }
    }
}