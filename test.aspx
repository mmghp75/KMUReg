<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="test.aspx.vb" Inherits="KMUReg.test" %>

<%@ Register Assembly="RWCTRLW01" Namespace="Rayavaran.RWControls" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphead" runat="server">
    <link href="Styles/fileinput.min.css" media="all" rel="stylesheet" type="text/css" />
    <script src="Scripts/fileinput.min.js" type="text/javascript"></script>
    <script src="Scripts/fileinput_locale_fa.js" type="text/javascript"></script>

    <%--<link href="Styles/viewer.css" rel="stylesheet" />
    <script src="Scripts/viewer.js" type="text/javascript"></script>--%>

    <style type="text/css">
        .RightPanel {
            overflow-y: auto;
        }

        .kv-fileinput-caption {
            height: 42px;
        }

        button.fileinput-upload-button, button.fileinput-remove-button {
            display: none;
        }

        @media screen and (min-width:980px) {
            .RightPanel, .LeftPanel {
                height: 448px;
            }
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpNavBar" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpMain" runat="server">

    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:HiddenField runat="server" ID="hfNewPanelVisibility" Value="0" />
            <asp:HiddenField runat="server" ID="hfActivePanelId" ClientIDMode="Static" />
            <%--            <asp:HiddenField runat="server" ID="hfExpanedPanelIds" ClientIDMode="Static" />--%>

            <div class="panel panel-primary" runat="server" id="pnlDemographic" visible="true">
                <div class="panel-heading">
                    <h4 class="panel-title my-MouseCursorDefault my-Titr">مشخصات دموگرافیک
                    </h4>
                </div>
                <div class="panel-body">
                    <div runat="server" id="pnlDemographicMessage" class="alert alert-danger" role="alert" visible="False">
                        <asp:Label runat="server" ID="lblDemographicMessage" Text="پیام مورد نظر در اینجا قرار میگیرد." />
                    </div>
                    <div class="panel col-xs-12" style="margin-bottom: 15px">
                        <div class="col-xs-6 text-right">
                            <asp:TextBox ID="txtFileNo" runat="server" MaxLength="8" AutoPostBack="True" PlaceHolder="شماره پرونده" ToolTip="شماره پرونده" BackColor="LightGreen" CssClass="text-center form-control" onFocus="this.select()"></asp:TextBox>
                        </div>
                        <div class="col-xs-6 text-right" style="margin-bottom: 15px">
                            <asp:TextBox ID="txtNationalCode" runat="server" MaxLength="10" AutoPostBack="True" Placeholder="* کدملی" ToolTip="کدملی" CssClass="form-control" onFocus="this.select()"></asp:TextBox>
                        </div>
                        <div class="clearfix">
                        </div>
                        <div class="col-xs-6 text-right" style="margin-bottom: 15px">
                            <asp:TextBox runat="server" ID="txtFirstName" PlaceHolder="* نام" ToolTip="نام" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-xs-6 text-right" style="margin-bottom: 15px">
                            <asp:TextBox runat="server" ID="txtLastName" PlaceHolder="* نام خانوادگی" ToolTip="نام خانوادگی" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="clearfix">
                        </div>
                        <div class="col-xs-6 text-right" style="margin-bottom: 15px">
                            <div class="input-group">
                                <asp:Label Text="* جنسیت:" Class="input-group-addon" runat="server" ID="Label4" Font-Bold="true" />
                                <asp:RadioButtonList runat="server" Class="form-control my-inline-table" RepeatLayout="Flow" ID="rblGender" RepeatColumns="2">
                                    <asp:ListItem Text="&nbsp;&nbsp;مذکر" Value="1" />
                                    <asp:ListItem Text="&nbsp;&nbsp;مؤنث" Value="2" Style="margin-right: 5px;" />
                                </asp:RadioButtonList>
                            </div>
                        </div>
                        <div class="col-xs-6 text-right" style="margin-bottom: 15px">
                            <div class="input-group">
                                <asp:TextBox class="form-control" runat="server" ID="txtAgeOf" PlaceHolder="سن(سال)" ToolTip="سن(سال)" TextMode="Number"></asp:TextBox>
                                <span class="input-group-addon">* یاتاریخ‌تولد</span>
                                <div class="col-xs-12 text-right" style="margin: 0; padding: 0;">
                                    <cc1:DateTimePicker ID="dpBirthDateOf" runat="server" EnableTheming="true" CssClass="text-left" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ تولد" />
                                </div>
                            </div>
                        </div>
                        <div class="clearfix">
                        </div>
                        <div class="col-xs-6 text-right" style="margin-bottom: 15px">
                            <asp:TextBox runat="server" ID="txtHeight" PlaceHolder="قد(سانتیمتر)" ToolTip="قد(سانتیمتر)" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        </div>
                        <div class="col-xs-6 text-right" style="margin-bottom: 15px">
                            <asp:TextBox runat="server" ID="txtWeight" PlaceHolder="وزن(کیلوگرم)" ToolTip="وزن(کیلوگرم)" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        </div>
                        <div class="clearfix">
                        </div>
                        <div class="col-xs-6 text-right" style="margin-bottom: 15px">
                            <div class="input-group">
                                <asp:Label Text="وضعیت‌تأهل:" CssClass="input-group-addon" runat="server" ID="Label7" Font-Bold="true" />
                                <asp:RadioButtonList runat="server" ID="rblMarriage" CssClass="form-control my-inline-table" RepeatLayout="Flow" RepeatColumns="2">
                                    <asp:ListItem Text="&nbsp;&nbsp;متأهل" Value="1" Style="margin-right: 10px;" />
                                    <asp:ListItem Text="&nbsp;&nbsp;مجرد" Value="2" Style="margin-right: 10px;" />
                                </asp:RadioButtonList>
                            </div>
                        </div>
                        <div class="clearfix">
                        </div>
                        <div class="col-xs-6 text-right" style="margin-bottom: 15px">
                            <asp:TextBox runat="server" ID="txtCellNo" PlaceHolder="* تلفن‌همراه" ToolTip="تلفن‌همراه" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-xs-6 text-right" style="margin-bottom: 15px">
                            <asp:TextBox runat="server" ID="txtPhoneNo" PlaceHolder="* تلفن‌ثابت" ToolTip="تلفن‌ثابت" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                            <div class="input-group">
                                <asp:Label Text="سطح‌تحصیلات:" CssClass="input-group-addon " runat="server" ID="Label8" Font-Bold="true" />
                                <asp:RadioButtonList runat="server" ID="rblEducation" CssClass="form-control my-inline-table" RepeatLayout="Flow" RepeatColumns="8">
                                    <asp:ListItem Text="&nbsp;&nbsp;بی‌سواد" Value="1" />
                                    <asp:ListItem Text="&nbsp;&nbsp;ابتدایی" Value="2" Style="margin-right: 10px;" />
                                    <asp:ListItem Text="&nbsp;&nbsp;سیکل" Value="3" Style="margin-right: 10px;" />
                                    <asp:ListItem Text="&nbsp;&nbsp;دیپلم" Value="4" Style="margin-right: 10px;" />
                                    <asp:ListItem Text="&nbsp;&nbsp;فوق‌دیپلم" Value="5" Style="margin-right: 10px;" />
                                    <asp:ListItem Text="&nbsp;&nbsp;لیسانس" Value="6" Style="margin-right: 10px;" />
                                    <asp:ListItem Text="&nbsp;&nbsp;فوق‌لیسانس" Value="7" Style="margin-right: 10px;" />
                                    <asp:ListItem Text="&nbsp;&nbsp;دکتری و بالاتر" Value="8" Style="margin-right: 10px;" />
                                </asp:RadioButtonList>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                        <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                            <asp:TextBox runat="server" ID="txtAddress" Height="50px" PlaceHolder="* آدرس‌منزل" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <div class="panel-footer text-left" runat="server" id="pnlDemographicFooter" visible="true">
                <div class="input-group">
                    <div class="input-group-btn text-left">
                        <asp:Button runat="server" ID="btnCancelDemographic" Text="انصراف" CssClass="btn-danger" Width="200px" Font-Names="Titr" />
                        <asp:Button runat="server" ID="btnEditContract" Text="ویرایش مراجعه" CssClass="btn-success" Width="200px" Font-Names="Titr" />
                        <asp:Button runat="server" ID="btnContinueDemographic" Text="مراجعه جدید" CssClass="btn-success" Width="200px" Font-Names="Titr" />
                    </div>
                </div>
                </div>
            </div>
            <div runat="server" id="pnlPages" visible="false">
                <ul class="nav nav-tabs" role="tablist">
                    <li class="active"><a data-toggle="tab" onclick="SetTabIndex(this, hfActivePanelId);" href="#History" style="font-family: 'B Titr'">تاریخچه بالینی</a></li>
                    <li><a data-toggle="tab" onclick="SetTabIndex(this, hfActivePanelId);" href="#PhysicalExam" style="font-family: 'B Titr'">معاینه فیزیکی</a></li>
                    <li><a data-toggle="tab" onclick="SetTabIndex(this, hfActivePanelId);" href="#LabResults" style="font-family: 'B Titr'">جواب آزمایشات</a></li>
                    <li><a data-toggle="tab" onclick="SetTabIndex(this, hfActivePanelId);" href="#Prescription" style="font-family: 'B Titr'">تجویز پزشک</a></li>
                </ul>
            </div>
            <div class="tab-content">
                <div id="PhysicalExam" class="tab-pane fade">
                    <div class="panel panel-primary" runat="server" clientidmode="Static" id="pnlPhysicalExam">
                        <div class="panel-heading">
                            <h4 id="lblPhysicalExamTitle"
                                runat="server"
                                class="panel-title"></h4>
                        </div>
                        <div class="panel-body">
                            <div runat="server" id="pnlPhysicalExamMessage" class="alert alert-danger" role="alert" visible="False">
                                <asp:Label runat="server" ID="lblPhysicalExamMessage" Text="پیام مورد نظر در اینجا قرار میگیرد." />
                            </div>
                            <div class="panel col-xs-12">
                                <div class="col-xs-8 text-right">
                                    <asp:TextBox ID="txtCC" runat="server" MaxLength="10" Placeholder="* علت مراجعه" ToolTip="علت مراجعه" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px;">
                                    <div class="input-group" style="margin-right: 0; padding: 0;">
                                        <span class="input-group-addon">* تاریخ مراجعه</span>
                                        <div class="col-xs-12 text-right" style="margin: 0; padding: 0;">

                                        </div>
                                    </div>
                                </div>
                                <div class="clearfix">
                                </div>
                                <div class="col-xs-4 text-right">
                                    <asp:CheckBox ID="cbxSore02" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;زخم‌پا" CssClass="form-control"></asp:CheckBox>
                                </div>
                                <div class="col-xs-4 text-right">
                                    <asp:CheckBox ID="cbxInfect01" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;عفونت" CssClass="form-control"></asp:CheckBox>
                                </div>
                                <div class="col-xs-4 text-right">
                                    <asp:CheckBox ID="cbxSwell01" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;تورم، تاول و قرمزی" CssClass="form-control"></asp:CheckBox>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:Label Text="نوروپاتی:" CssClass="input-group-addon" runat="server" ID="Label9" Font-Bold="true" />
                                        <asp:CheckBoxList runat="server" CssClass="form-control my-inline-table" RepeatLayout="Flow" ID="cblNeuropathy" RepeatColumns="2">
                                            <asp:ListItem Text="&nbsp;&nbsp;پای‌چپ" Value="1" Style="margin-right: 10px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پای‌راست" Value="2" Style="margin-right: 10px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:Label Text="خشکی‌پا:" runat="server" CssClass="input-group-addon" ID="Label11" Font-Bold="true" />
                                        <asp:RadioButtonList runat="server" CssClass="form-control my-inline-table" RepeatLayout="Flow" ID="rblDry" RepeatColumns="3">
                                            <asp:ListItem Text="&nbsp;&nbsp;کم" Value="1" Style="margin-right: 10px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;متوسط" Value="2" Style="margin-right: 10px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;زیاد" Value="3" Style="margin-right: 10px;" />
                                        </asp:RadioButtonList>
                                    </div>
                                </div>
                                <div class="col-xs-4 text-right">
                                    <div class="input-group">
                                        <asp:Label Text="حرارت‌پا:" CssClass="input-group-addon" runat="server" ID="Label10" Font-Bold="true" />
                                        <asp:RadioButtonList runat="server" CssClass="form-control my-inline-table" RepeatLayout="Flow" ID="rblTemp" RepeatColumns="3">
                                            <asp:ListItem Text="&nbsp;&nbsp;کم" Value="1" Style="margin-right: 10px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;متوسط" Value="2" Style="margin-right: 10px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;زیاد" Value="3" Style="margin-right: 10px;" />
                                        </asp:RadioButtonList>
                                    </div>
                                </div>
                                <div class="clearfix">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="panel-footer text-left" runat="server" id="pnlPhysicalExamFooter">
                        <div class="input-group">
                            <div class="input-group-btn">
                                <div class="col-xs-10">
                                </div>
                                <div class="col-xs-2">
                                    <asp:Button runat="server" ID="btnCancelPhysicalExam" Text="پاک کردن صفحه" CssClass="btn-danger" Width="100%" Font-Names="Titr" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
             </div>

             <script type="text/javascript">

                SetTabIndex = function (sender, hfId) {
                    $("#" + hfId.id).val($(sender).attr("href").replace("#", ""));
                }

                InitTabPage = function (isPostBack) {
                    var selectedTab = $("#<%=hfActivePanelId.ClientID%>");
                    //alert(selectedTab.val());
                    var tabId = selectedTab.val() != "" ? selectedTab.val() : "PhysicalExam";
                    var tabCtrl = $('a[href="#PhysicalExam"]');
                    if (!isPostBack)
                        $('a[href="#' + tabId + '"]').tab('show');
                }

                $(document).ready(function () {
                    InitTabPage(false);
                });

                Sys.WebForms.PageRequestManager.getInstance().add_endRequest(InitTabPage(true));
            </script>
        </ContentTemplate>
    </asp:UpdatePanel>
    <%--<script type="text/javascript" src="Scripts/useViewer.js"></script>--%>
</asp:Content>
