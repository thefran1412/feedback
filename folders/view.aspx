<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="view.aspx.cs" Inherits="entity_view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    entity > view
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <a class="folderUrl" href="/form/view/<%#Eval("hash") %>"><div class="folder">
                <asp:Label ID="data" runat="server" Text='<%#Eval("name") %>'></asp:Label>
            </div></a>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>