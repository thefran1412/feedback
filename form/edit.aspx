<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="edit.aspx.cs" Inherits="form_edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
        edit form
    <form runat="server">
        <table>
            <tr>
                <td>What do you want to be evaluated?
                </td>
                <td>
                    <asp:TextBox ID="question" runat="server" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="question" runat="server" />
                </td>
            </tr>
            <tr>
                <td>Add a Description:
                </td>
                <td>
                    <asp:TextBox ID="Description" TextMode="multiline" Columns="50" Rows="5" runat="server" />
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

