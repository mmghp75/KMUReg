<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Menu.aspx.vb" Inherits="KMUReg.Menu" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Assembly="RWCTRLW01" Namespace="Rayavaran.RWControls" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphead" runat="server">
    <style type="text/css">
        .circle-container {
            background-color: #E9F4FB;
            position: relative;
            width: 24em;
            height: 24em;
            padding: 2.8em; /*= 2em * 1.4 (2em = half the width of an img, 1.4 = sqrt(2))*/
            border: dashed 1px;
            border-radius: 50%;
            margin: 1.75em auto 0;
            border-color: #CECECE;
        }

            .circle-container > img {
                width: 21em;
                height: 21em;
                position: relative;
                top: -27px;
                left: 20px;
            }

            .circle-container a {
                display: block;
                position: absolute;
                top: 50%;
                left: 50%;
                margin: -2em; /* 2em = 4em/2 */ /* half the width */
            }

            .circle-container img {
                display: block;
            }
            /* .deg0
        {
            transform: translate(12em);
        }
        .deg45
        {
            transform: rotate(45deg) translate(12em) rotate(-45deg);
        }
        .deg135
        {
            transform: rotate(135deg) translate(12em) rotate(-135deg);
        }
        .deg180
        {
            transform: translate(-12em);
        }
        .deg225
        {
            transform: rotate(225deg) translate(12em) rotate(-225deg);
        }
        .deg315
        {
            transform: rotate(315deg) translate(12em) rotate(-315deg);
        }*/

            /* this is just for showing the angle on hover */
            .circle-container a:not(.center):before {
                position: absolute;
                width: 4em;
                color: white;
                background: rgba(0,0,0,.5);
                font: 1.25em/3.45 Courier, monospace;
                letter-spacing: 2px;
                text-decoration: none;
                text-indent: -2em;
            }


            .circle-container a:not(.center):after {
                position: absolute;
                top: 50%;
                left: 50%;
                width: 4px;
                height: 4px;
                border-radius: 50%;
                box-shadow: 0 0 .5em .5em white;
                margin: -2px;
            }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpMain" runat="server">
    <div class="col-xs-12">
        <div runat="server" id="divMessage" class="alert alert-danger" role="alert" visible="False">
            <asp:Label runat="server" ID="lblMessage" Text="پیام مورد نظر در اینجا قرار میگیرد."></asp:Label>
        </div>
    </div>
    <asp:Panel runat="server" ID="pnlDate" class="panel panel-heading col-xs-12" Visible="false">
        <div class="col-xs-6 col-sm-2  col-md-3 text-left">
            <asp:Label Text="تاریخ:" runat="server" ID="Label7" AssociatedControlID="txtDateOf" />
        </div>
        <div class="col-xs-6 col-sm-2  text-right">
            <cc1:DateTimePicker ID="txtDateOf" runat="server" ShowControlType="eDate" Width="100%" />
        </div>
        <div class="col-xs-6 col-sm-2  col-md-3 text-left">
            <asp:DropDownList runat="server" ID="ddlUser" Width="100%" AutoPostBack="true" />
        </div>
        <div class="col-xs-6 col-sm-1  col-md-1 text-left">
            <asp:DropDownList runat="server" ID="ddlShift" Width="100%" AutoPostBack="true">
                <asp:ListItem Value="0">صبح</asp:ListItem>
                <asp:ListItem Value="1">عصر</asp:ListItem>
            </asp:DropDownList>
        </div>
    </asp:Panel>
    <!-- content to be placed inside <body>…</body> -->
    <div class="clearfix">
    </div>
    <div class="clearfix">
    </div>
    <div class='circle-container'>
        <img src='Images/Main_Hospital.png'>
        <a runat="server" id="lblAdmission" class='deg0 icon-lg' visible="False">
            <img runat="server" id="btnAdmission" class="icon-lg" src='Images/Icons/r01.png' visible="False" /><center style="color: Red">ثبت بیمار جدید</center>
        </a><a runat="server" id="lblReports" class='deg135 icon-lg' visible="False">
            <img runat="server" id="btnReports" class="icon-lg" src='Images/Icons/17.png' visible="False"><center style="color: Red">گزارشات</center>
        </a><a runat="server" id="lblInsurance" class='deg180 icon-lg' visible="False">
        </a><a runat="server" id="lblSetting" class='deg315 icon-lg' visible="False">
            <img runat="server" id="btnSetting" class="icon-lg" src='Images/Icons/12.png' visible="False"><center style="color: Red">تنظیمات</center>
        </a>
    </div>
</asp:Content>
