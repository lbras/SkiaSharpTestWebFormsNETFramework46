<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SkiaSharpTestWebFormsNETFramework46._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>
    <div class="row">
        Select an image file:
        <asp:FileUpload ID="FileUpload1" runat="server" class="btn btn-default" />
    </div>
    <div class="row" style="margin-top: 20px">
        <asp:Button ID="Button1" runat="server" Text="Submit" class="btn btn-default" />
    </div>
    <div class="row">
        <asp:Label ID="LblResult" runat="server"></asp:Label>
    </div>        
</asp:Content>