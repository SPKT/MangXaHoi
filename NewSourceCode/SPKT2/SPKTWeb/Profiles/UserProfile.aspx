<%@ Page Title="" Language="C#" MasterPageFile="~/MXH1.Master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="SPKTWeb.Profiles.UserProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Main" runat="server">
<div>
        <div>
        <asp:LinkButton ID="lbtnInfo" Text="Thông Tin" runat="server"></asp:LinkButton>
    </div>
    <div>
    <asp:Panel ID="pnlAlert" runat="server">
    </asp:Panel>
    </div>
</div>
</asp:Content>
