﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="view.aspx.cs" Inherits="form_view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    Nom: <asp:Label ID="name" runat="server" Text="Label"></asp:Label>
    Page Before: <asp:Label ID="before" runat="server" Text="Label"></asp:Label>
</asp:Content>

