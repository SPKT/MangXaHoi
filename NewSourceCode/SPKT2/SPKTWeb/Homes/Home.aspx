<%@ Page Title="" Language="C#" MasterPageFile="~/MXH1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SPKTWeb.Homes.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="Main" runat="server">
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

