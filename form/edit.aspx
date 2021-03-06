﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="edit.aspx.cs" Inherits="form_edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <div class="title">
        <a class="back" id="back" runat="server" href="/folder/index/">
            <img src="/img/back.png"/>
        </a>
        <asp:Label ID="title" runat="server" Text="EDIT FORM"></asp:Label>
        <div class="actions">
            <a id="delete" runat="server" href="/folder/delete/">Delete</a>
        </div>
    </div>
    <form runat="server">
        <table class="inputs">
            <tr>
                <td>What do you want to be evaluated?
                </td>
                <td>
                    <asp:TextBox ID="question" class="input" runat="server" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="question" runat="server" />
                </td>
            </tr>
            <tr>
                <td>Add a Description:
                </td>
                <td>
                    <asp:TextBox ID="Description" CssClass="input" TextMode="multiline" Columns="50" Rows="5" runat="server" />
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>Choose main Color:
                </td>
                <td>
                    <asp:TextBox CssClass="color" ID="color1" value="#89CAFF" runat="server" />
                </td>
                <td>
                    <asp:Label ID="color1Label" ForeColor="Red" runat="server"></asp:Label>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="color1" runat="server" />
                </td>
            </tr>
            <tr>
                <td>Choose Secondary Color:
                </td>
                <td>
                    <asp:TextBox CssClass="color" value="#FFFFFF" ID="color2" runat="server" />
                </td>
                <td>
                    <asp:Label ID="color2Label" ForeColor="Red" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="rating">This Form is public:</asp:Label>
                </td>
                <td>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="input">
                    <asp:ListItem Value="1">Visible</asp:ListItem>
                    <asp:ListItem Value="0">Non visible</asp:ListItem>
                </asp:DropDownList>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="Button1" OnClick="Edit" Text="Save"
                        runat="server" />
                </td>
                <td></td>
            </tr>
            <tr>
                <td></td>
            </tr>

        </table>
    </form>
</asp:Content>

