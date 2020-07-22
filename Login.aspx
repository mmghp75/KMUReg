<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.vb" Inherits="KMUReg.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpNavBar" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMain" runat="server">
    <div id="loginbox" style="margin-top: 50px;" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
        <div class="panel panel-primary">
            <div class="panel-heading">
                <div class="panel-title">
                    ورود به رجیستری
                </div>
            </div>
            <div style="padding-top: 30px" class="panel-body">
                <div class="col-xs-8 col-xs-offset-2" style="margin-bottom: 15px;">
                    <center>
                        <img class="img-responsive" style="min-width: 200px;" src="Images/KMU.png" alt="Banner" /></center>
                </div>
                <div class="clearfix">
                </div>
                <div runat="server" id="divMessage" class="alert alert-danger" role="alert" visible="False">
                    
                        
                    <asp:Label runat="server" ID="lblMessage" Text="نام کاربری یا کلمه عبور صحیح نیست." Visible="True"></asp:Label>
                </div>
                <div class="clearfix">
                </div>
                <div style="margin-bottom: 15px" class="input-group  col-xs-12 col-sm-10 text-left ">
                    <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                    <asp:TextBox runat="server" ID="txtUserName" CssClass="form-control" placeholder="نام کاربری" />
                </div>
                <div class="clearfix">
                </div>
                <div class="input-group col-xs-12 col-sm-10 text-right pull-right" style="margin-bottom: 15px">
                    <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
                    <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control" TextMode="Password"
                        placeholder="رمز عبور" />
                </div>
                <div class="clearfix visible-xs">
                </div>
                <div class="col-sm-2 col-xs-12 text-right">
                    <asp:Button runat="server" ID="btnLogin" CssClass="btn btn-success" Text="ورود" />
                </div>
                <div class="clearfix">
                </div>
<%--                <div class="col-xs-12">
                    <asp:CheckBox runat="server" ID="cbxRememberMe" Text="مرا به خاطر بسپار" />
                    <br />
                    <asp:LinkButton runat="server" ID="lbtnForgotPassword" Text="رمز عبور خود را فراموش کرده اید؟" />
                </div>--%>
            </div>
        </div>
    </div>
</asp:Content>
