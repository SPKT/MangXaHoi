<%@ Import namespace="SPKTCore.Core.Domain"%>
<%@ Register Src="~/Friends/UserControl/FriendProfile.ascx" TagPrefix="uc7" TagName="FriendProfile" %>

<%@ Page Title="" Language="C#" MasterPageFile="~/MXH1.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="SPKTWeb.Search.Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
<div class="divContainer">
        <div class="divContainerBox">
            <div class="divContainerTitle"><asp:Label ID="lblSearchTerm" runat="server"></asp:Label></div>
            <div class="divContainerRow" style="height:350px;">
               <div class="divContainerCell">
                    <asp:Panel ID="pnlFriends" Height="350" ScrollBars="Vertical" runat="server">
                        <asp:Repeater ID="repAccounts" runat="server" OnItemDataBound="repAccounts_ItemDataBound">
                            <ItemTemplate>
                                <uc7:FriendProfile ShowDeleteButton="false" ID="pdProfileDisplay" runat="server"></uc7:FriendProfile>
                            </ItemTemplate>
                        </asp:Repeater>
                    </asp:Panel>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
