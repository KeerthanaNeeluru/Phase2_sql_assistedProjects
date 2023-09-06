<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P3S5WebFormWithTracing._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <br />
        <h4>Add Student Profile</h4>
        <div class="row">
            <div class="col-sm-4">Name</div>
            <div class="col-sm-8">
                <asp:TextBox ID="txtName" runat="server" MaxLength="100" CssClass="form-control"></asp:TextBox></div>
        </div>
        <div class="row">
            <div class="col-sm-4">Class</div>
            <div class="col-sm-8">
                <asp:TextBox ID="txtClass" runat="server" CssClass="form-control" MaxLength="3"></asp:TextBox></div>
        </div>
        <div class="row">
    <div class="col-sm-4">Email</div>
    <div class="col-sm-8">
        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" MaxLength="100"></asp:TextBox></div>
</div>
        <div class="col-sm-12 text-right">
            <asp:Button ID="Button1" runat="server" Text="submit" /></div>
    </div>
</asp:Content>
