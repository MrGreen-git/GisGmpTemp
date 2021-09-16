using GisGmp.Quittance;
using GisGmp.Services.ForcedAckmowledgement;

namespace GisGmp.Tests;

public class ForcedAcknowledgement
{
    static readonly string pathRoot = $@"..\..\..\XmlDocument\{nameof(ForcedAcknowledgement)}";

    #region ForcedAcknowledgement #1
    [Fact]
    public void ForcedAcknowledgementRequest1()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "G_e5c906a5-0ceb-4320-97e5-233f32dd8925",
            TestTimestamp = new(day: 01, month: 07, year: 2021, hour: 18, minute: 13, second: 51),
            SenderIdentifier = "3eb551",
            SenderRole = "3"
        };

        //Act
        var request = gisgmp.CreateForcedAcknowledgementRequest(
            new Reconcile(
                supplierBillId: "18817072711544879499",
                paymentId: new PaymentIdType[]
                {
                    new("10471020010005233009202100000001")
                })
            );

        //Assert              
        Assert.True(CheckObjToXml(request, $@"{nameof(ForcedAcknowledgementRequest1)}", pathRoot));
    }

    [Fact]
    public void ForcedAcknowledgementResponse1()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "G_52858add-199d-4d20-b1de-ed324630232a",
            RqId = "G_e5c906a5-0ceb-4320-97e5-233f32dd8925",
            TestTimestamp = new(day: 01, month: 07, year: 2021, hour: 18, minute: 13, second: 51),
            RecipientIdentifier = "3eb551"
        };

        //Act
        var response = gisgmp.CreateForcedAcknowledgementResponse(
            quittances: new QuittanceType[]
            {
                new(
                    supplierBillID: "18817072711544879499",
                    creationDate: new(day: 30, month: 07, year: 2021, hour: 18, minute: 13, second: 56, millisecond: 284, kind: DateTimeKind.Local),
                    billStatus: AcknowledgmentStatusType.Item5,
                    paymentId: "10471020010005233009202100000001")
                {
                    TotalAmount = 50000,
                    TotalAmountSpecified = true,
                    Balance = 0,
                    BalanceSpecified = true,
                    AmountPaymentSpecified = true,
                    AmountPayment = 50000
                }
            });

        //Assert              
        Assert.True(CheckObjToXml(response, $@"{nameof(ForcedAcknowledgementResponse1)}", pathRoot));
    }
    #endregion

    #region ForcedAcknowledgement #2
    [Fact]
    public void ForcedAcknowledgementRequest2()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "G_e5c906a5-0ceb-4320-97e5-233f32dd8925",
            TestTimestamp = new(day: 01, month: 07, year: 2021, hour: 18, minute: 13, second: 51, millisecond: 0),
            SenderIdentifier = "3eb551",
            SenderRole = "3"
        };

        //Act
        var response = gisgmp.CreateForcedAcknowledgementRequest(
            annulmentReconcile: new(
                uin: new("18817072711544878492"))
            {
                Items = new PaymentIdType[]
                {
                    new("10471020010005233009202100000851")
                }
            });

        //Assert              
        Assert.True(CheckObjToXml(response, $@"{nameof(ForcedAcknowledgementResponse2)}", pathRoot));
    }

    [Fact]
    public void ForcedAcknowledgementResponse2()
    {
        //Arrange
        //Act
        //Assert              
        Assert.True(false);
    }
    #endregion

    #region ForcedAcknowledgement #3
    [Fact]
    public void ForcedAcknowledgementRequest3()
    {
        //Arrange
        //Act
        //Assert              
        Assert.True(false);
    }

    [Fact]
    public void ForcedAcknowledgementResponse3()
    {
        //Arrange
        //Act
        //Assert              
        Assert.True(false);
    }
    #endregion

    #region ForcedAcknowledgement #4
    [Fact]
    public void ForcedAcknowledgementRequest4()
    {
        //Arrange
        //Act
        //Assert              
        Assert.True(false);
    }

    [Fact]
    public void ForcedAcknowledgementResponse4()
    {
        //Arrange
        //Act
        //Assert              
        Assert.True(false);
    }
    #endregion
}
