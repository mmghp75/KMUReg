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
<asp:Content ID="Content2" ContentPlaceHolderID="cpNavBar" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpMain" runat="server">

    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:HiddenField runat="server" ID="hfNewPanelVisibility" Value="0" />
            <asp:HiddenField runat="server" ID="hfExpanedPanelIds" ClientIDMode="Static" />

            <div class="panel panel-primary" runat="server" id="pnlDemographic" visible="true">
                <div class="panel-heading">
                    <h4 class="panel-title my-MouseCursorDefault my-Titr">مشخصات دموگرافیک
                    </h4>
                </div>
                <div class="panel-body">
                    <div runat="server" id="divDemographicMessage" class="alert alert-danger" role="alert" visible="False">
                        <asp:Label runat="server" ID="lblDemographicMessage" Text="پیام مورد نظر در اینجا قرار میگیرد." />
                    </div>
                    <div class="panel col-xs-12">
                        <div class="col-xs-3 text-right">
                            <asp:TextBox ID="txtFileNo" runat="server" MaxLength="8" AutoPostBack="True" PlaceHolder="شماره پرونده" ToolTip="شماره پرونده" BackColor="LightGreen" CssClass="text-center form-control"></asp:TextBox>
                        </div>
                        <div class="col-xs-3 text-right">
                            <asp:TextBox ID="txtNationalCode" runat="server" MaxLength="10" AutoPostBack="True" Placeholder="* کدملی" ToolTip="کدملی" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-xs-3 text-right">
                            <asp:TextBox runat="server" ID="txtFirstName" PlaceHolder="* نام" ToolTip="نام" CssClass="form-control" Style="margin-bottom: 10px"></asp:TextBox>
                        </div>
                        <div class="col-xs-3 text-right">
                            <asp:TextBox runat="server" ID="txtLastName" PlaceHolder="* نام خانوادگی" ToolTip="نام خانوادگی" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="clearfix">
                        </div>
                        <div class="col-xs-3 text-right" style="margin-bottom: 10px">
                            <div class="input-group">
                                <asp:Label Text="* جنسیت:" Class="input-group-addon" runat="server" ID="Label4" Font-Bold="true" />
                                <asp:RadioButtonList runat="server" Class="form-control my-inline-table" RepeatLayout="Flow" ID="rblGender" RepeatColumns="2">
                                    <asp:ListItem Text="&nbsp;&nbsp;مذکر" Value="1" />
                                    <asp:ListItem Text="&nbsp;&nbsp;مؤنث" Value="2" Style="margin-right: 5px;" />
                                </asp:RadioButtonList>
                            </div>
                        </div>
                        <div class="col-xs-3 text-right" style="margin-bottom: 10px">
                            <div class="input-group">
                                <asp:TextBox class="form-control" runat="server" ID="txtAgeOf" PlaceHolder="سن(سال)" ToolTip="سن(سال)"></asp:TextBox>
                                <span class="input-group-addon">* یاتاریخ‌تولد</span>
                                <cc1:DateTimePicker ID="dpBirthDateOf" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ تولد" />
                            </div>
                        </div>
                        <div class="col-xs-3 text-right" style="margin-bottom: 10px">
                            <asp:TextBox runat="server" ID="txtHeight" PlaceHolder="قد(سانتیمتر)" ToolTip="قد(سانتیمتر)" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-xs-3 text-right" style="margin-bottom: 10px">
                            <asp:TextBox runat="server" ID="txtWeight" PlaceHolder="وزن(کیلوگرم)" ToolTip="وزن(کیلوگرم)" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="clearfix">
                        </div>
                        <div class="col-xs-3 text-right">
                            <div class="input-group">
                                <asp:Label Text="وضعیت‌تأهل:" CssClass="input-group-addon" runat="server" ID="Label7" Font-Bold="true" />
                                <asp:RadioButtonList runat="server" ID="rbMarriage" CssClass="form-control my-inline-table" RepeatLayout="Flow" RepeatColumns="2">
                                    <asp:ListItem Text="&nbsp;&nbsp;متأهل" Value="1" Style="margin-right: 10px;" />
                                    <asp:ListItem Text="&nbsp;&nbsp;مجرد" Value="2" Style="margin-right: 10px;" />
                                </asp:RadioButtonList>
                            </div>
                        </div>
                        <div class="col-xs-3 text-right" style="margin-bottom: 10px">
                            <asp:TextBox runat="server" ID="txtCellNo" PlaceHolder="* تلفن‌همراه" ToolTip="تلفن‌همراه" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-xs-3 text-right" style="margin-bottom: 10px">
                            <asp:TextBox runat="server" ID="txtPhoneNo" PlaceHolder="* تلفن‌ثابت" ToolTip="تلفن‌ثابت" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="clearfix">
                        </div>
                        <div class="col-xs-9 text-right" style="margin-bottom: 10px">
                            <div class="input-group" >
                                <asp:Label Text="سطح‌تحصیلات:" CssClass="input-group-addon " runat="server" ID="Label8" Font-Bold="true" />
                                <asp:RadioButtonList runat="server" ID="rbEducation" CssClass="form-control my-inline-table" RepeatLayout="Flow" RepeatColumns="8">
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
                        <div class="clearfix">
                        </div>
                        <div class="col-xs-12 text-right" style="margin-bottom: 10px">
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

            <div class="panel panel-primary" runat="server" id="pnlHistory" clientidmode="Static" visible="false">
                <div class="panel-heading">
                    <h4 id="lblHistoryTitle"
                        runat="server"
                        class="panel-title my-MouseCursorDefault my-Titr"
                        data-toggle="collapse"
                        aria-expanded="true"
                        onclick="setExpandedPanels(this)"
                        data-target="#collapseHistoryMessage">تاریخچه بیماری
                    </h4>
                </div>
                <div runat="server" clientidmode="Static" id="collapseHistoryMessage" class="panel-collapse collapse in">
                    <div class="panel-body">
                        <div runat="server" id="div1" class="alert alert-danger" role="alert" visible="False">
                            <asp:Label runat="server" ID="lbllHistoryMessage" Text="پیام مورد نظر در اینجا قرار میگیرد." />
                        </div>
                        <div class="panel col-xs-12">
                            <div class="col-xs-4 text-right">
                                <div class="input-group">
                                    <asp:Label Text="* نوع‌دیابت:" CssClass="input-group-addon" runat="server" ID="Label2" Font-Bold="true" />
                                    <asp:RadioButtonList runat="server" CssClass="form-control my-inline-table" RepeatLayout="Flow" ID="rblDiabetTypeOf" RepeatColumns="3">
                                        <asp:ListItem Text="نوع 1" Value="1" />
                                        <asp:ListItem Text="نوع 2" Value="2" Style="margin-right: 20px;" />
                                        <asp:ListItem Text="حاملگی" Value="3" Style="margin-right: 20px;" />
                                    </asp:RadioButtonList>
                                </div>
                            </div>
                            <div class="col-xs-4 text-right" style="margin-bottom: 10px">
                                <div class="input-group">
                                    <asp:TextBox runat="server" ID="txtDateOf01" PlaceHolder="مدت ابتلا(سال)" ToolTip="مدت ابتلا(سال)" CssClass="form-control"></asp:TextBox>
                                    <span class="input-group-addon">* یاتاریخ‌ابتلا</span>
                                    <cc1:DateTimePicker ID="dpDateOf01" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ حدودی ابتلا" />
                                </div>
                            </div>
                            <div class="clearfix">
                            </div>
                            <div class="col-xs-2 text-right" style="margin-bottom: 10px">
                                <asp:CheckBox ID="cbxSore01" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;زخم‌پا" CssClass="form-control"></asp:CheckBox>
                            </div>
                            <div class="col-xs-2 text-right" style="margin-bottom: 10px">
                                <asp:CheckBox ID="cbxLaser01" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;لیزر زخم" CssClass="form-control"></asp:CheckBox>
                            </div>
                            <div class="col-xs-2 text-right" style="margin-bottom: 10px">
                                <asp:CheckBox ID="cbxDebrid01" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;دبریدمان" CssClass="form-control"></asp:CheckBox>
                            </div>
                            <div class="col-xs-2 text-right" style="margin-bottom: 10px">
                                <asp:CheckBox ID="cbxSurgery01" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;جراحی" CssClass="form-control"></asp:CheckBox>
                            </div>
                            <div class="col-xs-2 text-right" style="margin-bottom: 10px">
                                <asp:CheckBox ID="cbxGangrene01" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;گانگرن" CssClass="form-control"></asp:CheckBox>
                            </div>
                            <div class="col-xs-2 text-right" style="margin-bottom: 10px">
                                <asp:CheckBox ID="cbxAmp01" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;آمپوتاسیون" CssClass="form-control" ></asp:CheckBox>
                            </div>
                            <div class="clearfix">
                            </div>
                            <div class="col-xs-12 text-right" style="margin-bottom: 10px">
                                <div class="input-group">
                                    <asp:Label Text="بیماری‌زمینه‌ای:" CssClass="input-group-addon" runat="server" ID="Label3" Font-Bold="true" />
                                    <asp:CheckBoxList runat="server" ID="rblDesease" CssClass="form-control my-inline-table" RepeatLayout="Flow"  RepeatColumns="7" Style="height: auto">
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
                            <div class="col-xs-4 text-right" style="margin-bottom: 10px">
                                <asp:CheckBox ID="cbxAlcohol" runat="server" MaxLength="10" Text="&nbsp;&nbsp;مصرف مشروبات الکلی" CssClass="form-control"></asp:CheckBox>
                            </div>
                            <div class="col-xs-4 text-right" style="margin-bottom: 10px">
                                <asp:CheckBox ID="cbxSigarret" runat="server" MaxLength="10" Text="&nbsp;&nbsp;سیگار و قلیان" CssClass="form-control"></asp:CheckBox>
                            </div>
                            <div class="col-xs-4 text-right" style="margin-bottom: 10px">
                                <asp:CheckBox ID="cbxInPatient" runat="server" MaxLength="10" AutoPostBack="True" Text="&nbsp;&nbsp;سابقه بستری" CssClass="form-control"></asp:CheckBox>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="panel panel-primary" runat="server" clientidmode="Static" id="pnlPhysicalExam" visible="false">
                <div class="panel-heading">
                    <h4 id="lblPhysicalExamTitle"
                        runat="server"
                        class="panel-title my-MouseCursorDefault my-Titr"
                        data-toggle="collapse"
                        onclick="setExpandedPanels(this)"
                        data-target="#collapsePhysicalExam">شرح حال و معاینه بالینی
                    </h4>
                </div>
                <div id="collapsePhysicalExam" runat="server" clientidmode="Static" class="panel-collapse collapse">
                    <div class="panel-body">
                        <div runat="server" id="div2" class="alert alert-danger" role="alert" visible="False">
                            <asp:Label runat="server" ID="Label6" Text="پیام مورد نظر در اینجا قرار میگیرد." />
                        </div>
                        <div class="panel col-xs-12">
                            <div class="col-xs-4 text-right">
                                <asp:TextBox ID="txtCC" runat="server" MaxLength="10" Placeholder="* علت مراجعه" ToolTip="علت مراجعه" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="clearfix" style="margin-bottom: 10px">
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
                            <div class="clearfix" style="margin-bottom: 10px"></div>
                            <div class="col-xs-4 text-right" style="margin-bottom: 10px">
                                <div class="input-group">
                                    <asp:Label Text="نوروپاتی:" CssClass="input-group-addon" runat="server" ID="Label9" Font-Bold="true" />
                                    <asp:CheckBoxList runat="server" CssClass="form-control my-inline-table" RepeatLayout="Flow"  ID="cblNeuropathy" RepeatColumns="2">
                                        <asp:ListItem Text="&nbsp;&nbsp;پای‌چپ" Value="1" Style="margin-right: 10px;" />
                                        <asp:ListItem Text="&nbsp;&nbsp;پای‌راست" Value="2" Style="margin-right: 10px;" />
                                    </asp:CheckBoxList>
                                </div>
                            </div>
                            <div class="col-xs-4 text-right" style="margin-bottom: 10px">
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
                            <div class="clearfix" style="margin-bottom: 10px">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="panel panel-primary" runat="server" clientidmode="Static" id="pnlLabResults" visible="false">
                <div class="panel-heading">
                    <h4 id="lblLabResultsTitle"
                        runat="server"
                        class="panel-title my-MouseCursorDefault my-Titr"
                        data-toggle="collapse"
                        onclick="setExpandedPanels(this)"
                        data-target="#collapseLabResults">جواب آزمایشات
                    </h4>
                </div>
                <div id="collapseLabResults" runat="server" clientidmode="Static" class="panel-collapse collapse">
                    <div class="panel-body">
                        <div runat="server" id="div3" class="alert alert-danger" role="alert" visible="False">
                            <asp:Label runat="server" ID="lblLabMessage" Text="پیام مورد نظر در اینجا قرار میگیرد." />
                        </div>
                        <div class="panel col-xs-12">
                            <div class="col-xs-4 text-right">
                                <asp:TextBox ID="txtFBS" runat="server" MaxLength="10" Placeholder="* FBS" ToolTip="FBS" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-xs-4 text-right">
                                <asp:TextBox ID="txtA1C" runat="server" MaxLength="10" Placeholder="* Hb A1C" ToolTip="Hb A1C" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-xs-4 text-right" style="margin-bottom: 10px">
                                <div class="input-group">
                                    <asp:Label Text="* تاریخ آزمایش:" CssClass="input-group-addon" runat="server" ID="Label40" Font-Bold="true" Style="width: auto" />
                                    <cc1:DateTimePicker ID="dpDateOf02" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ آزمایش" />
                                </div>
                            </div>
                            <div class="clearfix">
                            </div>
                            <div class="col-xs-4 text-right">
                                <asp:TextBox runat="server" ID="txtSystol" PlaceHolder="فشارخون سیستولیک" ToolTip="فشارخون سیستولیک" CssClass="form-control" Style="margin-bottom: 10px"></asp:TextBox>
                            </div>
                            <div class="col-xs-4 text-right">
                                <asp:TextBox runat="server" ID="txtDyastol" PlaceHolder="فشارخون دیاستولیک" ToolTip="فشارخون دیاستولیک" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-xs-4 text-right" style="margin-bottom: 10px">
                                <asp:TextBox runat="server" ID="txtO2" PlaceHolder="اشباع اکسیژن" ToolTip="اشباع اکسیژن" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="clearfix">
                            </div>
                            <div class="col-xs-4 text-right" style="margin-bottom: 10px">
                                <asp:TextBox runat="server" ID="txtHR" PlaceHolder="تعداد ضربان قلب در دقیقه" ToolTip="تعداد ضربان قلب در دقیقه" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-xs-4 text-right" style="margin-bottom: 10px">
                                <asp:TextBox runat="server" ID="txtRR" PlaceHolder="تعداد تنفس در دقیقه" ToolTip="تعداد تنفس در دقیقه" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-xs-4 text-right" style="margin-bottom: 10px">
                                <div class="input-group">
                                    <asp:Label Text="تاریخ ثبت علایم‌حیاتی:" CssClass="input-group-addon" runat="server" ID="Label44" Font-Bold="true" />
                                    <cc1:DateTimePicker ID="dpDateOf03" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ ثبت علایم حیاتی" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="panel panel-primary" runat="server" clientidmode="Static" id="pnlPrescription" visible="false">
                <div class="panel-heading">
                    <h4 id="lblPrescriptionTitle"
                        runat="server"
                        class="panel-title my-MouseCursorDefault my-Titr"
                        data-toggle="collapse"
                        onclick="setExpandedPanels(this)"
                        data-target="#collapsePrescription">تجویز و توصیه‌های پزشک یا اقدامات درمانی
                    </h4>
                </div>
                <div id="collapsePrescription" runat="server" clientidmode="Static" class="panel-collapse collapse">
                    <div class="panel-body">
                        <div runat="server" id="div4" class="alert alert-danger" role="alert" visible="False">
                            <asp:Label runat="server" ID="Label14" Text="پیام مورد نظر در اینجا قرار میگیرد." />
                        </div>
                        <div class="panel col-xs-12">
                            <div class="col-xs-4 text-right">
                                <asp:CheckBox ID="cbxNeedAmp" runat="server" MaxLength="10" Text="&nbsp;&nbsp;نیاز به قطع عضو دارد" CssClass="form-control"></asp:CheckBox>
                            </div>
                            <div class="col-xs-4 text-right">
                                <asp:CheckBox ID="cbxNeedSurg" runat="server" MaxLength="10" Text="&nbsp;&nbsp;نیاز به جراحی دارد" CssClass="form-control"></asp:CheckBox>
                            </div>
                            <div class="col-xs-4 text-right" style="margin-bottom: 10px">
                                <asp:CheckBox ID="cbxNeedDebrid" runat="server" MaxLength="10" Text="&nbsp;&nbsp;نیاز به دبریدمان دارد" CssClass="form-control"></asp:CheckBox>
                            </div>
                            <div class="clearfix">
                            </div>
                            <div class="col-xs-4 text-right" style="margin-bottom: 10px">
                                <asp:CheckBox ID="cbxNeedShoe" runat="server" MaxLength="10" Text="&nbsp;&nbsp;تجویز کفش طبی دارد" CssClass="form-control"></asp:CheckBox>
                            </div>
                            <div class="col-xs-4 text-right">
                                <asp:CheckBox ID="cbxNeedVisit" runat="server" MaxLength="10" Text="&nbsp;&nbsp;نیاز به معاینه منظم و دوره‌ای توسط پزشک دارد" CssClass="form-control"></asp:CheckBox>
                            </div>
                            <div class="col-xs-4 text-right">
                                <asp:CheckBox ID="cbxNeedCover" runat="server" MaxLength="10" Text="&nbsp;&nbsp;نیاز به پانسمان و شست و شوی منظم زخم دارد" CssClass="form-control"></asp:CheckBox>
                            </div>
                            <div class="clearfix">
                            </div>
                            <div class="col-xs-4 text-right" style="margin-bottom: 10px">
                                <asp:CheckBox ID="cbxNeedEducation" runat="server" MaxLength="10" Text="&nbsp;&nbsp;نیاز به مشاوره‌ی‌درمانی و آموزش خودمراقبتی دارد" CssClass="form-control"></asp:CheckBox>
                            </div>
                            <div class="col-xs-4 text-right" style="margin-bottom: 10px">
                                <asp:CheckBox ID="cbxNeedRehab" runat="server" MaxLength="10" Text="&nbsp;&nbsp;نیاز به فرایندهای توان‌بخشی دارد" CssClass="form-control"></asp:CheckBox>
                            </div>
                            <div class="clearfix">
                            </div>
                            <div class="col-xs-12 text-right">
                                <div class="col-xs-12 text-right form-control" style="margin-bottom: 10px">
                                    <div class="col-xs-1 text-left">
                                        <asp:Label Text=" داروهای‌تجویزی:" runat="server" ID="Label21" Font-Bold="true" />
                                    </div>
                                    <div class="col-xs-11 text-right">
                                        <asp:CheckBoxList runat="server" ID="cblDrugs" CssClass="my-inline-table" RepeatLayout="Flow"  RepeatColumns="5">
                                            <asp:ListItem Text="&nbsp;&nbsp;پماد فنیتوئین" Value="1" Style="margin-right: 30px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
            <div class="panel-footer text-left" runat="server" id="pnlMainFooter" visible="false">
                <div class="input-group">
                    <div class="input-group-btn">
                        <div class="col-xs-8">
                        </div>
                        <div class="col-xs-2">
                            <asp:Button runat="server" ID="btnCancel" Text="پاک کردن صفحه" CssClass="btn-danger" Width="100%" Font-Names="Titr" />
                        </div>
                        <div class="col-xs-2">
                            <asp:Button runat="server" ID="btnOK" Text="ثبت" CssClass="btn-success" Width="100%" Font-Names="Titr" />
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
                            <div class="panel-body">
                                <div runat="server" id="pnlSore01MSG" class="alert alert-danger" role="alert" visible="False">
                                    <asp:Label runat="server" ID="lblSore01MSG" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration01" class="form-control" PlaceHolder="زمان ابتلا(چندماه‌پیش؟)" ToolTip="زمان ابتلا(چندماه‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="* یا تاریخ آخرین زخم:" CssClass="input-group-addon" runat="server" ID="Label15" />
                                        <cc1:DateTimePicker ID="dpLastSore01" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ آخرین زخم" />
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل زخم‌های قبلی در پای چپ:" CssClass="input-group-addon" Font-Bold="true" runat="server" ID="Label16" />
                                        <asp:CheckBoxList runat="server" ID="cblSoreLocationL01" CssClass="form-control my-inline-table" RepeatLayout="Flow"  RepeatColumns="4">
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" Style="margin-right: 20px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 20px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 20px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل زخم‌های قبلی در پای راست:" CssClass="input-group-addon" Font-Bold="true" runat="server" ID="Label17" />
                                        <asp:CheckBoxList runat="server" CssClass="form-control my-inline-table" RepeatLayout="Flow"  ID="cblSoreLocationR01" RepeatColumns="4">
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" Style="margin-right: 20px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 20px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 20px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                            </div>
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
                            <div class="panel-body">
                                <div runat="server" id="pnlLaser01MSG" class="alert alert-danger" role="alert" visible="False">
                                    <asp:Label runat="server" ID="lblLaser01MSG" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration02" PlaceHolder="زمان درمان(چندماه‌پیش؟)" ToolTip="زمان درمان(چندماه‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="* یا تاریخ آخرین درمان با لیزر:" CssClass="input-group-addon" runat="server" ID="Label19" />
                                        <cc1:DateTimePicker ID="dpLastLaser01" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ آخرین زخم" />
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right">
                                    <div class="input-group">
                                        <asp:Label Text="* محل لیزرتراپی‌های قبلی:" CssClass="input-group-addon" runat="server" ID="Label20" />
                                        <asp:CheckBoxList runat="server" ID="cblLaser" CssClass="form-control my-inline-table" RepeatLayout="Flow"  RepeatColumns="2">
                                            <asp:ListItem Text="&nbsp;&nbsp;پای چپ" Value="1" Style="margin-right: 50px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پای راست" Value="2" Style="margin-right: 50px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>

                                <div class="clearfix"></div>
                            </div>
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
                            <div class="panel-body">
                                <div runat="server" id="pnlDebrid01MSG" class="alert alert-danger" role="alert" visible="False">
                                    <asp:Label runat="server" ID="lblDebrid01MSG" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration03" PlaceHolder="زمان دبرید(چندماه‌پیش؟)" ToolTip="زمان دبرید(چندماه‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="* یا تاریخ آخرین دبریدمان:" CssClass="input-group-addon" Font-Bold="true" runat="server" ID="Label23" />
                                        <cc1:DateTimePicker ID="dpLastDebrid01" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ آخرین دبریدمان" />
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right">
                                    <div class="input-group">
                                        <asp:Label Text="* محل دبریدمان‌های قبلی:" CssClass="input-group-addon" Font-Bold="true" runat="server" ID="Label18" />
                                        <asp:CheckBoxList runat="server" ID="cblDebrid" CssClass="form-control my-inline-table" RepeatLayout="Flow"  RepeatColumns="5">
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
                            <div class="panel-body">
                                <div runat="server" id="pnlSurg01MSG" class="alert alert-danger" role="alert" visible="False">
                                    <asp:Label runat="server" ID="lblSurg01MSG" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration04" PlaceHolder="زمان جراحی(چندماه‌پیش؟)" ToolTip="زمان جراحی(چندماه‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="* یا تاریخ آخرین جراحی:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label27" />
                                        <cc1:DateTimePicker ID="dpLastSurg01" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ آخرین جراحی" />
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل جراحی‌های قبلی پای‌چپ:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label28" />
                                        <asp:CheckBoxList runat="server" ID="cblSurgL" CssClass="form-control my-inline-table" RepeatLayout="Flow"  RepeatColumns="5">
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;بالاترازمچ" Value="5" Style="margin-right: 40px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل جراحی‌های قبلی پای‌راست:" CssClass="input-group-addon" Font-Bold="true" runat="server" ID="Label29" />
                                        <asp:CheckBoxList runat="server" CssClass="form-control my-inline-table" RepeatLayout="Flow"  ID="cblSurgR" RepeatColumns="5">
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
                            <div class="panel-body">
                                <div runat="server" id="pnlGang01MSG" class="alert alert-danger" role="alert" visible="False">
                                    <asp:Label runat="server" ID="lblGang01MSG" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration05" PlaceHolder="زمان گانگرن(چندماه‌پیش؟)" ToolTip="زمان گانگرن(چندماه‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="* یا تاریخ آخرین گانگرن:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label31" />
                                        <cc1:DateTimePicker ID="dpLastGang01" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ آخرین گانگرن" />
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px">
                                    <div class="input-group">
                                        <asp:Label Text=" محل گانگرن‌های قبلی:" CssClass="input-group-addon" Font-Bold="true" runat="server" ID="Label32" />
                                        <asp:CheckBoxList runat="server" ID="cblGang" CssClass="form-control my-inline-table" RepeatLayout="Flow"  RepeatColumns="2">
                                            <asp:ListItem Text="&nbsp;&nbsp;پای چپ" Value="1" Style="margin-right: 50px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پای راست" Value="2" Style="margin-right: 50px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>

                                <div class="clearfix"></div>
                            </div>
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
                            <div class="panel-body">
                                <div runat="server" id="pnlAmp01MSG" class="alert alert-danger" role="alert" visible="False">
                                    <asp:Label runat="server" ID="lblAmp01MSG" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration06" PlaceHolder="زمان آمپوتاسیون(چندماه‌پیش؟)" ToolTip="زمان آمپوتاسیون(چندماه‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="*یا تاریخ آخرین آمپوتاسیون:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label35" />
                                        <cc1:DateTimePicker ID="dpLastAmp01" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ آخرین آمپوتاسیون" />
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px;">
                                    <div class="input-group">
                                        <asp:Label Text="* محل آمپوتاسیون‌های قبلی پای‌چپ:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label36" />
                                        <asp:CheckBoxList runat="server" ID="cblAmpL" CssClass="form-control my-inline-table" RepeatLayout="Flow"  RepeatColumns="3" Style="height: auto">
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
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل آمپوتاسیون‌های قبلی پای‌راست:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label37" />
                                        <asp:CheckBoxList runat="server" ID="cblAmpR" CssClass="form-control my-inline-table" RepeatLayout="Flow"  RepeatColumns="3" Style="height: auto">
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
                            </div>
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
                            <div class="panel-body">
                                <div runat="server" id="pnlInPatient01MSG" class="alert alert-danger" role="alert" visible="False">
                                    <asp:Label runat="server" ID="lblInPatient01MSG" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
                                </div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration07" PlaceHolder="زمان بستری(چندماه‌پیش؟)" ToolTip="زمان بستری(چندماه‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="* یا تاریخ آخرین بستری:" CssClass="input-group-addon" runat="server" ID="Label22" />
                                        <cc1:DateTimePicker ID="dpLastInPatient01" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ آخرین بستری" />
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
                            </div>
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
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration08" PlaceHolder="زمان زخم(چندماه‌پیش؟)" ToolTip="زمان زخم(چندماه‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="* یا تاریخ ایجاد زخم:" CssClass="input-group-addon" Font-Bold="true" runat="server" ID="Label25" />
                                        <cc1:DateTimePicker ID="dpNewSore" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ ایجاد زخم" />
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 10px">
                                    <asp:TextBox runat="server" ID="txtNewSoreCountOfL" PlaceHolder="* تعداد زخم‌های پای چپ" ToolTip="تعداد زخم‌های پای چپ" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 10px">
                                    <asp:TextBox runat="server" ID="txtNewSoreCountOfR" PlaceHolder="* تعداد زخم‌های پای راست" ToolTip="تعداد زخم‌های پای راست" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="col-xs-4 text-right" style="margin-bottom: 10px">
                                    <asp:TextBox runat="server" ID="txtNewMaxLength" PlaceHolder="* طول بزرگترین زخم(میلیمتر)" ToolTip="طول بزرگترین زخم(میلیمتر)" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل زخم‌های پای‌چپ:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label26" />
                                        <asp:CheckBoxList runat="server" ID="cblNewSoreL" RepeatColumns="5" CssClass="form-control my-inline-table" RepeatLayout="Flow" >
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;بالاترازمچ" Value="5" Style="margin-right: 40px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل زخم‌های پای‌راست:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label30" />
                                        <asp:CheckBoxList runat="server" ID="cblNewSoreR" RepeatColumns="5" CssClass="form-control my-inline-table" RepeatLayout="Flow" >
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;بالاترازمچ" Value="5" Style="margin-right: 40px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px">
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
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration09" PlaceHolder="زمان عفونت(چندروز‌پیش؟)" ToolTip="زمان عفونت(چندروز‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="* یا تاریخ ایجاد عفونت:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label34" />
                                        <cc1:DateTimePicker ID="dpNewInfect" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ ایجاد عفونت" />
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل‌عفونت‌پای‌چپ:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label38" />
                                        <asp:CheckBoxList runat="server" ID="cblNewInfectL" RepeatColumns="5" CssClass="form-control my-inline-table" RepeatLayout="Flow" >
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" Style="margin-right: 10px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 10px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 10px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;بالاترازمچ" Value="5" Style="margin-right: 10px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل‌عفونت‌پای‌راست:" CssClass="input-group-addon" Font-Bold="true" runat="server" ID="Label39" />
                                        <asp:CheckBoxList runat="server" ID="cblNewInfectR" RepeatColumns="5" CssClass="form-control my-inline-table" RepeatLayout="Flow" >
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
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" ID="txtDuration10" PlaceHolder="زمان ایجاد(چندروز‌پیش؟)" ToolTip="زمانایجاد تورم،تاول و قرمزی(چندروز‌پیش؟)" CssClass="form-control"></asp:TextBox>
                                        <asp:Label Text="* یا تاریخ ایجاد تورم،تاول و قرمزی:" runat="server" Font-Bold="true" CssClass="input-group-addon" ID="Label41" />
                                        <cc1:DateTimePicker ID="dpNewSwell" runat="server" EnableTheming="true" CssClass="text-right" ShowControlDateTimeMode="DatePicker" Theme="blue" ToolTip="تاریخ ایجاد تورم،تاول و قرمزی" />
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل تورم،تاول و قرمزی‌های پای‌چپ:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label42" />
                                        <asp:CheckBoxList runat="server" ID="cblNewSwellL" RepeatColumns="5" CssClass="form-control my-inline-table" RepeatLayout="Flow" >
                                            <asp:ListItem Text="&nbsp;&nbsp;انگشتان" Value="1" />
                                            <asp:ListItem Text="&nbsp;&nbsp;روی پا" Value="2" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;کف پا" Value="3" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;پاشنه" Value="4" Style="margin-right: 40px;" />
                                            <asp:ListItem Text="&nbsp;&nbsp;بالاترازمچ" Value="5" Style="margin-right: 40px;" />
                                        </asp:CheckBoxList>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="col-xs-12 text-right" style="margin-bottom: 10px">
                                    <div class="input-group">
                                        <asp:Label Text="* محل تورم،تاول و قرمزی‌های پای‌راست:" Font-Bold="true" CssClass="input-group-addon" runat="server" ID="Label43" />
                                        <asp:CheckBoxList runat="server" ID="cblNewSwellR" RepeatColumns="5" CssClass="form-control my-inline-table" RepeatLayout="Flow" >
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

            <script>
                var hfExpanedPanelIds = $("#hfExpanedPanelIds");

                function setExpandedPanels(sender) {

                    var currentPanelId = $(sender).parent().parent().attr("id");

                    var expandedList = $("[aria-expanded=true]");

                    hfExpanedPanelIds.val("");
                    for (var i = 0; i < expandedList.length; i++) {
                        hfExpanedPanelIds.val(hfExpanedPanelIds.value + $(expandedList[i]).parent().parent().attr("id") + " ");
                    }

                    if ($(sender).attr("aria-expanded") == "true") {
                        //remove from expand list
                        if (hfExpanedPanelIds.value != undefined) {
                            hfExpanedPanelIds.val(hfExpanedPanelIds.value.replace(currentPanelId + " ", ""));
                        }
                    }
                    else {
                        //add to expand list
                        if (hfExpanedPanelIds.value == undefined) {
                            hfExpanedPanelIds.val(currentPanelId + " ");
                        }
                        else {
                            hfExpanedPanelIds.val(hfExpanedPanelIds.value + currentPanelId + " ");
                        }
                    }
                }
            </script>
        </ContentTemplate>
    </asp:UpdatePanel>
    <%--<script type="text/javascript" src="Scripts/useViewer.js"></script>--%>
</asp:Content>
