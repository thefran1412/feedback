<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="edit.aspx.cs" Inherits="folders_edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <div class="title">
        <a class="back" href="/folder/index/">
            <img src="/img/back.png"/>
        </a>
        <asp:Label ID="title" runat="server" Text="EDIT FOLDER"></asp:Label>
        <div class="actions">
            <a id="delete" runat="server" href="/folder/delete/">Delete</a>
        </div>
    </div>
    <form runat="server">
        <table class="inputs">
            <tr>
                <td>
                    Name Of the folder:
                </td>
                <td>
                    <asp:TextBox ID="name" runat="server" class="input"/>
                </td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="name" runat="server" />
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
                <td></td>
                <td>
                    <asp:Button ID="Button1" OnClick="Edit" Text="Create"
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

