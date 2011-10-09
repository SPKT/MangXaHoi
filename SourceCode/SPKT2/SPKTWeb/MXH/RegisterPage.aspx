<%@ Page Title="" Language="C#" MasterPageFile="~/MXH1.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="MXH.WebForm1" %>
<%@ Register src="DangkyDesign.ascx" tagname="DangkyDesign" tagprefix="uc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div>
        <uc1:DangkyDesign ID="DangkyDesign1" runat="server" />
    </div>
    <div style="height: 125px">
    </div>
</asp:Content>
