<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="ShouldDo.aspx.vb" Inherits="ShouldDo.ShouldDo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:PlaceHolder ID="plhShouldDo" runat="server" />

    <p />
    You Finished shouldDo with ID: 
    <asp:Label ID="lblOut" Text="3" runat="server" />
</asp:Content>
