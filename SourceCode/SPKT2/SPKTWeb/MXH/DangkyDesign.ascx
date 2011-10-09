<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DangkyDesign.ascx.cs" Inherits="MXH.DangkyDesign" %>
<table style="padding: 0px; width: 100%; height: 245px; background-color: #FFFFFF; margin-top: 0px; margin-right:0px; background-image: none; background-repeat: repeat-x;" border="0" cellpadding="0" cellspacing="0">
					<tr style="background-image: url('Image/content_topbg_2.gif')">
						<td style="height: 45px; width: 50px"></td>
						<td style="height: 45px; width: 129px" align="center" valign="middle">
				<asp:Label id="Label4" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#CC0000" Text="ĐĂNG KÝ"></asp:Label>
						</td>
						<td style="height: 45px">&nbsp;</td>
					</tr>
					<tr>
						<td style="height: 30px; width: 50px; background-image: none; background-repeat: repeat-x;">
                            &nbsp;</td>
                    </tr>
                    <tr>
						<td style="width: 129px; height: 30px">
						    &nbsp;</td>
						<td style="height: 30px">
						    &nbsp;</td>
					</tr>
					<tr>
						<td style="height: 30px; width: 50px; background-image: none; background-repeat: repeat-x;"></td>
						<td style="width: 129px; height: 30px">
						<asp:Label id="Label1" runat="server" Text="Tên đăng nhập:"></asp:Label>
						</td>
						<td style="height: 30px">
						<asp:TextBox id="TextBox1" runat="server" BackColor="White" BorderColor="#3399FF" BorderStyle="Solid" BorderWidth="1px" Font-Names="Times New Roman" Font-Size="Medium" Width="183px"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td style="height: 34px; width: 50px; background-image: none; background-repeat: repeat-x;"></td>
						<td style="height: 34px; width: 129px">
						<asp:Label id="Label2" runat="server" Text="Mật khẩu:"></asp:Label>
						</td>
						<td style="height: 34px">
						<asp:TextBox id="TextBox2" runat="server" BorderColor="#3399FF" BorderStyle="Solid" BorderWidth="1px" Font-Names="Times New Roman" Font-Size="Medium" Width="183px" TextMode="Password"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td style="height: 27px; width: 50px; background-image: none; background-repeat: repeat-x;"></td>
						<td style="height: 27px; width: 129px">
						<asp:Label id="Label5" runat="server" Text="Nhắc lại mật khẩu:"></asp:Label>
						</td>
						<td style="height: 27px">
						<asp:TextBox id="TextBox3" runat="server" BorderColor="#3399FF" BorderStyle="Solid" BorderWidth="1px" Font-Names="Times New Roman" Font-Size="Medium" Width="183px" TextMode="Password"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td style="height: 35px; width: 50px"></td>
						<td style="width: 129px; height: 35px">
						<asp:Label id="Label6" runat="server" Text="Email:"></asp:Label>
						</td>
						<td style="height: 35px">
						<asp:TextBox id="TextBox4" runat="server" BorderColor="#3399FF" BorderStyle="Solid" BorderWidth="1px" Font-Names="Times New Roman" Font-Size="Medium" Width="183px"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td style="width: 50px; height: 32px"></td>
						<td align="left" style="width: 129px; height: 32px">
						<asp:Label id="Label7" runat="server" Text="Ảnh xác minh:"></asp:Label>
						</td>
						<td style="height: 32px">
						<asp:TextBox id="TextBox5" runat="server" BorderColor="#3399FF" BorderStyle="Solid" BorderWidth="1px" Font-Names="Times New Roman" Font-Size="Medium" Width="183px"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td style="width: 50px; height: 30px"></td>
						<td align="left" style="width: 129px; height: 30px">
						<asp:Label id="Label8" runat="server" Text="Thuộc nhóm:"></asp:Label>
						</td>
						<td style="height: 30px">
						<input checked="checked" name="Radio1" type="radio" />Cựu 
						sinh viên&nbsp; <input name="Radio1" type="radio" />Giáo 
						viên&nbsp; <input name="Radio1" type="radio" />Người 
						ngoài</td>
					</tr>
					<tr>
						<td style="width: 50px; height: 23px">&nbsp;</td>
						<td align="left" style="width: 129px; height: 23px">
						    &nbsp;</td>
						<td style="height: 23px">
						    &nbsp;</td>
					</tr>
					<tr>
						<td style="width: 50px; height: 23px">&nbsp;</td>
						<td align="left" style="width: 129px; height: 23px">
						<asp:Button id="Button1" runat="server" BackColor="#0066FF" BorderColor="Blue" 
                                BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" ForeColor="White" 
                                Height="26px" Text="Đăng ký" Width="87px" />
						</td>
						<td style="height: 23px">
						    &nbsp;</td>
					</tr>
					<tr>
						<td style="width: 50px; height: 23px">&nbsp;</td>
						<td align="left" style="width: 129px; height: 23px">
						&nbsp;</td>
						<td style="height: 23px">
							<asp:Label ID="lblRegisterMessage" runat="server"></asp:Label>
						&nbsp;</td>
					</tr>
					<tr style="background-color: #000000">
						<td style="width: 50px; height: 6px"></td>
						<td align="right" style="width: 129px; height: 6px">
						</td>
						<td style="height: 6px">
						</td>
					</tr>
					</table>

