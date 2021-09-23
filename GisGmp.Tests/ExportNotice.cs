using GisGmp.NoticeCharge;
using GisGmp.Organization;
using GisGmp.Services.ExportNotice;

namespace GisGmp.Tests;

public class ExportNotice
{
    static readonly string pathRoot = $@"..\..\..\XmlDocument\{nameof(ExportNotice)}";

    #region ExportNotice #1
    [Fact]
    public void ExportNoticeRequest1()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "G_e1ed8ef7-19a6-44b9-ac0b-34a0e20b09bd",
            TestTimestamp = new DateTime(2020, 09, 30, 13, 12, 43, 696, DateTimeKind.Local),
            RecipientIdentifier = "3eb6e5",
        };

        //Act
        var request = gisgmp.CreateExportNoticeRequest(
            destination: new Destination(recipientIdentifier: "3eb6e5", routingCode: "45382000"),
            noticeCharges: new Services.ExportNotice.NoticeCharge[]
            {
                new Services.ExportNotice.NoticeCharge()
                {
                    supplierBillID = "88818012505024915378",
                    billDate = new DateTime(day: 30, month: 09, year: 2020, hour: 10, minute: 12, second: 30, millisecond: 313, kind: DateTimeKind.Local),
                    totalAmount = 5000,
                    purpose = "test",
                    kbk = "32111301031016000130",                       
                    //Name = "ФГБУ «ФКП Росреестра» по г Москва", //TODO нет поля в типе
                    Payer = new NoticeChargeTypePayer() { PayerIdentifier = "1220000000007712579832", payerName = "Тестовый плательщик" },
                    ChangeStatusInfo = new ChangeStatusInfo(meaning: "1")
                }
                    
            });

        //Assert              
        Assert.True(CheckObjToXml(request, $@"{nameof(ExportNoticeRequest1)}", pathRoot));
        
    }

    [Fact]
    public void ExportNoticeResponse1()
    {
        //Arrange
        GisGmpBuilder gisgmp = new GisGmpBuilder()
        {
            TestEnable = true,
            //
            TestId = "G_327e3906-5a3d-4c79-98f8-18bdd3f7228b",
            RqId = "G_e1ed8ef7-19a6-44b9-ac0b-34a0e20b09bd",
            TestTimestamp = new(day: 01, month: 07, year: 2021, hour: 13, minute: 15, second: 47),
            RecipientIdentifier = "3eb6e5",
        };

        //Act
        var response = gisgmp.CreateExportNoticeResponse(
            routingCode: "45382000",
            exportNoticeConfirmation: true);

        //Assert              
        Assert.True(CheckObjToXml(response, $@"{nameof(ExportNoticeResponse1)}", pathRoot));
    }
    #endregion

    #region ExportNotice #2
    [Fact]
    public void ExportNoticeRequest2()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "G_c26e88cb-3a4f-4a36-81af-17ffcccfe16e",
            TestTimestamp = new(day: 01, month: 07, year: 2021, hour: 19, minute: 44, second: 47, millisecond: 032, kind: DateTimeKind.Local),
            RecipientIdentifier = "3eb6e5",
        };

        //Act
        var request = gisgmp.CreateExportNoticeRequest(
            destination: new Destination(recipientIdentifier: "3eb6e5", routingCode: "45382000"),
            noticePayments: new NoticePayment[] { 
                new NoticePayment()
                { 
                    PaymentId = "10445252250000010107202161716434",
                    Amount = 20,
                    Kbk = "88888880000000001140",
                    Oktmo = "88888000",
                    PaymentDate = new DateTime(day: 01, month: 07, year: 2021, hour: 14, minute: 06, second: 30, millisecond: 313, kind: DateTimeKind.Local),
                    Purpose = "test",
                    receiptDate = new DateTime(day: 01, month: 07, year: 2021),
                    receiptDateSpecified = true,
                    SupplierBillID = "88818012420345815071",
                    TransKind = TransKindType.Item01,
                    PaymentOrg = new(
                        bank: new(
                            bik: "044525225", 
                            name: "Отделение Московского банка ПАО Сбербанк")),
                    Payee = new(
                        organization: new(inn: "8888888004", kpp: "888888800", name: "АН 1роль"),
                        orgAccount: new(
                            accountNumber: new("03252643000000079500"),
                            bank: new(bik: "024501901", correspondentBankAccount: "40102810045370000002"))),
                    BudgetIndex = new BudgetIndexType(
                        status: "24",
                        paytReason: "0",
                        taxDocDate: "0",
                        taxDocNumber: "0",
                        taxPeriod: "0"),
                    ChangeStatusInfo = new ChangeStatusInfo(
                        meaning: "1")                       
                }
            });

        //Assert              
        Assert.True(CheckObjToXml(request, $@"{nameof(ExportNoticeRequest2)}", pathRoot));
    }

    [Fact]
    public void ExportNoticeResponse2()
    {
        //Arrange
        GisGmpBuilder gisgmp = new GisGmpBuilder()
        {
            TestEnable = true,
            //
            TestId = "G_bd3f8d23-c27c-4838-b2cf-80b3d99fdc52",
            RqId = "G_c26e88cb-3a4f-4a36-81af-17ffcccfe16e",
            TestTimestamp = new(day: 01, month: 07, year: 2021, hour: 19, minute: 45, second: 47),
            RecipientIdentifier = "3eb6e5",
        };

        //Act
        var response = gisgmp.CreateExportNoticeResponse(
            routingCode: "45382000",
            exportNoticeConfirmation: true);

        //Assert              
        Assert.True(CheckObjToXml(response, $@"{nameof(ExportNoticeResponse2)}", pathRoot));
    }
    #endregion

    #region ExportNotice #3
    [Fact]
    public void ExportNoticeRequest3()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "G_554d04cb-5be6-4372-be84-2ffbfbc42264",
            TestTimestamp = new(day: 01, month: 07, year: 2021, hour: 19, minute: 27, second: 15, millisecond: 425, kind: DateTimeKind.Local),
            RecipientIdentifier = "3eb6e5",
        };

        //Act
        var request = gisgmp.CreateExportNoticeRequest(
            destination: new(recipientIdentifier: "3eb6e5", routingCode: "45382000"),
            noticeQuittances: new NoticeQuittance[]
            {
                new NoticeQuittance()
                {
                SupplierBillID = "88818012420345815071",
                TotalAmount = 5000,
                TotalAmountSpecified = true,
                Balance = 4940,
                BalanceSpecified = true,
                BillStatus = AcknowledgmentStatusType.Item2,
                IsRevoked = false,
                IsRevokedSpecified = true,
                PaymentId = "10445252250000010107202161716434",
                AmountPayment = 60,
                AmountPaymentSpecified = true,
                CreationDate = new(day: 01, month: 07, year: 2021, hour: 19, minute: 26, second: 49, kind: DateTimeKind.Local),
                }
            }
            );

        //Assert              
        Assert.True(CheckObjToXml(request, $@"{nameof(ExportNoticeRequest3)}", pathRoot));
    }

    [Fact]
    public void ExportNoticeResponse3()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "G_4a2c00d9-f3f8-48e9-a6d9-3e9da1c87081",
            RqId = "G_554d04cb-5be6-4372-be84-2ffbfbc42264",
            TestTimestamp = new(day: 30, month: 09, year: 2020, hour: 19, minute: 30, second: 47),
            RecipientIdentifier = "3eb6e5",
        };

        //Act
        var response = gisgmp.CreateExportNoticeResponse(
            routingCode: "45382000",
            exportNoticeConfirmation: true);

        //Assert              
        Assert.True(CheckObjToXml(response, $@"{nameof(ExportNoticeResponse3)}", pathRoot));
    }
    #endregion

    #region ExportNotice #4
    [Fact]
    public void ExportNoticeRequest4()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "G_90274743-6807-4651-9e9d-8c380ca92577",
            TestTimestamp = new(day: 29, month: 04, year: 2021, hour: 18, minute: 13, second: 51),
            RecipientIdentifier = "3eb5f9",
        };

        //Act
        var request = gisgmp.CreateExportNoticeRequest(
            destination: new(recipientIdentifier: "3eb5f9", routingCode: "45382000"),
            noticeChargeExecutive: new NoticeChargeExecutiveType[]
            {
                new NoticeChargeExecutiveType()
                {
                    ChangeStatusInfo = new(meaning: "1"),

                    supplierBillID = "18819062009512650975",
                    billDate = new(day: 04, month: 02, year: 2021, hour: 18, minute: 13, second: 51),
                    totalAmount = 50000,
                    purpose = "Штраф за неоплаченную парковку",
                    kbk = "18811630000010000140",
                    oktmo = "45348000",
                    amountToPay = 50000,
                    Payee = new Payee(
                        organization: new OrganizationType(name: "ЦАФАП ОДД ГИБДД ГУ МВД России по г. Москве", inn: "7707089111", kpp: "770731015"),
                        orgAccount: new(accountNumber: "03100643000000019500",
                        bank: new(bik: "024501901", correspondentBankAccount: "40102810045370000002")
                        )
                        ),
                    Payer = new NoticeChargeExecutiveTypePayer(){ payerName = "Иванов Иван Иванович", PayerIdentifier = "1010000000008751379232" },
                    BudgetIndex = new(
                        status: "01",
                        paytReason: "0",
                        taxPeriod: "0",
                        taxDocNumber: "0",
                        taxDocDate: "0"),
                    ExecutiveProcedureInfo = new(
                        idDeloNo: "2524П",
                        idDesDate: new(day: 04, month: 02, year: 2021),
                        aktDate: "2021-02-05",
                        srokPrIsp: "1",
                        srokPrIspType: SrokPrIspType.Item1,
                        claimerAdr: "Тестовый адрес взыскателя/00074320071000000000",
                        notifFSSPDate: new(day: 29, month: 04, year: 2021),
                        deedInfo: new(
                            idType: IDType.Item3,
                            idDocNo: "18819062009512650975",
                            idDocDate: new(day: 04, month: 02, year: 2021),
                            subjCode: "1150000",
                            subjName: "Штраф по законодательству об административных правонарушениях (АП)"),
                        executOrgan: new(){
                            OrganOkogu = "1318025",
                            OrganCode = "30",
                            Organ = "МВД России",
                            OrganAdr = "Тестовый адрес/00074320071000000000",
                            OrganSignCodePost = "11-3-4-062",
                            OrganSign = "Специалист",
                            OrganSignFIO = "Фамилия Имя ОТчество"},
                        debtor: new(){
                            DebtorType = DebtorType.Item2,
                            DebtorAdr = "Тестовый адрес/00074320071000000000",
                            Person = new(){ DebtorGender = Gender.мужской }})
                }
            });

        //Assert              
        Assert.True(CheckObjToXml(request, $@"{nameof(ExportNoticeRequest4)}", pathRoot));
    }

    [Fact]
    public void ExportNoticeResponse4()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "G_4a2c58d9-f3f8-48e9-a7d2-3e4da1c45045",
            RqId = "G_90274743-6807-4651-9e9d-8c380ca92577",
            TestTimestamp = new(day: 29, month: 04, year: 2021, hour: 18, minute: 16, second: 47),
            RecipientIdentifier = "3eb5f9",
        };

        //Act
        var response = gisgmp.CreateExportNoticeResponse(
            routingCode: "45382000",
            exportNoticeConfirmation: true);

        //Assert              
        Assert.True(CheckObjToXml(response, $@"{nameof(ExportNoticeResponse4)}", pathRoot));
    }
    #endregion

    #region ExportNotice #5
    [Fact]
    public void ExportNoticeRequest5()
    {
        //Arrange
        //Act
        //Assert              
        Assert.True(false);
    }

    [Fact]
    public void ExportNoticeResponse5()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            // 
            TestId = "G_55e8a242-0a43-4d73-8d60-a0b9c9e1489b",
            RqId = "G_e4eb9ab7-8ac6-422e-b9a9-e91a2d66e200",
            TestTimestamp = new(day: 04, month: 05, year: 2021, hour: 20, minute: 15, second: 47),
            RecipientIdentifier = "3eb5f9",
        };

        //Act
        var response = gisgmp.CreateExportNoticeResponse(
            routingCode: "45382000",
            exportNoticeConfirmation: true);

        //Assert              
        Assert.True(CheckObjToXml(response, $@"{nameof(ExportNoticeResponse5)}", pathRoot));
    }
    #endregion
}

