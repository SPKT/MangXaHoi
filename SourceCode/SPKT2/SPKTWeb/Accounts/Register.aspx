<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="SPKTWeb.Accounts.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style104
        {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainLeft_above" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainLeft_under" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="mainCenter" runat="server">
                        <asp:ScriptManager ID="ScriptManager1" runat="server">
                        </asp:ScriptManager>
     <table border="0"  height:243px;" style="width: 602px">
                 <a class="divContainerTitle" style="height: 65px; width: 370px; color: #FF0000; font-size: x-large; font-weight: bold;">Đăng Ký Tài Khoản</a><br />
                   
                    <tr>
                        <td align="right" 
                            style="color: #0000FF; font-size: large;" class="style105">
                            Tên đăng ký:</td>


                        <td align="left" class="style108">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                       <ContentTemplate>
                            <asp:TextBox ID="txtUserName" runat="server" 
                                BorderStyle="Inset" BorderWidth="2px" 
                                Height="22px" Width="170px" ontextchanged="txtUserName_TextChanged"></asp:TextBox>
                            <asp:Label ID="lblCheckUsername" runat="server"></asp:Label>
                             </ContentTemplate>
                         </asp:UpdatePanel>
                        </td>
                       

                    </tr>
                    <tr>
                        <td align="right" 
                            style="color: #0000FF; font-size: large;" class="style106">
                            Mật khẩu:</td>
                        <td align="left" class="style109">
                           <asp:TextBox ID="txtPassword" EnableViewState="true" runat="server" 
                                BorderStyle="Inset" BorderWidth="2px" 
                                Height="21px"  Width="171px" TextMode="Password"
                                ontextchanged="txtPassword_TextChanged"></asp:TextBox>
                            <asp:Label ID="lblMessageLegthPass" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" 
                            style="color: #0000FF; font-size: large;" class="style106">
                            Nhắc lại Mật khẩu:</td>
                        <td align="left" class="style109">
                            <asp:TextBox ID="txtPasswordPre" AutoPostBack="true" runat="server" 
                                BorderStyle="Inset" BorderWidth="2px" 
                                Height="21px" TextMode="Password" Width="171px" 
                                ontextchanged="txtPasswordPre_TextChanged"></asp:TextBox>
                            <asp:Label ID="lblMessagepass" runat="server"></asp:Label>
                         </td>

                    </tr>
                    <tr>
                        <td align="right" 
                            style="color: #0000FF; font-size: large;" class="style104">
                            Email:</td>
                        <td align="left" class="style104">
                            <asp:TextBox ID="txtEmail" runat="server" BorderStyle="Inset" BorderWidth="2px" 
                                Height="21px" Width="170px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" 
                            style="color: #0000FF; font-size: large;" class="style104">
                            Captcha:</td>
                        <td align="left" class="style104">
                                  <div class="divContainerRow">
                                    <div class="divContainerCell">
                                        <asp:Image ID="Image1" runat="server" ImageUrl="~/image/CaptChaIma.aspx" />
                                </div>
                        </td>
                    </tr>
                   <tr>
                        <td align="right" 
                            style="color: #0000FF; font-size: large;" class="style104">
                            Captcha:</td>
                        <td align="left" class="style104">
                            <asp:TextBox ID="txtCaptCha" runat="server" BorderStyle="Inset" BorderWidth="2px" 
                                Height="21px" Width="170px"></asp:TextBox>
                        </td>
                    </tr>
                   <tr>
                        <td align="right" 
                            style="color: #0000FF; font-size: large;" class="style106">
                            Thuộc Nhóm:</td>
                        <td align="left" class="style109">
                        
                            <asp:RadioButton ID="rdbCuuSinhVien" runat="server" ForeColor="#0000CC" Text="Cựu sinh viên" 
                            />
&nbsp;&nbsp;
                            <asp:RadioButton ID="rdbGiaoVien" runat="server" ForeColor="#0000CC" Text="Giáo viên" 
                              />
&nbsp;&nbsp;
                            <asp:RadioButton ID="rdbNguoiNgoai" runat="server" Checked="True" 
                                ForeColor="#0000CC" Text="Người ngoài" 
                              />
                        
                        </td>
                    </tr>
                   <tr>
                        <td class="style107">
                        </td>
                        <td align="left" class="style110">
                            <asp:Button ID="btnRegister" runat="server" ForeColor="Blue" Height="30px" 
                                Text="Đăng Ký" Width="100px" onclick="btnRegister_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style107">
                        </td>
                        <td align="left" class="style110">
                            
                            <asp:Label ID="lblErrorMessage" runat="server"></asp:Label>
                            
                        </td>
                    </tr>
                    <tr>
                        <td class="style105">
                            &nbsp;</td>
                        <td align="left" class="style108">
                           
                            <asp:Label ID="lblRegisterMessage" runat="server"></asp:Label>
                           
                        </td>
                    </tr>
                </table>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="mainRight" runat="server">
</asp:Content>
