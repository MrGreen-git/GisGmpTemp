using GisGmp.Quittance;
using GisGmp.SearchConditions;

namespace GisGmp.Tests;

public class ExportQuittances
{
    static readonly string pathRoot = $@"..\..\..\XmlDocument\{nameof(ExportQuittances)}";

    [Fact]
    public void ExportQuittancesRequest()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            TestId = "G_327e3906-5a3d-4c79-98f8-18bdd3f7228b",
            TestTimestamp = new(day: 30, month: 07, year: 2021, hour: 18, minute: 13, second: 51),

            SenderIdentifier = "3eacb7",
            SenderRole = "1",

            PageNumber = 1,
            PageLength = 100
        };

        //Act
        var request = gisgmp.CreateExportQuittancesRequest(
            quittancesKind: ExportQuittancesKind.Quittance,
            uin: new SupplierBillIDType[] 
            { 
                new("32117072411021588933") 
            });

        //Assert              
        Assert.True(CheckObjToXml(request, $@"{nameof(ExportQuittancesRequest)}", pathRoot));
    }

    [Fact]
    public void ExportQuittancesResponse()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            TestId = "I_1cc3a1dc-263d-40ef-9f0a-51f8b51433a3",
            TestTimestamp = new(day: 30, month: 07, year: 2021, hour: 18, minute: 13, second: 51),

            RqId = "G_327e3906-5a3d-4c79-98f8-18bdd3f7228b",           
            RecipientIdentifier = "3eacb7"
        };

        //Act
        var response = gisgmp.CreateExportQuittancesResponse(
            hasMore: false,
            quittance:
            new QuittanceType[]
            {
                new(
                    supplierBillID: "32117072411021588933",
                    creationDate: new(day: 30, month: 07, year: 2021, hour: 16, minute: 35, second: 56, millisecond: 284, kind: DateTimeKind.Local),
                    billStatus: AcknowledgmentStatusType.Item1,
                    paymentId: "10471020010005233009202000000001"
                    )
                {                    
                    TotalAmount = 500000,
                    TotalAmountSpecified = true, // TODO исправить
                    Balance = 0,
                    BalanceSpecified = true, // TODO исправить
                    AmountPayment = 500000,
                    AmountPaymentSpecified = true, //TODO исправить
                    IsRevoked = false,
                    IsRevokedSpecified = true // TODO исправить
                }
            });

        //Assert              
        Assert.True(CheckObjToXml(response, $@"{nameof(ExportQuittancesResponse)}", pathRoot));
    }
}
