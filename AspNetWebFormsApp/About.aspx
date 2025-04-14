<%@ Page Title="About" Theme="MyTheme2" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="AspNetWebFormsApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Your application description page.</h3>
        <p>Use this area to provide additional information.</p>
    </main>
    <asp:Button runat="server" OnClientClick="onclientclick()" OnClick="Unnamed_Click"   SkinID="RedButton" />
</asp:Content>
