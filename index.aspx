<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<asp:Content ID="headInside" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>

<asp:Content ID="contentInside" ContentPlaceHolderID="content" Runat="Server">
        <div class="title">
        <asp:Label ID="title" runat="server" Text="SOME PUBLIC FORMS"></asp:Label>
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