<%@ Page Title="" Language="C#" MasterPageFile="~/MXH1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SPKTWeb.Accounts.Login" %>
<%@ Register src="UserControl/LoginDesign.ascx" tagname="LoginDesign" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <uc1:LoginDesign ID="LoginDesign2" runat="server" />
</asp:Content>
