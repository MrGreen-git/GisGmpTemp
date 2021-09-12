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
            TestId = "I_58d5a0d1-5183-4efc-86a8-93b4d547872c",
            TestTimestamp = new(day: 29, month: 04, year: 2021, hour: 18, minute: 13, second: 51),
            SenderIdentifier = "304A7C",
            SenderRole = "0"
        };

        //Act
        var request = gisgmp.CreateImportRenouncementRequest(
            importedRenouncementTypes: new ImportedRenouncementType[]
            {
                new(
                    id: "I_16456873-8080-49f4-b60f-6f87af897c6a",
                    originatorId: null,
                    renouncement: new(
                        supplierBillID: "32117072411021588933",
                        renouncementID: "F304A7C290420210000005894",
                        rulingNum: "356П",
                        refusalGround: "Документ не соответствует требованиям, предъявляемым к исполнительным документам",
                        reasonCode: ReasonCode.Item4,
                        approver: new(
                            positionCode: "25",
                            positionName: "Судебный пристав-исполнитель",
                            personApproving: "Артемьев Иван Константинович",
                            approvalDate: new(day: 28, month: 04, year: 2021)),
                        executor: new(
                            vKSPCode: "12937",
                            structuralUnitName: "Управление Федеральной службой судебных приставов по Москве",
                            structuralUnitAddress: "РФ, г. Москва, проезд Югорский, д. 22, корп. 1 /00074320071000000000",
                            structuralLocality: "Останкинский отдел УФССП по Москве",
                            executorFullName: "Москва"),
                        deedInfo: new(
                            idType: IDType.Item3,
                            idDocNo: "32117072411021588933",
                            idDocDate: new(day: 05, month: 03, year: 2021),
                            subjCode: "1150000",
                            subjName: "Штраф по законодательству об административных правонарушениях (АП)"))
                    {
                        RulingDate = new(day: 25, month: 04, year: 2021)
                    })
            });

        //Assert              
        Assert.True(CheckObjToXml(request, $@"{nameof(ImportRenouncementRequest)}", pathRoot));
    }

    [Fact]
    public void ImportRenouncementResponse()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "I_27651c94-6127-412a-b948-ba64b21db005",
            RqId = "I_58d5a0d1-5183-4efc-86a8-93b4d547872c",
            TestTimestamp = new(day: 29, month: 04, year: 2021, hour: 18, minute: 15, second: 51),
            RecipientIdentifier = "304A7C"
        };

        //Act
        var response = gisgmp.CreateImportRenouncementResponse(
            importProtocol: new ImportProtocolType[]
            {
                new (
                    entityID: "I_46488813-8080-49f4-b60f-7f87af897c6a",
                    code: "0",
                    description: "Успешно (ТЕСТОВЫЕ ДАННЫЕ!)")
            });

        //Assert              
        Assert.True(CheckObjToXml(response, $@"{nameof(ImportRenouncementResponse)}", pathRoot));
    }
}
