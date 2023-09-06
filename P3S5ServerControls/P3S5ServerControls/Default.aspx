<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P3S5ServerControls._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:HiddenField ID="Validation_id" Value="14635" runat="server" />
    <div class="row">
        <div class="col-12 text-center">
            <asp:Label runat="server" Text="PASSPORT APPLICATION FORM" Font-Bold="true" /></div>
    </div>
    <div class="row">
        <div class="col-6">
            <div class="row mt-5">
                <div class="col-4">First Name*</div>
                <div class="col-7"><asp:TextBox ID="fname" CssClass="form-control" runat="server" MaxLength="100"></asp:TextBox></div>
            </div>
             <div class="row mt-5">
                <div class="col-4">Last Name*</div>
                <div class="col-8"><asp:TextBox ID="lname" CssClass="form-control" runat="server" MaxLength="100"></asp:TextBox></div>
             </div>
             <div class="row mt-5">
                    <div class="col-4">Date of Birth*</div>
                    <div class="col-8">
                        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                    </div>
            </div>
             <div class="row mt-5">
                <div class="col-4">Current Address*</div>
                <div class="col-8">
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="40px" ImageAlign="Left" ImageUrl="https://www.techscrolling.com/wp-content/uploads/2018/02/Optimizing-Website-for-Google-Maps-Marketing.jpeg" OnClick="ImageButton1_Click1" />
                    click to launch Maps</div>
            </div>
        </div>
        <div class="col-6">
            <div class="row mt-5">
                <div class="col-4">Upload Photo</div>
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <hr />
               
            </div>
        </div>
        <div class="row m-5">
            <asp:Panel ID="Panel1" runat="server" CssClass="bg-info row mt-5">
                <div class="col-4">Emplyment Status</div>
                <div class="col-7">
                    <asp:RadioButton ID="RadioButton1" value="0" runat="server" Text="&amp;nbsp;UnEmployed" GroupName="rbGroup" /><br />
                    <asp:RadioButton ID="RadioButton2" value="1" runat="server" GroupName="rbGroup" Text="&amp;nbsp;Private company" /><br />
                    <asp:RadioButton ID="RadioButton3" value="2" runat="server" GroupName="rbGroup" Text="&amp;nbsp;Public Company" /><br />
                    <asp:RadioButton ID="RadioButton4" value="3" runat="server" GroupName="rbGroup" Text="&amp;nbsp;Self employment" /><br />
                    <asp:RadioButton ID="RadioButton5" value="4" runat="server" GroupName="rbGroup" Text="&amp;nbsp;Business" /><br /></div>
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server" CssClass="bg-info row mt-5">
                <div class="col-4">Special Status</div>
                <div class="col-7">
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="&amp;nbsp;Senior Citizen" /><br />
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="&amp;nbsp;Minor" /><br />
                    <asp:CheckBox ID="CheckBox3" runat="server" Text="&amp;nbsp;Armed forces" /><br />
                    <asp:CheckBox ID="CheckBox4" runat="server" Text="&amp;nbsp;Foreign Diplomat" /><br />
                </div>
            </asp:Panel>
        </div>
    </div>
    <div class="row mt-5 border-top">
        <div class="col-12 text-center">
            <asp:Button ID="btnSubmit" CssClass="btn btn-secondary"  runat="server" Text="Submit" />
        </div>
    </div>
</asp:Content>
