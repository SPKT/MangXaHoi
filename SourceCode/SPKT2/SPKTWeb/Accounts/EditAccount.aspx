<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditAccount.aspx.cs" Inherits="SPKTWeb.Accounts.EditAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainLeft_above" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainLeft_under" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="mainCenter" runat="server">
<table border="0"  height:243px;" style="width: 602px">
                 <a class="divContainerTitle" style="height: 65px; width: 370px; color: #FF0000; font-size: x-large; font-weight: bold;">Chỉnh sửa Tài Khoản</a><br />
                   
                    <tr>
                        <td align="Right" 
                            style="color: #0000FF; font-size: large;" class="style105">
                            Tên đăng nhập:</td>
                        <td align="left" class="style108">
                            <asp:Label ID="lblUserName" runat="server" ></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" 
                            style="color: #0000FF; font-size: large;" class="style104">
                            Tên hiển thị:</td>
                        <td align="left" class="style104">
                            <asp:TextBox ID="txtDisplayName" runat="server" BorderStyle="Inset" BorderWidth="2px" 
                                Height="18px" Width="170px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" 
                            style="color: #0000FF; font-size: large;" class="style104">
                            Email:</td>
                        <td align="left" class="style104">
                            <asp:TextBox ID="txtEmail" runat="server" BorderStyle="Inset" BorderWidth="2px" BorderColor="FloralWhite"
                                Height="18px" Width="170px"></asp:TextBox>
                        </td>
                    </tr>
                 
                   <tr>
                        <td class="style107">
                        </td>
                        <td align="left" class="style110">
                            <asp:Button ID="btnSave" runat="server" ForeColor="Blue" Height="30px" 
                                Text="Lưu" Width="100px" onclick="btnSave_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style107">
                        </td>
                        <td align="left" class="style110">
                            
                            <asp:Label ID="lblErrorMessage" runat="server"></asp:Label>
                            
                        </td>
                    </tr>

                </table>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="mainRight" runat="server">
</asp:Content>
