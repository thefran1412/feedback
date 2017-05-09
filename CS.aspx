<%@ Page Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="CS.aspx.cs" Inherits="CS" %>
<asp:Content ID="headInside" ContentPlaceHolderID="head" Runat="Server">s    
<link href="css/register.css" rel="stylesheet" />
</asp:Content>
    <asp:Content ID="contentInside" ContentPlaceHolderID="content" Runat="Server">

        <form id="form1" runat="server">
    <table border="0" cellpadding="0" cellspacing="0">
        <tr>
            <th colspan="3">
                Registration
            </th>
        </tr>
        <tr>
            <td>Nombre de Usuario</td>
            <td><asp:TextBox ID="txtUsername" runat="server" /></td>
            <td><asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtUsername" runat="server" /></td>
        </tr>
        <tr>
            <td>Nombre</td>
            <td><asp:TextBox ID="txtName" runat="server" />            </td>
            <td><asp:RequiredFieldValidator ForeColor="Red" ControlToValidate="txtName" runat="server" /></td>
        </tr>
        <tr>
            <td class="auto-style1">Contraseña</td>
            <td class="auto-style1"><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" /></td>
            <td class="auto-style1"><asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtPassword" runat="server" /></td>
        </tr>
        <tr>
            <td>Confirma la Contraseña</td>
            <td><asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" OnTextChanged="txtConfirmPassword_TextChanged" /></td>
            <td><asp:CompareValidator ErrorMessage="Passwords do not match." ForeColor="Red" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" runat="server" /></td>
        </tr>
        <tr>
            <td>Email</td>
            <td><asp:TextBox ID="txtEmail" runat="server" /></td>
            <td><asp:RequiredFieldValidator ErrorMessage="Required" Display="Dynamic" ForeColor="Red" ControlToValidate="txtEmail" runat="server" />
                <asp:RegularExpressionValidator runat="server" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEmail" ForeColor="Red" ErrorMessage="Invalid email address." />
            </td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button Text="Submit" runat="server" OnClick="RegisterUser" /></td>
            <td></td>
        </tr>
    </table>
    </form>
        
</asp:Content>