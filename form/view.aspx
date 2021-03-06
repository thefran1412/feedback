﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="view.aspx.cs" Inherits="form_view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <div class="title">
        <asp:Label ID="title" runat="server" Text="Label"></asp:Label>
        <div class="actions"> Average: <asp:Label ID="rating" runat="server" Text="Rating"></asp:Label></div>
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
                <asp:Button ID="submit" OnClick="Create" Text="Send" runat="server" CssClass="submit"/>
            </form>
        </div>

        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
            <ItemTemplate>

                    <div class="answer" >
                        <div>
                            <span>Name:</span><asp:Label ID="Label1" runat="server" Text='<%#Eval("name") %>'></asp:Label>
                        </div>
                        <div>
                            <span>Rating:</span><asp:Label ID="data" runat="server" Text='<%#Eval("rating") %>'></asp:Label>
                        </div>
                        <div>
                            <span>Answer:</span><asp:Label ID="data2" runat="server" Text='<%#Eval("answer") %>'></asp:Label>
                        </div>
                    </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>

