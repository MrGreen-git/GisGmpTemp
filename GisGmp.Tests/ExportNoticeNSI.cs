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
            TestTimestamp = new(day: 01, month: 07, year: 2021, hour: 12, minute: 13, second: 51, millisecond: 621, kind: DateTimeKind.Local),
            RecipientIdentifier = "3637ed",
        };

        //Act
        var request = gisgmp.CreateExportNoticeNSIRequest(
            destination: new(
                recipientIdentifier: "3637ed", 
                routingCode: "45382000"),
            noticeNSI: new(
                directoryCode: "UBP")
            { 
                PayeeNSIInfoType = new PayeeNSIInfoType[]
                {
                    new(
                        name: "ФГБУ «ФКП Росреестра» по г Москва (Тестовые данные!)",
                        inn: "7705401341",
                        kpp: "770542151",
                        orgStatus: OrgStatus.Item1,
                        updateDate: new(day: 01, month: 07, year: 2021, hour: 12, minute: 10, second: 51))
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
            TestTimestamp = new(day: 01, month: 07, year: 2021, hour: 12, minute: 14, second: 52, millisecond: 685, kind: DateTimeKind.Local),
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
            TestTimestamp = new(day: 01, month: 07, year: 2021, hour: 12, minute: 13, second: 51, millisecond: 621, kind: DateTimeKind.Local),
            RecipientIdentifier = "3637ed",

        };

        //Act
        var request = gisgmp.CreateExportNoticeNSIRequest(
            destination: new(
                recipientIdentifier: "3637ed",
                routingCode: "45382000"),
            noticeNSI: new NoticeNSI(directoryCode: "OKTMO")
            { 
                OktmoNSIInfoType = new oktmoNSIInfoType[]
                {
                    new(
                        regionCode: "81",
                        areaCode: "615",
                        cityCode: "440",
                        localCode: "101",
                        controlNum: "9",
                        section: "2",
                        name: "с Комсомольское (Тестовые данные!)",
                        code: "81615440101",
                        lastChangeNum: "0",
                        lastChangeType: LastChangeType.Item0,
                        changeDate: new(day: 14, month: 06, year: 2013),
                        introductionDate: new(day: 01, month: 01, year: 2014),
                        updateDate: new(day: 07, month: 01, year: 2021, hour: 12, minute: 10, second: 51)
                    )
                }
                
            });

        //Assert              
        Assert.True(CheckObjToXml(request, $@"{nameof(ExportNoticeNSIRequest2)}", pathRoot));
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
            TestTimestamp = new(day: 01, month: 07, year: 2021, hour: 12, minute: 14, second: 52, millisecond: 685, kind: DateTimeKind.Local),
            RecipientIdentifier = "3637ed",
        };

        //Act
        var response = gisgmp.CreateExportNoticeNSIResponse(
            routingCode: "45382000", 
            exportNoticeNSIConfirmation: true);

        //Assert              
        Assert.True(CheckObjToXml(response, $@"{nameof(ExportNoticeNSIResponse2)}", pathRoot));
    }
    #endregion
}
