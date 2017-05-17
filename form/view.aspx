<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="view.aspx.cs" Inherits="form_view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <div class="title">
        <asp:Label ID="title" runat="server" Text="Label"></asp:Label>
    </div>
    <div id="conttent" runat="server" style="min-height: calc(100% - 22px);">   
        <div class="response">
            <form runat="server">
        
                <asp:Label runat="server" Text="name2">Name</asp:Label>
                <asp:TextBox ID="Name2" runat="server" CssClass="input"/>
       
                <asp:Label runat="server" Text="answer1">Answer</asp:Label>
                <asp:TextBox ID="answer1" runat="server" CssClass="input"/>
        
                <asp:Label runat="server" Text="rating">Rating</asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="input">
                    <asp:ListItem Value="1">1</asp:ListItem>
                    <asp:ListItem Value="2">2</asp:ListItem>
                    <asp:ListItem Value="3">3</asp:ListItem>
                    <asp:ListItem Value="4">4</asp:ListItem>
                    <asp:ListItem Value="5">5</asp:ListItem>
                </asp:DropDownList>
                <asp:Button ID="submit" OnClick="Create" Text="Send" runat="server" CssClass="input"/>
            </form>
        </div>

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
    </div>
</asp:Content>

