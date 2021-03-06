﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="login_Default" %>

<asp:Content ID="headInside" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/register.css" rel="stylesheet" />
    <link href="../css/main.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="contentInside" ContentPlaceHolderID="content" Runat="Server">
    <div class="wrapper">
        <form id="form" runat="server">
    <table border="0" cellpadding="0" cellspacing="0">
        <tr>
            <th colspan="3">
                <h2>Registration</h2>
            </th>
        </tr>
        <tr>
            <td>Nombre de Usuario</td>
            <td>
                <asp:TextBox ID="txtUsername" runat="server" CssClass="input" />
            </td>
            <td>
                <asp:Label ID="UserNameValidation" ForeColor="Red" runat="server"></asp:Label>
                <asp:RequiredFieldValidator ErrorMessage="Campo requerido" ForeColor="Red" ControlToValidate="txtUsername" runat="server" /></td>
        </tr>
        <tr>
            <td>Nombre</td>
            <td><asp:TextBox ID="txtName" runat="server" CssClass="input"/>            </td>
            <td><asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="Campo requerido" ControlToValidate="txtName" runat="server" /></td>
        </tr>
        <tr>
            <td class="auto-style1">Contraseña</td>
            <td class="auto-style1"><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="input"/></td>
            <td class="auto-style1"><asp:RequiredFieldValidator ErrorMessage="Campo requerido" ForeColor="Red" ControlToValidate="txtPassword" runat="server" /></td>
        </tr>
        <tr>
            <td>Confirma la Contraseña</td>
            <td><asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" CssClass="input"/></td>
            <td><asp:CompareValidator ErrorMessage="Las contraseñas no coinciden" ForeColor="Red" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" runat="server" /></td>
        </tr>
        <tr>
            <td>Email</td>
            <td><asp:TextBox ID="txtEmail" runat="server" CssClass="input"/></td>
            <td>
                <asp:Label ID="EmailValidator" ForeColor="Red" runat="server"></asp:Label>
                <asp:RequiredFieldValidator ErrorMessage="Campo requerido" Display="Dynamic" ForeColor="Red" ControlToValidate="txtEmail" runat="server" />
                <asp:RegularExpressionValidator runat="server" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEmail" ForeColor="Red" ErrorMessage="Invalid email address." />
            </td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button Text="Submit" runat="server" OnClick="RegisterUser" CssClass="submit"/></td>
            <td></td>
        </tr>
    </table>
    </form>
    </div>
</asp:Content>

<%--<%@ Page Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="CS.aspx.cs" Inherits="CS" %>--%>

    