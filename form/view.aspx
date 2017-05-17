<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="view.aspx.cs" Inherits="form_view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    Pregunta: <asp:Label ID="name" runat="server" Text="Label"></asp:Label>

    Question: <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
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

    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>

                <div class="answer" >
                    <div>
                        <span>Nom de la persona que a respost:</span><asp:Label ID="Label1" runat="server" Text='<%#Eval("name") %>'></asp:Label>
                    </div>
                    <div>
                        <span>Puntuació sobre 5:</span><asp:Label ID="data" runat="server" Text='<%#Eval("rating") %>'></asp:Label>
                    </div>
                    <div>
                        <span>Resposta:</span><asp:Label ID="data2" runat="server" Text='<%#Eval("answer") %>'></asp:Label>
                    </div>
                </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>

