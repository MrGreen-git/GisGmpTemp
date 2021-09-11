namespace GisGmp.Tests;
public class ImportRenouncement
{
    static readonly string pathRoot = $@"..\..\..\XmlDocument\{nameof(ImportRenouncement)}";

    [Fact]
    public void ImportRenouncementRequest()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "U_49655ef1-07fe-41f9-9538-c1bcdffb2b95",
            RqId = "G_5e8e6ede-db3a-4fd4-af74-4e76268368b0",
            TestTimestamp = new(day: 30, month: 09, year: 2020, hour: 16, minute: 04, second: 25, millisecond: 932, kind: DateTimeKind.Local),
            RecipientIdentifier = "000009"
        };

        //Act
        var response = gisgmp.CreateImportRenouncementRequest(
            importedRenouncementTypes: new ImportedRenouncementType[]
            {
                new (
                    id: "",
                    renouncement: new ImportedRenouncementType[] 
                    {
                    }
                    )
                {

                }
            });

        //Assert              
        Assert.True(false);
    }

    [Fact]
    public void ImportRenouncementResponse()
    {
        //Arrange
        //Act
        //Assert              
        Assert.True(false);
    }
}
