using GisGmp.Clarification;
using GisGmp.SearchConditions;
using GisGmp.Services.ExportClarification;

namespace GisGmp.Tests;

public class ExportClarifications
{
    static readonly string pathRoot = $@"..\..\..\XmlDocument\{nameof(ExportClarifications)}";

    [Fact]
    public void ExportClarificationRequest()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            TestId = "G_cfe0c895-b33d-33bc-28d8-697f21d9e561",
            TestTimestamp = new(day: 30, month: 09, year: 2020, hour: 18, minute: 13, second: 51),

            SenderIdentifier = "3eacb7",
            SenderRole = "70",
            //
            PageLength = 100,
            PageNumber = 1
        };
        
        //Act
        var request = gisgmp.CreateExportClarificationRequest(
            kind: ExportClarificationsKind.Clarification,
            clarificationID: new string[]{ 
                    new("55100120320210000000000000000008")
                });

        //Assert              
        Assert.True(CheckObjToXml(request, $@"{nameof(ExportClarificationRequest)}", pathRoot));
    }

    [Fact]
    public void ExportClarificationResponse()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "I_54a39db1-8753-5522-1739-bc94254ccdb4",
            RqId = "G_cfe0c895-b33d-33bc-28d8-697f21d9e561",
            TestTimestamp = new(day: 30, month: 09, year: 2020, hour: 17, minute: 25, second: 45, millisecond: 031, kind: DateTimeKind.Local),
            RecipientIdentifier = "3eacb7",
        };
        //Act
        var response = gisgmp.CreateExportClarificationResponse(
            hasMore: false,
            clarificationInfo: new ClarificationInfo[] {
                new(
                    changeStatusInfo: new(
                        meaning: "1"),
                    clarification: new ClarificationType(
                        clarificationNumber: "202103310000001",
                        clarificationDate: new(day: 11, month: 03, year: 2021),
                        clarificationId: "55100120320210000000000000000008",
                        paymentId: "10471020010005233009202000000001",
                        authorAccount: "03511А37790",
                        authorName: "Управление Федеральной службы государственной регистрации, кадастра и картографии по Новосибирской области",
                        codeUBP: "001А3779",
                        budgetLevel: Clarification.BudgetLevel.Item1,
                        okpo: "74953678",
                        financialBody: "Министерство финансов Новосибирской области",
                        tofkName: "Управление Федерального казначейства по Новосибирской области",
                        tofkCode: "5100",
                        clarificationApplication: new(
                            ordinalNumber: "1",
                            setDetails: new() { Kbk = "32110807020018000110" },
                            appCode: AppCode.PL,
                            appDate: new(day: 10, month: 03, year: 2021),
                            originalDetails: new(){
                                PayeeName = "Управление Федеральной службы государственной регистрации, кадастра и картографии по Новосибирской области",
                                Inn = "5406299278",
                                Kpp = "540601001",
                                PayeeAccount = "01234567891",
                                Oktmo = "50701000",
                                Kbk = "32110807020011000110",
                                Subsidy = "1234567890",
                                Amount = 35000,
                                Purpose = "Государственная пошлина за государственную регистрацию прав, ограничений (обременений) прав на недвижимое имущество и сделок с ним",
                                Description = "Описание тестовое"
                            })
                        {
                            AppDateSpecified = true,
                            AppCodeSpecified = true,
                            ApplicationDateSpecified = true,
                            ApplicationName = "1",
                            AppNum = "01232567890123456789",
                            ApplicationNumber = "000000000000001",
                            ApplicationDate = new(day: 11, month: 03, year: 2021),
                            IncomeId = "45100110320210000000000000000004"
                            
                        },
                        signs: new(){
                            HeadPost = "Смирнова А.М.",
                            HeadName = "Смирнова А.М.",
                            ExecutorPost = "Петров А.Г.",
                            ExecutorName = "Петров А.Г.",
                            ExecutorNum = "Петров А.Г.",
                            SignDate = new(day: 11, month: 03, year: 2021),
                            SignDateSpecified = true,
                            TOFKheadPost = "Смирнова А.М.",
                            TOFKheadName = "Смирнова А.М.",
                            TOFKexecutorPost = "Петров А.Г.",
                            TOFKexecutorName = "Петров А.Г.",
                            TOFKexecutorNum = "Петров А.Г.",
                            TOFKsignDate = new(day: 11, month: 03, year: 2021),
                            TOFKsignDateSpecified = true
                            }
                        )
                    {
                        MainAuthorName = "Федеральная служба государственной регистрации, кадастра и картографии",
                        KbkGlavaCode = "321",
                        FinBodyAccount = "03511А37790",
                        PayerName = "ООО Альфа",
                        PayerIdentifier = "2007703461103774301001",
                        Inn = "7703461103",
                        Kpp = "774301001",
                        PayerDocument = "01-456",
                        PayerAccount = "40702810500000000001",
                        FindingoutRequestNum = "123456789012345",
                        FindingoutRequestDate = new(day: 12, month: 03, year: 2021),
                        FindingoutRequestDateSpecified = true
                    })
            });
        //Assert              
        Assert.True(CheckObjToXml(response, $@"{nameof(ExportClarificationResponse)}", pathRoot));
    }
}
