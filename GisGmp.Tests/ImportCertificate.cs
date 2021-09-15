namespace GisGmp.Tests;

public class ImportCertificate
{
    static readonly string pathRoot = $@"..\..\..\XmlDocument\{nameof(ImportCertificate)}";

    [Fact]
    public void ImportCertificateRequest()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "I_6e188de4-8491-49ea-8ec6-a09a607d020a",
            TestTimestamp = new (day: 30, month: 07, year: 2021, hour: 18, minute: 13, second: 51),
            SenderIdentifier = "3eb551",
            SenderRole = "3"
        };

        //Act
        var request = gisgmp.CreateImportCertificateRequest(
            new ImportCertificateEntryType[]
            {
                new(
                    id: "I_6e188de4-8491-49ea-8ec6-a09a607d020a",
                    ownership: "3eb551")
            });

        //Assert 
        XmlDocument xmlDoc = default;
        Assert.Null(Record.Exception(() => xmlDoc = SerializerObject(request, true)));
        Assert.Null(Record.Exception(() => Deserialize<ImportCertificateRequest>(xmlDoc)));

        Assert.True(CheckObjToXml(request, $@"{nameof(ImportCertificateRequest)}", pathRoot));
    }


    [Fact]
    public void ImportCertificateResponse()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "G_3752f2cf-86f2-4214-afd0-1e21d80ef30d",
            RqId = "I_6e188de4-8491-49ea-8ec6-a09a607d020a",
            TestTimestamp = new(day: 30, month: 09, year: 2020, hour: 18, minute: 13, second: 51),
            RecipientIdentifier = "3eb551"
        };

        //Act
        var response = gisgmp.CreateImportCertificateResponse(
            importProtocol: new ImportProtocolType[]
            {
                new (
                    entityID: "I_6e188de4-8491-49ea-8ec6-a09a607d020a",
                    code: "0",
                    description: "Успешно (ТЕСТОВЫЕ ДАННЫЕ!)")
            });

        //Assert  
        XmlDocument xmlDoc = default;
        Assert.Null(Record.Exception(() => xmlDoc = SerializerObject(response, true)));
        Assert.Null(Record.Exception(() => Deserialize<ImportCertificateResponse>(xmlDoc)));

        Assert.True(CheckObjToXml(response, $@"{nameof(ImportCertificateResponse)}", pathRoot));
    }
}

