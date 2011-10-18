<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SPKTWeb.Accounts.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style105
        {
            height: 36px;
            width: 231px;
        }
        .style106
        {
            height: 45px;
            width: 231px;
        }
        .style107
        {
            height: 32px;
            width: 231px;
        }
        .style108
        {
            height: 36px;
            width: 230px;
        }
        .style109
        {
            height: 45px;
            width: 230px;
        }
        .style110
        {
            height: 32px;
            width: 230px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainLeft_above" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainLeft_under" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="mainCenter" runat="server">
        <table border="0"  height:243px;" style="width: 602px">
                 <a style="height: 65px; width: 370px; color: #FF0000; font-size: x-large; font-weight: bold;">Đăng nhập</a><br />
                   
                    <tr>
                        <td align="Right" 
                            style="color: #0000FF; font-size: large;" class="style105">
                            Tên đăng nhập:</td>
                        <td align="left" class="style108">
                            <asp:TextBox ID="txtUserName" runat="server" BorderStyle="Inset" BorderWidth="2px" 
                                Height="27px" Width="177px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" 
                            style="color: #0000FF; font-size: large;" class="style106">
                            Mật khẩu:</td>
                        <td align="left" class="style109">
                            <asp:TextBox ID="txtPassword" runat="server" BorderStyle="Inset" BorderWidth="2px" 
                                Height="26px" TextMode="Password" Width="178px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style105">
                            &nbsp;</td>
                        <td align="left" class="style108">
                            <asp:CheckBox ID="ckbAutoLogin" runat="server" ForeColor="Blue" 
                                Text="Lưu trạng thái đăng nhập" />
                        </td>
                    </tr>
                   <tr>
                        <td class="style107">
                        </td>
                        <td align="left" class="style110">
                            <asp:Button ID="btnLogin" runat="server" ForeColor="Blue" Height="30px" 
                                Text="Đăng Nhập" Width="100px" onclick="btnLogin_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style105">
                            &nbsp;</td>
                        <td align="left" class="style108">
                           <asp:LinkButton ID="lbRegister" runat="server" Text="Đăng ký" 
                                onclick="lbRegister_Click"></asp:LinkButton><br />
                        </td>
                    </tr>
                    <tr>
                        <td class="style105">
                            &nbsp;</td>
                        <td align="left" class="style108">
                           <asp:LinkButton ID="lbRecoverPassword" runat="server" Text="Quên mật khẩu" OnClick="lbRecoverPassword_Click"></asp:LinkButton><br />
                        </td>
                    </tr>
                    <tr>
                        <td class="style105">
                            &nbsp;</td>
                        <td align="left" class="style108">
                           <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label><br />
                        </td>
                    </tr>
                </table>
        
  
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="mainRight" runat="server">
</asp:Content>
