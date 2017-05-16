<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="view.aspx.cs" Inherits="form_view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    Pregunta: <asp:Label ID="name" runat="server" Text="Label"></asp:Label>
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>

                <div class="answer" >
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

