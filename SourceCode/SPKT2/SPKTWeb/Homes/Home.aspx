<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SPKTWeb.Homes.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainLeft_above" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainLeft_under" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="mainCenter" runat="server">
<div>
    <div>
    <asp:Label ID="lblXinChao" runat="server"></asp:Label>
    <asp:LinkButton Visible="false" ID="lbtnProfile" runat="server" 
            onclick="lbtnProfile_Click"></asp:LinkButton>
    </div>
    <div>
    <asp:Label ID="lblHome" runat="server"></asp:Label>
    </div>
</div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="mainRight" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="mainUnder" runat="server">
</asp:Content>
