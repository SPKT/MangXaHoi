<%@ Import namespace="SPKTCore.Core.Domain"%>
<%@ Page Title="" Language="C#" MasterPageFile="~/MXH1.Master" AutoEventWireup="true" CodeBehind="ShowFriend.aspx.cs" Inherits="SPKTWeb.Friends.ShowFriend1" %>
<%@ Register src="~/Friends/UserControl/ShowFriend.ascx" tagname="ShowFriend" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
<div>
    
    <uc1:ShowFriend ID="ShowFriend2" runat="server" />
</div>

</asp:Content>
