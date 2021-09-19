namespace GisGmp.Tests;

public class ExportNotice
{
    static readonly string pathRoot = $@"..\..\..\XmlDocument\{nameof(ExportNotice)}";

    #region ExportNotice #1
    [Fact]
    public void ExportNoticeRequest1()
    {
        //Arrange
        GisGmpBuilder gisgmp = new GisGmpBuilder()
        {
            TestEnable = true,
            //
            TestId = "G_e1ed8ef7-19a6-44b9-ac0b-34a0e20b09bd",
            TestTimestamp = new DateTime(2020, 09, 30, 13, 12, 43, 696, DateTimeKind.Local),
            RecipientIdentifier = "3eb6e5",
        };

        //Act
        //var request = gisgmp.CreateExportNoticeRequest(
        //    new NoticeChargeType[]
        //    {
        //            new NoticeCharge(
        //                supplierBillID: "88818012505024915378",
        //                billDate: new DateTime(day: 30, month: 09, year: 2020, hour: 10, minute: 12, second: 30, millisecond: 313, kind: DateTimeKind.Local),
        //                totalAmount: 5000,
        //                purpose: "test",
        //                kbk: "32111301031016000130",
        //                name: "ФГБУ «ФКП Росреестра» по г Москва",
        //                payer: new NoticeChargeTypePayer() { PayerIdentifier = "1220000000007712579832", payerName = "Тестовый плательщик" },
        //                changeStatusInfo: new ChangeStatusInfo(meaning: "1")
        //                )
        //    },
        //    new Destination(recipientIdentifier: "3eb6e5", routingCode: "45382000")
        //    );

        ////Assert              
        //Assert.True(CheckObjToXml(request, $@"{nameof(ExportNoticeRequest1)}", pathRoot));
        Assert.True(false);
    }

    [Fact]
    public void ExportNoticeResponse1()
    {
        //Arrange
        //Act
        //Assert              
        Assert.True(false);
    }
    #endregion

    #region ExportNotice #2
    [Fact]
    public void ExportNoticeRequest2()
    {
        //Arrange
        //Act
        //Assert              
        Assert.True(false);
    }

    [Fact]
    public void ExportNoticeResponse2()
    {
        //Arrange
        //Act
        //Assert              
        Assert.True(false);
    }
    #endregion

    #region ExportNotice #3
    [Fact]
    public void ExportNoticeRequest3()
    {
        //Arrange
        //Act
        //Assert              
        Assert.True(false);
    }

    [Fact]
    public void ExportNoticeResponse3()
    {
        //Arrange
        //Act
        //Assert              
        Assert.True(false);
    }
    #endregion

    #region ExportNotice #4
    [Fact]
    public void ExportNoticeRequest4()
    {
        //Arrange
        //Act
        //Assert              
        Assert.True(false);
    }

    [Fact]
    public void ExportNoticeResponse4()
    {
        //Arrange
        //Act
        //Assert              
        Assert.True(false);
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
        //Act
        //Assert              
        Assert.True(false);
    }
    #endregion
}

