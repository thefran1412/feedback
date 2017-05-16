<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="add.aspx.cs" Inherits="folders_add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    add new folder
    <form runat="server">
        <asp:Label runat="server" Text="name">Name</asp:Label>
        <asp:TextBox ID="name" runat="server"/>
        <asp:Label runat="server" Text="name">Color1</asp:Label>
        <asp:TextBox ID="color1" runat="server"/>
        <asp:Label runat="server" Text="name">Color2</asp:Label>
        <asp:TextBox ID="color2" runat="server"/>
        <asp:Button ID="submit" OnClick="Create" Text="Create" 
                   runat="server" />
    </form>

</asp:Content>

