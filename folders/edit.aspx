<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="edit.aspx.cs" Inherits="folders_edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    edit folder
    <form runat="server">
        <asp:Label runat="server" Text="name"></asp:Label>
        <asp:TextBox ID="name" Name="name" runat="server"/>
        
        <asp:Label runat="server" Text="color1"></asp:Label>
        <asp:TextBox ID="color1" Name="color1" runat="server"/>
        
        <asp:Label runat="server" Text="color1"></asp:Label>
        <asp:TextBox ID="color2" Name="color2" runat="server"/>
        
        <asp:Button ID="submit" OnClick="Edit" Text="Create" runat="server" />
    </form>
</asp:Content>

