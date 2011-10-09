<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/MXH1.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="MXH._Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>


<%@ Register src="LoginDesign.ascx" tagname="LoginDesign" tagprefix="uc1" %>


<%@ Register src="DangkyDesign.ascx" tagname="DangkyDesign" tagprefix="uc2" %>
<%@ Register TagPrefix="Custom" Namespace="ASB" Assembly="AutoSuggestBox" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="Main">
    <div style="height: 450px">
        <table class="style1" style="height: 450px">
            <tr>
                <td class="style18" style="background-color: #FFFFFF">
                    </td>
                <td class="style19">
                    	
                    </td>
            </tr>
            <tr>
                <td class="style20" style="background-color: #FFFFFF; vertical-align:middle">
                    &nbsp;
                    <script runat="Server" type="text/C#">
                        [System.Web.Services.WebMethod]
                        [System.Web.Script.Services.ScriptMethod]
                        public static AjaxControlToolkit.Slide[] GetSlides()
                        {
                            AjaxControlToolkit.Slide[] slides = new AjaxControlToolkit.Slide[5];
                            slides[0] = new AjaxControlToolkit.Slide("images/01.jpg", "Blue Hills", "Go Blue");
                            slides[1] = new AjaxControlToolkit.Slide("images/02.jpg", "Sunset", "Setting sun");
                            slides[2] = new AjaxControlToolkit.Slide("images/03.jpg", "Winter", "Wintery...");
                            slides[3] = new AjaxControlToolkit.Slide("images/04.jpg", "Water lillies", "Lillies in the water");
                            slides[4] = new AjaxControlToolkit.Slide("images/05.jpg", "Sedona", "Portrait style picture");
                            return (slides);
                        }
                    </script>
                    &nbsp; &nbsp;
                    <asp:Image ID="Image1" runat="server" Height="316px" Width="388px" /><br />
                    <asp:Label ID="lblImageDescription" runat="server" /><br />
                    <asp:Button ID="Btn_Previous" runat="server" Text="Previous" />
                    <asp:Button ID="Btn_Next" runat="server" Text="Next" Width="64px" /><br />
                    <asp:Button ID="Btn_Play" runat="server" Text="Play" /><br />
                    <asp:SlideShowExtender ID="SlideShowExtender1" runat="server" AutoPlay="true" ImageDescriptionLabelID="lblImageDescription"
               Loop="true" NextButtonID="Btn_Next" PlayButtonID="Btn_Play" 
                PlayButtonText="Play" PreviousButtonID="Btn_Previous" 
                 SlideShowServiceMethod="GetSlides" StopButtonText="Stop"
                  TargetControlID="Image1">
                    </asp:SlideShowExtender>
                   </td>
                <td class="style8" style="background-color: #FFFFFF">
                    <uc1:LoginDesign ID="LoginDesign1" runat="server" />
                </td>
            </tr>
            
            <tr>
                <td class="style16" style="background-color: #FFFFFF">
                    </td>
                <td class="style17" style="background-color: #FFFFFF">
                    	
                    </td>
            </tr>
            </table>
    </div>
    <div style="background-color: #FF9966; height: 29px;" >
        &nbsp;&nbsp;Chào mừng các bạn đến với website Mạng xã hội ĐH Sư phạm kỹ thuật tphcm</div>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .style7
        {
            width: 65%;
        }
        .style8
        {
            width: 173px;
            height: 76px;
        }
        .style16
        {
            width: 65%;
        }
        .style17
        {
            width: 173px;
        }
        .style18
        {
            width: 9px;
            height: 20px;
        }
        .style19
        {
            height: 20px;
            width: 173px;
        }
        .style20
        {
            width: 9px;
            height: 76px;
        }
        </style>
</asp:Content>

