<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProfileAttributeControlFull.ascx.cs" Inherits="SPKTWeb.Profiles.UserControls.ProfileAttributeControlFull" %>
           <table border="0"  height:243px;" style="width: 602px">
  <a style="height: 65px; width: 370px; color:Green; font-size:large;font-weight: bold;"> Nơi ở</a>
                    <tr>
                        <td align="right" 
                            style="color: #0000FF; font-size: large;" class="style106">
                            Quê quán:</td>
                        <td align="left" class="style109">
                            <asp:TextBox ID="txtquequan" runat="server" BorderStyle="Inset" BorderWidth="2px" 
                                Height="21px" Width="171px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" 
                            style="color: #0000FF; font-size: large;" class="style106">
                            Nơi ở hiện tại:</td>
                        <td align="left" class="style109">
                            <asp:TextBox ID="txtnoiohientai" runat="server" BorderStyle="Inset" BorderWidth="2px" 
                                Height="21px" Width="171px"></asp:TextBox>
                        </td>
                    </tr>
          </table>
              <table border="0"  height:243px;" style="width: 602px">
  <a style="height: 65px; width: 370px; color:Green; font-size:large;font-weight: bold;">Trường học</a>
                    <tr>
                        <td align="Right" 
                            style="color: #0000FF; font-size: large;" class="style105">
                            Đại học:</td>
                        <td align="left" class="style108">
                            <asp:TextBox ID="txtdaihoc" runat="server" BorderStyle="Inset" BorderWidth="2px" 
                                Height="22px" Width="170px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" 
                            style="color: #0000FF; font-size: large;" class="style106">
                            Phổ thông trung học:</td>
                        <td align="left" class="style109">
                            <asp:TextBox ID="txtcap3" runat="server" BorderStyle="Inset" BorderWidth="2px" 
                                Height="21px" Width="171px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" 
                            style="color: #0000FF; font-size: large;" class="style106">
                            Trung học cơ sở:</td>
                        <td align="left" class="style109">
                            <asp:TextBox ID="txtcap2" runat="server" BorderStyle="Inset" BorderWidth="2px" 
                                Height="21px"  Width="171px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" 
                            style="color: #0000FF; font-size: large;" class="style106">
                            Tiểu học:</td>
                        <td align="left" class="style109">
                            <asp:TextBox ID="txtcap1" runat="server" BorderStyle="Inset" BorderWidth="2px" 
                                Height="21px" Width="171px"></asp:TextBox>
                        </td>
                    </tr>
          </table>
                <table border="0"  height:243px;" style="width: 602px">
  <a style="height: 65px; width: 370px; color:Green; font-size:large;font-weight: bold;">Nghề nghiệp</a>
                    <tr>
                        <td align="Right" 
                            style="color: #0000FF; font-size: large;" class="style105">
                            Công việc hiện tại:</td>
                        <td align="left" class="style108">
                            <asp:TextBox ID="txtJob" runat="server" BorderStyle="Inset" BorderWidth="2px" 
                                Height="22px" Width="170px"></asp:TextBox>
                        </td>
                    </tr>
                                        <tr>
                        <td align="Right" 
                            style="color: #0000FF; font-size: large;" class="style105">
                            Công việc khác:</td>
                        <td align="left" class="style108">
                            <asp:TextBox ID="txtOtherJob" runat="server" BorderStyle="Inset" BorderWidth="2px" 
                                Height="22px" Width="170px"></asp:TextBox>
                        </td>
                    </tr>
 
          </table>
                        <table border="0"  height:243px;" style="width: 602px">
  <a style="height: 65px; width: 370px; color:Green; font-size:large;font-weight: bold;">Sở thích</a>
                    <tr>
                        <td align="Right" 
                            style="color: #0000FF; font-size: large;" class="style105">
                            Màu sắc:</td>
                        <td align="left" class="style108">
                            <asp:TextBox ID="txtColor" runat="server" BorderStyle="Inset" BorderWidth="2px" 
                                Height="22px" Width="170px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" 
                            style="color: #0000FF; font-size: large;" class="style106">
                            Âm nhạc:</td>
                        <td align="left" class="style109">
                            <asp:TextBox ID="txtSong" runat="server" BorderStyle="Inset" BorderWidth="2px" 
                                Height="21px" Width="171px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" 
                            style="color: #0000FF; font-size: large;" class="style106">
                            Điện ảnh:</td>
                        <td align="left" class="style109">
                            <asp:TextBox ID="txtDienAnh" runat="server" BorderStyle="Inset" BorderWidth="2px" 
                                Height="21px"  Width="171px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" 
                            style="color: #0000FF; font-size: large;" class="style106">
                            Sở thích khác</td>
                        <td align="left" class="style109">
                            <asp:TextBox ID="txtEsle" runat="server" BorderStyle="Inset" BorderWidth="2px" 
                                Height="21px" Width="171px"></asp:TextBox>
                        </td>
          </table>

          <table border="0"  height:243px;" style="width: 602px">
  <a style="height: 65px; width: 370px; color:Green; font-size:large;font-weight: bold;">Giới thiệu về bản thân</a>
                    <tr>
                        <td align="Right" 
                            style="color: #0000FF; font-size: large;" class="style105">
                            </td>
                        <td align="left" class="style108">
                            <asp:TextBox ID="txtAbout" runat="server" BorderStyle="Inset" BorderWidth="2px" 
                                Height="159px" TextMode="MultiLine" Width="578px"></asp:TextBox>
                        </td>
                    </tr>
     
          </table>