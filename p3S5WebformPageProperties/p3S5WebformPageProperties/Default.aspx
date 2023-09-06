<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="p3S5WebformPageProperties._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <div class="container">
       <div class="row">
           <div class="col-sm-6">
               <div class="row">
                   <div class="col-sm-4">Name</div>
                   <div class="col-sm-8">
                       <asp:TextBox ID="txtname" runat="server" CssClass="form-control" MaxLength="100"></asp:TextBox></div>
                </div>
               <div class="row">
                    <div class="col-sm-4">Address</div>
                    <div class="col-sm-8">
                     <asp:TextBox ID="txtaddress" runat="server" CssClass="form-control" MaxLength="100"></asp:TextBox></div>
                 </div>
               <div class="row">
                    <div class="col-sm-4">Class</div>
                    <div class="col-sm-8">
                    <asp:TextBox ID="txtclass" runat="server" CssClass="form-control" MaxLength="3"></asp:TextBox></div>
                </div>
               <div class="row">
                    <div class="col-sm-4">Email</div>
                    <div class="col-sm-8">
                    <asp:TextBox ID="txtemail" runat="server" type="email" CssClass="form-control" MaxLength="100"></asp:TextBox></div>
                </div>
               <div class="row">
                   <div class="col-sm-12 text-right">
                       <asp:Button ID="btnSubmit" runat="server" Text="Button" CssClass="btn btn-default" OnClick="btnSubmit_Click" />
                   </div>
               </div>
           </div>
       </div>
   </div>
    <div class="row">
        <div class="col-sm-6">
            <asp:Label ID="lblCount" runat="server"></asp:Label><br />
            <asp:Label ID="lblLog" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>
