<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<asp:Content ID="headInside" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>

<asp:Content ID="contentInside" ContentPlaceHolderID="content" Runat="Server">
    esto es la landing page
    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="dati">
    
    </asp:Repeater>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server">

    </asp:SqlDataSource>
</asp:Content>