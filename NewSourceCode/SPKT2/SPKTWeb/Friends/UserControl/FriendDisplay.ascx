<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FriendDisplay.ascx.cs" Inherits="SPKTWeb.Friends.UserControl.FriendDisplay" %>
<div style="border: 1px solid #CCCCCC; float:left; width: 206px; height: 77px;">
    <div style="height:75px; float:left; width: 205px;">
        <a href="~/Profiles/UserProfile.aspx?AccountID=<asp:Literal id='litAccountID' runat='server'></asp:Literal>">
        <asp:Image style="padding:5px;" ImageAlign="Left" Width="69px" Height="60px" 
            ID="imgAvatar" ImageUrl="~/Image/ProfileAvatar.aspx" 
            runat="server" /></a>
        <br />
        &nbsp;<asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" 
            Font-Size="Medium">LinkButton</asp:LinkButton>
        <br />
        &nbsp;<asp:Label ID="lblFriendID" runat="server" Visible="false"></asp:Label>
    </div>
    
    <br />
</div>
