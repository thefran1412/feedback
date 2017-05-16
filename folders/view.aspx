<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="view.aspx.cs" Inherits="entity_view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <div class="title">
        FOLDER
    </div>
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <a class="folderUrl" href="/form/view/<%#Eval("hash") %>">
                <div class="folder" style="background: linear-gradient(to right, <%#Eval("color1") %> , <%#Eval("color2") %>);">
                    <asp:Label ID="data" runat="server" Text='<%#Eval("name") %>'></asp:Label>
                </div>
            </a>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
