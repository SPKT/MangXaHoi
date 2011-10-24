<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ManageProfile.aspx.cs" Inherits="SPKTWeb.Profiles.ManageProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainLeft_above" runat="server">
    <div>
    <div>
    <img src="~/Image/ProfileAvatar.aspx" alt="test image" id="testImage" width="100" height="75" runat="server" />
    </div>
    <div>
        <asp:LinkButton  ID="lbtnChangeAvatar" runat="server" Text="Đối Avatar"
            onclick="lbtnChangeAvatar_Click" ></asp:LinkButton>
    </div>
    <div>
    <asp:Label ID="lblProfileName" runat="server"></asp:Label>
    </div>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainLeft_under" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="mainCenter" runat="server">
<div>
    <div>
        <asp:Wizard EnableViewState="true" ID="Wizard1" runat="server" ActiveStepIndex="0" 
            BackColor="LemonChiffon" BorderStyle="Groove" BorderWidth="2px" 
            CellPadding="10" FinishCompleteButtonText="Lưu" 
            FinishPreviousButtonText="Trước" 
            onfinishbuttonclick="Wizard1_FinishButtonClick" StartNextButtonText="Tiếp" 
            StepNextButtonText="Tiếp" StepPreviousButtonText="Trước">
            <WizardSteps>
                <asp:WizardStep EnableViewState="true" ID="WizardStep1" runat="server" Title="Quảnlýthôngtincánhân">
                <asp:Panel runat="server">
                    <a style="height: 65px; width: 370px; color: #FF0000; font-size: x-large; font-weight: bold;"> Quản lý thông tin cá nhân</a>
                    <br />
    
                    <table border="0"  height:243px;" style="width: 602px">
                    <a style="height: 65px; width: 370px; color:Green; font-size:large;font-weight: bold;">Thông tin tài khoản</a>
                    <tr>
                        <td align="Right" 
                            style="color: #0000FF; font-size: large;" class="style105">
                            Tên tài khoản:</td>
                        <td align="left" class="style108">
                            <asp:TextBox ID="txtProfileName" runat="server" BorderStyle="Inset" BorderWidth="2px" 
                                Height="22px" Width="170px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" 
                            style="color: #0000FF; font-size: large;" class="style106">
                            Tên đầy đủ:</td>
                        <td align="left" class="style109">
                            <asp:TextBox ID="txtTenThat" runat="server" BorderStyle="Inset" BorderWidth="2px" 
                                Height="21px"  Width="171px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" 
                            style="color: #0000FF; font-size: large;" class="style106">
                            Ngày sinh:</td>
                        <td align="left" class="style109">
                            <asp:TextBox ID="txtNgaySinh" runat="server" BorderStyle="Inset" BorderWidth="2px" 
                                Height="21px" Width="171px"></asp:TextBox>
                        </td>
                    </tr>
            
                    <tr>
                        <td align="right" 
                            style="color: #0000FF; font-size: large;" class="style104">
                            Giới Tính:</td>
                        <td align="left" class="style104">
                            <asp:TextBox ID="txtSex" runat="server" BorderStyle="Inset" BorderWidth="2px" BorderColor="FloralWhite"
                                Height="18px" Width="170px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" 
                            style="color: #0000FF; font-size: large;" class="style106">
                            Chữ ký:</td>
                        <td align="left" class="style109">
                            <asp:TextBox ID="txtChuKy" runat="server" BorderStyle="Inset" BorderWidth="2px" 
                                Height="21px" Width="171px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
                </asp:Panel>
            </asp:WizardStep>
            <asp:wizardStep ID="WinzardStep2" runat="server" Title="Thôngtin">
                <asp:Panel runat="server">
                    <div id="divProfileAttribute" runat="server">
                        <asp:Label ID="lblError" runat="server"></asp:Label>
                    </div>
                </asp:Panel>
            </asp:wizardStep>
     </WizardSteps>
   </asp:Wizard>
 </div>
            <div>
              <asp:Button ID="btnSaveProfile" runat="server" onclick="btnSaveProfile_Click" 
                  Text="Lưu thay đổi" Visible="False" />
            </div>
</div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="mainRight" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="mainUnder" runat="server">
<div>
        
</div>

</asp:Content>
