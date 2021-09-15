using GisGmp.Common.NSI;
using GisGmp.Services.ExportNotice;
using GisGmp.Services.ExportNoticeNSI;

namespace GisGmp.Tests;

public class ExportNoticeNSI
{
    static readonly string pathRoot = $@"..\..\..\XmlDocument\{nameof(ExportNoticeNSI)}";

    #region ExportNoticeNSI #1
    [Fact]
    public void ExportNoticeNSIRequest1()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "G_30c7731b-739d-47bd-befd-86b50e800803",
            TestTimestamp = new(day: 04, month: 06, year: 2020, hour: 12, minute: 13, second: 51, millisecond: 621, kind: DateTimeKind.Local),
            RecipientIdentifier = "3eb6e5",
        };

        //Act
        var request = gisgmp.CreateExportNoticeNSIRequest(
            destination: new(
                recipientIdentifier: "3637ed", 
                routingCode: "45382000"),
            noticeNSI: new(
                directoryCode: "UBP")
            { 
                Items = new PayeeNSIInfoType[]
                {
                    new(
                        kBKlist: new[]{ "11111" },
                        name: "ФГБУ «ФКП Росреестра» по г Москва (Тестовые данные!)",
                        inn: "7705401341",
                        kpp: "770542151",
                        orgStatus: OrgStatus.Item1,
                        updateDate: new(day: 04, month: 06, year: 2020, hour: 12, minute: 10, second: 51)
                        )
                }
            });

        //Assert              
        Assert.True(CheckObjToXml(request, $@"{nameof(ExportNoticeNSIRequest1)}", pathRoot));
    }

    [Fact]
    public void ExportNoticeNSIResponse1()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "I555bfcc0-80b1-11ea-9aaa-00155d7a2500",
            RqId = "G_30c7731b-739d-47bd-befd-86b50e800803",
            TestTimestamp = new(day: 04, month: 06, year: 2020, hour: 12, minute: 14, second: 52, millisecond: 685, kind: DateTimeKind.Local),
            RecipientIdentifier = "3637ed",
        };

        //Act
        var response = gisgmp.CreateExportNoticeNSIResponse(
            routingCode: "45382000", 
            exportNoticeNSIConfirmation: true);

        //Assert              
        Assert.True(CheckObjToXml(response, $@"{nameof(ExportNoticeNSIResponse1)}", pathRoot));
    }
    #endregion

    #region ExportNoticeNSI #2
    [Fact]
    public void ExportNoticeNSIRequest2()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "G_554d04cb-5be6-4372-be84-2ffbfbc42264",
            TestTimestamp = new(day: 04, month: 06, year: 2020, hour: 12, minute: 13, second: 51, millisecond: 621, kind: DateTimeKind.Local),
            RecipientIdentifier = "3637ed",

        };

        //Act
        //var request = gisgmp.CreateExportNoticeNSIRequest(
        //    new Destination(recipientIdentifier: "3637ed", routingCode: "45382000"),
        //    new NoticeNSI(
        //        directoryCode: "OKTMO",
        //        signAttachment: false,
        //        oktmoNSIInfoType: new oktmoNSIInfoType[]
        //        {
        //                new(
        //                    name: "город Каспийск (Тестовые данные!)",
        //                    //oktmo: "82720000",
        //                    status: OrgStatus.Item1,
        //                    changeDate: new(day: 04, month: 06, year: 2020, hour: 12, minute: 10, second: 51)
        //                )
        //        }
        //        )
        //    );

        ////Assert              
        //Assert.True(CheckObjToXml(request, $@"{nameof(ExportNoticeNSIRequest2)}", pathRoot));
    }

    [Fact]
    public void ExportNoticeNSIResponse2()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "G_4a2c00d9-f3f8-48e9-a6d9-3e9da1c87081",
            RqId = "G_554d04cb-5be6-4372-be84-2ffbfbc42264",
            TestTimestamp = new(day: 04, month: 06, year: 2020, hour: 12, minute: 14, second: 52, millisecond: 685, kind: DateTimeKind.Local),
            RecipientIdentifier = "3637ed",
        };

        //Act
        var response = gisgmp.CreateExportNoticeNSIResponse(routingCode: "45382000", exportNoticeNSIConfirmation: true);

        //Assert              
        Assert.True(CheckObjToXml(response, $@"{nameof(ExportNoticeNSIResponse2)}", pathRoot));
    }
    #endregion
}
