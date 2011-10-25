<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="InviteFriends.ascx.cs" Inherits="SPKTWeb.Friends.InviteFriends" %>
<div class="divContainer" id="com">
        <div class="divContainerBox">
            <div class="divContainerTitle" 
                             
                style="border: 0px none #000066; font-family: 'Times New Roman', Times, serif; font-weight: bold; color: #CC0000; width: 621px; height: 51px; background-image: url('../Image/post_entry_bkgr.png'); font-size: 22px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; KẾT BẠN</div>
            <asp:Panel ID="pnlInvite" runat="server" Width="619px" BorderColor="#CCCCFF" 
                BorderStyle="Solid" BorderWidth="1px">
                <div class="divContainerRow">
                    <div class="divContainerCellHeader" style="font-style: normal; font-size: 14px">Đến từ:&nbsp;&nbsp;
                        <asp:Label ID="lblFrom" runat="server" Font-Italic="True" ForeColor="Blue"></asp:Label>
                    </div>
                </div>
                <div class="divContainerRow">
                    <div class="divContainerCellHeader" style="font-size: 14px">Gửi đến:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                        <div  
                         class="divContainerHelpText" style="font-style: italic; width: 576px;">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtTo" runat="server" Columns="40" Font-Italic="True" 
                                ForeColor="#0000CC" Height="45px" Rows="5" TextMode="MultiLine" 
                                Width="495px"></asp:TextBox>
                            <br />
                            (Ban co the gui cho nhieu mail, moi mail cach nhau boi dau &quot;,&quot;)</div></div>
                </div>
                <div class="divContainerRow">
                    <div  
                        class="divContainerCellHeader" style="font-size: 12px">
                        <div class="divContainerCell" 
                            style="font-size: 14px; width: 576px; height: 74px;">
                            Thông điệp:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtMessage" runat="server" Columns="40" Height="39px" 
                                Rows="10" TextMode="MultiLine" Width="495px" style="margin-left: 75px"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="divContainerFooter" style="height: 31px; margin-top: 8px">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                    <asp:Button ID="btnInvite" runat="server"  
                           Text="Gửi Lời mời" OnClick="btnInvite_Click" BackColor="#0066FF" 
                        BorderColor="#FFCC00" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" 
                        Font-Names="Constantia" ForeColor="White" />
                </div>
            </asp:Panel>
            <div class="divContainerRow">
                <div class="divContainerCell" 
                    
                    
                    
                    
                    style="border: thin none #000066; width: 621px; height: 42px; background-color: #CCCCCC; font-size: 11px; background-image: url('../Image/page_top_bkgr.gif');">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:Label  
                        ID="lblMessage" runat="server" ForeColor="Maroon"></asp:Label><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br /><br /></div>
                </div>
            </div>
    </div>