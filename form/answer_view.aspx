<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="answer_view.aspx.cs" Inherits="form_answer_view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    Question: <asp:Label ID="name" runat="server" Text="Label"></asp:Label>
    <form runat="server">
        <asp:Label runat="server" Text="name2">Name</asp:Label>
        <asp:TextBox ID="Name2" runat="server"/>
        <asp:Label runat="server" Text="answer1">Answer</asp:Label>
        <asp:TextBox ID="answer1" runat="server"/>
        <asp:Label runat="server" Text="rating">Rating</asp:Label>
        <asp:TextBox ID="rating" runat="server"/>
        <asp:Button ID="submit" OnClick="Create" Text="Send" 
                   runat="server" />
    </form>
</asp:Content>

