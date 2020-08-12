<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="RegPatient.aspx.vb" Inherits="KMUReg.RegPatient" %>

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
<asp:Content ID="Content3" ContentPlaceHolderID="cpMain" runat="server">
    <asp:HiddenField runat="server" ID="hfNewPanelVisibility" Value="0" />
    <asp:HiddenField runat="server" ID="hfActivePanelId" ClientIDMode="Static" />

    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:Literal runat="server" ID="litMessage"></asp:Literal>
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
                                <asp:RadioButtonList runat="server" ID="rblGender" CssClass="form-control my-inline-table" RepeatLayout="Flow" RepeatColumns="2">
                                    <asp:ListItem Text="&nbsp;&nbsp;مذکر" Value="1" Style="margin-right: 5px;" />
                                    <asp:ListItem Text="&nbsp;&nbsp;مؤنث" Value="2" Style="margin-right: 5px;" />
                                </asp:RadioButtonList>
                            </div>
                        </div>
                        <div class="col-xs-6 text-right" style="margin-bottom: 15px">
                            <asp:Panel runat="server" ID="pnlBirthDateOf">
                                <div class="input-group">
                                    <asp:TextBox class="form-control" runat="server" ID="txtAgeOf" PlaceHolder="سن(سال)" ToolTip="سن(سال)" TextMode="Number"></asp:TextBox>
                                    <span class="input-group-addon">* یاتاریخ‌تولد</span>
                                    <div class="col-xs-12 text-right" style="margin: 0; padding: 0;">
                                        <cc1:DateTimePicker ID="dpBirthDateOf" runat="server" EnableTheming="true" CssClass="text-left" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ تولد" />
                                    </div>
                                </div>
                            </asp:Panel>
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
                    <div class="input-group-btn">
                        <div class="col-xs-8">
                        </div>
                        <div class="col-xs-2">
                            <asp:Button runat="server" ID="btnCancelDemographic" Text="انصراف" CssClass="btn-danger" Width="100%" Font-Names="Titr" />
                        </div>
                        <div class="col-xs-2">
                            <asp:Button runat="server" ID="btnContinueDemographic" Text="ادامه" CssClass="btn-success" Width="100%" Font-Names="Titr" />
                        </div>
                    </div>
                </div>
            </div>
            <div runat="server" id="pnlPages" visible="false">
                <ul class="nav nav-tabs" role="tablist">
                    <li runat="server" clientidmode="Static" id="tabHistory" class="active"><a data-toggle="tab" onclick="SetTabIndex(this, hfActivePanelId);" href="#History" style="font-family: 'B Titr'">تاریخچه بالینی</a></li>
                    <li runat="server" clientidmode="Static" id="tabPhysicalExam"><a data-toggle="tab" onclick="SetTabIndex(this, hfActivePanelId);" href="#PhysicalExam" style="font-family: 'B Titr'">معاینه فیزیکی</a></li>
                    <li runat="server" clientidmode="Static" id="tabLabResults"><a data-toggle="tab" onclick="SetTabIndex(this, hfActivePanelId);" href="#LabResults" style="font-family: 'B Titr'">جواب آزمایشات</a></li>
                    <li runat="server" clientidmode="Static" id="tabPrescription"><a data-toggle="tab" onclick="SetTabIndex(this, hfActivePanelId);" href="#Prescription" style="font-family: 'B Titr'">تجویز پزشک</a></li>
                </ul>
            </div>
            <div class="tab-content">
                <div id="History" class="tab-pane fade in active">
                    <asp:Panel class="panel panel-primary" runat="server" ID="pnlHistory" ClientIDMode="Static" Visible="false">
                        <div class="panel-heading">
                            <h4 id="lblHistoryTitle"
                                runat="server"
                                class="panel-title"></h4>
                        </div>
                        <div class="panel-body">
                            <div runat="server" id="pnlHistoryMessage" class="alert alert-danger" role="alert" visible="False">
                                <asp:Label runat="server" ID="lbllHistoryMessage" Text="پیام مورد نظر در اینجا قرار میگیرد." />
                            </div>
                            <div class="panel col-xs-12">
                                <div class="col-xs-6 text-right">
                                    <div class="input-group">
                                        <asp:Label Text="* نوع‌دیابت:" CssClass="input-group-addon" runat="server" ID="Label2" Font-Bold="true" />
                                        <asp:RadioButtonList runat="server" CssClass="form-control my-inline-table" RepeatLayout="Flow" ID="rblDiabetTypeOf" RepeatColumns="3">
                                            <asp:ListItem Text="&nbsp;&nbsp;نوع 1" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;نوع 2" Value="2" Style="margin-right: 20px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;حاملگی" Value="3" Style="margin-right: 20px;" />
                                        </asp:RadioButtonList>
                                    </div>
                                </div>
                                <div class="col-xs-6 text-right" style="margin-bottom: 15px;">
                                    <div class="input-group" style="margin: 0; padding: 0;">
                                        <asp:TextBox runat="server" ID="txtDateOf01" PlaceHolder="مدت ابتلا(سال)" ToolTip="مدت ابتلا(سال)" CssClass="form-control" TextMode="Number"></asp:TextBox>
                                        <span class="input-group-addon">* یاتاریخ‌ابتلا</span>
                                        <div class="col-xs-12 text-right" style="margin: 0; padding: 0;">
                                            <cc1:DateTimePicker ID="dpDateOf01" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ حدودی ابتلا" />
                                        </div>
                                    </div>
                                </div>
                                <div class="clearfix">
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:CheckBox ID="cbxSore01" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;زخم‌پا" CssClass="form-control input-group-btn"></asp:CheckBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:CheckBox ID="cbxLaser01" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;لیزر زخم" CssClass="form-control input-group-btn"></asp:CheckBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:CheckBox ID="cbxDebrid01" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;دبریدمان" CssClass="form-control input-group-btn"></asp:CheckBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:CheckBox ID="cbxSurg01" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;جراحی" CssClass="form-control input-group-btn"></asp:CheckBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:CheckBox ID="cbxGang01" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;گانگرن" CssClass="form-control input-group-btn"></asp:CheckBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:CheckBox ID="cbxAmp01" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;آمپوتاسیون" CssClass="form-control"></asp:CheckBox>
                                </div>
                                <div class="clearfix">
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:Label Text="بیماری‌زمینه‌ای:" CssClass="input-group-addon" runat="server" ID="Label3" Font-Bold="true" />
                                        <asp:CheckBoxList runat="server" ID="cblDisease" CssClass="form-control my-inline-table" RepeatLayout="Flow" RepeatColumns="7" Style="height: auto">
                                            <asp:ListItem Text="&nbsp;&nbsp;قلبی‌عروقی" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;رتینوپاتی(بیماری‌های‌چشمی)" Value="2" />
                                            <asp:ListItem Text="&nbsp;&nbsp;مزمن‌کلیوی" Value="3" Style="margin-right: 30px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;تصلب‌شرائین" Value="4" Style="margin-right: 30px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;فشارخون" Value="5" Style="margin-right: 30px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;انسدادریوی" Value="6" Style="margin-right: 30px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;آسم" Value="7" Style="margin-right: 30px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;دیالیز" Value="8" Style="margin-right: 30px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;مزمن‌کبدی" Value="9" Style="margin-right: 30px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;ضعف‌ایمنی" Value="10" Style="margin-right: 30px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;سرطان" Value="11" Style="margin-right: 30px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;شیمی‌درمانی" Value="12" Style="margin-right: 30px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پیوند" Value="13" Style="margin-right: 30px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>
                                <div class="clearfix">
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:CheckBox ID="cbxAlcohol" runat="server" MaxLength="10" Text="&nbsp;&nbsp;مصرف مشروبات الکلی" CssClass="form-control input-group-btn"></asp:CheckBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:CheckBox ID="cbxSigarret" runat="server" MaxLength="10" Text="&nbsp;&nbsp;سیگار و قلیان" CssClass="form-control input-group-btn"></asp:CheckBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:CheckBox ID="cbxInPatient" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;سابقه بستری" CssClass="form-control input-group-btn"></asp:CheckBox>
                                </div>
                            </div>
                        </div>
                    </asp:Panel>
                    <div class="panel-footer text-left" runat="server" id="pnlHistoryFooter" visible="false">
                        <div class="input-group">
                            <div class="input-group-btn">
                                <div class="col-xs-10">
                                </div>
                                <div class="col-xs-2">
                                    <asp:Button runat="server" ID="btnCancelHistory" Text="پاک کردن صفحه" CssClass="btn-danger" Width="100%" Font-Names="Titr" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
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
                                <div class="col-xs-6 text-right">
                                    <asp:TextBox ID="txtCC" runat="server" MaxLength="10" Placeholder="* علت مراجعه" ToolTip="علت مراجعه" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="col-xs-6 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <span class="input-group-addon">* تاریخ مراجعه</span>
                                        <div class="col-xs-12 text-right" style="margin: 0; padding: 0;">
                                            <cc1:DateTimePicker ID="dpContract" runat="server" EnableTheming="true" CssClass="text-left" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ مراجعه" />
                                        </div>
                                    </div>
                                </div>
                                <div class="clearfix">
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:CheckBox ID="cbxSore02" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;زخم‌پا" CssClass="form-control input-group-btn"></asp:CheckBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:CheckBox ID="cbxInfect01" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;عفونت" CssClass="form-control input-group-btn"></asp:CheckBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:CheckBox ID="cbxSwell01" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;تورم، تاول و قرمزی" CssClass="form-control input-group-btn"></asp:CheckBox>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:CheckBox ID="cbxLaser02" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;لیزر" CssClass="form-control input-group-btn"></asp:CheckBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:CheckBox ID="cbxDebrid02" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;دبریدمان" CssClass="form-control input-group-btn"></asp:CheckBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:CheckBox ID="cbxGang02" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;گانگرن" CssClass="form-control input-group-btn"></asp:CheckBox>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:CheckBox ID="cbxAmp02" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;آمپوتاسیون" CssClass="form-control input-group-btn"></asp:CheckBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:CheckBox ID="cbxSurg02" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;جراحی" CssClass="form-control input-group-btn"></asp:CheckBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:CheckBox ID="cbxInPatient02" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;بستری" CssClass="form-control input-group-btn"></asp:CheckBox>
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
                <div id="LabResults" class="tab-pane fade">
                    <div class="panel panel-primary" runat="server" clientidmode="Static" id="pnlLabResults">
                        <div class="panel-heading">
                            <h4 id="lblLabResultsTitle"
                                runat="server"
                                class="panel-title"></h4>
                        </div>
                        <div class="panel-body">
                            <div runat="server" id="pnlLabResultsMessage" class="alert alert-danger" role="alert" visible="False">
                                <asp:Label runat="server" ID="lblLabResultsMessage" Text="پیام مورد نظر در اینجا قرار میگیرد." />
                            </div>
                            <div class="panel col-xs-12">
                                <div class="col-xs-4 text-right">
                                    <asp:TextBox ID="txtFBS" runat="server" MaxLength="10" Placeholder="* FBS" ToolTip="FBS" CssClass="form-control" TextMode="Number"></asp:TextBox>
                                </div>
                                <div class="col-xs-4 text-right">
                                    <asp:TextBox ID="txtA1C" runat="server" MaxLength="10" Placeholder="* Hb A1C" ToolTip="Hb A1C" CssClass="form-control" TextMode="Number" step="any"></asp:TextBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:Label Text="* تاریخ آزمایش:" CssClass="input-group-addon" runat="server" ID="Label1" Font-Bold="true" />
                                        <div class="col-xs-12 text-right" style="margin: 0; padding: 0;">
                                            <cc1:DateTimePicker ID="dpDateOf02" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ ثبت علایم حیاتی" />
                                        </div>
                                    </div>
                                </div>
                                <div class="clearfix">
                                </div>
                                <asp:Panel runat="server" ID="P03" Style="border-top-style: solid; border-top-color: brown; height: 1px; margin-bottom: 15px" CssClass="col-xs-12" />
                                <div class="col-xs-4 text-right">
                                    <asp:TextBox runat="server" ID="txtSystol" PlaceHolder="فشارخون سیستولیک mmHg" ToolTip="فشارخون سیستولیک mmHg" CssClass="form-control" Style="margin-bottom: 15px" TextMode="Number"></asp:TextBox>
                                </div>
                                <div class="col-xs-4 text-right">
                                    <asp:TextBox runat="server" ID="txtDyastol" PlaceHolder="فشارخون دیاستولیک mmHg" ToolTip="فشارخون دیاستولیک mmHg" CssClass="form-control" TextMode="Number"></asp:TextBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:TextBox runat="server" ID="txtO2" PlaceHolder="اشباع اکسیژن" ToolTip="اشباع اکسیژن" CssClass="form-control" TextMode="Number"></asp:TextBox>
                                </div>
                                <div class="clearfix">
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:TextBox runat="server" ID="txtHR" PlaceHolder="تعداد ضربان قلب در دقیقه" ToolTip="تعداد ضربان قلب در دقیقه" CssClass="form-control" TextMode="Number" MaxLength="4" ValidateRequestMode="Inherit"></asp:TextBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:TextBox runat="server" ID="txtRR" PlaceHolder="تعداد تنفس در دقیقه" ToolTip="تعداد تنفس در دقیقه" CssClass="form-control" TextMode="Number"></asp:TextBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:Label Text="تاریخ ثبت علایم‌حیاتی:" CssClass="input-group-addon" runat="server" ID="Label44" Font-Bold="true" />
                                        <div class="col-xs-12 text-right" style="margin: 0; padding: 0;">
                                            <cc1:DateTimePicker ID="dpDateOf03" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ ثبت علایم حیاتی" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="panel-footer text-left" runat="server" id="pnlLabResultsFooter">
                        <div class="input-group">
                            <div class="input-group-btn">
                                <div class="col-xs-10">
                                </div>
                                <div class="col-xs-2">
                                    <asp:Button runat="server" ID="btnCacelLabResults" Text="پاک کردن صفحه" CssClass="btn-danger" Width="100%" Font-Names="Titr" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div id="Prescription" class="tab-pane fade">
                    <div class="panel panel-primary" runat="server" clientidmode="Static" id="pnlPrescription">
                        <div class="panel-heading">
                            <h4 id="lblPrescriptionTitle"
                                runat="server"
                                class="panel-title"></h4>
                        </div>
                        <div class="panel-body">
                            <div runat="server" id="pnlPrescriptionMessage" class="alert alert-danger" role="alert" visible="False">
                                <asp:Label runat="server" ID="lblPrescriptionMessage" Text="پیام مورد نظر در اینجا قرار میگیرد." />
                            </div>
                            <div class="panel col-xs-12">
                                <div class="col-xs-4 text-right">
                                    <asp:CheckBox ID="cbxNeedAmp" runat="server" MaxLength="10" Text="&nbsp;&nbsp;نیاز به قطع عضو دارد" CssClass="form-control input-group-btn"></asp:CheckBox>
                                </div>
                                <div class="col-xs-4 text-right">
                                    <asp:CheckBox ID="cbxNeedSurg" runat="server" MaxLength="10" Text="&nbsp;&nbsp;نیاز به جراحی دارد" CssClass="form-control input-group-btn"></asp:CheckBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:CheckBox ID="cbxNeedDebrid" runat="server" MaxLength="10" Text="&nbsp;&nbsp;نیاز به دبریدمان دارد" CssClass="form-control input-group-btn"></asp:CheckBox>
                                </div>
                                <div class="clearfix">
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:CheckBox ID="cbxNeedShoe" runat="server" MaxLength="10" Text="&nbsp;&nbsp;تجویز کفش طبی دارد" CssClass="form-control input-group-btn"></asp:CheckBox>
                                </div>
                                <div class="col-xs-4 text-right">
                                    <asp:CheckBox ID="cbxNeedVisit" runat="server" MaxLength="10" Text="&nbsp;&nbsp;نیاز به معاینه منظم و دوره‌ای توسط پزشک دارد" CssClass="form-control input-group-btn"></asp:CheckBox>
                                </div>
                                <div class="col-xs-4 text-right">
                                    <asp:CheckBox ID="cbxNeedCover" runat="server" MaxLength="10" Text="&nbsp;&nbsp;نیاز به پانسمان و شست و شوی منظم زخم دارد" CssClass="form-control input-group-btn"></asp:CheckBox>
                                </div>
                                <div class="clearfix">
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:CheckBox ID="cbxNeedEducation" runat="server" MaxLength="10" Text="&nbsp;&nbsp;نیاز به مشاوره‌ی‌درمانی و آموزش خودمراقبتی دارد" CssClass="form-control input-group-btn"></asp:CheckBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:CheckBox ID="cbxNeedRehab" runat="server" Text="&nbsp;&nbsp;نیاز به فرایندهای توان‌بخشی دارد" MaxLength="10" CssClass="form-control input-group-addon"></asp:CheckBox>
                                </div>
                                <div class="clearfix">
                                </div>
                                <div class="col-xs-12 text-right">
                                    <div class="col-xs-12 text-right form-control" style="margin-bottom: 15px">
                                        <div class="col-xs-1 text-left">
                                            <asp:Label Text=" داروهای‌تجویزی:" runat="server" ID="Label21" Font-Bold="true" />
                                        </div>
                                        <div class="col-xs-11 text-right">
                                            <asp:CheckBoxList runat="server" ID="cblDrugs" CssClass="my-inline-table" RepeatLayout="Flow" RepeatColumns="5">
                                                <asp:ListItem Text="&nbsp;&nbsp;پماد فنیتوئین" Value="1" Style="margin-right: 30px;" />
                                            </asp:CheckBoxList>
                                        </div>
                                    </div>
                                </div>
                                <div class="clearfix">
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:Label Text="توضیحات" CssClass="input-group-addon" runat="server" ID="Label5" Font-Bold="true" />
                                        <asp:TextBox ID="txtFreeText" runat="server" CssClass="form-control" TextMode="MultiLine" Height="100px"></asp:TextBox>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                    <div class="panel-footer text-left" runat="server" id="pnlPrescriptionFooter">
                        <div class="input-group">
                            <div class="input-group-btn">
                                <div class="col-xs-6">
                                </div>
                                <div class="col-xs-2">
                                    <asp:Button runat="server" ID="btnCancelPrescription" Text="پاک کردن صفحه" CssClass="btn-danger" Width="100%" Font-Names="Titr" />
                                </div>
                                <div class="col-xs-2">
                                    <asp:Button runat="server" ID="btnCancelReg" Text="انصراف" CssClass="btn-danger" Width="100%" Font-Names="Titr" />
                                </div>
                                <div class="col-xs-2">
                                    <asp:Button runat="server" ID="btnOK" Text="ثبت" CssClass="btn-success" Width="100%" Font-Names="Titr" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <asp:Panel runat="server" ClientIDMode="Static" ID="pnlSore01" class="modal fade" role="dialog">
                <asp:Panel runat="server" ID="pnlSore01Back" Visible="false" class='modal-backdrop fade in' Style='height: 100%;' />
                <div class="modal-dialog media-middle">
                    <div class="modal-content">
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <div class="panel-title">مشخصات زخم</div>
                            </div>
                            <asp:Panel runat="server" class="panel-body" ID="pnlSore01Body">
                                <div runat="server" id="pnlSore01MSG" class="alert alert-danger" role="alert" visible="False">
                                    <asp:Label runat="server" ID="lblSore01MSG" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration01" class="form-control" PlaceHolder="زمان ابتلا(چندماه‌پیش؟)" ToolTip="زمان ابتلا(چندماه‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="* یا تاریخ آخرین زخم:" CssClass="input-group-addon" runat="server" ID="Label15" />
                                        <div class="col-xs-12 text-right" style="margin: 0; padding: 0;">
                                            <cc1:DateTimePicker ID="dpLastSore01" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ آخرین زخم" />
                                        </div>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل زخم‌های قبلی در پای چپ:" CssClass="input-group-addon" Font-Bold="true" runat="server" ID="Label16" />
                                        <asp:CheckBoxList runat="server" ID="cblSoreLocationL01" CssClass="form-control my-inline-table" RepeatLayout="Flow" RepeatColumns="4">
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" Style="margin-right: 20px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 20px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 20px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل زخم‌های قبلی در پای راست:" CssClass="input-group-addon" Font-Bold="true" runat="server" ID="Label17" />
                                        <asp:CheckBoxList runat="server" CssClass="form-control my-inline-table" RepeatLayout="Flow" ID="cblSoreLocationR01" RepeatColumns="4">
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" Style="margin-right: 20px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 20px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 20px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                            </asp:Panel>
                            <div class="panel-footer text-left">
                                <asp:Button runat="server" ID="btnCancelSore01" Text="انصراف" CssClass="btn-danger" />
                                <asp:Button runat="server" ID="btnOKSore01" Text="ثبت" CssClass="btn-success" />
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel runat="server" ClientIDMode="Static" ID="pnlLaser01" class="modal fade" role="dialog">
                <asp:Panel runat="server" ID="pnlLaser01Back" Visible="false" class='modal-backdrop fade in' Style='height: 100%;'></asp:Panel>
                <div class="modal-dialog media-middle">
                    <div class="modal-content">
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    مشخصات لیزرتراپی انجام شده
                                </div>
                            </div>
                            <asp:Panel runat="server" class="panel-body" ID="pnlLaser01Body">
                                <div runat="server" id="pnlLaser01MSG" class="alert alert-danger" role="alert" visible="False">
                                    <asp:Label runat="server" ID="lblLaser01MSG" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration02" PlaceHolder="زمان درمان(چندماه‌پیش؟)" ToolTip="زمان درمان(چندماه‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="* یا تاریخ آخرین درمان با لیزر:" CssClass="input-group-addon" runat="server" ID="Label19" />
                                        <div class="col-xs-12 text-right" style="margin: 0; padding: 0;">
                                            <cc1:DateTimePicker ID="dpLastLaser01" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ لیزر زخم" />
                                        </div>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right">
                                    <div class="input-group">
                                        <asp:Label Text="* محل لیزرتراپی‌های قبلی:" CssClass="input-group-addon" runat="server" ID="Label20" />
                                        <asp:CheckBoxList runat="server" ID="cblLaser" CssClass="form-control my-inline-table" RepeatLayout="Flow" RepeatColumns="2">
                                            <asp:ListItem Text="&nbsp;&nbsp;پای چپ" Value="1" Style="margin-right: 50px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پای راست" Value="2" Style="margin-right: 50px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>

                                <div class="clearfix"></div>
                            </asp:Panel>
                            <div class="panel-footer text-left">
                                <asp:Button runat="server" ID="btnCancelLaser01" Text="انصراف" CssClass="btn-danger" />
                                <asp:Button runat="server" ID="btnOKLaser01" Text="ثبت" CssClass="btn-success" />
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel runat="server" ClientIDMode="Static" ID="pnlDebrid01" class="modal fade" role="dialog">
                <asp:Panel runat="server" ID="pnlDebrid01Back" Visible="false" class='modal-backdrop fade in' Style='height: 100%;'></asp:Panel>
                <div class="modal-dialog media-middle">
                    <div class="modal-content">
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    مشخصات دبریدمان انجام شده
                                </div>
                            </div>
                            <asp:Panel runat="server" class="panel-body" ID="pnlDebrid01Body">
                                <div runat="server" id="pnlDebrid01MSG" class="alert alert-danger" role="alert" visible="False">
                                    <asp:Label runat="server" ID="lblDebrid01MSG" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration03" PlaceHolder="زمان دبرید(چندماه‌پیش؟)" ToolTip="زمان دبرید(چندماه‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="* یا تاریخ آخرین دبریدمان:" CssClass="input-group-addon" Font-Bold="true" runat="server" ID="Label23" />
                                        <div class="col-xs-12 text-right" style="margin: 0; padding: 0;">
                                            <cc1:DateTimePicker ID="dpLastDebrid01" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ آخرین دبریدمان" />
                                        </div>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right">
                                    <div class="input-group">
                                        <asp:Label Text="* محل دبریدمان‌های قبلی:" CssClass="input-group-addon" Font-Bold="true" runat="server" ID="Label18" />
                                        <asp:CheckBoxList runat="server" ID="cblDebrid" CssClass="form-control my-inline-table" RepeatLayout="Flow" RepeatColumns="5">
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" Style="margin-right: 10px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 10px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 10px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;بالاترازمچ" Value="5" Style="margin-right: 10px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>

                                <div class="clearfix"></div>
                            </asp:Panel>
                            <div class="panel-footer text-left">
                                <asp:Button runat="server" ID="btnCancelDebrid01" Text="انصراف" CssClass="btn-danger" />
                                <asp:Button runat="server" ID="btnOKDebrid01" Text="ثبت" CssClass="btn-success" />
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel runat="server" ClientIDMode="Static" ID="pnlSurg01" class="modal fade" role="dialog">
                <asp:Panel runat="server" ID="pnlSurg01Back" Visible="false" class='modal-backdrop fade in' Style='height: 100%;'></asp:Panel>
                <div class="col-xs-3"></div>
                <div class="modal-dialog media-middle col-xs-7">
                    <div class="modal-content">
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    مشخصات جراحی‌ها
                                </div>
                            </div>
                            <asp:Panel runat="server" class="panel-body" ID="pnlSurg01Body">
                                <div runat="server" id="pnlSurg01MSG" class="alert alert-danger" role="alert" visible="False">
                                    <asp:Label runat="server" ID="lblSurg01MSG" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration04" PlaceHolder="زمان جراحی(چندماه‌پیش؟)" ToolTip="زمان جراحی(چندماه‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="* یا تاریخ آخرین جراحی:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label27" />
                                        <div class="col-xs-12 text-right" style="margin: 0; padding: 0;">
                                            <cc1:DateTimePicker ID="dpLastSurg01" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ آخرین جراحی" />
                                        </div>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل جراحی‌های قبلی پای‌چپ:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label28" />
                                        <asp:CheckBoxList runat="server" ID="cblSurgL" CssClass="form-control my-inline-table" RepeatLayout="Flow" RepeatColumns="5">
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;بالاترازمچ" Value="5" Style="margin-right: 40px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل جراحی‌های قبلی پای‌راست:" CssClass="input-group-addon" Font-Bold="true" runat="server" ID="Label29" />
                                        <asp:CheckBoxList runat="server" CssClass="form-control my-inline-table" RepeatLayout="Flow" ID="cblSurgR" RepeatColumns="5">
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;بالاترازمچ" Value="5" Style="margin-right: 40px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>

                                <div class="clearfix"></div>
                            </asp:Panel>
                            <div class="panel-footer text-left">
                                <asp:Button runat="server" ID="btnCancelSurg01" Text="انصراف" CssClass="btn-danger" />
                                <asp:Button runat="server" ID="btnOKSurg01" Text="ثبت" CssClass="btn-success" />
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel runat="server" ClientIDMode="Static" ID="pnlGang01" class="modal fade" role="dialog">
                <asp:Panel runat="server" ID="pnlGang01Back" Visible="false" class='modal-backdrop fade in' Style='height: 100%;'></asp:Panel>
                <div class="modal-dialog media-middle">
                    <div class="modal-content">
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    مشخصات گانگرن
                                </div>
                            </div>
                            <asp:Panel runat="server" class="panel-body" ID="pnlGang01Body">
                                <div runat="server" id="pnlGang01MSG" class="alert alert-danger" role="alert" visible="False">
                                    <asp:Label runat="server" ID="lblGang01MSG" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration05" PlaceHolder="زمان گانگرن(چندماه‌پیش؟)" ToolTip="زمان گانگرن(چندماه‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="* یا تاریخ آخرین گانگرن:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label31" />
                                        <div class="col-xs-12 text-right" style="margin: 0; padding: 0;">
                                            <cc1:DateTimePicker ID="dpLastGang01" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ آخرین گانگرن" />
                                        </div>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:Label Text=" محل گانگرن‌های قبلی:" CssClass="input-group-addon" Font-Bold="true" runat="server" ID="Label32" />
                                        <asp:CheckBoxList runat="server" ID="cblGang" CssClass="form-control my-inline-table" RepeatLayout="Flow" RepeatColumns="2">
                                            <asp:ListItem Text="&nbsp;&nbsp;پای چپ" Value="1" Style="margin-right: 50px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پای راست" Value="2" Style="margin-right: 50px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>

                                <div class="clearfix"></div>
                            </asp:Panel>
                            <div class="panel-footer text-left">
                                <asp:Button runat="server" ID="btnCancelGang01" Text="انصراف" CssClass="btn-danger" />
                                <asp:Button runat="server" ID="btnOKGang01" Text="ثبت" CssClass="btn-success" />
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel runat="server" ClientIDMode="Static" ID="pnlAmp01" class="modal fade" role="dialog">
                <asp:Panel runat="server" ID="pnlAmp01Back" Visible="false" class='modal-backdrop fade in' Style='height: 100%;'></asp:Panel>
                <div class="modal-dialog media-middle">
                    <div class="modal-content">
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    مشخصات آمپوتاسیون
                                </div>
                            </div>
                            <asp:Panel runat="server" class="panel-body" ID="pnlAmp01Body">
                                <div runat="server" id="pnlAmp01MSG" class="alert alert-danger" role="alert" visible="False">
                                    <asp:Label runat="server" ID="lblAmp01MSG" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration06" PlaceHolder="زمان آمپوتاسیون(چندماه‌پیش؟)" ToolTip="زمان آمپوتاسیون(چندماه‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="*یا تاریخ آخرین آمپوتاسیون:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label35" />
                                        <div class="col-xs-12 text-right" style="margin: 0; padding: 0;">
                                            <cc1:DateTimePicker ID="dpLastAmp01" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ آخرین آمپوتاسیون" />
                                        </div>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px;">
                                    <div class="input-group">
                                        <asp:Label Text="* محل آمپوتاسیون‌های قبلی پای‌چپ:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label36" />
                                        <asp:CheckBoxList runat="server" ID="cblAmpL" CssClass="form-control my-inline-table" RepeatLayout="Flow" RepeatColumns="3" Style="height: auto">
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 20px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 20px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;ساق" Value="5" Style="margin-right: 20px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;ران" Value="6" Style="margin-right: 20px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل آمپوتاسیون‌های قبلی پای‌راست:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label37" />
                                        <asp:CheckBoxList runat="server" ID="cblAmpR" CssClass="form-control my-inline-table" RepeatLayout="Flow" RepeatColumns="3" Style="height: auto">
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 20px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 20px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;ساق" Value="5" Style="margin-right: 20px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;ران" Value="6" Style="margin-right: 20px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                            </asp:Panel>
                            <div class="panel-footer text-left">
                                <asp:Button runat="server" ID="btnCancelAmp01" Text="انصراف" CssClass="btn-danger" />
                                <asp:Button runat="server" ID="btnOKAmp01" Text="ثبت" CssClass="btn-success" />
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel runat="server" ClientIDMode="Static" ID="pnlInPatient01" class="modal fade" role="dialog">
                <asp:Panel runat="server" ID="pnlInPatient01Back" Visible="false" class='modal-backdrop fade in' Style='height: 100%;'></asp:Panel>
                <div class="modal-dialog media-middle">
                    <div class="modal-content">
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    مشخصات سابقه بستری
                                </div>
                            </div>
                            <asp:Panel runat="server" class="panel-body" ID="pnlInPatient01Body">
                                <div runat="server" id="pnlInPatient01MSG" class="alert alert-danger" role="alert" visible="False">
                                    <asp:Label runat="server" ID="lblInPatient01MSG" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration07" PlaceHolder="زمان بستری(چندماه‌پیش؟)" ToolTip="زمان بستری(چندماه‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="* یا تاریخ آخرین بستری:" CssClass="input-group-addon" runat="server" ID="Label22" />
                                        <div class="col-xs-12 text-right" style="margin: 0; padding: 0;">
                                            <cc1:DateTimePicker ID="dpLastInPatient01" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ آخرین بستری" />
                                        </div>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-left">
                                    <div class="input-group">
                                        <asp:Label Text="علت بستری:" CssClass="input-group-addon" runat="server" ID="Label24" Font-Bold="true" />
                                        <asp:TextBox ID="txtSurg01Cause" runat="server" MaxLength="8" CssClass="text-right form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                            </asp:Panel>
                            <div class="panel-footer text-left">
                                <asp:Button runat="server" ID="btnCancelInPatient01" Text="انصراف" CssClass="btn-danger" />
                                <asp:Button runat="server" ID="btnOKInPatient01" Text="ثبت" CssClass="btn-success" />
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel runat="server" ClientIDMode="Static" ID="pnlSore02" class="modal fade" role="dialog">
                <asp:Panel runat="server" ID="pnlSore02Back" Visible="false" class='modal-backdrop fade in' Style='height: 100%;'></asp:Panel>
                <div class="modal-lg modal-dialog media-middle">
                    <div class="modal-content">
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    مشخصات زخم‌ها
                                </div>
                            </div>
                            <div class="panel-body">
                                <div runat="server" id="pnlSore02MSG" class="alert alert-danger" role="alert" visible="False">
                                    <asp:Label runat="server" ID="lblSore02MSG" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration08" PlaceHolder="زمان زخم(چندماه‌پیش؟)" ToolTip="زمان زخم(چندماه‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="* یا تاریخ ایجاد زخم:" CssClass="input-group-addon" Font-Bold="true" runat="server" ID="Label25" />
                                        <div class="col-xs-12 text-right" style="margin: 0; padding: 0;">
                                            <cc1:DateTimePicker ID="dpNewSore" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ ایجاد زخم" />
                                        </div>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:TextBox runat="server" ID="txtNewSoreCountOfL" PlaceHolder="* تعداد زخم‌های پای چپ" ToolTip="تعداد زخم‌های پای چپ" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:TextBox runat="server" ID="txtNewSoreCountOfR" PlaceHolder="* تعداد زخم‌های پای راست" ToolTip="تعداد زخم‌های پای راست" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 15px">
                                    <asp:TextBox runat="server" ID="txtNewMaxLength" PlaceHolder="* طول بزرگترین زخم(میلیمتر)" ToolTip="طول بزرگترین زخم(میلیمتر)" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل زخم‌های پای‌چپ:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label26" />
                                        <asp:CheckBoxList runat="server" ID="cblNewSoreL" RepeatColumns="5" CssClass="form-control my-inline-table" RepeatLayout="Flow">
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;بالاترازمچ" Value="5" Style="margin-right: 40px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل زخم‌های پای‌راست:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label30" />
                                        <asp:CheckBoxList runat="server" ID="cblNewSoreR" RepeatColumns="5" CssClass="form-control my-inline-table" RepeatLayout="Flow">
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;بالاترازمچ" Value="5" Style="margin-right: 40px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:Label Text="* شدیدترین‌زخم‌پای‌چپ:" runat="server" Font-Bold="true" CssClass="input-group-addon" ID="Label33" />
                                        <asp:RadioButtonList runat="server" ID="rblNewWorstSoreL" CssClass="form-control my-inline-table" RepeatLayout="Flow" RepeatColumns="1" Style="height: auto;">
                                            <asp:ListItem Text="&nbsp;&nbsp;مرحله صفر: پا شدیدا مستعد ایجاد زخم می‌باشد، ولی هنوز زخمی ایجاد نشده است" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;مرحله1: زخم سطحی است" Value="2" />
                                            <asp:ListItem Text="&nbsp;&nbsp;مرحله2: زخم عمقی با درگیری ماهیچه، تاندون و مفصل و بدون درگیری استخوانی. ممکن است دچار عفونت نیز بشود" Value="3" />
                                            <asp:ListItem Text="&nbsp;&nbsp;مرحله3: زخم عمقی با درگیری استخوانی. احتمالاً استئومیلیت وجود دارد و ممکن است آبسه نیز تشکیل شود" Value="4" />
                                            <asp:ListItem Text="&nbsp;&nbsp;مرحله4: گانگرن موضعی درانگشتان، جلوی پا یا پاشنه تشکیل شده است" Value="5" />
                                            <asp:ListItem Text="&nbsp;&nbsp;مرحله5: گانگرن شدیدکه ممکن است به آمپوتاسیون و قطع عضو منجر شود" Value="6" />
                                        </asp:RadioButtonList>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right">
                                    <div class="input-group">
                                        <asp:Label Text="* شدیدترین‌زخم‌پای‌راست:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label45" />
                                        <asp:RadioButtonList runat="server" ID="rblNewWorstSoreR" RepeatColumns="1" CssClass="form-control my-inline-table" RepeatLayout="Flow" Style="height: auto;">
                                            <asp:ListItem Text="&nbsp;&nbsp;مرحله صفر: پا شدیدا مستعد ایجاد زخم می‌باشد، ولی هنوز زخمی ایجاد نشده است" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;مرحله1: زخم سطحی است" Value="2" />
                                            <asp:ListItem Text="&nbsp;&nbsp;مرحله2: زخم عمقی با درگیری ماهیچه، تاندون و مفصل و بدون درگیری استخوانی. ممکن است دچار عفونت نیز بشود" Value="3" />
                                            <asp:ListItem Text="&nbsp;&nbsp;مرحله3: زخم عمقی با درگیری استخوانی. احتمالاً استئومیلیت وجود دارد و ممکن است آبسه نیز تشکیل شود" Value="4" />
                                            <asp:ListItem Text="&nbsp;&nbsp;مرحله4: گانگرن موضعی درانگشتان، جلوی پا یا پاشنه تشکیل شده است" Value="5" />
                                            <asp:ListItem Text="&nbsp;&nbsp;مرحله5: گانگرن شدیدکه ممکن است به آمپوتاسیون و قطع عضو منجر شود" Value="6" />
                                        </asp:RadioButtonList>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                            </div>
                            <div class="panel-footer text-left">
                                <asp:Button runat="server" ID="btnCancelSore02" Text="انصراف" CssClass="btn-danger" />
                                <asp:Button runat="server" ID="btnOKSore02" Text="ثبت" CssClass="btn-success" />
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel runat="server" ClientIDMode="Static" ID="pnlInfect01" class="modal fade" role="dialog">
                <asp:Panel runat="server" ID="pnlInfect01Back" Visible="false" class='modal-backdrop fade in' Style='height: 100%;'></asp:Panel>
                <div class="modal-dialog media-middle">
                    <div class="modal-content">
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    مشخصات عفونت‌ها
                                </div>
                            </div>
                            <div class="panel-body">
                                <div runat="server" id="pnlInfect01MSG" class="alert alert-danger" role="alert" visible="False">
                                    <asp:Label runat="server" ID="lblInfect01MSG" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration09" PlaceHolder="زمان عفونت(چندروز‌پیش؟)" ToolTip="زمان عفونت(چندروز‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="* یا تاریخ ایجاد عفونت:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label34" />
                                        <div class="col-xs-12 text-right" style="margin: 0; padding: 0;">
                                            <cc1:DateTimePicker ID="dpNewInfect" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ ایجاد عفونت" />
                                        </div>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل‌عفونت‌پای‌چپ:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label38" />
                                        <asp:CheckBoxList runat="server" ID="cblNewInfectL" RepeatColumns="5" CssClass="form-control my-inline-table" RepeatLayout="Flow">
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" Style="margin-right: 10px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 10px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 10px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;بالاترازمچ" Value="5" Style="margin-right: 10px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل‌عفونت‌پای‌راست:" CssClass="input-group-addon" Font-Bold="true" runat="server" ID="Label39" />
                                        <asp:CheckBoxList runat="server" ID="cblNewInfectR" RepeatColumns="5" CssClass="form-control my-inline-table" RepeatLayout="Flow">
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" Style="margin-right: 10px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 10px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 10px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;بالاترازمچ" Value="5" Style="margin-right: 10px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>

                                <div class="clearfix"></div>
                            </div>
                            <div class="panel-footer text-left">
                                <asp:Button runat="server" ID="btnCancelInfect01" Text="انصراف" CssClass="btn-danger" />
                                <asp:Button runat="server" ID="btnOKInfect01" Text="ثبت" CssClass="btn-success" />
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel runat="server" ClientIDMode="Static" ID="pnlSwell01" class="modal fade" role="dialog">
                <asp:Panel runat="server" ID="pnlSwell01Back" Visible="false" class='modal-backdrop fade in' Style='height: 100%;'></asp:Panel>
                <div class="modal-dialog media-middle modal-lg">
                    <div class="modal-content">
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    مشخصات تورم،تاول و قرمزی‌ها
                                </div>
                            </div>
                            <div class="panel-body">
                                <div runat="server" id="pnlSwell01MSG" class="alert alert-danger" role="alert" visible="False">
                                    <asp:Label runat="server" ID="lblSwell01MSG" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration10" PlaceHolder="زمان ایجاد(چندروز‌پیش؟)" ToolTip="زمانایجاد تورم،تاول و قرمزی(چندروز‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="* یا تاریخ ایجاد تورم،تاول و قرمزی:" runat="server" Font-Bold="true" CssClass="input-group-addon" ID="Label41" />
                                        <div class="col-xs-12 text-right" style="margin: 0; padding: 0;">
                                            <cc1:DateTimePicker ID="dpNewSwell" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ ایجاد تورم،تاول و قرمزی" />
                                        </div>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل تورم،تاول و قرمزی‌های پای‌چپ:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label42" />
                                        <asp:CheckBoxList runat="server" ID="cblNewSwellL" RepeatColumns="5" CssClass="form-control my-inline-table" RepeatLayout="Flow">
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;بالاترازمچ" Value="5" Style="margin-right: 40px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل تورم،تاول و قرمزی‌های پای‌راست:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label43" />
                                        <asp:CheckBoxList runat="server" ID="cblNewSwellR" RepeatColumns="5" CssClass="form-control my-inline-table" RepeatLayout="Flow">
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;بالاترازمچ" Value="5" Style="margin-right: 40px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>

                                <div class="clearfix"></div>
                            </div>
                            <div class="panel-footer text-left">
                                <asp:Button runat="server" ID="btnCancelSwell01" Text="انصراف" CssClass="btn-danger" />
                                <asp:Button runat="server" ID="btnOKSwell01" Text="ثبت" CssClass="btn-success" />
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel runat="server" ClientIDMode="Static" ID="pnlLaser02" class="modal fade" role="dialog">
                <asp:Panel runat="server" ID="pnlLaser02Back" Visible="false" class='modal-backdrop fade in' Style='height: 100%;'></asp:Panel>
                <div class="modal-dialog media-middle">
                    <div class="modal-content">
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    مشخصات لیزرتراپی
                                </div>
                            </div>
                            <asp:Panel runat="server" class="panel-body" ID="pnlLaser02Body">
                                <div runat="server" id="pnlLaser02MSG" class="alert alert-danger" role="alert" visible="False">
                                    <asp:Label runat="server" ID="lblLaser02MSG" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration11" PlaceHolder="زمان درمان(چندماه‌پیش؟)" ToolTip="زمان درمان(چندماه‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="* یا تاریخ درمان با لیزر:" CssClass="input-group-addon" runat="server" ID="Label6" />
                                        <div class="col-xs-12 text-right" style="margin: 0; padding: 0;">
                                            <cc1:DateTimePicker ID="dpLastLaser02" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ لیزرزخم" />
                                        </div>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right">
                                    <div class="input-group">
                                        <asp:Label Text="* محل لیزرتراپی‌های جدید:" CssClass="input-group-addon" runat="server" ID="Label12" />
                                        <asp:CheckBoxList runat="server" ID="cblLaser02" CssClass="form-control my-inline-table" RepeatLayout="Flow" RepeatColumns="2">
                                            <asp:ListItem Text="&nbsp;&nbsp;پای چپ" Value="1" Style="margin-right: 50px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پای راست" Value="2" Style="margin-right: 50px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>

                                <div class="clearfix"></div>
                            </asp:Panel>
                            <div class="panel-footer text-left">
                                <asp:Button runat="server" ID="btnCancelLaser02" Text="انصراف" CssClass="btn-danger" />
                                <asp:Button runat="server" ID="btnOKLaser02" Text="ثبت" CssClass="btn-success" />
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel runat="server" ClientIDMode="Static" ID="pnlDebrid02" class="modal fade" role="dialog">
                <asp:Panel runat="server" ID="pnlDebrid02Back" Visible="false" class='modal-backdrop fade in' Style='height: 100%;'></asp:Panel>
                <div class="modal-dialog media-middle">
                    <div class="modal-content">
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    مشخصات دبریدمان
                                </div>
                            </div>
                            <asp:Panel runat="server" class="panel-body" ID="pnlDebrid02Body">
                                <div runat="server" id="pnlDebrid02MSG" class="alert alert-danger" role="alert" visible="False">
                                    <asp:Label runat="server" ID="lblDebrid02MSG" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration12" PlaceHolder="زمان دبرید(چندماه‌پیش؟)" ToolTip="زمان دبرید(چندماه‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="* یا تاریخ دبریدمان:" CssClass="input-group-addon" Font-Bold="true" runat="server" ID="Label13" />
                                        <div class="col-xs-12 text-right" style="margin: 0; padding: 0;">
                                            <cc1:DateTimePicker ID="dpLastDebrid02" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ دبریدمان" />
                                        </div>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right">
                                    <div class="input-group">
                                        <asp:Label Text="* محل دبریدمان:" CssClass="input-group-addon" Font-Bold="true" runat="server" ID="Label14" />
                                        <asp:CheckBoxList runat="server" ID="cblDebrid02" CssClass="form-control my-inline-table" RepeatLayout="Flow" RepeatColumns="5">
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" Style="margin-right: 10px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 10px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 10px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;بالاترازمچ" Value="5" Style="margin-right: 10px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>

                                <div class="clearfix"></div>
                            </asp:Panel>
                            <div class="panel-footer text-left">
                                <asp:Button runat="server" ID="btnCancelDebrid02" Text="انصراف" CssClass="btn-danger" />
                                <asp:Button runat="server" ID="btnOKDebrid02" Text="ثبت" CssClass="btn-success" />
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel runat="server" ClientIDMode="Static" ID="pnlSurg02" class="modal fade" role="dialog">
                <asp:Panel runat="server" ID="pnlSurg02Back" Visible="false" class='modal-backdrop fade in' Style='height: 100%;'></asp:Panel>
                <div class="col-xs-3"></div>
                <div class="modal-dialog media-middle col-xs-7">
                    <div class="modal-content">
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    مشخصات جراحی
                                </div>
                            </div>
                            <asp:Panel runat="server" class="panel-body" ID="pnlSurg02Body">
                                <div runat="server" id="pnlSurg02MSG" class="alert alert-danger" role="alert" visible="False">
                                    <asp:Label runat="server" ID="lblSurg02MSG" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration13" PlaceHolder="زمان جراحی(چندماه‌پیش؟)" ToolTip="زمان جراحی(چندماه‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="* یا تاریخ جراحی:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label40" />
                                        <div class="col-xs-12 text-right" style="margin: 0; padding: 0;">
                                            <cc1:DateTimePicker ID="dpLastSurg02" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ جراحی" />
                                        </div>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل جراحی پای‌چپ:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label46" />
                                        <asp:CheckBoxList runat="server" ID="cblSurg02L" CssClass="form-control my-inline-table" RepeatLayout="Flow" RepeatColumns="5">
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;بالاترازمچ" Value="5" Style="margin-right: 40px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل جراحی پای‌راست:" CssClass="input-group-addon" Font-Bold="true" runat="server" ID="Label47" />
                                        <asp:CheckBoxList runat="server" CssClass="form-control my-inline-table" RepeatLayout="Flow" ID="cblSurg02R" RepeatColumns="5">
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;بالاترازمچ" Value="5" Style="margin-right: 40px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>

                                <div class="clearfix"></div>
                            </asp:Panel>
                            <div class="panel-footer text-left">
                                <asp:Button runat="server" ID="btnCancelSurg02" Text="انصراف" CssClass="btn-danger" />
                                <asp:Button runat="server" ID="btnOKSurg02" Text="ثبت" CssClass="btn-success" />
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel runat="server" ClientIDMode="Static" ID="pnlGang02" class="modal fade" role="dialog">
                <asp:Panel runat="server" ID="pnlGang02Back" Visible="false" class='modal-backdrop fade in' Style='height: 100%;'></asp:Panel>
                <div class="modal-dialog media-middle">
                    <div class="modal-content">
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    مشخصات گانگرن
                                </div>
                            </div>
                            <asp:Panel runat="server" class="panel-body" ID="pnlGang02Body">
                                <div runat="server" id="pnlGang02MSG" class="alert alert-danger" role="alert" visible="False">
                                    <asp:Label runat="server" ID="lblGang02MSG" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration14" PlaceHolder="زمان گانگرن(چندماه‌پیش؟)" ToolTip="زمان گانگرن(چندماه‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="* یا تاریخ گانگرن:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label48" />
                                        <div class="col-xs-12 text-right" style="margin: 0; padding: 0;">
                                            <cc1:DateTimePicker ID="dpLastGang02" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ گانگرن" />
                                        </div>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:Label Text=" محل گانگرن:" CssClass="input-group-addon" Font-Bold="true" runat="server" ID="Label49" />
                                        <asp:CheckBoxList runat="server" ID="cblGang02" CssClass="form-control my-inline-table" RepeatLayout="Flow" RepeatColumns="2">
                                            <asp:ListItem Text="&nbsp;&nbsp;پای چپ" Value="1" Style="margin-right: 50px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پای راست" Value="2" Style="margin-right: 50px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>

                                <div class="clearfix"></div>
                            </asp:Panel>
                            <div class="panel-footer text-left">
                                <asp:Button runat="server" ID="btnCancelGang02" Text="انصراف" CssClass="btn-danger" />
                                <asp:Button runat="server" ID="btnOKGang02" Text="ثبت" CssClass="btn-success" />
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel runat="server" ClientIDMode="Static" ID="pnlAmp02" class="modal fade" role="dialog">
                <asp:Panel runat="server" ID="pnlAmp02Back" Visible="false" class='modal-backdrop fade in' Style='height: 100%;'></asp:Panel>
                <div class="modal-dialog media-middle">
                    <div class="modal-content">
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    مشخصات آمپوتاسیون
                                </div>
                            </div>
                            <asp:Panel runat="server" class="panel-body" ID="pnlAmp02Body">
                                <div runat="server" id="pnlAmp02MSG" class="alert alert-danger" role="alert" visible="False">
                                    <asp:Label runat="server" ID="lblAmp02MSG" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration15" PlaceHolder="زمان آمپوتاسیون(چندماه‌پیش؟)" ToolTip="زمان آمپوتاسیون(چندماه‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="*یا تاریخ آمپوتاسیون:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label50" />
                                        <div class="col-xs-12 text-right" style="margin: 0; padding: 0;">
                                            <cc1:DateTimePicker ID="dpLastAmp02" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ آمپوتاسیون" />
                                        </div>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px;">
                                    <div class="input-group">
                                        <asp:Label Text="* محل آمپوتاسیون پای‌چپ:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label51" />
                                        <asp:CheckBoxList runat="server" ID="cblAmp02L" CssClass="form-control my-inline-table" RepeatLayout="Flow" RepeatColumns="3" Style="height: auto">
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 20px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 20px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;ساق" Value="5" Style="margin-right: 20px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;ران" Value="6" Style="margin-right: 20px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل آمپوتاسیون‌ پای‌راست:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label52" />
                                        <asp:CheckBoxList runat="server" ID="cblAmp02R" CssClass="form-control my-inline-table" RepeatLayout="Flow" RepeatColumns="3" Style="height: auto">
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 20px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 20px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;ساق" Value="5" Style="margin-right: 20px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;ران" Value="6" Style="margin-right: 20px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                            </asp:Panel>
                            <div class="panel-footer text-left">
                                <asp:Button runat="server" ID="btnCancelAmp02" Text="انصراف" CssClass="btn-danger" />
                                <asp:Button runat="server" ID="btnOKAmp02" Text="ثبت" CssClass="btn-success" />
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel runat="server" ClientIDMode="Static" ID="pnlInPatient02" class="modal fade" role="dialog">
                <asp:Panel runat="server" ID="pnlInPatient02Back" Visible="false" class='modal-backdrop fade in' Style='height: 100%;'></asp:Panel>
                <div class="modal-dialog media-middle">
                    <div class="modal-content">
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    مشخصات بستری
                                </div>
                            </div>
                            <asp:Panel runat="server" class="panel-body" ID="pnlInPatient02Body">
                                <div runat="server" id="pnlInPatient02MSG" class="alert alert-danger" role="alert" visible="False">
                                    <asp:Label runat="server" ID="lblInPatient02MSG" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 15px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration16" PlaceHolder="زمان بستری(چندماه‌پیش؟)" ToolTip="زمان بستری(چندماه‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="* یا تاریخ بستری:" CssClass="input-group-addon" runat="server" ID="Label53" />
                                        <div class="col-xs-12 text-right" style="margin: 0; padding: 0;">
                                            <cc1:DateTimePicker ID="dpLastInPatient02" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ بستری" />
                                        </div>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-left">
                                    <div class="input-group">
                                        <asp:Label Text="علت بستری:" CssClass="input-group-addon" runat="server" ID="Label54" Font-Bold="true" />
                                        <asp:TextBox ID="txtSurg02Cause" runat="server" MaxLength="8" CssClass="text-right form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                            </asp:Panel>
                            <div class="panel-footer text-left">
                                <asp:Button runat="server" ID="btnCancelInPatient02" Text="انصراف" CssClass="btn-danger" />
                                <asp:Button runat="server" ID="btnOKInPatient02" Text="ثبت" CssClass="btn-success" />
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>

            <script type="text/javascript">
                SetTabIndex = function (sender, hfId) {
                    $("#" + hfId.id).val($(sender).parent().attr("id"));
                }
            </script>
        </ContentTemplate>
    </asp:UpdatePanel>
    <%--<script type="text/javascript" src="Scripts/useViewer.js"></script>--%>
</asp:Content>
