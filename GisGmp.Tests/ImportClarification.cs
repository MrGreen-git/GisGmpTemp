using GisGmp.Clarification;
using GisGmp.Services.ExportClarification;
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
                TestId = "G_d6a23916-a3a5-4e04-bbfc-839872f9260d",
                TestTimestamp = new(day: 11, month: 03, year: 2021, hour: 13, minute: 27, second: 53, millisecond: 045, kind: DateTimeKind.Local),
                SenderIdentifier = "3eacb7",
                SenderRole = "70"
            };

            //Act
            var request = gisgmp.CreateImportClarificationRequest(
                importedClarificationTypes: new ImportedClarificationType[]
                {
                    new(
                        id: "I_9df961f3-5900-4501-ab61-7b0f3064b6d6",
                        originatorId: "301D63",
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
                                originalDetails: new()
                                {
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
                            signs: new(
                                executorPost: "Петров А.Г.",
                                executorName: "Петров А.Г.",
                                executorNum: "Петров А.Г."
                                )
                            {
                                HeadPost = "Смирнова А.М.",
                                HeadName = "Смирнова А.М.",
                                SignDate = new(day: 11, month: 03, year: 2021),
                                SignDateSpecified = true,
                                TOFKheadPost = "Смирнова А.М.",
                                TOFKheadName = "Смирнова А.М.",
                                TOFKexecutorPost = "Петров А.Г.",
                                TOFKexecutorName = "Петров А.Г.",
                                TOFKexecutorNum = "Петров А.Г.",
                                TOFKsignDate = new(day: 11, month: 03, year: 2021),
                                TOFKsignDateSpecified = true })
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
            Assert.True(CheckObjToXml(request, $@"{nameof(ImportClarificationRequest)}", pathRoot));
        }

        [Fact]
        public void ImportClarificationResponse()
        {
            //Arrange
            GisGmpBuilder gisgmp = new()
            {
                TestEnable = true,
                //
                TestId = "I_1bb7dbca-d28f-48b1-7b39-b4a5f16d5e5c",
                RqId = "G_fce0c522-b08d-44bc-55d8-738f10e9d068",
                TestTimestamp = new(day: 11, month: 03, year: 2021, hour: 13, minute: 29, second: 43, millisecond: 116, kind: DateTimeKind.Local),
                RecipientIdentifier = "3eacb7",
            };

            //Act
            var response = gisgmp.CreateImportClarificationResponse(
                importProtocol: new ImportProtocolType[]
                {
                new(
                    entityID: "I_9df961f3-5900-4501-ab61-7b0f3064b6d6",
                    code: "0",
                    description: "Успешно")
                });

            //Assert              
            Assert.True(CheckObjToXml(response, $@"{nameof(ImportClarificationResponse)}", pathRoot));
        }
    }
}