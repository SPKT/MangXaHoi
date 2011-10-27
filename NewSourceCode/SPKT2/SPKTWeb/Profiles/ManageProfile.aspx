<%@ Page Title="" Language="C#" MasterPageFile="~/MXH1.Master" AutoEventWireup="true" CodeBehind="ManageProfile.aspx.cs" Inherits="SPKTWeb.Profiles.ManageProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style15
        {
            width: 287px;
        }
        .winzard
        {
            display:run-in;
            margin:0;
            padding:0;
            }
        #scroll_box {   height:400px; 
                          display: auto; 
                            border: 1px solid #CCCCCC; 
                              margin: 1em 0; 
                              overflow:scroll; 
        }
    </style>
</asp:Content>
<<<<<<< HEAD
<asp:Content ID="Content2" ContentPlaceHolderID="Left" runat="server">
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
<asp:Content ID="Content4" ContentPlaceHolderID="Main" runat="server">
<div style="height:auto">
=======


<asp:Content ID="Content4" ContentPlaceHolderID="Main" runat="server">
>>>>>>> 74349b0b329f92be16c92eafca08b233a2499789
    <div>
        <div class="mainleft">
            <img src="~/Image/ProfileAvatar.aspx" alt="test image" id="testImage" width="145"
                height="75" runat="server" />
            <div>
                <asp:LinkButton ID="lbtnChangeAvatar" runat="server" Text="Đối Avatar" OnClick="lbtnChangeAvatar_Click"></asp:LinkButton>
            </div>
            <div>
                <asp:Label ID="lblProfileName" runat="server"></asp:Label>
            </div>
        </div>
        <div class="main">
    <div id="scroll_box" class="winzard">
        <asp:Wizard CssClass="winzard"  EnableViewState="true" ID="Wizard1" 
            runat="server" ActiveStepIndex="0" 
            CellPadding="10" FinishCompleteButtonText="Lưu" 
            FinishPreviousButtonText="Trước" 
            onfinishbuttonclick="Wizard1_FinishButtonClick" StartNextButtonText="Tiếp" 
            StepNextButtonText="Tiếp" StepPreviousButtonText="Trước" Width="630px">
            <WizardSteps>
                <asp:WizardStep EnableViewState="true" ID="WizardStep1" runat="server" Title="Quảnlýthôngtincánhân">
                <asp:Panel runat="server">
                    <a style=" color: #FF0000; font-size: x-large; font-weight: bold;"> Quản lý thông tin cá nhân</a>
                    <br />
    
<<<<<<< HEAD
                    <table border="0"  style="width: 602px; height:auto">
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
=======
                    <table border="0"">
                        <caption>
                            <a style="color:Green; font-size:large;font-weight: bold;">
                            Thông tin tài khoản</a>
                            <tr>
                                <td align="Right" class="style105" style="color: #0000FF; font-size: large;">
                                    Tên tài khoản:</td>
                                <td align="left" class="style15">
                                    <asp:TextBox ID="txtProfileName" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="style106" style="color: #0000FF; font-size: large;">
                                    Tên đầy đủ:</td>
                                <td align="left" class="style15">
                                    <asp:TextBox ID="txtTenThat" runat="server" 
                                        ></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="style106" style="color: #0000FF; font-size: large;">
                                    Ngày sinh:</td>
                                <td align="left" class="style15">
                                    <asp:TextBox ID="txtNgaySinh" runat="server" 
                                     ></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="style104" style="color: #0000FF; font-size: large;">
                                    Giới Tính:</td>
                                <td align="left" class="style15">
                                    <asp:TextBox ID="txtSex" runat="server" BorderColor="FloralWhite" 
                                     ></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="style106" style="color: #0000FF; font-size: large;">
                                    Chữ ký:</td>
                                <td align="left" class="style15">
                                    <asp:TextBox ID="txtChuKy" runat="server"  
                                     ></asp:TextBox>
                                </td>
                            </tr>
                        </caption>
>>>>>>> 74349b0b329f92be16c92eafca08b233a2499789
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
<<<<<<< HEAD
=======
</div>
>>>>>>> 74349b0b329f92be16c92eafca08b233a2499789
</asp:Content>

