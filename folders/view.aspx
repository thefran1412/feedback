<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="view.aspx.cs" Inherits="entity_view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <div class="title">
        <a class="back" href="/folder/index/">
            <img src="/img/back.png"/>
        </a>
        <asp:Label ID="title" runat="server" Text="FOLDER"></asp:Label>
        <div class="actions">
            <a id="edit" runat="server" href="/folder/edit/">Edit</a>
            <a id="delete" runat="server" href="/folder/delete/">Delete</a>
        </div>
    </div>
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            
                <div class="folder" style="background: linear-gradient(to right, <%#Eval("color1") %> , <%#Eval("color2") %>);">

                    <a class="folderUrl" href="/form/view/<%#Eval("hash") %>">
                        <asp:Label ID="data" runat="server" Text='<%#Eval("name") %>'></asp:Label>
                    </a>
                    <div class="onSite">
                        <a href="/form/edit/<%#Eval("hash") %>">Edit</a>
                        <a href="/form/delete/<%#Eval("hash") %>">Delete</a>
                    </div>

                </div>

        </ItemTemplate>
    </asp:Repeater>
    <a class="folderUrl" ID="add_new" runat="server" href="/form/add/">
        <div class="folder add">    
            <span>+</span>
        </div>
    </a>
</asp:Content>