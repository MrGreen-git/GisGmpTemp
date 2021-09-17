namespace GisGmp.Tests;

public class ExportIncomes
{
    static readonly string pathRoot = $@"..\..\..\XmlDocument\{nameof(ExportIncomes)}";

    [Fact]
    public void ExportIncomesRequest()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            TestId = "G_cfe0c895-b33d-33bc-28d8-697f21d9e561",
            TestTimestamp = new(day: 01, month: 07, year: 2021, hour: 18, minute: 13, second: 51),

            SenderIdentifier = "3eacb7",
            SenderRole = "1",
            //
            PageLength = 100,
            PageNumber = 1
        };

        //Act
        var request = gisgmp.CreateExportIncomesRequest();

        //Assert              
        Assert.True(CheckObjToXml(request, $@"{nameof(ExportIncomesRequest)}", pathRoot));
    }

    [Fact]
    public void ExportIncomesResponse()
    {
        //Arrange
        //Act
        //Assert              
        Assert.True(false);
    }
}
