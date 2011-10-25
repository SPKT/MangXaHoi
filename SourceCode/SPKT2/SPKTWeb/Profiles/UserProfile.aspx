<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="SPKTWeb.Profiles.UserProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainLeft_above" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainLeft_under" runat="server">
<div>
    <div>
        <asp:LinkButton ID="lbtnInfo" Text="Thông Tin" runat="server"></asp:LinkButton>
    </div>
</div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="mainCenter" runat="server">
<div>
    
    <div>
    <asp:Panel ID="pnlAlert" runat="server">
    </asp:Panel>
    </div>
</div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="mainRight" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="mainUnder" runat="server">
</asp:Content>
