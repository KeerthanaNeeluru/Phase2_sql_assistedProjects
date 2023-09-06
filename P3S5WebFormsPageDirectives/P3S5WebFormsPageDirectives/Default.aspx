<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P3S5WebFormsPageDirectives._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div class="container">
<h4>List OF students</h4>
    <%
        System.Data.DataTable table = new System.Data.DataTable();
        table.Columns.Add("Name", typeof(string));
        table.Columns.Add("Classs", typeof(string));

        table.Rows.Add("Walter", "6B");
        table.Rows.Add("Eva", "6B");
        table.Rows.Add("Jane", "6B");
        table.Rows.Add("Sen", "6B");
        foreach(System.Data.DataRow dr in table.Rows)
        {
            Response.Write(dr["Name"] + "is in class " + dr["Classs"] + "<br>");
        }
     %>
    </div>
</asp:Content>
