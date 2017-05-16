<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="entity_index" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <div class="title">
        <asp:Label ID="title" runat="server" Text="HOME"></asp:Label>
    </div>
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <a class="folderUrl" href="/folder/view/<%#Eval("hash") %>"> 
                <div class="folder" style="background: linear-gradient(to right, <%#Eval("color1") %> , <%#Eval("color2") %>);">    
                    <asp:Label ID="data" runat="server" Text='<%#Eval("name") %>'></asp:Label>
                </div>
            </a>
        </ItemTemplate>
     </asp:Repeater>
    <a class="folderUrl" href="/folder/add">
        <div class="folder add">    
            <span>+</span>
        </div>
    </a>
</asp:Content>

