<%@ Page Title="" Language="C#" MasterPageFile="~/MXH1.Master" AutoEventWireup="true" CodeBehind="Invite.aspx.cs" Inherits="SPKTWeb.Friends.Invite" %>
<%@ Register src="~/Friends/UserControl/InviteFriends.ascx" tagname="InviteFriends" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div style=" margin-left:7%; margin-top:2%; height: 364px;">
    <div align="center" 
           style="background-image: url('../Image/post_entry_bkgr.png'); background-repeat: no-repeat; font-family: Constantia; font-size: 18px; color: #990000; font-weight: bold; width: 621px;" 
           title="MƠI">
        <br />
        MỜI BẠN<br />
    </div>
    <div style="height:auto; margin-top:1px">
        <asp:Panel ID="pnlInvite" runat="server" Height="268px" Width="618px" 
            BorderColor="#CCCCFF" BorderWidth="1" BorderStyle="Solid" 
            HorizontalAlign="Left" Font-Size="12pt">
            &nbsp; Từ :
            <asp:Label ID="lblFrom" runat="server" Font-Italic="True" ForeColor="Blue" 
                Font-Bold="True"></asp:Label>

            <br />
            &nbsp; Đến :<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:TextBox ID="txtTo" runat="server" Columns="40" Font-Italic="True" 
                                ForeColor="#0000CC" Height="57px" Rows="5" TextMode="MultiLine" 
                                Width="495px"></asp:TextBox>
            <br />
            &nbsp; Thông điệp:
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtMessage" runat="server" Columns="40" Font-Italic="True" 
                ForeColor="#0000CC" Height="57px" Rows="5" TextMode="MultiLine" Width="495px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnInvite" runat="server"  
                           Text="Gửi Lời mời" OnClick="btnInvite_Click" BackColor="#0066FF" 
                        BorderColor="#FFCC00" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" 
                        Font-Names="Constantia" ForeColor="White" />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Font-Italic="True" 
                Font-Names="Times New Roman" ForeColor="#003300" 
                
                Text="Chú ý: có thể gửi cùng lúc cho nhiều mail, mỗi mail cách nhau dấu &quot;,&quot;" 
                Font-Size="10pt"></asp:Label>
            <br />
        </asp:Panel>
    </div>
    <div align="left">
        <asp:Panel ID="Panel3" runat="server" Height="44px" HorizontalAlign="Center" 
            ScrollBars="Vertical" Width="618px" BorderColor="#CCCCFF" BorderWidth="1" BorderStyle="Solid" >
            <asp:Label  ID="lblMessage" runat="server" ForeColor="Maroon"></asp:Label>
        </asp:Panel>
    </div>
   </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Left" runat="server">
 <div align="left" style="margin-left:20px;">
     <br />
     &nbsp;&nbsp;
     <asp:LinkButton ID="lbt_Profile" runat="server" OnClick="lbt_Profile_Click">Trang Thông tin cá nhân</asp:LinkButton>
     <br />
     &nbsp;&nbsp;
     <asp:LinkButton ID="lbt_Account" runat="server" OnClick="lbt_Profile_Click">Tài khoản</asp:LinkButton>
     &nbsp;<br />
     &nbsp;&nbsp;
     <asp:LinkButton ID="lbt_Home" runat="server" OnClick="lbt_Profile_Click">Trang Chủ </asp:LinkButton>
     <br />
     &nbsp;&nbsp;
     <asp:LinkButton ID="lbt_Friend" runat="server" OnClick="lbt_Friend_Click">Bạn bè </asp:LinkButton>
</div>
</asp:Content>
